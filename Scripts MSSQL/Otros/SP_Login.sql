CREATE PROCEDURE loginUsuario(
    @username VARCHAR(30),
    @password VARCHAR(40)
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    SELECT * FROM Usuarios WHERE @username = @username AND @password=AES_ENCRYPT(@password,'Root.32643520');
END;
GO