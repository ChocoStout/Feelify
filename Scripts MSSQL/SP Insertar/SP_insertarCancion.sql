CREATE PROCEDURE insertarCancion(
    @nombre varchar(40),
    @duracion TIME(0),
    @numero INT,
    @album INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Canciones
    VALUES (@nombre,@duracion,@numero,@album);
END;
GO