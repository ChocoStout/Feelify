CREATE PROCEDURE loginUsuario(
    @username VARCHAR(30),
    @password VARCHAR(40)
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    SELECT * FROM Usuarios WHERE @username = @username AND Clave = HASHBYTES('SHA2_512',@password);
END;
GO