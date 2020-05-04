using Terraria.ModLoader;

namespace CelestialInfernalMod
{
    public class CelestialLocalization
    {
        private static string[][] _localizations;

        public static void Load()
        {
            _localizations = new[]
            {
                new [] { "OozeMetalText", "The cavern walls ooze with a strange kind of gel..." }
            };
        }

        public static void Unload()
        {
            _localizations = null;
        }

        public static void AddLocalizations()
        {
            Load();
            foreach (string[] localization in _localizations)
            {
                ModTranslation text = ModContent.GetInstance<CelestialInfernalMod>().CreateTranslation(localization[0]);
                text.SetDefault(localization[1]);
                ModContent.GetInstance<CelestialInfernalMod>().AddTranslation(text);
            }
            Unload();
        }
    }
}
