CREATE PROCEDURE insertarGenerosSentimientos(
    IN genero INT,
    IN sentimiento INT
)
    BEGIN 
    INSERT INTO GenerosSentimientos
    VALUES (genero,sentimiento);
END