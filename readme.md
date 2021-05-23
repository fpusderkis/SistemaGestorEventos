# Sistema Gestor de eventos

## Estrutura

### /docs

Contiene documentaci�n respaldatoria del proyecto.

* [SGE.eap](/docs/SGE.eap): Archivo de EnterpriseArchitect con diagramas UML


### SistemaGestorEventos.GUI

Contiene las vistas del sistema.
Es importante destacar que esta capa no es responsable de la logica del negocio, sino que unicamente se encarga de presentar y capturar datos del usuario.

### SistemaGestorEventos.BLL

Capa de negocio, se encarga de realizar validaciones del negocio ademas de implementar la logica especifica del SGE

### SistemaGestorEventos.DAL

Capa de acceso a datos, todos los DAL implementar�n la interfaz CRUD.

### SistemaGestorEventos.BE

Contiene las estructuras de negocio.

### SistemaGestorEventos.SharedServices

Implementaci�n de servicios que no son propios del negocio del SGE.
Ejemplos:
* Bitacora
* Sesion
* Multiidioma


