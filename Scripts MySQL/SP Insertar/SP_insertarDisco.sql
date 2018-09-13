CREATE PROCEDURE insertarDisco(
    IN nombre varchar(45),
    IN ruta TEXT,
    IN fecha DATE,
    IN artista INT
)
    BEGIN 
    INSERT INTO Albums
    VALUES (0,nombre,ruta,fecha,artista);
END