Microsoft.EntityFrameworkCore -> ORM
Microsoft.EntityFrameworkCore.Tools -> Herramientas
Microsoft.EntityFrameworkCore.SQLServer -> Conexi�n
Microsoft.EntityFrameworkCore.Design -> Conexi�n
Microsoft.Extensions.Configuration -> Conexi�n

Visual Studio Community 2022
Current version -> Versión 17.3.3

.Net versi�n 6

Verificar todas las dependencias agregadas.

Nombre de la base de datos: challenge-back-end
SQLEXPRESS -> SQLSERVER

Verificar el nombre del server para la conexi�n con la base de datos.
select @@SERVERNAME

add-migration initialcreate
update-database

Se utiliza SQL Server Express -> Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;