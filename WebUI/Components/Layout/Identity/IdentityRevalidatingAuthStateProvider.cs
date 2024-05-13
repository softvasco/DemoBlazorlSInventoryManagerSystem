using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace WebUI.Components.Layout.Identity
{
    //internal sealed class IdentityRevalidatingAuthStateProvider(ILoggerFactory loggerFactory,
    //    IServiceScopeFactory scopefactory, IOptions<IdentityOptions> options)
    //    : RevalidatingServerAuthenticationStateProvider(loggerFactory)
    //{
    //    protected override TimeSpan RevalidationInterval => TimeSpan.FromSeconds(20);

    //    //protected override async Task<bool> ValidateAuthenticationStateAsync(AuthenticationState authenticationState, CancellationToken cancellationToken)
    //    //{
    //    //    await using var scope = scopefactory.CreateAsyncScope();
    //    //    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Microsoft.AspNetCore.Components.Server.Application>>();
    //    //    return await ValidateSecutiryStampAsync(userManager, authenticationState);
    //    //}

    //    //private async Task<bool> ValidateSecutiryStampAsync(UserManager<Microsoft.AspNetCore.Components.Server.Application> userManager, 
    //    //    AuthenticationState authenticationState)
    //    //{
    //    //    var user = await userManager.GetUserAsync(principal);
    //    //    if (user is null)
    //    //    {
    //    //        return false;
    //    //    }
    //    //    else if (!userManager.SupportsUserSecurityStamp)
    //    //    {
    //    //        return true;
    //    //    }
    //    //    else
    //    //    {
    //    //        var principalStamp = principal.FindFirstValue(options.Value.ClaimsIdentity);
    //    //        var userStamp = await userManager.GetSecurityStampAsync(user);
    //    //        return principalStamp == userStamp;
    //    //    }
    //    //}

    //}
}