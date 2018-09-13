CREATE PROCEDURE insertarAlbumGenero(
    IN album INT,
    IN genero INT
)
    BEGIN 
    INSERT INTO AlbumsGeneros
    VALUES (album,genero);
END