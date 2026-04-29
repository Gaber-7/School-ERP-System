namespace LMS_Presentation_Layer.Services.FileValidations
{
    public class FileValidationService : BaseFileValidationService
    {

        // Define allowed extensions and MIME types for common file types - this can be expanded based on your application's needs
        private readonly string[] _allowedExtensions =
{
            ".jpg", ".jpeg", ".png", ".gif", // Images
            ".pdf", ".doc", ".docx", ".txt", // Documents
            ".xls", ".xlsx", ".csv",         // Excel/CSV
            ".mp4", ".avi", ".mkv", ".mov"   // Video
        };


        // Common file signatures (magic numbers) for validating file content - this is a simplified list and can be expanded for more formats
        private readonly string[] _allowedMimeTypes =
        {
            "image/jpeg", "image/png", "image/gif",
            "application/pdf", "application/msword",
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
            "text/plain",
            "application/vnd.ms-excel",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "text/csv",
            "video/mp4", "video/x-msvideo", "video/x-matroska", "video/quicktime"
        };

        // A more comprehensive mapping of file signatures can be implemented here for stricter validation,
        // but for simplicity, we will rely on MIME type checks and basic heuristics in this example.
        public async Task<string?> ValidateFileWithTimeoutAsync(IFormFile file)
        {
            return await ValidateWithTimeoutAsync(file, ValidateFileInternalAsync);
        }
        // Internal method that performs the actual validation logic, called by the timeout wrapper to ensure it doesn't run indefinitely
        // - this method can be expanded with more detailed checks as needed    
        private async Task<string?> ValidateFileInternalAsync(IFormFile file, CancellationToken cancellationToken)
        {
            // 1. Basic checks (from base class)
            var basicCheck = await ValidateBasicChecksAsync(file, _allowedExtensions, _allowedMimeTypes);
            if (basicCheck != null) return basicCheck;

            var extension = Path.GetExtension(file.FileName)?.ToLowerInvariant();
            var contentType = file.ContentType?.ToLowerInvariant();

            // 2. File signature validation (magic number check)
            try
            {
                using var stream = file.OpenReadStream();

                // Read enough bytes for the longest signature (usually 8 bytes)
                var header = new byte[8];
                var bytesRead = await stream.ReadAsync(header, 0, 8, cancellationToken);

                if (bytesRead < 4)
                    return "File is too small for signature validation.";

                // Check for executable content first
                if (IsExecutableContent(header))
                    return "File contains executable content";

                // Reset stream for content scanning
                stream.Position = 0;
            }
            catch (Exception ex)
            {
                return $"Unable to verify file content: {ex.Message}";
            }

            return null; // Validation passed
        }
    }
}
