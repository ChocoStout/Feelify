CREATE PROCEDURE insertarPais( @nombrePais varchar(35))
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Paises
    VALUES (@nombrePais);
END;
GO