CREATE PROCEDURE insertarUsuarioActividad(
    @usuario INT,
    @actividad INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO UsuariosActividades
    VALUES (@usuario,@actividad,GETDATE());
END;
GO