Microsoft.EntityFrameworkCore -> ORM
Microsoft.EntityFrameworkCore.Tools -> Herramientas
Microsoft.EntityFrameworkCore.SQLServer -> Conexión
Microsoft.EntityFrameworkCore.Design -> Conexión
Microsoft.Extensions.Configuration -> Conexión

.Net versión 6

Verificar todas las dependencias agregadas.

Nombre de la base de datos: challenge-back-end
SQLEXPRESS -> SQLSERVER

Verificar el nombre del server para la conexión con la base de datos.
select @@SERVERNAME

add-migration initialcreate
update-database

Se utiliza SQL Server Express -> Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;