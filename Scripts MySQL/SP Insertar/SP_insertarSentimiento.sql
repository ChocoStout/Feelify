CREATE PROCEDURE insertarSentimiento(IN nombre varchar(20))
    BEGIN 
    INSERT INTO Sentimientos
    VALUES (0,nombre);
END