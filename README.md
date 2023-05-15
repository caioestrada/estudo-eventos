# Event Driven

Projeto para exemplificar a aplicação do padrão de arquitetura Event Driven Architecture.

## Pré-requisitos

* Docker;

## Teste

* Abrir o prompt do windows;
* Direcionar para a pasta do projeto;
* Executar o seguinte comando:

```
docker-compose up
```

* Para abrir a api do email no navegador, informar a url "http://localhost:9997/swagger";
* Para abrir a api do autsis no navegador, informar a url "http://localhost:9998/swagger";
* Para abrir a api do orbcore no navegador, informar a url "http://localhost:9999/swagger";
* Para abrir o RabbitMQ no navegador, informar a url "http://localhost:8080", com usuario "guest" e senha "guest";

## Funcionamento

* Abrir a api do orbcore;
* Adicionar um novo item no método post;
* Chamar o método get para ver o item adicionado.
* Abrir a api do autsis e de email, para verificar que foram atualizadas a partir do item adicionado no orbcore.