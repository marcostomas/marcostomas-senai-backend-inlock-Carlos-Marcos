USE InLock_Games_Manha;

--Listar todos os Usuarios
SELECT * FROM Usuarios;
go

--Listar todos os Estudios
SELECT * FROM Estudio;
go

--Listar todos os Jogos
SELECT * FROM Jogos;
go

--Listar todos os TiposUsuarios
SELECT * FROM TipoUsuarios;
go

--Listar todos os jogos e seus respectivos estudios
SELECT NomeEstudio, NomeJogo
FROM Jogos J INNER JOIN Estudio E ON J.IdEstudio = E.IdEstudio

--Buscar e trazer na lista todos os estudios...
SELECT NomeEstudio, NomeJogo
FROM Estudio E LEFT JOIN Jogos J ON E.IdEstudio = J.IdEstudio

-- Buscar um usuario por email e senha
SELECT Email, Senha,IdTipoUsuario FROM Usuarios
WHERE Email ='admin@admin.com' AND Senha = 'admin';

-- Buscar um jogo por IdJogo
SELECT NomeJogo FROM Jogos
WHERE IdJogo = 1;

--Buscar um estudio por IdEstudio
SELECT NomeEstudio FROM Estudio
WHERE IdEstudio = 1;