CREATE PROCEDURE insertarUsuario(
    @nombre varchar(20),
    @paterno varchar(20),
    @materno varchar(20),
    @correo varchar(40),
    @password varchar(40),
    @username varchar(30),
    @pais INT,
    @tipo INT,
    @estado INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Usuarios
    VALUES (0,
    @nombre,
    @paterno,
    @materno,
    @correo,
    HASHBYTES('SHA2_512',@password),
    @username,
    GETDATE(),
    @pais,
    @tipo,
    1);
END;
GO