CREATE DATABASE Feelify;
USE Feelify;

--# #####################################################
--# Crear tabla Paises
--# #####################################################
CREATE TABLE Paises(
  idPais INT NOT NULL IDENTITY, --#id del Pais
  Nombre VARCHAR(35) NOT NULL UNIQUE, --#Nombre del pais
  PRIMARY KEY(idPais)
);


--# #####################################################
--# Crear tabla TipoUsuario
--# #####################################################
CREATE TABLE TiposUsuario(
  idTipoUsuario INT NOT NULL IDENTITY, --#id del tipo de usuario
  Nombre CHAR(11) NOT NULL UNIQUE, --#Tipo de usuario(Admin,moderador,etc.)
  PRIMARY KEY(idTipoUsuario)
);


--# #####################################################
--# Crear tabla Estados
--# #####################################################
CREATE TABLE Estados(
  idEstado INT NOT NULL IDENTITY, --#id del estado
  Nombre CHAR(8) NOT NULL UNIQUE, --#Tipo de estado(activo o inactivo)
  PRIMARY KEY(idEstado)
);


--# #####################################################
--# Crear tabla Usuarios
--# #####################################################
CREATE TABLE Usuarios(
  idUsuario INT NOT NULL IDENTITY, --#id del usuario
  Nombre VARCHAR(20) NOT NULL, --#Nombre del usuario
  A_Paterno VARCHAR(20) NOT NULL, --#Apellido paterno del usuario
  A_Materno VARCHAR(20) NULL, --#Apellido materno del usuario (puede ser nulo)
  Correo VARCHAR(40) NOT NULL UNIQUE, --#Correo del usuario
  Password VARBINARY(max) NOT NULL, --#Contraseña del usuario, debe ser BLOB para usar encriptacion AES (https://mysqldatabaseadministration.blogspot.com/2006/08/storing#passwords#in#mysql.html)
  Username VARCHAR(30) NOT NULL UNIQUE, --#Nombre de pantalla del usuario
  FechaRegistro DATE NOT NULL, --#Fecha en la que se registro el usuario
  idPais INT NOT NULL, --#id del pais del usuario
  idTipoUsuario INT NOT NULL, --#id del tipo de usuario del usuario
  idEstado INT NOT NULL, --#id del estado del usuario
  PRIMARY KEY(idUsuario), 
  CONSTRAINT FK_Usuarios_Paises
    FOREIGN KEY(idPais)
    REFERENCES Paises(idPais)
    ON DELETE CASCADE,
  CONSTRAINT FK_Usuarios_TiposUsuario
    FOREIGN KEY(idTipoUsuario)
    REFERENCES TiposUsuario(idTipoUsuario)
    ON DELETE CASCADE,
  CONSTRAINT FK_Usuarios_Estados1
    FOREIGN KEY(idEstado)
    REFERENCES Estados(idEstado)
    ON DELETE CASCADE
);


--# #####################################################
--# Crear tabla Actividades
--# #####################################################
CREATE TABLE Actividades(
  idActividad INT NOT NULL IDENTITY, --#id de la activdad 
  Nombre VARCHAR(20) NOT NULL UNIQUE, --#Nombre de la actividad (correr, programar, jugar, etc.)
  PRIMARY KEY(idActividad)
);


--# #####################################################
--# Crear Tabla Sentimientos
--# #####################################################
CREATE TABLE Sentimientos(
  idSentimiento INT NOT NULL IDENTITY, --#id del sentimiento
  Nombre VARCHAR(20) NOT NULL UNIQUE, --#Nombre del sentimiento (felicidad, tristeza, etc.)
  PRIMARY KEY(idSentimiento)
);


--# #####################################################
--# Crear tabla UsuariosSentimientos
--# #####################################################
CREATE TABLE UsuariosSentimientos(
  idUsuario INT NOT NULL, --#id del usuario
  idSentimiento INT NOT NULL, --#id del sentimiento
  Fecha DATETIME2(0) NULL, --#Fecha y hora en la que se registro el sentimiento
  PRIMARY KEY(idUsuario, idSentimiento),
  CONSTRAINT FK_UsuariosSentimientos_Usuarios
    FOREIGN KEY(idUsuario)
    REFERENCES Usuarios(idUsuario)
    ON DELETE CASCADE,
  CONSTRAINT FK_UsuariosSentimientos_Sentimientos
    FOREIGN KEY(idSentimiento)
    REFERENCES Sentimientos(idSentimiento)
    ON DELETE CASCADE
);


--# #####################################################
--# Crear tabla UsuariosActividades
--# #####################################################
CREATE TABLE UsuariosActividades(
  idUsuario INT NOT NULL, --#id del usuario
  idActividad INT NOT NULL, --#id de la actividad
  Fecha DATETIME2(0) NOT NULL, --#Fecha y hora de la actividad
  PRIMARY KEY(idUsuario, idActividad),
  CONSTRAINT FK_UsuariosActividades_Usuarios
    FOREIGN KEY(idUsuario)
    REFERENCES Usuarios(idUsuario)
    ON DELETE CASCADE,
  CONSTRAINT FK_UsuariosActividades_Actividades
    FOREIGN KEY(idActividad)
    REFERENCES Actividades(idActividad)
    ON DELETE CASCADE
);


