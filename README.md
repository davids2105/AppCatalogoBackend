# Backend API - AP Catalogo

API desarrollada en **.NET Core 9** con **Entity Framework Core** y SQL Server, para manejar un catálogo de productos.

---

## **Tecnologías**

- .NET Core 9
- C#
- Entity Framework Core 9
- SQL Server
- Swashbuckle / Swagger para documentación de la API

---
## **Instalación y Configuración**

1. Clonar el repositorio:

```bash
git clone <URL_DEL_REPO>
cd backend

2. Restaurar paquetes NuGet:

dotnet restore

3. Configurar la cadena de conexión en appsettings.json:

{
  "ConnectionStrings": {
    "MiConexion": "Server=localhost\\SQLEXPRESS;Database=dbProductos;Trusted_Connection=True;TrustServerCertificate=True;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}


⚠ Cambia localhost\SQLEXPRESS y dbProductos según tu entorno.

4. Aplicar migraciones y crear la base de datos:

dotnet ef database update


5. Ejecutar la API:

dotnet run


La API estará disponible en:

http://localhost:5033

| Método | Ruta               | Descripción                      |
| ------ | ------------------ | -------------------------------- |
| GET    | /api/products      | Listar todos los productos       |
| GET    | /api/products/{id} | Obtener un producto por id       |
| POST   | /api/products      | Crear un nuevo producto          |
| PUT    | /api/products/{id} | Actualizar un producto existente |

La documentación de la API se puede ver en Swagger:
http://localhost:5033/swagger/index.html

Autor

Deivid Andres Cifuentes Sanchez

