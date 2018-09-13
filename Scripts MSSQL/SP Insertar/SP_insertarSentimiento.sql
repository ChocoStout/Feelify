CREATE PROCEDURE insertarSentimiento(
    @nombre varchar(20)
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Sentimientos
    VALUES (0,@nombre);
END;
GO