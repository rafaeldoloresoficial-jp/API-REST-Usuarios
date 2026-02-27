using API_REST.Data;
using Microsoft.EntityFrameworkCore;

namespace API_REST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 1. Configurar la base de datos en memoria (UsuariosDB)
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase("UsuariosDB"));

            // 2. Agregar controladores y Swagger
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // 3. Configurar Swagger para que abra en la raíz
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Usuarios V1");
                c.RoutePrefix = string.Empty; // Swagger se abre en http://localhost:5000
            });

            // 4. Mapear controladores
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}