/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using JetBrains.Annotations;
using Newtonsoft.Json.Linq;

namespace AspNet.Security.OAuth.VidZapper {
    /// <summary>
    /// Contains static methods that allow to extract user's information from a <see cref="JObject"/>
    /// instance retrieved from VidZapper after a successful authentication process.
    /// </summary>
    public static class VidZapperAuthenticationHelper {
        /// <summary>
        /// Gets the identifier corresponding to the authenticated user.
        /// </summary>
        public static string GetIdentifier([NotNull] JObject user) => user.Value<string>("Username");

        /// <summary>
        /// Gets the full name corresponding to the authenticated user.
        /// </summary>
        public static string GetFullName([NotNull] JObject user) => user.Value<string>("Name");

        /// <summary>
        /// Gets the full name corresponding to the authenticated user.
        /// </summary>
        public static string GetEmail([NotNull] JObject user) => user.Value<string>("Email");

        /// <summary>
        /// Gets the first name corresponding to the authenticated user.
        /// </summary>
        public static string GetFirstName([NotNull] JObject user) => user.Value<string>("FirstName");

        /// <summary>
        /// Gets the surname corresponding to the authenticated user.
        /// </summary>
        public static string GetSurname([NotNull] JObject user) => user.Value<string>("LastName");

        /// <summary>
        /// Gets the surname corresponding to the authenticated user.
        /// </summary>
        public static string GetPicture([NotNull] JObject user) => user.Value<string>("Picture");

        /// <summary>
        /// Gets the surname corresponding to the authenticated user.
        /// </summary>
        public static string GetCity([NotNull] JObject user) => user.Value<string>("City");

        /// <summary>
        /// Gets the country id corresponding to the authenticated user.
        /// </summary>
        public static string GetCountry([NotNull] JObject user) => user.Value<string>("CountryId");

        /// <summary>
        /// Gets the language id corresponding to the authenticated user.
        /// </summary>
        public static string GetLanguage([NotNull] JObject user) => user.Value<string>("LanguageId");

        /// <summary>
        /// Gets the client id corresponding to the authenticated user.
        /// </summary>
        public static string GetClient([NotNull] JObject user) => user.Value<string>("ClientId");

        /// <summary>
        /// Gets the birthday corresponding to the authenticated user.
        /// </summary>
        public static string GetBirthday([NotNull] JObject user) => user.Value<string>("Birthday");

        /// <summary>
        /// Gets the client id corresponding to the authenticated user.
        /// </summary>
        public static string GetId([NotNull] JObject user) => user.Value<string>("Id");
    }
}
