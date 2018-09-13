CREATE PROCEDURE insertarEstados( @estado varchar(8))
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Estados
    VALUES (0,@estado);
END;
GO