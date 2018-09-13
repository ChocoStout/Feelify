CREATE PROCEDURE insertarPais(IN nombrePais varchar(35))
    BEGIN 
    INSERT INTO Paises
    VALUES (0,nombrePais);
END