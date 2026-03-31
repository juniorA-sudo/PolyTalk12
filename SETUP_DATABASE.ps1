# =====================================================
# POLYTALK - DATABASE SETUP SCRIPT
# Execute this PowerShell script to reset and setup the database
# =====================================================

Write-Host ""
Write-Host "========================================"
Write-Host "PolyTalk Database Setup"
Write-Host "========================================"
Write-Host ""

# SQL Server connection info
$sqlServer = "localhost\SQLEXPRESS01"
$workingDir = "C:\Proyectos\PolyTalk12\.claude\worktrees\laughing-panini\Database"

Write-Host "Step 1: Creating Complete Database Schema..."
Write-Host "  SQL Server: $sqlServer"
Write-Host "  Script: 01_CreateDatabase_Complete.sql"
Write-Host ""

sqlcmd -S $sqlServer -E -C -i "$workingDir\01_CreateDatabase_Complete.sql"

if ($LASTEXITCODE -eq 0) {
    Write-Host "✓ Database created successfully!" -ForegroundColor Green
} else {
    Write-Host "✗ Error creating database" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "Step 2: Inserting Test Data..."
Write-Host "  Script: 02_InsertTestData_Complete.sql"
Write-Host ""

sqlcmd -S $sqlServer -E -C -i "$workingDir\02_InsertTestData_Complete.sql"

if ($LASTEXITCODE -eq 0) {
    Write-Host "✓ Test data inserted successfully!" -ForegroundColor Green
} else {
    Write-Host "✗ Error inserting test data" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "========================================"
Write-Host "DATABASE SETUP COMPLETE!"
Write-Host "========================================"
Write-Host ""
Write-Host "Login Credentials:"
Write-Host "  Admin:"
Write-Host "    Username: admin_poly"
Write-Host "    Password: admin123"
Write-Host ""
Write-Host "  Teachers:"
Write-Host "    Username: maestro1, maestro2, maestro3"
Write-Host "    Password: maestro123"
Write-Host ""
Write-Host "  Students:"
Write-Host "    Username: estudiante1 - estudiante6"
Write-Host "    Password: estudiante123"
Write-Host ""
Write-Host "Next Steps:"
Write-Host "  1. Close Visual Studio if open"
Write-Host "  2. Delete bin and obj folders:"
Write-Host "     - C:\Proyectos\PolyTalk12\Presentation\bin"
Write-Host "     - C:\Proyectos\PolyTalk12\Presentation\obj"
Write-Host "  3. Open: C:\Proyectos\PolyTalk12\LoginLayeredCSharp.sln"
Write-Host "  4. Build → Rebuild Solution"
Write-Host "  5. Press Ctrl+F5 to run"
Write-Host ""
