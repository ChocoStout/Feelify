CREATE PROCEDURE insertarArtista(
    @nombre varchar(45),
    @pais INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Artistas
    VALUES (0,@nombre,@pais);
END;
GO