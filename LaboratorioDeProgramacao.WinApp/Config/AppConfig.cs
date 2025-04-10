using Newtonsoft.Json;

namespace LaboratorioDeProgramacao.WinApp.Config
{
    public static class AppConfig
    {
        private const string ConfigPath = "config.json";

        public static string ObterIdioma()
        {
            if (!File.Exists(ConfigPath))
                return "pt";

            var json = File.ReadAllText(ConfigPath);
            var obj = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return obj.ContainsKey("language") ? obj["language"] : "pt";
        }

        public static void SetarIdioma(string lang)
        {
            var obj = new Dictionary<string, string> { { "language", lang } };
            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(ConfigPath, json);
        }
    }
}