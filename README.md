# challenge-back-end

## Información General 🔬

| N° | Item              |                      Detalle |
|:--:|:------------------|-----------------------------:|
| 1  | Java              |                      11.0.20 |
| 3  | Navegador         |                Google Chrome |
| 4  | Sistema Operativo |               Windows 10 Pro |
| 5  | IDE               | Visual Studio Community 2022 |
| 6  | .NET              |                            6 |

## Dependencias Agregadas

```
Microsoft.EntityFrameworkCore
```
```
Microsoft.EntityFrameworkCore.Tools
```
```
Microsoft.EntityFrameworkCore.SQLServer
```
```
Microsoft.EntityFrameworkCore.Design
```
```
Microsoft.Extensions.Configuration
```

## Pre requisitos para ejecutar 📋

- Java: versión 1.8 o superior (variables de entorno configuradas).
- Entorno de desarrollo: Visual Studio Community

## Ejecutar 🔨

### Nombre de la base de datos: 
challenge-back-end

### SQLSERVER - SQLEXPRESS

Verificar el nombre del server para la conexi�n con la base de datos.
select @@SERVERNAME

Dentro del archivo 

#### appsettings.Development.json
Se debe modificar el nombre del server: 

``` cpp
"ConnectionStrings": {
    "DefaultConnection": "Server={server_name};Database=challenge-back-end;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true;"
}
```

### Nota
La herramienta de compilación de código y administrador de dependencias para este proyecto es **Gradle**, así que pare
ejecutar las pruebas use el siguiente comando en la raíz del proyecto.

### Comandos para migraciones

Dentro de la consola de administración de paquetes se debe correr los siguientes comandos:

```
add-migration initialcreate
```
```
update-database
```

## Versionamiento 📌

Se usa Git para el control de versiones. 🔀
###Link del Proyecto

https://github.com/jugiros/challenge-back-end

## Autor 👨 Juan Molina
https://github.com/jugiros
Visual Studio Community 2022
Current version -> Versión 17.3.3