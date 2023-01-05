namespace Application.Localization
{
    public static class LocalizationConstants
    {
        public const string DefaultLanguague = "en-US";

        public static readonly LanguageCode[] SupportedLanguages = {
            new LanguageCode
            {
                Code = "en-US",
                DisplayName= "English"
            },
            new LanguageCode
            {
                Code = "pt-BR",
                DisplayName = "Portuguese"
            }
        };
    }
}