--# #####################################################
--# Crear tabla Artistas
--# #####################################################
CREATE TABLE Artistas(
  idArtista INT NOT NULL IDENTITY, --#id del artista
  Nombre VARCHAR(45) NOT NULL, --#Nombre del artista (Billy Joel, PXNDX, etc)
  idPais INT NOT NULL, --#id del pais del artista
  PRIMARY KEY(idArtista),
  CONSTRAINT FK_Artistas_Paises
    FOREIGN KEY(idPais)
    REFERENCES Paises(idPais)
    ON DELETE CASCADE
);


--# #####################################################
--# Crear tabla Albums
--# #####################################################
CREATE TABLE Albums(
  idAlbum INT NOT NULL IDENTITY, --#id del album
  Nombre VARCHAR(45) NOT NULL, --#Nombre del album
  Imagen VARCHAR(max), --#Ruta en la que esta almacenada la imagen
  FechaSalida DATE NULL, --#Fecha en la que salio el album
  idArtista INT NOT NULL, --#id del artista del album
  PRIMARY KEY(idAlbum),
  CONSTRAINT FK_Albums_Artistas
    FOREIGN KEY(idArtista)
    REFERENCES Artistas(idArtista)
    ON DELETE CASCADE
);


--# #####################################################
--# Crear tabla Canciones
--# #####################################################
CREATE TABLE Canciones(
  idCancion INT NOT NULL IDENTITY, --#id de la cancion
  Nombre VARCHAR(40) NOT NULL, --#Nombre de la cancion
  Duracion TIME(0) NOT NULL, --#Duracion de la cancion
  N_Pista SMALLINT NOT NULL, --#Numero de pista dentro del album de la cancion 
  idAlbum INT NOT NULL, --#id del album de la cancion,
  idSentimiento INT NOT NULL,
  PRIMARY KEY(idCancion),
  CONSTRAINT FK_Canciones_Albums
    FOREIGN KEY(idAlbum)
    REFERENCES Albums(idAlbum)
    ON DELETE CASCADE,
  CONSTRAINT FK_Canciones_Sentimientos
    FOREIGN KEY(idSentimiento)
    REFERENCES Sentimientos(idSentimiento)
    ON DELETE CASCADE
);


--# #####################################################
--# Crear tabla Generos
--# #####################################################
CREATE TABLE Generos(
  idGenero INT NOT NULL IDENTITY, --#id del genero
  Nombre VARCHAR(45) NOT NULL, --#Nombre del genero (Death Metal, Power Pop, etc.)
  idPais INT NOT NULL,  --#id del pais del genero
  PRIMARY KEY(idGenero),
  CONSTRAINT FK_Generos_Paises
    FOREIGN KEY(idPais)
    REFERENCES Paises(idPais)
    ON DELETE CASCADE
);


--# #####################################################
--# Crear tabla AlbumsGeneros
--# #####################################################
CREATE TABLE AlbumsGeneros(
  idAlbum INT NOT NULL, --#id del album
  idGenero INT NOT NULL, --#id del genero
  PRIMARY KEY(idAlbum, idGenero),
  CONSTRAINT FK_AlbumsGeneros_Albums
    FOREIGN KEY(idAlbum)
    REFERENCES Albums(idAlbum)
    ON DELETE CASCADE,
  CONSTRAINT FK_AlbumsGeneros_Generos
    FOREIGN KEY(idGenero)
    REFERENCES Generos(idGenero)
    ON DELETE CASCADE
);


--# #####################################################
--# Crear tabla Playlists
--# #####################################################
CREATE TABLE Playlists(
  idPlaylist INT NOT NULL IDENTITY, --#id de la playlist
  Nombre VARCHAR(45) NOT NULL, --#Nombre de la playlist
  Descripcion VARCHAR(255) NOT NULL, --#Descripcion de la playlist
  Imagen VARCHAR(max), --#Ruta en la que se encuentra la imagen de la playlist
  FechaCreacion DATE NOT NULL, --#Fecha en la que se creo la playlist
  idUsuario INT NOT NULL, --#id del usuario de la playlist
  idEstado INT NOT NULL, --#id del estado de la playlist
  PRIMARY KEY(idPlaylist),
  CONSTRAINT FK_Playlists_Usuarios
    FOREIGN KEY(idUsuario)
    REFERENCES Usuarios(idUsuario)
    ON DELETE CASCADE,
  CONSTRAINT FK_Playlists_Estados
    FOREIGN KEY(idEstado)
    REFERENCES Estados(idEstado)
    ON DELETE CASCADE
);


--# #####################################################
--# Crear tabla PlaylistsCanciones
--# #####################################################
CREATE TABLE PlaylistsCanciones(
  idPlaylist INT NOT NULL, --#id de la playlist
  idCancion INT NOT NULL, --#id de la cancion
  Fecha DATETIME2(0) NOT NULL, --#Fecha y hora de la modificacion
  PRIMARY KEY(idPlaylist, idCancion),
  CONSTRAINT FK_PlaylistsCanciones_Playlists
    FOREIGN KEY(idPlaylist)
    REFERENCES Playlists(idPlaylist)
    ON DELETE CASCADE,
  CONSTRAINT FK_PlaylistsCanciones_Canciones
    FOREIGN KEY(idCancion)
    REFERENCES Canciones(idCancion)
    ON DELETE CASCADE
);