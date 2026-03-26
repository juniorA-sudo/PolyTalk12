using System;
using System.Collections.Generic;
using System.Data;
using LoginLayeredCSharp.Domain.Models;

namespace Presentation.Helpers
{
    /// <summary>
    /// Clase centralizada para mapeo bidireccional entre DataTable y modelos tipados
    /// Garantiza estandarización y consistencia de datos en toda la aplicación
    /// </summary>
    public static class DataMapper
    {
        // =====================================================================
        // USER MAPPING
        // =====================================================================

        public static User MapRowToUser(DataRow row)
        {
            return new User
            {
                UserId = GetInt(row, "user_id"),
                Username = GetString(row, "username"),
                Email = GetString(row, "email"),
                Phone = GetString(row, "phone"),
                UserRole = GetString(row, "user_role"),
                IsActive = GetBool(row, "is_active"),
                CreatedAt = GetDateTime(row, "created_at")
            };
        }

        public static List<User> MapToUserList(DataTable dt)
        {
            var users = new List<User>();
            if (dt == null) return users;
            foreach (DataRow row in dt.Rows)
                users.Add(MapRowToUser(row));
            return users;
        }

        // =====================================================================
        // STUDENT MAPPING
        // =====================================================================

        public static Student MapRowToStudent(DataRow row)
        {
            return new Student
            {
                StudentId = GetInt(row, "student_id"),
                UserId = GetInt(row, "user_id"),
                StudentCode = GetString(row, "student_code"),
                CurrentEnglishLevel = GetString(row, "current_english_level"),
                EnrollmentDate = GetDateTime(row, "enrollment_date"),
                Username = GetString(row, "username"),
                Email = GetString(row, "email")
            };
        }

        public static List<Student> MapToStudentList(DataTable dt)
        {
            var students = new List<Student>();
            if (dt == null) return students;
            foreach (DataRow row in dt.Rows)
                students.Add(MapRowToStudent(row));
            return students;
        }

        // =====================================================================
        // TEACHER MAPPING
        // =====================================================================

        public static Teacher MapRowToTeacher(DataRow row)
        {
            return new Teacher
            {
                TeacherId = GetInt(row, "teacher_id"),
                UserId = GetInt(row, "user_id"),
                TeacherCode = GetString(row, "teacher_code"),
                EnglishLevel = GetString(row, "english_level"),
                HireDate = GetDateTime(row, "hire_date"),
                Username = GetString(row, "username"),
                Email = GetString(row, "email"),
                Phone = GetString(row, "phone"),
                IsActive = GetBool(row, "is_active")
            };
        }

        public static List<Teacher> MapToTeacherList(DataTable dt)
        {
            var teachers = new List<Teacher>();
            if (dt == null) return teachers;
            foreach (DataRow row in dt.Rows)
                teachers.Add(MapRowToTeacher(row));
            return teachers;
        }

        // =====================================================================
        // GROUP MAPPING
        // =====================================================================

        public static Group MapRowToGroup(DataRow row)
        {
            return new Group
            {
                GroupId = GetInt(row, "group_id"),
                GroupName = GetString(row, "group_name"),
                GroupCode = GetString(row, "group_code"),
                EnglishLevel = GetString(row, "english_level"),
                MaxCapacity = GetInt(row, "max_capacity"),
                TeacherId = GetInt(row, "teacher_id"),
                TeacherName = GetString(row, "teacher_name"),
                CreatedAt = GetDateTime(row, "created_at"),
                CurrentEnrollment = GetInt(row, "current_enrollment") != 0 ? GetInt(row, "current_enrollment") : GetInt(row, "Inscritos")
            };
        }

        public static List<Group> MapToGroupList(DataTable dt)
        {
            var groups = new List<Group>();
            if (dt == null) return groups;
            foreach (DataRow row in dt.Rows)
                groups.Add(MapRowToGroup(row));
            return groups;
        }

        // =====================================================================
        // LESSON MAPPING
        // =====================================================================

        public static Lesson MapRowToLesson(DataRow row)
        {
            return new Lesson
            {
                LessonId = GetInt(row, "lesson_id"),
                UnitId = GetInt(row, "unit_id"),
                LessonTitle = GetString(row, "lesson_title"),
                Content = GetString(row, "content"),
                OrderNumber = GetInt(row, "order_number"),
                IsPublished = GetBool(row, "is_published"),
                CreatedAt = GetDateTime(row, "created_at"),
                UpdatedAt = GetDateTimeNull(row, "updated_at"),
                UnitTitle = GetString(row, "unit_title"),
                TeacherId = GetInt(row, "teacher_id"),
                TeacherName = GetString(row, "teacher_name")
            };
        }

        public static List<Lesson> MapToLessonList(DataTable dt)
        {
            var lessons = new List<Lesson>();
            if (dt == null) return lessons;
            foreach (DataRow row in dt.Rows)
                lessons.Add(MapRowToLesson(row));
            return lessons;
        }

        // =====================================================================
        // VOCABULARY MAPPING
        // =====================================================================

        public static VocabularyList MapRowToVocabularyList(DataRow row)
        {
            return new VocabularyList
            {
                ListId = GetInt(row, "list_id"),
                GroupId = GetInt(row, "group_id"),
                ListName = GetString(row, "list_name"),
                Description = GetString(row, "description"),
                TeacherId = GetInt(row, "teacher_id"),
                TeacherName = GetString(row, "teacher_name"),
                IsPublished = GetBool(row, "is_published"),
                CreatedAt = GetDateTime(row, "created_at"),
                GroupName = GetString(row, "group_name"),
                TotalWords = GetInt(row, "total_words")
            };
        }

