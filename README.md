Microsoft.EntityFrameworkCore -> ORM
Microsoft.EntityFrameworkCore.Tools -> Herramientas
Microsoft.EntityFrameworkCore.SQLServer -> Conexi�n
Microsoft.EntityFrameworkCore.Design -> Conexi�n
Microsoft.Extensions.Configuration -> Conexi�n


dotnet ef migrations add Initial
add-migration initialcreate

Se utiliza SQL Server Express -> Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;