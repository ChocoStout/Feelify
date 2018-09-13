CREATE PROCEDURE insertarGenero(
    @nombre varchar(45),
    @pais INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Genero
    VALUES (0,@nombre,@pais);
END;
GO