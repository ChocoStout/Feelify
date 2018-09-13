CREATE PROCEDURE insertarTipoUsuario( @tipoUsuario varchar(11))
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO TiposUsuario
    VALUES (@tipoUsuario);
END;
GO