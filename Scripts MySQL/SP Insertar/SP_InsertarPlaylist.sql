CREATE PROCEDURE insertarPlaylist(
    IN nombre varchar(45),
    IN descripcion TINYTEXT,
    IN ruta TEXT,
    IN fecha DATE,
    IN usuario INT
)
    BEGIN 
    INSERT INTO Playlists
    VALUES (0,nombre,descripcion,ruta,fecha,usuario,1);
END