        public static List<VocabularyList> MapToVocabularyListList(DataTable dt)
        {
            var lists = new List<VocabularyList>();
            if (dt == null) return lists;
            foreach (DataRow row in dt.Rows)
                lists.Add(MapRowToVocabularyList(row));
            return lists;
        }

        public static VocabularyItem MapRowToVocabularyItem(DataRow row)
        {
            return new VocabularyItem
            {
                ItemId = GetInt(row, "item_id"),
                ListId = GetInt(row, "list_id"),
                EnglishWord = GetString(row, "english_word"),
                SpanishWord = GetString(row, "spanish_word"),
                ImageUrl = GetString(row, "image_url"),
                Pronunciation = GetString(row, "pronunciation"),
                OrderNumber = GetInt(row, "order_number"),
                CreatedAt = GetDateTime(row, "created_at"),
                ListName = GetString(row, "list_name")
            };
        }

        public static List<VocabularyItem> MapToVocabularyItemList(DataTable dt)
        {
            var items = new List<VocabularyItem>();
            if (dt == null) return items;
            foreach (DataRow row in dt.Rows)
                items.Add(MapRowToVocabularyItem(row));
            return items;
        }

        // =====================================================================
        // ENROLLMENT MAPPING
        // =====================================================================

        public static Enrollment MapRowToEnrollment(DataRow row)
        {
            return new Enrollment
            {
                EnrollmentId = GetInt(row, "enrollment_id"),
                StudentId = GetInt(row, "student_id"),
                GroupId = GetInt(row, "group_id"),
                EnrollmentDate = GetDateTime(row, "enrollment_date"),
                Status = GetString(row, "status"),
                StudentName = GetString(row, "student_name"),
                StudentCode = GetString(row, "student_code"),
                GroupName = GetString(row, "group_name"),
                GroupCode = GetString(row, "group_code"),
                EnglishLevel = GetString(row, "english_level")
            };
        }

        public static List<Enrollment> MapToEnrollmentList(DataTable dt)
        {
            var enrollments = new List<Enrollment>();
            if (dt == null) return enrollments;
            foreach (DataRow row in dt.Rows)
                enrollments.Add(MapRowToEnrollment(row));
            return enrollments;
        }

        // =====================================================================
        // TASK MAPPING (ya existe en otros servicios)
        // =====================================================================

        public static LoginLayeredCSharp.Domain.Models.Task MapRowToTask(DataRow row)
        {
            return new LoginLayeredCSharp.Domain.Models.Task
            {
                TaskId = GetInt(row, "task_id"),
                Title = GetString(row, "title"),
                Description = GetString(row, "description"),
                TeacherId = GetInt(row, "teacher_id"),
                TeacherName = GetString(row, "teacher_name"),
                GroupId = GetInt(row, "group_id"),
                GroupName = GetString(row, "group_name"),
                GroupCode = GetString(row, "group_code"),
                EnglishLevel = GetString(row, "english_level"),
                UnitId = GetIntNull(row, "unit_id"),
                UnitTitle = GetString(row, "unit_title"),
                AssignedDate = GetDateTime(row, "assigned_date"),
                DueDate = GetDateTime(row, "due_date"),
                MaxScore = GetInt(row, "max_score"),
                SubmissionType = GetString(row, "submission_type"),
                AllowLate = GetBool(row, "allow_late"),
                ShowGrade = GetBool(row, "show_grade"),
                Status = GetString(row, "status"),
                CreatedAt = GetDateTime(row, "created_at")
            };
        }

        public static List<LoginLayeredCSharp.Domain.Models.Task> MapToTaskList(DataTable dt)
        {
            var tasks = new List<LoginLayeredCSharp.Domain.Models.Task>();
            if (dt == null) return tasks;
            foreach (DataRow row in dt.Rows)
                tasks.Add(MapRowToTask(row));
            return tasks;
        }

        // =====================================================================
        // HELPER METHODS - DATA TYPE CONVERSIONS
        // =====================================================================

        /// <summary>Obtiene int desde DataRow, retorna 0 si es DBNull</summary>
        private static int GetInt(DataRow row, string columnName)
        {
            return (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
                ? Convert.ToInt32(row[columnName])
                : 0;
        }

        /// <summary>Obtiene int? desde DataRow, retorna null si es DBNull</summary>
        private static int? GetIntNull(DataRow row, string columnName)
        {
            return (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
                ? (int?)Convert.ToInt32(row[columnName])
                : null;
        }

        /// <summary>Obtiene string desde DataRow, retorna vacío si es DBNull</summary>
        private static string GetString(DataRow row, string columnName)
        {
            return (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
                ? row[columnName].ToString()
                : string.Empty;
        }

        /// <summary>Obtiene bool desde DataRow, retorna false si es DBNull</summary>
        private static bool GetBool(DataRow row, string columnName)
        {
            return (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
                ? Convert.ToBoolean(row[columnName])
                : false;
        }

        /// <summary>Obtiene DateTime desde DataRow, retorna Today si es DBNull</summary>
        private static DateTime GetDateTime(DataRow row, string columnName)
        {
            return (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
                ? Convert.ToDateTime(row[columnName])
                : DateTime.Today;
        }

        /// <summary>Obtiene DateTime? desde DataRow, retorna null si es DBNull</summary>
        private static DateTime? GetDateTimeNull(DataRow row, string columnName)
        {
            return (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
                ? (DateTime?)Convert.ToDateTime(row[columnName])
                : null;
        }
    }
}
