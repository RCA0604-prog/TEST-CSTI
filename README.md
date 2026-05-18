# TEST-CSTI

Este repositorio contiene la solución completa para la prueba técnica, incluyendo tanto el **frontend** como el **backend** del proyecto.

## 🏗️ Estructura del proyecto
TEST-CSTI-FRONTEND/
├── ProductosApi BACKEND/ # API REST desarrollada con .NET 9
└── test-productos FRONTEND/ # Aplicación cliente desarrollada con Angular 19

## 🚀 Tecnologías utilizadas

### Backend
- **.NET 9** - Framework principal
- **ASP.NET Core** - API RESTful
- **Entity Framework Core** - ORM para acceso a datos
- **Swagger/OpenAPI** - Documentación interactiva de la API

### Frontend
- **Angular 19** - Framework principal
- **TypeScript** - Lenguaje de programación
- **Bootstrap / CSS** - Estilos y diseño responsive

## Cómo ejecutar

### Base de datos
Ejecutar el archivo **Creacion de productos.sql**
### Backend
1. Abrir solución en Visual Studio
2. Configurar connection string
3. Ejecutar `dotnet run`

### Frontend
1. `npm install`
2. `ng serve -o`

## Endpoints
- GET /api/Producto/consultar
- POST /api/Producto/insertar
