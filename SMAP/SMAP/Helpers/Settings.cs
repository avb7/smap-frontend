// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SMAP.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		#region Setting Constants

		private const string SettingsKey = "settings_key";
		private static readonly string SettingsDefault = string.Empty;

        private const string IsLoggedKey = "IsLoggedKey";
        private const string UserEmailKey = "UserEmailKey";
        private const string UserImageKey = "UserImageKey";
        private const string UserFullNameKey = "UserFullNameKey";

		#endregion


		public static string GeneralSettings
		{
			get
			{
				return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(SettingsKey, value);
			}
		}

        public static bool IsLoggedIn
        {
            get
            {
                return AppSettings.GetValueOrDefault(IsLoggedKey, false);
            }
            set
            {
                AppSettings.AddOrUpdateValue(IsLoggedKey, value);
            }
        }
        public static string UserEmail
        {
            get
            {
                return AppSettings.GetValueOrDefault(UserEmailKey, null);
            }
            set
            {
                AppSettings.AddOrUpdateValue(UserEmailKey, value);
            }
        }

        public static string UserImageUrl
        {
            get
            {
                return AppSettings.GetValueOrDefault(UserImageKey, "DummyDP.png");
            }
            set
            {
                AppSettings.AddOrUpdateValue(UserImageKey, value);
            }
        }

        public static string UserFullName
        {
            get
            {
                return AppSettings.GetValueOrDefault(UserFullNameKey, null);
            }
            set
            {
                AppSettings.AddOrUpdateValue(UserFullNameKey, value);
            }
        }
	}
}


