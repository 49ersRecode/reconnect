# API Reconnect
Esta é uma API construída em C# utilizando o framework .NET 6.0, que fornece serviços para serem consumidos por uma aplicação Frontend desenvolvida em [React com Next.js]( https://github.com/49ersRecode/ReconnectReactNext). 
A API utiliza o Entity Framework Core para interagir com o banco de dados e é capaz de se conectar a diferentes provedores de banco de dados.

## Tecnologias Utilizadas
- C# (.NET 6.0)
- Entity Framework Core
- MySQL
## Requisitos
- .NET 6.0 SDK

## Dependências

- Microsoft.EntityFrameworkCore: Versão 6.0.26 - Biblioteca principal para o Entity Framework, permitindo operações de banco de dados.
- Microsoft.EntityFrameworkCore.Design: Versão 6.0.26 - Suporte em tempo de design para comandos do Entity Framework Core.
- Microsoft.EntityFrameworkCore.Proxies: Versão 6.0.0 - Habilita proxies de carregamento preguiçoso para o Entity Framework Core.
- Microsoft.EntityFrameworkCore.Sqlite: Versão 6.0.26 - Provedor de banco de dados SQLite para o Entity Framework Core.
- Microsoft.EntityFrameworkCore.SqlServer: Versão 6.0.26 - Provedor de banco de dados SQL Server para o Entity Framework Core.
- Microsoft.EntityFrameworkCore.Tools: Versão 6.0.26 - Ferramentas adicionais para o Entity Framework Core.
- Microsoft.VisualStudio.Web.CodeGeneration.Design: Versão 6.0.16 - Suporte em tempo de design para geração de código ASP.NET Core.
- Pomelo.EntityFrameworkCore.MySql: Versão 6.0.2 - Provedor de banco de dados MySQL para o Entity Framework Core.
- Swashbuckle.AspNetCore: Versão 6.5.0 - Biblioteca para geração automática de documentação OpenAPI para a API.

## Iniciando
- Clone o repositório.
- Certifique-se de ter o SDK .NET 6.0 instalado.
- Atualize as strings (`Uid` e `Pwd`) de conexão do banco de dados (`appsettings.json`) e as configurações do projeto, se necessário.
    - Não é necessário criar o banco de dados manualmente no Workbench, ele cria ao executar a API.