using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace LMS_Presentation_Layer.Services
{
    public class DynamicPermissionPolicyProvider : DefaultAuthorizationPolicyProvider
    {
        public DynamicPermissionPolicyProvider(IOptions<AuthorizationOptions> options) : base(options) { }

        public override async Task<AuthorizationPolicy?> GetPolicyAsync(string policyName)
        {
            var policy = await base.GetPolicyAsync(policyName);
            if (policy != null) return policy;

            // إذا لم يجد Policy بهذا الاسم، سيعتبرها "صلاحية ديناميكية" ويقوم بإنشائها
            return new AuthorizationPolicyBuilder()
                .AddRequirements(new PermissionRequirement(policyName))
                .Build();
        }
    }
}
