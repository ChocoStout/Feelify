CREATE PROCEDURE insertarUsuarioSentimiento(
    @usuario INT,
    @sentimiento INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO UsuariosSentimientos
    VALUES (@usuario,@sentimiento,GETDATE());
END;
GO