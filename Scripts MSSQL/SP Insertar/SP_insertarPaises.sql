CREATE PROCEDURE insertarPais( @nombrePais varchar(35))
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Paises
    VALUES (0,@nombrePais);
END;
GO