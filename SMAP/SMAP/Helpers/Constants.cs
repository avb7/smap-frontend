using System;
namespace SMAP.Helpers
{
    public static class Constants
    {
        public static string FacebookAppId = "393142507831557";
        // OAuth
        // For Google login, configure at https://console.developers.google.com/
        public static string iOSClientId = "<insert IOS client ID here>";
        public static string AndroidClientId = "<insert Android client ID here>";

        // These values do not need changing
        public static string Scope = "email";
        public static string AuthorizeUrl = "https://www.facebook.com/dialog/oauth/";

        // Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
        public static string iOSRedirectUrl = "https://www.facebook.com/connect/login_success.html";
        public static string AndroidRedirectUrl = "https://www.facebook.com/connect/login_success.html";

    }
}
