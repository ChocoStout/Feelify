CREATE PROCEDURE insertarUsuario(
    IN nombre varchar(20),
    IN paterno varchar(20),
    IN materno varchar(20),
    IN correo varchar(40),
    IN password varchar(40),
    IN username varchar(30),
    IN pais INT,
    IN tipo INT,
    IN estado INT
)
    BEGIN 
    INSERT INTO Usuarios
    VALUES (0,
    nombre,
    paterno,
    materno,
    correo,
    AES_ENCRYPT(password,'Root.32643520'),
    username,
    NOW(),
    pais,
    tipo,
    1);
END