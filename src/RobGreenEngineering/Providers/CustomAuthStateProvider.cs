using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace RobGreenEngineering.Providers;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    private ClaimsPrincipal _claimsPrincipal = new(new ClaimsIdentity());

    public override async Task<AuthenticationState> GetAuthenticationStateAsync() => new(_claimsPrincipal);

    public void SetAuthInfo()
    {
        var identity = new ClaimsIdentity(new[]{
            //new Claim(ClaimTypes.Email, userProfile.Email),
            //new Claim(ClaimTypes.Name, $"{userProfile.FirstName} {userProfile.LastName}"),
            new Claim("auth", "")
        }, "AuthCookie");

        _claimsPrincipal = new ClaimsPrincipal(identity);

        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
}