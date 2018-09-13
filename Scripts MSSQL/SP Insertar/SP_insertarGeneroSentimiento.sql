CREATE PROCEDURE insertarGenerosSentimientos(
    @genero INT,
    @sentimiento INT
)
    AS
    BEGIN
    SET NOCOUNT ON; 
    INSERT INTO GenerosSentimientos
    VALUES (@genero,@sentimiento);
END;
GO