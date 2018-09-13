CREATE PROCEDURE insertarSentimiento(
    @nombre varchar(20)
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Sentimientos
    VALUES (@nombre);
END;
GO