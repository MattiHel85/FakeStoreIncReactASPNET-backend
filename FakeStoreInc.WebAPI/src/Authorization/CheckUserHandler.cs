using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace FakeStoreInc.WebAPI.src.Authorization
{
    public class CheckUserRequirement : IAuthorizationRequirement
    {
        public string UserId { get; set;}
        public CheckUserRequirement(string userId)
        {
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
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
            Console.WriteLine($"userIdClaim: {userIdClaim}, requirement.UserId: {requirement.UserId}");
            if (userIdClaim == requirement.UserId)
            {
                context.Succeed(requirement);
                // return Task.CompletedTask;
            }
            else
            {
                context.Fail();
            }

            // context.Fail();
            return Task.CompletedTask;
        }
    }
}
