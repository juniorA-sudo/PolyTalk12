// =============================================
// POLYTALK - DATA ACCESS LAYER
// Clase: TaskDAO
// Carpeta: DataAccess/TaskDAO.cs
// =============================================

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LoginLayeredCSharp.Domain.Models;

namespace LoginLayeredCSharp.DataAccess
{
    public class TaskDAO
    {
        private readonly string _connectionString;

        public TaskDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        // =============================================
        // CREAR TAREA NUEVA
        // =============================================
        public int CreateTask(Task task)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_CreateTask", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@title", task.Title);
                cmd.Parameters.AddWithValue("@description", (object)task.Description ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@teacher_id", task.TeacherId);
                cmd.Parameters.AddWithValue("@group_id", task.GroupId);
                cmd.Parameters.AddWithValue("@unit_id", (object)task.UnitId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@assigned_date", task.AssignedDate.Date);
                cmd.Parameters.AddWithValue("@due_date", task.DueDate.Date);
                cmd.Parameters.AddWithValue("@max_score", task.MaxScore);
                cmd.Parameters.AddWithValue("@submission_type", task.SubmissionType);
                cmd.Parameters.AddWithValue("@allow_late", task.AllowLate);
                cmd.Parameters.AddWithValue("@show_grade", task.ShowGrade);
                cmd.Parameters.AddWithValue("@status", task.Status);

                con.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        // =============================================
        // OBTENER TAREAS POR MAESTRO
        // =============================================
        public List<Task> GetTasksByTeacher(int teacherId)
        {
            var list = new List<Task>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetTasksByTeacher", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@teacher_id", teacherId);

                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(MapTask(dr));
                    }
                }
            }
            return list;
        }

        // =============================================
        // OBTENER TAREAS POR ESTUDIANTE
        // =============================================
        public List<TaskSubmission> GetTasksByStudent(int studentId)
        {
            var list = new List<TaskSubmission>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetTasksByStudent", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@student_id", studentId);

                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(MapSubmission(dr));
                    }
                }
            }
            return list;
        }

        // =============================================
        // OBTENER ENTREGAS DE UNA TAREA (para maestro)
        // =============================================
        public List<TaskSubmission> GetSubmissionsByTask(int taskId)
        {
            var list = new List<TaskSubmission>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT ts.submission_id, ts.task_id, ts.student_id,
                         u.first_name + ' ' + u.last_name AS student_name,
                         ts.comment, ts.file_path, ts.file_name,
                         ts.submitted_at, ts.is_late, ts.status,
                         ts.score, ts.feedback, ts.graded_at,
                         t.max_score, t.show_grade, t.due_date, t.title
                  FROM   task_submissions ts
                  INNER JOIN students  st ON ts.student_id = st.student_id
                  INNER JOIN users     u  ON st.user_id    = u.user_id
                  INNER JOIN tasks     t  ON ts.task_id    = t.task_id
                  WHERE  ts.task_id = @task_id
                  ORDER  BY ts.submitted_at ASC", con))
            {
                cmd.Parameters.AddWithValue("@task_id", taskId);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(MapSubmission(dr));
                    }
                }
            }
            return list;
        }

        // =============================================
        // ENTREGAR TAREA (estudiante)
        // =============================================
        public bool SubmitTask(int taskId, int studentId,
                               string comment, string filePath, string fileName)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_SubmitTask", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@task_id", taskId);
                cmd.Parameters.AddWithValue("@student_id", studentId);
                cmd.Parameters.AddWithValue("@comment", (object)comment ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@file_path", (object)filePath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@file_name", (object)fileName ?? DBNull.Value);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // =============================================
        // CALIFICAR ENTREGA (maestro)
        // =============================================
        public bool GradeSubmission(int submissionId, decimal score, string feedback)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GradeSubmission", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@submission_id", submissionId);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.Parameters.AddWithValue("@feedback", (object)feedback ?? DBNull.Value);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // =============================================
        // GUARDAR MATERIAL ADJUNTO
        // =============================================
        public bool SaveMaterial(TaskMaterial material)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"INSERT INTO task_materials
                    (task_id, file_name, file_path, file_type, file_size_kb)
                  VALUES
                    (@task_id, @file_name, @file_path, @file_type, @file_size_kb)", con))
            {
                cmd.Parameters.AddWithValue("@task_id", material.TaskId);
                cmd.Parameters.AddWithValue("@file_name", material.FileName);
                cmd.Parameters.AddWithValue("@file_path", material.FilePath);
                cmd.Parameters.AddWithValue("@file_type", (object)material.FileType ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@file_size_kb", (object)material.FileSizeKb ?? DBNull.Value);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // =============================================
        // OBTENER MATERIALES DE UNA TAREA
        // =============================================
        public List<TaskMaterial> GetMaterialsByTask(int taskId)
        {
            var list = new List<TaskMaterial>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT material_id, task_id, file_name, file_path,
                         file_type, file_size_kb, uploaded_at
                  FROM   task_materials
                  WHERE  task_id = @task_id
                  ORDER  BY uploaded_at ASC", con))
            {
                cmd.Parameters.AddWithValue("@task_id", taskId);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new TaskMaterial
                        {
                            MaterialId = Convert.ToInt32(dr["material_id"]),
                            TaskId = Convert.ToInt32(dr["task_id"]),
                            FileName = dr["file_name"].ToString(),
                            FilePath = dr["file_path"].ToString(),
                            FileType = dr["file_type"] == DBNull.Value ? null : dr["file_type"].ToString(),
                            FileSizeKb = dr["file_size_kb"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["file_size_kb"]),
                            UploadedAt = Convert.ToDateTime(dr["uploaded_at"])
                        });
                    }
                }
            }
            return list;
        }

        // =============================================
        // ELIMINAR MATERIAL
        // =============================================
        public bool DeleteMaterial(int materialId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM task_materials WHERE material_id = @material_id", con))
            {
                cmd.Parameters.AddWithValue("@material_id", materialId);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // =============================================
        // ACTUALIZAR ESTADO DE TAREA
        // =============================================
        public bool UpdateTaskStatus(int taskId, string status)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE tasks SET status = @status WHERE task_id = @task_id", con))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@task_id", taskId);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // =============================================
        // MAPPERS PRIVADOS
        // =============================================
        private Task MapTask(SqlDataReader dr)
        {
            return new Task
            {
                TaskId = Convert.ToInt32(dr["task_id"]),
                TeacherId = Convert.ToInt32(dr["teacher_id"]),
                Title = dr["title"].ToString(),
                Description = dr["description"] == DBNull.Value ? null : dr["description"].ToString(),
                AssignedDate = Convert.ToDateTime(dr["assigned_date"]),
                DueDate = Convert.ToDateTime(dr["due_date"]),
                MaxScore = Convert.ToInt32(dr["max_score"]),
                SubmissionType = dr["submission_type"].ToString(),
                AllowLate = Convert.ToBoolean(dr["allow_late"]),
                ShowGrade = Convert.ToBoolean(dr["show_grade"]),
                Status = dr["status"].ToString(),
                CreatedAt = Convert.ToDateTime(dr["created_at"]),
                TeacherName = dr["teacher_name"].ToString(),
                GroupName = dr["group_name"].ToString(),
                GroupCode = dr["group_code"].ToString(),
                EnglishLevel = dr["english_level"] == DBNull.Value ? null : dr["english_level"].ToString(),
                UnitTitle = dr["unit_title"] == DBNull.Value ? null : dr["unit_title"].ToString(),
                TotalSubmissions = Convert.ToInt32(dr["total_submissions"]),
                TotalGraded = Convert.ToInt32(dr["total_graded"]),
                TotalStudents = Convert.ToInt32(dr["total_students"]),
                ComputedStatus = dr["computed_status"].ToString()
            };
        }

        private TaskSubmission MapSubmission(SqlDataReader dr)
        {
            return new TaskSubmission
            {
                SubmissionId = dr["submission_id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["submission_id"]),
                TaskId = Convert.ToInt32(dr["task_id"]),
                TaskTitle = dr.HasColumn("title") ? dr["title"].ToString() : null,
                StudentId = dr["student_id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["student_id"]),
                StudentName = dr.HasColumn("student_name") ? dr["student_name"].ToString() : null,
                Comment = dr["student_comment"] == DBNull.Value ? null : dr["student_comment"].ToString(),
                FileName = dr["submitted_file"] == DBNull.Value ? null : dr["submitted_file"].ToString(),
                SubmittedAt = dr["submitted_at"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["submitted_at"]),
                IsLate = dr["is_late"] != DBNull.Value && Convert.ToBoolean(dr["is_late"]),
                Score = dr["score"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["score"]),
                Feedback = dr["feedback"] == DBNull.Value ? null : dr["feedback"].ToString(),
                GradedAt = dr["graded_at"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["graded_at"]),
                MaxScore = dr.HasColumn("max_score") ? Convert.ToInt32(dr["max_score"]) : 100,
                ShowGrade = dr.HasColumn("show_grade") && Convert.ToBoolean(dr["show_grade"]),
                DueDate = dr.HasColumn("due_date") ? Convert.ToDateTime(dr["due_date"]) : DateTime.Today,
                DaysRemaining = dr.HasColumn("days_remaining") ? Convert.ToInt32(dr["days_remaining"]) : 0,
                TaskStatus = dr.HasColumn("task_status") ? dr["task_status"].ToString() : null,
                TeacherName = dr.HasColumn("teacher_name") ? dr["teacher_name"].ToString() : null,
                GroupName = dr.HasColumn("group_name") ? dr["group_name"].ToString() : null,
            };
        }
    }

    // =============================================
    // EXTENSIÓN: HasColumn para SqlDataReader
    // =============================================
    public static class SqlDataReaderExtensions
    {
        public static bool HasColumn(this SqlDataReader dr, string columnName)
        {
            for (int i = 0; i < dr.FieldCount; i++)
                if (dr.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            return false;
        }
    }
}