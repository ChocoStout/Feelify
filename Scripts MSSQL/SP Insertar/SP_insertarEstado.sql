CREATE PROCEDURE insertarEstados( @estado varchar(8))
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Estados
    VALUES (@estado);
END;
GO