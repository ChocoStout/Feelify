CREATE PROCEDURE insertarCancion(
    IN nombre varchar(40),
    IN duracion TIME,
    IN numero INT,
    IN album INT,
    IN sentimiento INT
)
    BEGIN 
    INSERT INTO Canciones
    VALUES (0,nombre,duracion,numero,album,sentimiento);
END