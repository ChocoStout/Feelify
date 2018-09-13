CREATE PROCEDURE insertarArtista(
    IN nombre varchar(45),
    IN pais INT
)
    BEGIN 
    INSERT INTO Artistas
    VALUES (0,nombre,pais);
END