Microsoft.EntityFrameworkCore -> ORM
Microsoft.EntityFrameworkCore.Tools -> Herramientas
Microsoft.EntityFrameworkCore.SQLServer -> Conexión
Microsoft.EntityFrameworkCore.Design -> Conexión
Microsoft.Extensions.Configuration -> Conexión


dotnet ef migrations add Initial
add-migration initialcreate

Se utiliza SQL Server Express -> Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;