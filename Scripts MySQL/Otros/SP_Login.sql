CREATE PROCEDURE loginUsuario(
    IN username VARCHAR(30),
    IN password VARCHAR(40)
)
    BEGIN 
    SELECT * FROM Usuarios WHERE Username = username AND Password=AES_ENCRYPT(password,'Root.32643520');
END