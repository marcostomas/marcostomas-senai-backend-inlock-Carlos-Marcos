USE InLock_Games_Manha;

INSERT INTO Estudio (NomeEstudio)
VALUES		('Blizzard'),
			('Rockstar Studios'),
			('Square Enix');

INSERT INTO Jogos (NomeJogo, Descricao, DataLancamento, Valor, IdEstudio)
VALUES		('Diablo 3', 'Diablo 3 � uma jogo cheio de a��o e viciante, seja voc� novato ou f�', '2012-05-15', 99.00, 1),
			('Red Dead Redemption II' , 'Jogo de a��o-aventura western', '2018-10-26', 120.00 , 2);

INSERT INTO Usuarios (Email, Senha)
VALUES		('carlos@gmail.com', 'carlos123'),
			('marcos@gmail.com', 'marcos123'),
			('saulo@gmail.com', 'saulo123'),
			('carol@gmail.com', 'carol123');

INSERT INTO TipoUsuarios (Titulo)
VALUES		('Administrador'),
			('Comum');
