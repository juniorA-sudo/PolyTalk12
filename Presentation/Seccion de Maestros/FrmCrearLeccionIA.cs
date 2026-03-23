using System;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Maestros
{
    public partial class FrmCrearLeccionIA : Form
    {
        // =====================================================
        // CAMPOS
        // =====================================================
        private readonly DatabaseHelper db;
        private readonly LessonService lessonService;
        private static readonly HttpClient client = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(120)
        };

        private const string OPENROUTER_API = "https://openrouter.ai/api/v1/chat/completions";
        private const string OPENROUTER_KEY = "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";

        // MODELO CONFIRMADO QUE FUNCIONA SIEMPRE (pago mínimo)
        private const string MODEL = "openai/gpt-4o-mini";

        // Datos generados por la IA
        private JsonDocument _iaResult;
        private int _lessonIdGuardado = 0;

        public FrmCrearLeccionIA()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            lessonService = new LessonService();
        }

        private void FrmCrearLeccionIA_Load(object sender, EventArgs e)
        {
            CargarNiveles();
        }

        // =====================================================
        // CARGA DE DATOS
        // =====================================================
        private void CargarNiveles()
        {
            try
            {
                DataTable dt = db.ObtenerNiveles();
                cmbNivel.Items.Clear();
                cmbNivel.Items.Add(new ComboItem("-- Selecciona nivel --", 0));
                foreach (DataRow row in dt.Rows)
                    cmbNivel.Items.Add(new ComboItem(
                        $"{row["level_code"]} — {row["level_name"]}",
                        Convert.ToInt32(row["level_id"])));
                cmbNivel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar niveles: " + ex.Message);
            }
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUnidad.Items.Clear();
            cmbUnidad.Items.Add(new ComboItem("-- Selecciona unidad --", 0));

            if (cmbNivel.SelectedItem is ComboItem item && item.Id > 0)
            {
                try
                {
                    DataTable dt = db.ObtenerUnidadesPorNivel(item.Id);
                    foreach (DataRow row in dt.Rows)
                        cmbUnidad.Items.Add(new ComboItem(
                            $"Unidad {row["unit_number"]}: {row["unit_title"]}",
                            Convert.ToInt32(row["unit_id"])));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar unidades: " + ex.Message);
                }
            }
            cmbUnidad.SelectedIndex = 0;
        }

        // =====================================================
        // GENERAR CON OPENROUTER
        // =====================================================
        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            string tema = txtTema.Text.Trim();
            string nivel = (cmbNivel.SelectedItem as ComboItem)?.Text.Split('—')[0].Trim() ?? "";

            SetGenerando(true);
            panelResultado.Visible = false;
            _iaResult = null;

            try
            {
                string json = await GenerarConOpenRouter(tema, nivel);
                if (string.IsNullOrEmpty(json))
                {
                    MessageBox.Show("La IA no pudo generar contenido. Intenta de nuevo.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _iaResult = JsonDocument.Parse(json);
                MostrarResultadoIA(_iaResult.RootElement);
                panelResultado.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetGenerando(false);
            }
        }

        private async Task<string> GenerarConOpenRouter(string tema, string nivel)
        {
            string prompt = $@"Eres un experto en enseñanza de inglés. Genera una lección completa de inglés sobre el tema: ""{tema}"" para el nivel {nivel} del Marco Común Europeo de Referencia (MCER).

IMPORTANTE: Responde ÚNICAMENTE con un objeto JSON válido, sin texto adicional, sin bloques de código, sin explicaciones. Solo el JSON puro.

El JSON debe tener exactamente esta estructura:
{{
  ""titulo"": ""Título de la lección en inglés"",
  ""descripcion"": ""Descripción breve de la lección en español"",
  ""tipo"": ""grammar"",
  ""duracion_minutos"": 20,
  ""contenido"": [
    {{
      ""titulo"": ""Título del tema explicativo"",
      ""explicacion"": ""Explicación clara del tema en español con ejemplos en inglés entre comillas. Mínimo 100 palabras."",
      ""orden"": 1
    }}
  ],
  ""actividades"": [
    {{
      ""tipo"": ""multiple_choice"",
      ""instruccion"": ""Instrucción de la actividad"",
      ""contenido"": ""Pregunta o enunciado"",
      ""respuesta_correcta"": ""respuesta correcta"",
      ""orden"": 1,
      ""opciones"": [
        {{""texto"": ""opción 1"", ""correcta"": true}},
        {{""texto"": ""opción 2"", ""correcta"": false}},
        {{""texto"": ""opción 3"", ""correcta"": false}},
        {{""texto"": ""opción 4"", ""correcta"": false}}
      ]
    }},
    {{
      ""tipo"": ""fill_blank"",
      ""instruccion"": ""Complete the sentence with the correct word"",
      ""contenido"": ""Oración con ___ en el espacio en blanco"",
      ""respuesta_correcta"": ""la palabra correcta"",
      ""orden"": 2,
      ""opciones"": []
    }},
    {{
      ""tipo"": ""translate"",
      ""instruccion"": ""Translate the following word to English"",
      ""contenido"": ""Palabra en español"",
      ""respuesta_correcta"": ""palabra en inglés"",
      ""orden"": 3,
      ""opciones"": []
    }},
    {{
      ""tipo"": ""listen_respond"",
      ""instruccion"": ""Listen and write what you hear"",
      ""contenido"": ""Frase en inglés para escuchar"",
      ""respuesta_correcta"": ""la frase correcta"",
      ""orden"": 4,
      ""opciones"": []
    }},
    {{
      ""tipo"": ""vocabulary"",
      ""instruccion"": ""Learn this word"",
      ""contenido"": ""Palabra clave en inglés"",
      ""respuesta_correcta"": ""traducción al español"",
      ""orden"": 5,
      ""opciones"": []
    }}
  ]
}}

Genera contenido real y educativo sobre: {tema} para nivel {nivel}. Asegúrate de que el JSON sea válido.";

            var body = new
            {
                model = MODEL,
                max_tokens = 4000,
                temperature = 0.7,
                messages = new[]
                {
                    new { role = "system", content = "Eres un experto en enseñanza de inglés. Siempre respondes con JSON puro y válido, sin texto adicional." },
                    new { role = "user",   content = prompt }
                }
            };

            var request = new HttpRequestMessage(HttpMethod.Post, OPENROUTER_API);

            // Headers específicos para OpenRouter
            request.Headers.Add("Authorization", $"Bearer {OPENROUTER_KEY}");
            request.Headers.Add("HTTP-Referer", "http://localhost:5000");
            request.Headers.Add("X-Title", "English Learning App");

            request.Content = new StringContent(
                JsonSerializer.Serialize(body),
                Encoding.UTF8,
                "application/json");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    string errorMsg = $"Error {response.StatusCode}: ";
                    try
                    {
                        using JsonDocument errorDoc = JsonDocument.Parse(responseBody);
                        if (errorDoc.RootElement.TryGetProperty("error", out JsonElement error))
                        {
                            if (error.TryGetProperty("message", out JsonElement message))
                                errorMsg += message.GetString();
                            else
                                errorMsg += responseBody;
                        }
                        else
                        {
                            errorMsg += responseBody;
                        }
                    }
                    catch
                    {
                        errorMsg += responseBody;
                    }
                    throw new Exception(errorMsg);
                }

                using JsonDocument doc = JsonDocument.Parse(responseBody);
                string text = doc.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString() ?? "";

                // Limpiar posibles bloques de código markdown
                text = text.Trim();
                if (text.StartsWith("```json"))
                    text = text.Substring(7);
                else if (text.StartsWith("```"))
                    text = text.Substring(3);

                if (text.EndsWith("```"))
                    text = text.Substring(0, text.Length - 3);

                return text.Trim();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión con OpenRouter: {ex.Message}");
            }
        }

        // =====================================================
        // MOSTRAR RESULTADO EN EL FORM
        // =====================================================
        private void MostrarResultadoIA(JsonElement root)
        {
            // Título y descripción
            txtTituloGenerado.Text = root.GetProperty("titulo").GetString() ?? "";
            txtDescripcionGenerada.Text = root.GetProperty("descripcion").GetString() ?? "";
            lblTipoGenerado.Text = $"Tipo: {root.GetProperty("tipo").GetString()} · {root.GetProperty("duracion_minutos").GetInt32()} min";

            // Contenido / explicación
            rtbContenidoGenerado.Clear();
            var contenido = root.GetProperty("contenido");
            foreach (JsonElement c in contenido.EnumerateArray())
            {
                rtbContenidoGenerado.AppendText($"📌 {c.GetProperty("titulo").GetString()}\n\n");
                rtbContenidoGenerado.AppendText($"{c.GetProperty("explicacion").GetString()}\n\n");
            }

            // Actividades
            rtbActividadesGeneradas.Clear();
            var actividades = root.GetProperty("actividades");
            int n = 1;
            foreach (JsonElement a in actividades.EnumerateArray())
            {
                string tipo = a.GetProperty("tipo").GetString() ?? "";
                string instruccion = a.GetProperty("instruccion").GetString() ?? "";
                string contenidoA = a.GetProperty("contenido").GetString() ?? "";
                string respuesta = a.GetProperty("respuesta_correcta").GetString() ?? "";

                rtbActividadesGeneradas.AppendText($"▶ Actividad {n} [{TipoAmigable(tipo)}]\n");
                rtbActividadesGeneradas.AppendText($"  Instrucción: {instruccion}\n");
                rtbActividadesGeneradas.AppendText($"  Contenido: {contenidoA}\n");
                rtbActividadesGeneradas.AppendText($"  Respuesta: {respuesta}\n");

                if (a.TryGetProperty("opciones", out JsonElement opciones))
                {
                    foreach (JsonElement op in opciones.EnumerateArray())
                    {
                        bool correcta = op.GetProperty("correcta").GetBoolean();
                        string opText = op.GetProperty("texto").GetString() ?? "";
                        rtbActividadesGeneradas.AppendText($"    {(correcta ? "✓" : "○")} {opText}\n");
                    }
                }
                rtbActividadesGeneradas.AppendText("\n");
                n++;
            }

            lblEstadoIA.Text = "✅ Contenido generado correctamente. Revisa y guarda.";
            lblEstadoIA.ForeColor = Color.FromArgb(22, 101, 52);
        }

        // =====================================================
        // GUARDAR EN BD
        // =====================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_iaResult == null)
            {
                MessageBox.Show("Primero genera el contenido con IA.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbUnidad.SelectedItem is not ComboItem unidadItem || unidadItem.Id == 0)
            {
                MessageBox.Show("Selecciona una unidad.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var root = _iaResult.RootElement;
                int unitId = unidadItem.Id;
                string titulo = txtTituloGenerado.Text.Trim();
                string desc = txtDescripcionGenerada.Text.Trim();
                string tipo = root.GetProperty("tipo").GetString() ?? "grammar";
                int duracion = root.GetProperty("duracion_minutos").GetInt32();

                // 1. Crear lección
                int lessonId = lessonService.CrearLeccion(unitId, titulo, desc, tipo, duracion,
                    ObtenerSiguienteOrden(unitId));

                // 2. Guardar contenido explicativo
                var contenido = root.GetProperty("contenido");
                foreach (JsonElement c in contenido.EnumerateArray())
                {
                    lessonService.GuardarContenido(
                        lessonId,
                        c.GetProperty("titulo").GetString() ?? "",
                        c.GetProperty("explicacion").GetString() ?? "",
                        null, null,
                        c.GetProperty("orden").GetInt32());
                }

                // 3. Guardar actividades
                var actividades = root.GetProperty("actividades");
                foreach (JsonElement a in actividades.EnumerateArray())
                {
                    string tipoAct = a.GetProperty("tipo").GetString() ?? "";
                    string tipoDb = MapearTipo(tipoAct);
                    string instruc = a.GetProperty("instruccion").GetString() ?? "";
                    string contenidoA = a.GetProperty("contenido").GetString() ?? "";
                    string respuesta = a.GetProperty("respuesta_correcta").GetString() ?? "";
                    int orden = a.GetProperty("orden").GetInt32();

                    int activityId = lessonService.GuardarActividad(
                        lessonId, tipoDb, instruc, contenidoA, respuesta,
                        null, null, orden);

                    // Opciones de opción múltiple
                    if (a.TryGetProperty("opciones", out JsonElement opciones))
                    {
                        int opOrden = 1;
                        foreach (JsonElement op in opciones.EnumerateArray())
                        {
                            lessonService.GuardarOpcion(
                                activityId,
                                op.GetProperty("texto").GetString() ?? "",
                                op.GetProperty("correcta").GetBoolean(),
                                opOrden++);
                        }
                    }
                }

                _lessonIdGuardado = lessonId;
                lblEstadoIA.Text = $"✅ Lección guardada con ID #{lessonId}";
                lblEstadoIA.ForeColor = Color.FromArgb(22, 101, 52);
                btnGuardar.Enabled = false;

                MessageBox.Show(
                    $"✅ Lección creada exitosamente.\n\nTítulo: {titulo}\nID: #{lessonId}\n\nYa está disponible para los estudiantes.",
                    "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevaLeccion_Click(object sender, EventArgs e)
        {
            txtTema.Clear();
            txtTituloGenerado.Clear();
            txtDescripcionGenerada.Clear();
            rtbContenidoGenerado.Clear();
            rtbActividadesGeneradas.Clear();
            lblEstadoIA.Text = "";
            panelResultado.Visible = false;
            btnGuardar.Enabled = true;
            _iaResult = null;
            txtTema.Focus();
        }

        // =====================================================
        // HELPERS
        // =====================================================
        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtTema.Text))
            {
                MessageBox.Show("Escribe el tema de la lección.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTema.Focus();
                return false;
            }
            if (cmbNivel.SelectedItem is not ComboItem nivelItem || nivelItem.Id == 0)
            {
                MessageBox.Show("Selecciona un nivel.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbUnidad.SelectedItem is not ComboItem unidadItem || unidadItem.Id == 0)
            {
                MessageBox.Show("Selecciona una unidad.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SetGenerando(bool generando)
        {
            btnGenerar.Enabled = !generando;
            btnGenerar.Text = generando ? "⏳ Generando..." : "✨ Generar con IA";
            progressGenerando.Visible = generando;
            lblEstadoIA.Text = generando ? "La IA está creando tu lección, por favor espera..." : "";
            lblEstadoIA.ForeColor = Color.FromArgb(79, 70, 229);
            Cursor = generando ? Cursors.WaitCursor : Cursors.Default;
        }

        private int ObtenerSiguienteOrden(int unitId)
        {
            DataTable dt = lessonService.ObtenerLeccionesPorUnidad(unitId);
            return dt.Rows.Count + 1;
        }

        private string MapearTipo(string tipo) => tipo switch
        {
            "multiple_choice" => "multiple_choice",
            "fill_blank" => "fill_blank",
            "translate" => "translate",
            "listen_respond" => "listen_respond",
            "vocabulary" => "vocabulary",
            _ => "multiple_choice"
        };

        private string TipoAmigable(string tipo) => tipo switch
        {
            "multiple_choice" => "Opción múltiple",
            "fill_blank" => "Rellenar espacio",
            "translate" => "Traducción",
            "listen_respond" => "Escuchar y responder",
            "vocabulary" => "Vocabulario",
            _ => tipo
        };

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();
    }

    // =====================================================
    // CLASE HELPER PARA COMBOBOX
    // =====================================================
    public class ComboItem
    {
        public string Text { get; }
        public int Id { get; }

        public ComboItem(string text, int id)
        {
            Text = text;
            Id = id;
        }

        public override string ToString() => Text;
    }
}