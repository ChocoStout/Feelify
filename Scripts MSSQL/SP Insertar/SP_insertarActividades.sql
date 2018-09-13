CREATE PROCEDURE insertarActividad( @actividad varchar(20))
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO Actividades
    VALUES (0,nombre);
END;
GO