Microsoft.EntityFrameworkCore -> ORM
Microsoft.EntityFrameworkCore.Tools -> Herramientas
Microsoft.EntityFrameworkCore.SQLServer -> Conexi�n
Microsoft.EntityFrameworkCore.Design -> Conexi�n
Microsoft.Extensions.Configuration -> Conexi�n

Nombre de la base de datos: challenge-back-end
Habilitar conei�n para SQLEXPRESS Sql Server Configuration Manager
IPAddresses -> IPALL TCP PORT 

Verificar el nombre del server para la conexi�n con la base de datos.

add-migration initialcreate
update-database

Se utiliza SQL Server Express -> Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;