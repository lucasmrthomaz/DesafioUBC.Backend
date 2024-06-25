@echo off

echo [EF Core] Atualizando banco de dados...
echo [EF Core] Aplicando migrations se necessario...
dotnet-ef database update

pause