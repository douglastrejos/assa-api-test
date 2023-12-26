# Prueba de Conocimiento para Programador Backend en C#
## Objetivos:
Evaluar las habilidades del candidato en el desarrollo de aplicaciones backend utilizando C#, Entity Framework, pruebas unitarias con XUnit, y la configuración de entornos con Docker Compose.

- Conexión a la Base de Datos
- Migración y Data Seed
- API REST - Consumir Datos
- Docker Compose
- Pruebas Unitarias

## Instalacion

Es necesario Docker Desktop, Abra PowerShell y ubiquese en la carpeta del proyecto, escriba la siguiente linea de comando

```sh
dotnet build
dotnet ef migrations add ¨initial migrations¨
dotnet ef database update
docker-compose up --build
```

Ingrese a la url http://localhost:8088/MarcasAutos

