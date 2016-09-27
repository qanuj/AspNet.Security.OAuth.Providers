/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OAuth.VidZapper {
    /// <summary>
    /// Defines a set of options used by <see cref="VidZapperAuthenticationHandler"/>.
    /// </summary>
    public class VidZapperAuthenticationOptions : OAuthOptions {
        public VidZapperAuthenticationOptions() {
            AuthenticationScheme = VidZapperAuthenticationDefaults.AuthenticationScheme;
            DisplayName = VidZapperAuthenticationDefaults.DisplayName;
            ClaimsIssuer = VidZapperAuthenticationDefaults.Issuer;

            CallbackPath = new PathString(VidZapperAuthenticationDefaults.CallbackPath);

            AuthorizationEndpoint = string.Format(VidZapperAuthenticationDefaults.AuthorizationEndpoint, _host);
            TokenEndpoint = string.Format(VidZapperAuthenticationDefaults.TokenEndpoint, _host);
            UserInformationEndpoint = string.Format(VidZapperAuthenticationDefaults.UserInformationEndpoint, _host);

            Scope.Add("basic");
        }

        private string _host = "live.vzconsole.com";

        /// <summary>
        /// Gets or sets a boolean indicating host of the vidzapper server
        /// </summary>
        public string Host { get { return _host; }
            set {
                _host = value;
                AuthorizationEndpoint = string.Format(VidZapperAuthenticationDefaults.AuthorizationEndpoint, _host);
                TokenEndpoint = string.Format(VidZapperAuthenticationDefaults.TokenEndpoint, _host);
                UserInformationEndpoint = string.Format(VidZapperAuthenticationDefaults.UserInformationEndpoint, _host);
            }
        }
    }
}
