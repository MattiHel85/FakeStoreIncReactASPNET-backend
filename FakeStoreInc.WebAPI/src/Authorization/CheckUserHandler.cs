using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace FakeStoreInc.WebAPI.Authorization
{
    public class CheckUserRequirement : IAuthorizationRequirement
    {
        public string UserIdBeingUpdated { get; set;}
        public CheckUserRequirement(){}
        public CheckUserRequirement(string userIdBeingUpdated)
        {
            UserIdBeingUpdated = userIdBeingUpdated;
        }
    }

    public class CheckUserHandler : AuthorizationHandler<CheckUserRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CheckUserRequirement requirement)
        {
            if (context.User.IsInRole("Admin"))
            {
                context.Succeed(requirement); 
                return Task.CompletedTask;
            }

            var userIdClaim = context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userIdClaim == requirement.UserIdBeingUpdated)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }

            context.Fail();
            return Task.CompletedTask;
        }
    }
}
