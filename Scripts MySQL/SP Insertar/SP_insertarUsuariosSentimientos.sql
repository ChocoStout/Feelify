CREATE PROCEDURE insertarUsuarioSentimiento(
    IN usuario INT,
    IN sentimiento INT
)
    BEGIN 
    INSERT INTO UsuariosSentimientos
    VALUES (usuario,sentimiento,NOW());
END