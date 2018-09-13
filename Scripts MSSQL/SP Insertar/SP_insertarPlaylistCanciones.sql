CREATE PROCEDURE insertarPlaylistCancione(
    @playlist INT,
    @cancion INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO PlaylistsCanciones
    VALUES (@playlist,@cancion);
END;
GO