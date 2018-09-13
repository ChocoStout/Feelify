CREATE PROCEDURE insertarUsuarioActividad(
    IN usuario INT,
    IN actividad INT
)
    BEGIN 
    INSERT INTO UsuariosActividades
    VALUES (usuario,actividad,NOW());
END