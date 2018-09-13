CREATE PROCEDURE insertarAlbumGenero(
    @album INT,
    @genero INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO AlbumsGeneros
    VALUES (@album,@genero);
END;
GO