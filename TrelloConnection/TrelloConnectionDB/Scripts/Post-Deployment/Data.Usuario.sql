IF NOT EXISTS (SELECT * FROM Usuario)
BEGIN
INSERT INTO Usuario(Login, Senha)VALUES('daniel','lldaniell28');
END
