# ListasDeCompras
TP univeristario simple, con 2 entidades conectadas con arquitectura DDD
El siguiente programa se ejecuta a travez del IDE Visual Studio abriendo el archivo ListasDeCompras.sln.

Para que corra correctamente debe tener localmente una base de datos MySQL con los siguientes datos:

Database: listas_de_compras
Tabla buylist con las columnas id(VARCHAR(70)), name(VARCHAR(40)), classification(VARCHAR(30)) y buyDate(datetime).
Tabla product con las columnas id(VARCHAR(70)), buyListId(VARCHAR(70)), name(VARCHAR(40)), brand(VARCHAR(30)), quantity(INT) y category(VARCHAR(30)).

El programa consta de 5 capas: 
  Presentación - Donde el usuario interactua con el programa por medio de una console app.
  App - En donde se implementan los servicios que correponden a los casos de uso.
  Domain - Donde se implementa toda la logica de negocio.
  Infraestructure - Donde se implementa la persistencia de los datos.
  Transversal - Es un capa particular donde se almacenan funciones compartidas por todas las capas.
  
Por ultimo dentro del proyecto Infraestructura, en la carpeta Repositories estan los repositorios encargados de conectarse a diferentes DDBB, dentro de los 
archivos BuyListMySQLRepository y ProductMySQLRepository en el metodo MySQLConnection debe colocar el string correpondiente a su base de datos local.
