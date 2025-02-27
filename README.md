# EmployeeManagerAPI
Proyecto Backend para la gestion de empleados

# Instrucciones para su uso
1 - Restaurar la base de datos adjunta en el correo 
2 - Clonar el Repositorio del proyecto
3 - Modificar el archivo appsenttings.json con la direccion y credenciales de su gestor de base de datos SQLServer

# Configuracion de IIS
1 - Verifique que IIS se encuentre habilitado en su Servidor
  1.1 - En el caso que no tenga configurado IIS en su servidor continue con los siguientes pasos
    1.1.1 - Entre al panel de control > programas > Activar y desactivar caracteristicas de Windows
    1.1.2 - Marque el check de Servidor Web (IIS)
    1.1.3 - Espere a que termine la instalacion
2 - Cree un nuevo sitio web dentro de IIS
    2.1 - Coloque el nombre del sitio "EmployeeManagerAPI" 
    2.2 - Utilizando el puerto 5017
    2.3 - Seleccione la carpeta donde almacena sus sitios web sino cuenta con usa puede crearla la ubicacion que usted prefiera
        2.3.1 - Verifique que la carpeta contenga los permisos necesarios 
    2.4 - Utilizando http asigne la ip de salida de sus servidor con el puerto antes mencionado
    2.5 - Guarde las configuraciones 

# Publicar el proyecto
1 - Verfique que su servidor tenga instalado el Runtime correspondiente a .NET 8
2 - Utilizando Visual Studio Code genere la publicacion del proyecto utilizando el codigo en la consola  "dotnet publish -c Release -o ./publish"
2 - Utilizando Visual Studio utilice la herramienta de publicacion
3 - Copie y despues pegue los archivos de publicacion a la carpeta asignada al sitio web 
4 - Inicie el sitio web 
5 - El sistema deberia mostrar la pagina de Swagger 

# Notas 
- Tener en cuenta que esta API cuenta con Identity por lo que se ha configurado un usuario por defecto
    user: userTest@testmail.com pass: Pass@test01

