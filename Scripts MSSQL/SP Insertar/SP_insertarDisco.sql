CREATE PROCEDURE insertarDisco(
    @nombre varchar(45),
    @ruta VARCHAR(max),
    @fecha DATE,
    @artista INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Albums
    VALUES (0,@nombre,@ruta,@fecha,@artista);
END;
GO