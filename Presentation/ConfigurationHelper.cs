using System;
using System.IO;
using System.Text.Json;

namespace Presentation
{
    internal class ConfigurationHelper
    {
        private static string? _connectionString;

        public static string GetConnectionString(string name = "DefaultConnection")
        {
            if (_connectionString != null)
                return _connectionString;

            try
            {
                string appSettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

                if (!File.Exists(appSettingsPath))
                    throw new FileNotFoundException($"appsettings.json not found at {appSettingsPath}");

                string jsonContent = File.ReadAllText(appSettingsPath);
                using (JsonDocument doc = JsonDocument.Parse(jsonContent))
                {
                    var root = doc.RootElement;
                    if (root.TryGetProperty("ConnectionStrings", out var connStrings))
                    {
                        if (connStrings.TryGetProperty(name, out var connString))
                        {
                            _connectionString = connString.GetString();
                            return _connectionString ?? throw new InvalidOperationException($"Connection string '{name}' is empty.");
                        }
                    }
                }

                throw new InvalidOperationException($"Connection string '{name}' not found in appsettings.json");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error loading connection string: {ex.Message}", ex);
            }
        }
    }
}
