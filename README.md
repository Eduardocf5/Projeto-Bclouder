# Gerenciador de Tarefas

Um gerenciador de tarefas simples construído com **ASP.NET Core** e **Angular**. Este projeto permite que os usuários criem, visualizem e gerenciem suas tarefas de forma intuitiva e eficiente.

## Pré-requisitos

Certifique-se de ter os seguintes pré-requisitos instalados em sua máquina:

- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)
- [Node.js](https://nodejs.org/) (versão 14 ou superior)
- [Angular CLI](https://angular.io/cli) (instalável via npm com `npm install -g @angular/cli`)

## Configuração do Projeto

### Back-end

1. Navegue até o diretório do backend: 

cd backend/TaskManager.Api. 

2. Restaure as dependências do projeto executando o comando 

dotnet restore

3. Antes de migrar o banco de dados, certifique-se de que a string de conexão no arquivo appsettings.jsoné correta. Ela deve apontar para o seu servidor de banco de dados. O padrão usado é para o LocalDB do SQL Server. A estrutura appsettings.jsoné a seguinte:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaskManagerDb;Trusted_Connection=True;"
  }
}


4. Para migrar para o banco de dados, execute o comando dotnet ef database update. Caso ainda não tenha criado as migrações, você pode fazê-lo com o comando dotnet ef migrations add InitialCreate. Agora, você pode iniciar a API executando o comando dotnet run. Uma API estará acessível em http ://localhost :5001 /api .


### Front-end

1. Navegue até o diretório do frontend: 

cd frontend/task-manager. 

2. Instale as dependências do Angular executando o comando 

npm install. 

3. Após a instalação, você pode iniciar o aplicativo Angular com o comando 

ng serve. 

O frontend estará acessível em http ://localhost :4200 .

## Estrutura do Projeto

Abaixo está uma visão geral da estrutura de diretórios do projeto:

TaskManager/
│
├── backend/
│   └── TaskManager.Api/
│       ├── Controllers/            # Controladores da API
│       ├── Models/                 # Modelos de dados
│       ├── Data/                   # Contexto do banco de dados
│       ├── TaskManager.Api.csproj  # Arquivo de projeto .NET
│       ├── appsettings.json        # Configurações do projeto
│       └── Program.cs              # Ponto de entrada da aplicação
│
└── frontend/
    └── task-manager/
        ├── src/                    # Código fonte do aplicativo Angular
        ├── angular.json             # Configurações do Angular
        ├── package.json             # Dependências do projeto
        └── styles.css               # Estilos globais do aplicativo

## Uso

Uma vez que tudo esteja configurado e em funcionamento, você pode acessar uma API em 
http ://localhost :5001 /api para interagir com os dados das tarefas e o frontend em http ://localhost :4200 para gerenciar suas tarefas por meio da interface do usuário.


## Funcionalidades

Gerenciar Tarefas : Você pode adicionar, visualizar e gerenciar suas tarefas de forma eficiente.
Persistência de Dados : Todas as tarefas são armazenadas em um banco de dados SQL.
Interface Responsiva : Uma interface construída com Angular, garantindo uma experiência de usuário suave.