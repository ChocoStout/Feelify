CREATE PROCEDURE insertarPlaylist(
    @nombre varchar(45),
    @descripcion VARCHAR(255),
    @ruta VARCHAR(max),
    @fecha DATE,
    @usuario INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Playlists
    VALUES (@nombre,@descripcion,@ruta,@fecha,@usuario,1);
END;
GO