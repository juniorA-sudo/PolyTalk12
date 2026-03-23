# PolyTalk - English Language Learning Management System

PolyTalk es una aplicación Windows Forms (.NET 8) para gestionar un sistema completo de enseñanza del idioma inglés, incluyendo estudiantes, maestros, grupos, lecciones, vocabulario y tareas.

## 📋 Tabla de Contenidos

- [Requisitos](#requisitos)
- [Instalación](#instalación)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Arquitectura](#arquitectura)
- [Configuración](#configuración)
- [Base de Datos](#base-de-datos)
- [Compilación y Ejecución](#compilación-y-ejecución)
- [Características](#características)

## 📦 Requisitos

- **OS**: Windows 7+
- **.NET**: .NET 8.0 o superior
- **SQL Server**: SQL Server 2019+ (o SQL Server Express)
- **Visual Studio**: 2022+ (recomendado)

## 🚀 Instalación

### 1. Clonar el repositorio

```bash
git clone <repository-url>
cd LoginLayeredCSharp
```

### 2. Configurar la base de datos

**Opción A: Usar SQL Server Management Studio (SSMS)**

1. Abre SSMS y conéctate a tu instancia de SQL Server
2. Abre el archivo `Database/01_CreateDatabase.sql`
3. Ejecuta el script (F5 o botón Execute)
4. La base de datos `PruebaPolyTalk` será creada con todas las tablas

**Opción B: Usar línea de comandos**

```bash
sqlcmd -S SERVIDOR\INSTANCIA -U usuario -P contraseña -i Database/01_CreateDatabase.sql
```

### 3. Actualizar connection string

Edita `Presentation/appsettings.json` y cambia la connection string según tu ambiente:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=TU_SERVIDOR\\TU_INSTANCIA;Initial Catalog=PruebaPolyTalk;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=60;"
  }
}
```

### 4. Compilar el proyecto

```bash
dotnet build LoginLayeredCSharp.sln
```

### 5. Ejecutar la aplicación

```bash
dotnet run --project Presentation/Presentation.csproj
```

O desde Visual Studio: `F5` o `Ctrl + F5`

## 📁 Estructura del Proyecto

```
LoginLayeredCSharp/
├── Presentation/           # Capa de UI (Windows Forms)
│   ├── Program.cs         # Entry point
│   ├── appsettings.json   # Configuración
│   ├── ConfigurationHelper.cs
│   ├── DatabaseHelper.cs
│   ├── TaskService.cs
│   ├── Login, Register, Principal/
│   │   ├── FrmLogin.cs
│   │   ├── FrmPrincipal.cs
│   │   └── FrmEditarPerfil.cs
│   ├── Seccion de Administrador/
│   ├── Seccion de Maestros/
│   ├── Seccion de Estudiantes/
│   ├── Controls/
│   ├── SubForms/
│   └── Reportes/
├── Domain/               # Capa de modelos de negocio
│   ├── TaskModel.cs
│   ├── UserModel.cs
│   └── [otros modelos]
├── DataAccess/          # Capa de acceso a datos (vacía, TODO)
├── Database/
│   └── 01_CreateDatabase.sql
└── README.md
```

## 🏗️ Arquitectura

El proyecto sigue una **arquitectura en capas**:

### Capas

```
┌─────────────────────────────────────┐
│    Presentation Layer               │
│    (Windows Forms UI)               │
└─────────────┬───────────────────────┘
              │ references
┌─────────────▼───────────────────────┐
│    Domain Layer                     │
│    (Business Models)                │
└─────────────┬───────────────────────┘
              │ references
┌─────────────▼───────────────────────┐
│    DataAccess Layer                 │
│    (Database Operations)            │
└─────────────────────────────────────┘
```

### Flujo de Datos

1. **Presentation** → User interacts with forms
2. **Services** (DatabaseHelper, TaskService) → Execute business logic
3. **DataAccess** → SQL queries & stored procedures
4. **SQL Server** → Data persistence

## 🔧 Configuración

### appsettings.json

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "..."  // Tu connection string aquí
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information"  // Niveles: Trace, Debug, Information, Warning, Error
    }
  }
}
```

### Obtener connection string en código

```csharp
string connString = ConfigurationHelper.GetConnectionString();
```

## 📊 Base de Datos

### Tablas principales

| Tabla | Propósito |
|-------|-----------|
| `users` | Cuentas de usuarios (Admin, Teacher, Student) |
| `students` | Información de estudiantes |
| `teachers` | Información de maestros |
| `groups` | Grupos/clases de estudiantes |
| `tasks` | Tareas asignadas por maestros |
| `task_submissions` | Entregas de estudiantes |
| `lessons` | Lecciones del curso |
| `vocabulary_lists` | Listas de vocabulario |
| `vocabulary_items` | Palabras en vocabulario |

### Usuario de ejemplo (seed data)

```
Username: admin
Password: admin123
Role: Administrator
```

## 🔨 Compilación y Ejecución

### Compilar

```bash
dotnet build LoginLayeredCSharp.sln
```

### Ejecutar en modo Debug

```bash
dotnet run --project Presentation/Presentation.csproj
```

### Compilar Release

```bash
dotnet build -c Release LoginLayeredCSharp.sln
```

### Ejecutar executable

```bash
./Presentation/bin/Release/net8.0-windows/Presentation.exe
```

## ✨ Características

### Para Estudiantes
- ✅ Ver lecciones y contenido
- ✅ Practicar vocabulario
- ✅ Entregar tareas
- ✅ Ver calificaciones y feedback

### Para Maestros
- ✅ Crear y gestionar tareas
- ✅ Administrar grupos/clases
- ✅ Crear lecciones y vocabulario
- ✅ Calificar entregas
- ✅ Ver reportes de desempeño

### Para Administradores
- ✅ Gestionar usuarios (create, read, update, delete)
- ✅ Crear grupos
- ✅ Ver reportes del sistema
- ✅ Auditoría de actividades

## 🎨 Tecnologías Utilizadas

- **Framework**: .NET 8.0
- **UI**: Windows Forms with Guna.UI2
- **Database**: SQL Server
- **ORM**: ADO.NET (Direct SQL/Stored Procedures)
- **Icons**: FontAwesome.Sharp
- **Reports**: FastReport OpenSource
- **Spreadsheets**: ClosedXML
- **PDF**: iText7
- **Audio**: NAudio

## ⚠️ Pendiente TODO

- [ ] Mover DatabaseHelper a DataAccess layer
- [ ] Implementar unit tests
- [ ] Agregar logging completo
- [ ] Mejorar validación de entrada en forms
- [ ] Crear histórico de cambios (auditoría)
- [ ] Agregar más reportes predefinidos
- [ ] Implementar backup automático de BD
- [ ] Encriptación de contraseñas (usar bcrypt/Argon2)

## 📝 Convenciones de Código

### Naming

- `Frm` prefix para forms: `FrmLogin`, `FrmPrincipal`
- `UC` prefix para user controls: `UCLeccion`, `UCTareas`
- Métodos en español para lógica de negocio
- PascalCase para clases y métodos públicos
- camelCase para variables locales

### Español en el código

El codebase usa español para:
- Nombres de métodos de negocio
- Nombres de variables en lógica compleja
- Comentarios y documentación
- Etiquetas de UI

## 🤝 Contribución

Para contribuir al proyecto:

1. Crea una rama: `git checkout -b feature/tu-feature`
2. Haz commit: `git commit -am 'Agregar feature'`
3. Push a la rama: `git push origin feature/tu-feature`
4. Abre un Pull Request

## 📄 Licencia

[Especifica la licencia aquí]

## 👨‍💻 Soporte

Para reportar bugs o pedir features: [Link a issues]

---

**Última actualización**: Marzo 2026
