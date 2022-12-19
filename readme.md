# Sistema Gestor de eventos

## Estrutura

### /docs

Contiene documentación respaldatoria del proyecto.

* [SGE.eap](/docs/SGE.eap): Archivo de EnterpriseArchitect con diagramas UML


### SistemaGestorEventos.GUI

Contiene las vistas del sistema.
Es importante destacar que esta capa no es responsable de la logica del negocio, sino que unicamente se encarga de presentar y capturar datos del usuario.

### SistemaGestorEventos.BLL

Capa de negocio, se encarga de realizar validaciones del negocio ademas de implementar la logica especifica del SGE

### SistemaGestorEventos.DAL

Capa de acceso a datos, todos los DAL implementarán la interfaz CRUD.

Tambien esta incluido el archivo para levantar la base de datos como recurso del proyecto  DAL.
Buscar 'createSchema.txt' (se usa en el instalador).

### SistemaGestorEventos.BE

Contiene las estructuras de negocio.

### SistemaGestorEventos.SharedServices

Implementación de servicios que no son propios del negocio del SGE.
Ejemplos:
* Bitacora
* Sesion
* Multiidioma



### Dataset utiles
* listado de todas las localidades argentinas.

https://datos.gob.ar/dataset/jgm-servicio-normalizacion-datos-geograficos/archivo/jgm_8.1
https://infra.datos.gob.ar/catalog/modernizacion/dataset/7/distribution/7.5/download/localidades.json

* Para generar la ayuda:
https://www.helpndoc.com/es/
hack para abrirlo cuando no encontras el path: [LINK](https://github.com/fpusderkis/SistemaGestorEventos/blob/master/SistemaGestorEventos.GUI/FirstTime/FirstTimeForm.cs#L57-L68)

* Instalador

Crea un proyecto instalador de visual studio 2022 (o el que estes usando) y busca un tutorial.

La documentación es bastante escueta, para evitar demoras lo que no salio facil (levantar la db) lo hice dentro del programa [LINK](https://github.com/fpusderkis/SistemaGestorEventos/pull/10/files#diff-2c86bfe45ad2da9ced2a7681d32c5386926a9028ecb7b8e29ba5bcbcae637124R93)

si el script tira error, buscar la innerException adentro del try catch y te da mas info.

El script lo hice exportando de la base de datos.
