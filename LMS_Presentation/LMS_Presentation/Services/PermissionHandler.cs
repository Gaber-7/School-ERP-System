using Microsoft.AspNetCore.Authorization;

namespace LMS_Presentation_Layer.Services
{
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        // This handler checks if the user has the required permission claim to access a resource.
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            // Extract the permissions from the user's claims. We assume that permissions are stored as claims with type "perm".
            var permissions = context.User.Claims
                .Where(x => x.Type == "perm") 
                .Select(x => x.Value);

            // Check if the required permission is present in the user's permissions. If it is, mark the requirement as succeeded.
            if (permissions.Contains(requirement.Permission))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
