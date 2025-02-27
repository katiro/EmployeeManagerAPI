# EmployeeManagerAPI
Proyecto Backend para la gestion de empleados

# Instrucciones para su uso
- Restaurar la base de datos adjunta en el correo 
- Clonar el Repositorio del proyecto
- Modificar el archivo appsenttings.json con la direccion y credenciales de su gestor de base de datos SQLServer

# Configuracion de IIS
- Verifique que IIS se encuentre habilitado en su Servidor
  - En el caso que no tenga configurado IIS en su servidor continue con los siguientes pasos
    - Entre al panel de control > programas > Activar y desactivar caracteristicas de Windows
    - Marque el check de Servidor Web (IIS)
    - Espere a que termine la instalacion
- Cree un nuevo sitio web dentro de IIS
    - Coloque el nombre del sitio "EmployeeManagerAPI" 
    - Utilizando el puerto 5017
    - Seleccione la carpeta donde almacena sus sitios web sino cuenta con usa puede crearla la ubicacion que usted prefiera
        - Verifique que la carpeta contenga los permisos necesarios 
    - Utilizando http asigne la ip de salida de sus servidor con el puerto antes mencionado
    - Guarde las configuraciones 

# Publicar el proyecto
- Verfique que su servidor tenga instalado el Runtime correspondiente a .NET 8
- Utilizando Visual Studio Code genere la publicacion del proyecto utilizando el codigo en la consola  "dotnet publish -c Release -o ./publish"
- Utilizando Visual Studio utilice la herramienta de publicacion
- Copie y despues pegue los archivos de publicacion a la carpeta asignada al sitio web 
- Inicie el sitio web 
- El sistema deberia mostrar la pagina de Swagger 

# Notas 
- Tener en cuenta que esta API cuenta con Identity por lo que se ha configurado un usuario por defecto
    user: userTest@testmail.com pass: Pass@test01

