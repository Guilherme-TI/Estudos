CREATE DATABASE chat;
USE chat;
INSERT INTO usuarios(usuario, senha) VALUES ('zeruela', '1234');
SELECT * FROM usuarios;

INSERT INTO mensagens (conteudo, id_usuario) VALUES ('olá', 1);
SELECT * FROM mensagens;

CREATE TABLE usuarios (
id_usuario INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
usuario VARCHAR(45) NOT NULL,
senha VARCHAR(220) NOT NULL
);

CREATE TABLE mensagens (
id_mensagem INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
conteudo TEXT NOT NULL,
id_usuario INT NOT NULL,
FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);