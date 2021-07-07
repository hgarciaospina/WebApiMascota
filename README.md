# WebApiMascota
Ejercicio 1 - Bootcamp Exsis WebApi Método Get
-------------------------------------------------
Crear un proyecto de web api y un nuevo end point
1.Crear Proyecto WebAPI
2.Agregar un controlador
3.Crear un clase (Libre)
4.Crear en metodo marcado como HTTP Get que regrese una instancia de la clase creada.

Ejercicio 2:
--------------------------------------------------
Agregar un nuevo proyecto a la solucion (.net standard) y nombrarlo 'Models'
Agregar una clase al proyecto de models, la clase debe cumpliar con lo siguiente
propiedad Id del tipo int
3 propiedades mas (libre)
Agregar un proyecto nuevo a la solucion (.net core) y nombrarlo 'Data'
Agregar como referencia el proyecto 'Models'
Agregar los siguientes nuget packages paquetes
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Crear una clase de contexto (basarse en el contenido de lo que vimos en clase)
Crear un nueva migracion desde el nuget package console 'add-migration name'
Correr la migracion desde nuget packafe console 'update-database -verbose'