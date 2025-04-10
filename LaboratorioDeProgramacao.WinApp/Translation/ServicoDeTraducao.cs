using System.Text.Json;
using LaboratorioDeProgramacao.WinApp.Config;

namespace LaboratorioDeProgramacao.WinApp.Translation
{
    public class ServicoDeTraducao
    {
        private Dictionary<string, string> _traducoes;

        public ServicoDeTraducao()
        {
            var languageCode = AppConfig.ObterIdioma();
            var filePath = Path.Combine("Resources", $"{languageCode}.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Arquivo de tradução não encontrado: {filePath}");
            }

            var json = File.ReadAllText(filePath);

            _traducoes = JsonSerializer.Deserialize<Dictionary<string, string>>(json)
                            ?? new Dictionary<string, string>();
        }

        public string ObterTexto(string texto)
        {
            return _traducoes.TryGetValue(texto, out var value) ? value : $"[Sem tradução para: '{texto}']";
        }
    }
}