<h1 align="center">Restaurante</h1>
<br>



<h1>Descrição</h1>
Este projeto é um sistema de gerenciamento de pedidos para um restaurante. Ele permite que usuários façam pedidos e que administradores visualizem esses pedidos na cozinha e na copa.


<h1>Pré-requisitos</h1>


- Visual Studio
- NET Core SDK
- SQL Server

<h3>Configuração do Projeto</h3>

- Siga os passos abaixo para configurar o projeto na sua máquina local.


<h3>Clonar o Repositório</h3>

- git clone https://github.com/lapiedradaniel/Restaurante
- cd nome-do-repositorio

<h3>Configurar a String de Conexão</h3> 

- Abra o arquivo appsettings.json e substitua a string de conexão com o seu SQL Server local:

 
- "DefaultConnection": "Server=SEU_SERVIDOR;Database=Restaurante;User Id=SEU_USUARIO;Password=SUA_SENHA;"
  

<h3>Criar as Migrações e Atualizar o Banco de Dados</h3>

- Abra o Gerenciador de Pacotes NuGet no Visual Studio e execute os seguintes comandos:
- Add-Migration "InitialMigration"
- Update-Database

<h3>Compilar o Projeto</h3>

- Se tudo ocorreu bem até aqui, você pode compilar o projeto. Isso irá criar a base de dados e aplicar as migrações necessárias.


<h1>Seed de Usuários e Roles</h1>

- Quando o projeto é executado pela primeira vez, a classe SeedUserRoleInitial será responsável por criar um usuário administrador e o papel correspondente.
- Login do Admin abaixo

- UserName: admin@localhost
- Password: Numsey#2022


<h1>Acesso do Administrador</h1>

- Somente o usuário com o papel de administrador pode visualizar os pedidos na cozinha e na copa. Para que os pedidos apareçam, siga os passos abaixo.
<br>

<h1>Criar uma Conta de Usuário </h1>

- Registre um novo usuário no sistema com um nome e uma senha que contenha letras, números e caracteres especiais.
- Faça login com essa conta recém-criada.
- Realize um pedido.

<h1>Visualizar Pedidos</h1>

- Depois de criar um pedido com uma conta de usuário normal, faça login com a conta de administrador para visualizar os pedidos na cozinha e na copa.

- Siga essas instruções para configurar e usar o sistema corretamente. Se você encontrar algum problema ou tiver alguma dúvida, sinta-se à vontade para abrir uma issue no repositório do GitHub.


<h1> Estrutura do Projeto </h1>

- Controllers: Contém os controladores MVC.
- Models: Contém os modelos de dados.
- Views: Contém as views Razor.
- Services: Contém a lógica de negócios.
- Migrations: Contém as migrações do Entity Framework Core.

<h1></h1>

- ASP.NET MVC
- C#
- SQL Server
- HTML, CSS, JavaScript (para a interface do usuário)
- Bootstrap (para design responsivo)
- Visual Studio (ambiente de desenvolvimento)

<br>



<div style="display: inline_block" align = "center"><br>
  <img align="center" alt="Daniel-Csharp" height="70" width="70" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg">
  <img align="center" alt="Daniel-Js" height="70" width="70" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/javascript/javascript-plain.svg">
  <img align="center" alt="Daniel-HTML" height="70" width="70" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original.svg">
  <img align="center" alt="Daniel-CSS" height="70" width="70" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original.svg">
  <img align="center" alt="Daniel-Bootstrap" height="70" width="70"  src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/bootstrap/bootstrap-original-wordmark.svg" />
          
</div>
