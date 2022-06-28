# ListasDeCompras
TP univeristario simple, con 2 entidades conectadas con arquitectura DDD.

Para tener una copia local del proyecto debe ejercutar el comando:
Git clone https://github.com/emiizaca/ListasDeCompras.git

Se le habrá descargado una carpeta llamada ListasDeCompras, dentro de ella está el archivo principal ListasDeCompras.sln el cual se ejecuta con el IDE
Visual Studio.

Para que corra correctamente debe tener localmente una base de datos MySQL con los siguientes datos:

Database: listas_de_compras
Tabla buylist con las columnas id(VARCHAR(70)), name(VARCHAR(40)), classification(VARCHAR(30)) y buyDate(datetime).
Tabla product con las columnas id(VARCHAR(70)), buyListId(VARCHAR(70)), name(VARCHAR(40)), brand(VARCHAR(30)), quantity(INT) y category(VARCHAR(30)).

El programa consta de 5 capas: \n
  Presentación - Donde el usuario interactua con el programa por medio de una console app.\n
  App - En donde se implementan los servicios que correponden a los casos de uso.\n
  Domain - Donde se implementa toda la logica de negocio.\n
  Infraestructure - Donde se implementa la persistencia de los datos.\n
  Transversal - Es un capa particular donde se almacenan funciones compartidas por todas las capas.\n
  
Por ultimo dentro del proyecto Infraestructura, en la carpeta Repositories estan los repositorios encargados de conectarse a diferentes DDBB, dentro de los 
archivos BuyListMySQLRepository y ProductMySQLRepository en el metodo MySQLConnection debe colocar el string correpondiente a su base de datos local.
