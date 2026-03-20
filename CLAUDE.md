# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

PolyTalk is a C# Windows Forms (.NET 8) application for English language learning management. It manages students, teachers, administrators, groups, lessons, vocabulary, and tasks.

## Build Commands

```bash
# Build the solution
dotnet build LoginLayeredCSharp.sln

# Build specific project
dotnet build Presentation/Presentation.csproj

# Run the application
dotnet run --project Presentation/Presentation.csproj
```

## Architecture

The project uses a layered architecture with three projects:

- **Presentation** (WinForms UI) - Entry point, references Domain
- **Domain** (Business models) - References DataAccess
- **DataAccess** (Data layer) - No dependencies

**Dependency flow**: Presentation → Domain → DataAccess

### Key Files

- `Presentation/Program.cs` - Application entry point, currently starts with `FrmLogin`
- `Presentation/DatabaseHelper.cs` - Central database operations class (~39KB, ~1000 lines)
- `Presentation/TaskService.cs` - Task management service
- `Presentation/Seccion de Estudiantes/VocabularyService.cs` - Vocabulary operations
- `Presentation/Seccion de Estudiantes/LessonService.cs` - Lesson operations
- `Domain/TaskModel.cs` - Domain models: `Task`, `TaskMaterial`, `TaskSubmission`
- `Domain/UserModel.cs` - User domain model

### UI Organization (Presentation)

Organized by user roles:
- `Login, Register, Principal/` - FrmLogin, FrmPrincipal (main navigation after login)
- `Seccion de Administrador/` - Admin forms (users, groups, content management)
- `Seccion de Maestros/` - Teacher forms (classes, students, lessons, tasks)
- `Seccion de Estudiantes/` - Student forms (lessons, vocabulary, practice, tasks)
- `Controls/` - User controls (UCLeccion, UCUnidad, UCTareas, etc.)
- `SubForms/` - Modal dialogs (FrmNuevoEstudiante, FrmNuevoMaestro, etc.)

### Database

- SQL Server database: `PruebaPolyTalk`
- Connection string in `DatabaseHelper.cs`
- Uses stored procedures (e.g., `SP_GetTasksByTeacher`, `sp_GetUserVocabularyLists`)
- Tables include: `users`, `students`, `teachers`, `groups`, `tasks`, `lessons`, `vocabulary_lists`

### NuGet Packages

- `Guna.UI2.WinForms` - Modern UI controls
- `FontAwesome.Sharp` - Icon library
- `Microsoft.Data.SqlClient` - SQL Server connectivity
- `NAudio` - Audio playback
- `System.Speech` - Speech synthesis

## Code Patterns

### Database Operations

```csharp
// Pattern used in DatabaseHelper, TaskService, VocabularyService
using (var conn = new SqlConnection(connectionString))
using (var cmd = new SqlCommand("StoredProcedureName", conn))
{
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.AddWithValue("@param", value);
    conn.Open();
    new SqlDataAdapter(cmd).Fill(dataTable);
}
```

### Forms Naming Convention

- `Frm` prefix for forms (FrmLogin, FrmPrincipal)
- `UC` prefix for user controls (UCLeccion, UCTareas)
- Designer files are auto-generated (.Designer.cs)

### Spanish Language

The codebase uses Spanish for:
- UI text and labels
- Method names (ObtenerEstudiantes, CrearTarea)
- Variable names in business logic
- Comments in code

## Notes

- The layered architecture is not strictly enforced - database logic exists in Presentation layer (DatabaseHelper, TaskService, etc.) rather than DataAccess
- Domain models are minimal; most data transfer uses DataTable
- Forms use Guna.UI2 controls extensively for modern appearance
- COM references to WMPLib for Windows Media Player functionality