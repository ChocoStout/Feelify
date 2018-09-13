CREATE PROCEDURE insertarPlaylistCanciones(
    IN playlist INT,
    IN cancion INT
)
    BEGIN 
    INSERT INTO PlaylistCanciones
    VALUES (playlist,cancion,NOW());
END