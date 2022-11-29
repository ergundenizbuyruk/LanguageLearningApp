using LanguageLearning.Debugging;

namespace LanguageLearning
{
    public class LanguageLearningConsts
    {
        public const string LocalizationSourceName = "LanguageLearning";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "2a116e73c57241adb21447a5ceb6d4a7";
    }
}
