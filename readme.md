# :computer: APIs com C# :rocket:

## Neste repositório, está uma api desenvolvida através do Entity Framework, durante os meus estudos na trilha .NET Developer, da Digital Innovation One, com 3 controllers:
#### :point_right: ContatoController, que armazena informações de um contato
#### :point_right: UsuarioController, que exibe uma mensagem de boas vindas em um arquivo .JSON para o usuário
#### :point_right: WeatherForecastController, que exibe informações climáticas em um arquivo .JSON


## O Controller Contato possui os seguinte métodos HTTP:

#### :point_right: Método CREATE, para a criação do registro de um contato em um banco de dados, armazenando informações de nome e telefone, quando fornecidos
#### :point_right: Método GET para obter um contato pelo seu id
#### :point_right: Método GET para obter um contato pelo seu nome
#### :point_right: Método PUT para atualizar informações de um contato, sendo necessário informar o id do contato a ser alterado
#### :point_right: Método DELETE para apagar o registro de um contato

## O Controller Usuario possui os seguintes métodos HTTP:

#### :point_right: Método GET, para exibir a data e hora atual
#### :point_right: Método GET, para exibir uma mensagem de boas vindas em um arquivo .JSON para o usuário

## O Controller WeatherForecast possui os seguintes métodos HTTP:

#### :point_right: Método GET, para exibir informações climáticas

## A API também está documentada com o Swagger, caso queira ver a documentação da API, clone o repositorio na sua maquina local:
#### :point_right: Abra o terminal na pasta do repositório clonado
#### :point_right: Digite no terminal o seguinte comando: "dotnet watch run" (sem as aspas)

#### :point_right: Será aberto no seu navegador a documentação da API no Swagger
