using Group5_OnlinePharmacy.Data;
using Microsoft.AspNetCore.Identity;

namespace Group5_OnlinePharmacy.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<Group5_OnlinePharmacyUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<Group5_OnlinePharmacyUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
