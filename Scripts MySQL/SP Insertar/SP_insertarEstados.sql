CREATE PROCEDURE insertarEstados(IN estado varchar(8))
    BEGIN 
    INSERT INTO Estados
    VALUES (0,estado);
END