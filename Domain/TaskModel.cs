// =============================================
// POLYTALK - DOMAIN LAYER
// Modelos: Task, TaskMaterial, TaskSubmission
// Carpeta sugerida: Domain/Models/Tasks/
// =============================================

using System;

namespace LoginLayeredCSharp.Domain.Models
{
    // =============================================
    // MODELO: Task (tarea creada por el maestro)
    // =============================================
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public string EnglishLevel { get; set; }
        public int? UnitId { get; set; }
        public string UnitTitle { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime DueDate { get; set; }
        public int MaxScore { get; set; }
        public string SubmissionType { get; set; }  // File, Text, Image, Review
        public bool AllowLate { get; set; }
        public bool ShowGrade { get; set; }
        public string Status { get; set; }  // Active, Expired, Completed, Draft
        public DateTime CreatedAt { get; set; }

        // Propiedades calculadas (desde SP/Vista)
        public int TotalSubmissions { get; set; }
        public int TotalGraded { get; set; }
        public int TotalStudents { get; set; }
        public string ComputedStatus { get; set; }

        // Propiedad calculada localmente
        public int DaysRemaining =>
            (DueDate.Date - DateTime.Today).Days;

        public bool IsExpired =>
            DateTime.Today > DueDate.Date && Status == "Active";

        public bool IsComplete =>
            TotalStudents > 0 && TotalSubmissions >= TotalStudents;

        // Constructor por defecto
        public Task()
        {
            AssignedDate = DateTime.Today;
            MaxScore = 100;
            SubmissionType = "File";
            AllowLate = false;
            ShowGrade = true;
            Status = "Active";
            CreatedAt = DateTime.Now;
        }
    }

    // =============================================
    // MODELO: TaskMaterial (archivos adjuntos)
    // =============================================
    public class TaskMaterial
    {
        public int MaterialId { get; set; }
        public int TaskId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }   // PDF, Image, Audio, Video, Word
        public int? FileSizeKb { get; set; }
        public DateTime UploadedAt { get; set; }

        // Propiedad calculada: tamaño legible
        public string FileSizeDisplay
        {
            get
            {
                if (!FileSizeKb.HasValue) return "—";
                if (FileSizeKb.Value >= 1024)
                    return $"{FileSizeKb.Value / 1024.0:F1} MB";
                return $"{FileSizeKb.Value} KB";
            }
        }

        // Icono según tipo de archivo
        public string FileIcon
        {
            get
            {
                return FileType?.ToUpper() switch
                {
                    "PDF" => "📄",
                    "WORD" => "📝",
                    "IMAGE" => "🖼️",
                    "AUDIO" => "🎵",
                    "VIDEO" => "🎬",
                    _ => "📁"
                };
            }
        }

        public TaskMaterial()
        {
            UploadedAt = DateTime.Now;
        }
    }

    // =============================================
    // MODELO: TaskSubmission (entrega del estudiante)
    // =============================================
    public class TaskSubmission
    {
        public int SubmissionId { get; set; }
        public int TaskId { get; set; }
        public string TaskTitle { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Comment { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public DateTime SubmittedAt { get; set; }
        public bool IsLate { get; set; }
        public string Status { get; set; }  // Submitted, Graded, Reviewed

        // Evaluación del maestro
        public decimal? Score { get; set; }
        public string Feedback { get; set; }
        public DateTime? GradedAt { get; set; }

        // Info adicional de la tarea
        public int MaxScore { get; set; }
        public bool ShowGrade { get; set; }
        public DateTime DueDate { get; set; }
        public int DaysRemaining { get; set; }
        public string TaskStatus { get; set; }  // Pending, Submitted, Graded, Expired
        public string TeacherName { get; set; }
        public string GroupName { get; set; }

        // Propiedades calculadas
        public bool IsGraded => Score.HasValue;
        public bool IsPending => SubmissionId == 0 && DateTime.Today <= DueDate.Date;
        public bool IsExpired => SubmissionId == 0 && DateTime.Today > DueDate.Date;

        public string ScoreDisplay =>
            IsGraded ? $"{Score:F0} / {MaxScore}" : "Sin calificar";

        public string StatusDisplay
        {
            get
            {
                return TaskStatus switch
                {
                    "Pending" => "⏳ Pendiente",
                    "Submitted" => "✅ Entregada",
                    "Graded" => "🏆 Calificada",
                    "Expired" => "⚠️ Vencida",
                    _ => TaskStatus
                };
            }
        }

        public string LetterGrade
        {
            get
            {
                if (!IsGraded || MaxScore == 0) return "—";
                double pct = (double)Score.Value / MaxScore * 100;
                return pct switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };
            }
        }

        public TaskSubmission()
        {
            SubmittedAt = DateTime.Now;
            Status = "Submitted";
        }
    }
}