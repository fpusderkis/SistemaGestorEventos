USE [sgedb]
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Administrador', N'031165cc-98f4-460a-95db-18ea25e3bd9b', NULL)
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'GestionServicio', N'439dc8c5-4fce-4f70-b31c-48f0ba8c3673', N'GestionarServicio')
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Organizador', N'94686786-66f5-4975-9767-7d1d9a3d1cf6', NULL)
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Participante', N'730fae8e-aa38-48e9-a563-8436c3d8c6e8', NULL)
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'GestionLugar', N'b5cab92c-55fb-4ba9-9953-8739ce5eaeb6', N'GestionarLugar')
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Administrador', N'dc37e126-1f43-49cc-ad7c-bade3cc0fa7e', N'AdministradorSistema')
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Lugar', N'778dcb13-cee3-4941-95d0-bc8819227757', NULL)
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'VerReserva', N'01a8303f-5ca2-430b-8685-d043d6f84f3c', N'GestionarLugar')
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Servicio', N'c68adcd8-c7fa-480d-93c5-d157b026df99', NULL)
GO
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'', N'41731814-ce22-4fc4-93ad-ec7b5013a469', N'GestionarLugar')
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (N'031165cc-98f4-460a-95db-18ea25e3bd9b', N'778dcb13-cee3-4941-95d0-bc8819227757')
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (N'031165cc-98f4-460a-95db-18ea25e3bd9b', N'b5cab92c-55fb-4ba9-9953-8739ce5eaeb6')
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (N'94686786-66f5-4975-9767-7d1d9a3d1cf6', N'730fae8e-aa38-48e9-a563-8436c3d8c6e8')
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (N'031165cc-98f4-460a-95db-18ea25e3bd9b', N'94686786-66f5-4975-9767-7d1d9a3d1cf6')
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (N'730fae8e-aa38-48e9-a563-8436c3d8c6e8', N'01a8303f-5ca2-430b-8685-d043d6f84f3c')
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (N'778dcb13-cee3-4941-95d0-bc8819227757', N'b5cab92c-55fb-4ba9-9953-8739ce5eaeb6')
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (N'778dcb13-cee3-4941-95d0-bc8819227757', N'01a8303f-5ca2-430b-8685-d043d6f84f3c')
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (N'031165cc-98f4-460a-95db-18ea25e3bd9b', N'dc37e126-1f43-49cc-ad7c-bade3cc0fa7e')
GO
INSERT [dbo].[Usuarios] ([Id], [username], [password], [idioma]) VALUES (N'1b79b9e1-025b-4a2f-938d-61fb991b47f4', N'pepe', N'???P?8?^}?/0???', N'es_AR')
GO
INSERT [dbo].[Usuarios] ([Id], [username], [password], [idioma]) VALUES (N'2b43a323-0e19-4c98-840d-e6bf69239824', N'Carlitos', N'??C????!u??	-?`', N'en_US')
GO
INSERT [dbo].[Usuarios] ([Id], [username], [password], [idioma]) VALUES (N'62c937d7-041e-41fc-87f8-fa2114810ec1', N'fede', N'}???t???"?????', N'es_AR')
GO
INSERT [dbo].[Usuarios] ([Id], [username], [password], [idioma]) VALUES (N'645ed0cc-a5cb-4783-a176-fb151b026931', N'federico', N'}???t???"?????', N'es_AR')
GO
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (N'62c937d7-041e-41fc-87f8-fa2114810ec1', N'031165cc-98f4-460a-95db-18ea25e3bd9b')
GO
INSERT [dbo].[Idiomas] ([Id], [Descripcion]) VALUES (N'en-US', N'Ingles USA')
GO
INSERT [dbo].[Idiomas] ([Id], [Descripcion]) VALUES (N'es-AR', N'Español Argentina')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'admin.users.title', N'en-US', N'Users admin')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'admin.users.title', N'es-AR', N'Administrar Permisos de Usuarios')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'admin.users.usersetup', N'en-US', N'Users settings')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'admin.users.usersetup', N'es-AR', N'Configurar Usuario')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.add', N'en-US', N'Add')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.add', N'es-AR', N'Agregar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.cancel', N'en-US', N'Cancel')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.cancel', N'es-AR', N'Cancel')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.config', N'en-US', N'Config')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.config', N'es-AR', N'Configurar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.config.save', N'en-US', N'Save')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.config.save', N'es-AR', N'Guardar configuracion')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.config.selected', N'en-US', N'Config selected')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.config.selected', N'es-AR', N'Configurar seleccionado')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.create', N'en-US', N'Create')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.create', N'es-AR', N'Crear')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.dismiss', N'en-US', N'Dismiss')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.dismiss', N'es-AR', N'Descartar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.exit', N'en-US', N'Exit')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.exit', N'es-AR', N'Salir')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.login', N'en-US', N'Login')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.login', N'es-AR', N'Login')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.manage', N'es-AR', N'Gestionar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.remove', N'en-US', N'Remove')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.remove', N'es-AR', N'Quitar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.save', N'en-US', N'Save')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.save', N'es-AR', N'Guardar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'btn.singin', N'es-AR', N'Registrar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'cancel', N'es-AR', N'Cancelar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'contactinfo', N'es-AR', N'Información de contacto')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'direccion', N'es-AR', N'Direccion')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'edit.family', N'en-US', N'Family')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'edit.family', N'es-AR', N'Editar familia')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'email', N'es-AR', N'E-Mail')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'errors.invaliduserorpassword', N'en-US', N'Invalid username or password')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'errors.invaliduserorpassword', N'es-AR', N'Usuario/clave invalidos')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'event', N'es-AR', N'Evento')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'event.create', N'es-AR', N'Crear evento')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'event.date', N'es-AR', N'Fecha')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'event.description', N'es-AR', N'Direccion')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'event.duration', N'es-AR', N'Duracion')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'event.participants', N'es-AR', N'Participantes')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'event.place', N'es-AR', N'Lugar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'event.servicios', N'es-AR', N'Servicios adicionales')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'event.title', N'es-AR', N'Titulo')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'families', N'en-US', N'Families')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'families', N'es-AR', N'Familias')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'family', N'en-US', N'Family')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'family', N'es-AR', N'Familia')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'FrmCrearEditarIdioma.Error.SeleccionaIdioma', N'en-US', N'')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'FrmCrearEditarIdioma.Error.SeleccionaIdioma', N'es-AR', N'Escriba un identificador de idioma, se recomienda el formato de la RFC3066 (es-AR)')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'grants', N'en-US', N'Grants')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'grants', N'es-AR', N'Patentes')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'language', N'es-AR', N'Idioma')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'lugar.buscar', N'es-AR', N'Buscar Lugar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'main.title', N'es-AR', N'Se Hace!')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.admin', N'es-AR', N'Administrador')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.admin.grants', N'en-US', N'Manage grants')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.admin.grants', N'es-AR', N'Admnistrar Permisos')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.admin.lang', N'es-AR', N'Gestor idiomas')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.admin.users', N'en-US', N'Manage users')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.admin.users', N'es-AR', N'Admnistrar Usuarios')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.home', N'es-AR', N'Home')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.lang.change', N'en-US', N'Change languaje')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.lang.change', N'es-AR', N'Cambiar Idioma')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.login', N'en-US', N'Login')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.login', N'es-AR', N'Iniciar Sesión')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.logout', N'en-US', N'Logout')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.logout', N'es-AR', N'Cerrar sesión')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.newevent', N'es-AR', N'Crear evento')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.register', N'es-AR', N'Registrarse')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.singin', N'en-US', N'Sign In')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.singin', N'es-AR', N'Registrar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.usuario', N'en-US', N'User')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'mnu.usuario', N'es-AR', N'Usuario')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'nombre', N'es-AR', N'Nombre')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'password', N'en-US', N'Password')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'password', N'es-AR', N'Clave')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'phone', N'es-AR', N'Teléfono')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'precio', N'es-AR', N'Precio')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'servicio.btn.agregar', N'es-AR', N'Quitar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'title.admin.grants', N'en-US', N'Manage grants')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'title.admin.grants', N'es-AR', N'Administrar permisos')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'title.doit', N'es-AR', N'Se hace!')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'title.login', N'en-US', N'Login')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'title.login', N'es-AR', N'Login')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'title.main', N'en-US', N'Do it!')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'title.main', N'es-AR', N'Se Hace!')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'title.signin', N'es-AR', N'Registrar')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'UnhandledGenericErrorMessage', N'en-US', N'Ops! An unexpected error occurs')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'UnhandledGenericErrorMessage', N'es-AR', N'Ups! Ocurrio un error.')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'user', N'es-AR', N'Usuario')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'username', N'en-US', N'Username')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'username', N'es-AR', N'Nombre de usuaio')
GO
INSERT [dbo].[Traducciones] ([clave], [idioma], [valor]) VALUES (N'webpage', N'es-AR', N'Web')
GO
