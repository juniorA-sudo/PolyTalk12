using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Presentation
{
    /// <summary>
    /// Service for generating multimedia content (images, audio) using AI APIs
    /// </summary>
    public class AIContentService
    {
        private readonly string apiKey;
        private readonly HttpClient httpClient;
        private readonly string mediaFolder;

        public AIContentService()
        {
            // For now, using placeholder API key - in production would load from configuration
            apiKey = Environment.GetEnvironmentVariable("OPENROUTER_API_KEY") ?? "demo-key";
            httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(60) };
            mediaFolder = Path.Combine(Path.GetTempPath(), "PolyTalk_Media");

            if (!Directory.Exists(mediaFolder))
                Directory.CreateDirectory(mediaFolder);
        }

        /// <summary>
        /// Generate image for an activity using OpenRouter API
        /// </summary>
        public async Task<string> GenerarImagenParaActividad(string topico, string descripcion)
        {
            try
            {
                // For now, return a placeholder image URL
                // In production, would call actual image generation API (Stable Diffusion via OpenRouter)
                string filename = $"img_{Guid.NewGuid().ToString().Substring(0, 8)}.jpg";
                string filepath = Path.Combine(mediaFolder, filename);

                // Create a simple placeholder image
                using (var bitmap = new System.Drawing.Bitmap(400, 300))
                {
                    using (var graphics = System.Drawing.Graphics.FromImage(bitmap))
                    {
                        graphics.Clear(System.Drawing.Color.FromArgb(220, 240, 255));
                        var font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
                        graphics.DrawString(topico, font, System.Drawing.Brushes.DarkBlue,
                                          new System.Drawing.PointF(20, 50));
                        graphics.DrawString(descripcion, new System.Drawing.Font("Segoe UI", 11),
                                          System.Drawing.Brushes.Gray, new System.Drawing.PointF(20, 150));
                    }
                    bitmap.Save(filepath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                return filepath;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error generating image: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Generate audio for pronunciation or activities using text-to-speech
        /// </summary>
        public async Task<string> GenerarAudioParaActividad(string texto, string idioma = "en")
        {
            try
            {
                // For now, use Windows SAPI text-to-speech
                string filename = $"audio_{Guid.NewGuid().ToString().Substring(0, 8)}.wav";
                string filepath = Path.Combine(mediaFolder, filename);

                // Generate TTS using SAPI
                GenerarAudioConSAPI(texto, filepath);

                return filepath;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error generating audio: {ex.Message}");
                return null;
            }
        }

        private void GenerarAudioConSAPI(string texto, string filepath)
        {
            try
            {
                string vbsScript = $@"
Set objVoice = CreateObject(""SAPI.SpVoice"")
Set objFileStream = CreateObject(""SAPI.FileStream"")
objFileStream.Open ""{filepath}"", 3
Set objVoice.AudioOutputStream = objFileStream
objVoice.Speak ""{texto.Replace("\"", "\\\"")}""
objFileStream.Close
";

                string vbsPath = Path.Combine(Path.GetTempPath(), $"tts_{Guid.NewGuid().ToString().Substring(0, 8)}.vbs");
                File.WriteAllText(vbsPath, vbsScript);

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "cscript",
                    Arguments = $"//NoLogo \"{vbsPath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = System.Diagnostics.Process.Start(psi))
                {
                    process.WaitForExit(30000);
                }

                if (File.Exists(vbsPath))
                    File.Delete(vbsPath);
            }
            catch { }
        }

        /// <summary>
        /// Generate matching activity pairs using AI
        /// </summary>
        public async Task<List<(string left, string right)>> GenerarParesPalabras(string topico, int cantidad = 5)
        {
            var pares = new List<(string, string)>();

            try
            {
                // For demo: return sample pairs
                // In production: would use OpenRouter API to generate via LLM
                var ejemplos = new Dictionary<string, List<(string, string)>>
                {
                    ["animals"] = new List<(string, string)>
                    {
                        ("Dog", "Perro"),
                        ("Cat", "Gato"),
                        ("Bird", "Pájaro"),
                        ("Fish", "Pez"),
                        ("Lion", "León"),
                    },
                    ["fruits"] = new List<(string, string)>
                    {
                        ("Apple", "Manzana"),
                        ("Banana", "Plátano"),
                        ("Orange", "Naranja"),
                        ("Grapes", "Uvas"),
                        ("Strawberry", "Fresa"),
                    },
                    ["colors"] = new List<(string, string)>
                    {
                        ("Red", "Rojo"),
                        ("Blue", "Azul"),
                        ("Green", "Verde"),
                        ("Yellow", "Amarillo"),
                        ("Purple", "Púrpura"),
                    }
                };

                if (ejemplos.ContainsKey(topico.ToLower()))
                {
                    var ejemplosTopic = ejemplos[topico.ToLower()];
                    for (int i = 0; i < Math.Min(cantidad, ejemplosTopic.Count); i++)
                    {
                        pares.Add(ejemplosTopic[i]);
                    }
                }

                return pares;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error generating pairs: {ex.Message}");
                return pares;
            }
        }

        public class ImageGenerationRequest
        {
            [System.Text.Json.Serialization.JsonPropertyName("model")]
            public string Model { get; set; } = "stable-diffusion-3-5-large";

            [System.Text.Json.Serialization.JsonPropertyName("prompt")]
            public string Prompt { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("steps")]
            public int Steps { get; set; } = 20;
        }

        public class AudioGenerationRequest
        {
            [System.Text.Json.Serialization.JsonPropertyName("text")]
            public string Text { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("voice")]
            public string Voice { get; set; } = "en_US-male";
        }
    }
}
