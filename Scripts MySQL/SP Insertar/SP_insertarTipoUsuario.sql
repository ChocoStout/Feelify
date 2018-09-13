CREATE PROCEDURE insertarTipoUsuario(IN tipoUsuario varchar(11))
    BEGIN 
    INSERT INTO TiposUsuario
    VALUES (0,tipoUsuario);
END