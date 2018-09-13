CREATE PROCEDURE insertarGenero(
    IN nombre varchar(45),
    IN pais INT
)
    BEGIN 
    INSERT INTO Genero
    VALUES (0,nombre,pais);
END