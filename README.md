API REST de Usuarios
Este proyecto consiste en el desarrollo de una API REST utilizando ASP.NET Core y Entity Framework Core con enfoque Code First. La API permite gestionar usuarios mediante operaciones CRUD (Crear, Leer, Actualizar y Eliminar), incluyendo validación para evitar correos electrónicos duplicados.
Tecnologías utilizadas

ASP.NET Core Web API

Entity Framework Core

Base de datos en memoria (InMemory)

Swagger (OpenAPI)
Abrir el proyecto en Visual Studio

Ejecutar la aplicación (F5 o botón "Start")

Se abrirá automáticamente Swagger en:

http://localhost:5000
🧪 Pruebas con Swagger

La API permite las siguientes operaciones:

🔹 GET /api/Usuarios

Obtiene todos los usuarios registrados.

🔹 GET /api/Usuarios/{id}

Obtiene un usuario por su ID.

Respuesta 404 si no existe.

🔹 POST /api/Usuarios

Crea un nuevo usuario.

Valida que el correo no esté duplicado.

Retorna error 400 si el correo ya existe.

Ejemplo:

{
  "nombre": "Juan",
  "correo": "juan@gmail.com",
  "fechaDeNacimiento": "2000-01-01"
}
🔹 PUT /api/Usuarios/{id}

Actualiza un usuario existente.

El ID debe coincidir.

Retorna error 400 si el ID es incorrecto.

🔹 DELETE /api/Usuarios/{id}

Elimina un usuario por ID.

Retorna 404 si no existe.

 Manejo de errores

La API incluye:

Validación de correo duplicado

Respuestas claras (400, 404, 500)

Mensajes descriptivos para cada error

Capturas de pantalla

Las capturas de las pruebas CRUD se encuentran incluidas en este repositorio:

GET usuarios

GET por ID

POST usuario

PUT usuario

DELETE usuario

 Estructura del proyecto
![Uploading image.png…]()

Controllers → Controladores de la API

Models → Modelo Usuario

Data → Contexto de base de datos

Program.cs → Configuración principal

 Estado del proyecto

✔ CRUD completo
✔ Validación de correo duplicado
✔ Uso de Entity Framework Core (Code First)
✔ Pruebas realizadas con Swagger
✔ Manejo de errores implementado
