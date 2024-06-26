# 📚 Labor Portfolio API

¡Bienvenido a la API de proyectos laborales para un portafolio! Este proyecto está construido con .NET y Entity Framework (EF). Esta API te permite gestionar proyectos laborales de manera eficiente y profesional.

## 🚀 Tecnologías Utilizadas

- .NET Core
- Entity Framework Core
- SQL Server Lite

## 🏁 Comenzando

Sigue estos pasos para poner en marcha el proyecto en tu entorno local.

### Pre-requisitos

- .NET Core SDK 5.0 o superior
- SQL Server

### Instalación

1. Clona el repositorio a tu máquina local::

   ```sh
   git clone https://github.com/tu-usuario/tu-repo.git
   cd tu-repo
   
   
1. Restaura las dependencias y construye el proyecto::

   ```sh
   dotnet restore
   dotnet build

1. Aplica las migraciones de la base de datos::

   ```sh
   dotnet ef database update
   
1. Ejecución::

   ```sh
   dotnet run
El servidor estará disponible en https://localhost:7194 o http://localhost:7194.

### 📋 Endpoints
Aquí tienes algunos de los endpoints disponibles en la API:

GET /api/Proyect - Obtiene todos los Proyectos
GET /api/Proyect/{idProyect} - Obtiene solo un Proyecto
POST /api/Proyect - Agrega un nuevo Proyecto
PUT /api/Proyect/{id} - Actualiza un Proyecto existente
DELETE /api/Proyect/{id} - Elimina un Proyecto
GET /api/Proyect/search - Buscar un proyecto
### 🛠 Herramientas de Desarrollo
Visual Studio Code / Visual Studio
Postman/swagger para probar los endpoints
### 👥 Contribuyendo
Si deseas contribuir a este proyecto, Comunicate

### Haz un fork del proyecto
Crea una rama con tu nueva funcionalidad (git checkout -b nueva-funcionalidad)
Realiza tus cambios y haz commit (git commit -am 'Agrega nueva funcionalidad')
Sube tus cambios (git push origin nueva-funcionalidad)
Crea un nuevo Pull Request
