USE InLock_Games_Manha;

INSERT INTO Estudio (NomeEstudio)
VALUES		('Blizzard'),
			('Rockstar Studios'),
			('Square Enix');

INSERT INTO Jogos (NomeJogo, Descricao, DataLancamento, Valor, IdEstudio) VALUES ('Diablo 3', 'Diablo 3 � uma jogo cheio de a��o e viciante, seja voc� novato ou f�', '2012-05-15', 99.00, 1);
INSERT INTO Jogos (NomeJogo, Descricao, DataLancamento, Valor, IdEstudio) VALUES('Red Dead Redemption II' , 'Jogo de a��o-aventura western', '2018-10-26', 120.00 , 2);

INSERT INTO Usuarios (Email, Senha,IdTipoUsuario)
VALUES		('admin@admin.com', 'admin',1),
			('cliente@cliente.com', 'cliente',2);
		

INSERT INTO TipoUsuarios (Titulo)
VALUES		('Administrador'),
			('Comum');
