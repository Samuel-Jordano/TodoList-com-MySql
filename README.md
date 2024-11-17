# To-Do List App

**To-Do List App** é uma aplicação simples para gerenciamento de tarefas, desenvolvida em **C#** com **Windows Forms** e **MySQL**. A aplicação permite aos usuários adicionar, editar, excluir e visualizar tarefas, além de gerenciar seu status (A Fazer, Fazendo, Feito).

---

## 🚀 Funcionalidades

- **Adicionar tarefas** à lista 📌
- **Editar tarefas** existentes ✏️
- **Excluir tarefas** da lista 🗑️
- **Gerenciar status** das tarefas (A Fazer, Fazendo, Feito) 🔲
- **Persistência de dados** usando banco de dados **MySQL** 💾

---

## 🔧 Tecnologias

- **C#** (Windows Forms) 💻
- **MySQL** 🌐
- **ADO.NET** (para conexão com o banco de dados) 🔗

---

## 📋 Como usar

### 1. **Clone o Repositório**

Primeiro, faça o clone deste repositório para o seu computador local:

```bash
git clone https://github.com/seu-usuario/to-do-list.git
```

### 2. **Configuração do Banco de Dados**

Para que a aplicação funcione corretamente, você precisa de um banco de dados **MySQL** configurado localmente. O banco de dados pode ser configurado de duas formas:

#### Opção 1: **Banco de Dados Local**

1. **Crie um banco de dados no MySQL** (você pode usar o MySQL Workbench ou qualquer cliente de sua preferência). O nome sugerido para o banco de dados é `CrudTodoList`.

2. **Importe o script SQL** para criar as tabelas e estrutura do banco de dados. O script pode ser encontrado no arquivo `database.sql` (ou equivalente) do repositório, ou você pode criar a tabela manualmente com a seguinte estrutura:

```sql
CREATE TABLE TodoList (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Tarefa VARCHAR(255) NOT NULL,
    Status VARCHAR(50) NOT NULL
);
```

#### Opção 2: **Alterar a Conexão no Código**

Se você já tem um banco de dados **MySQL** em outro servidor, ou deseja configurar uma conexão personalizada, basta editar o arquivo `Database.cs` para atualizar a string de conexão.

No arquivo `Database.cs`, localize a seguinte linha de código:

```csharp
string connectionString = "server=localhost;database=CrudTodoList;user=root;password= ";
```

- **`server`**: Endereço do seu servidor MySQL (pode ser `localhost` ou o IP/hostname de outro servidor).
- **`database`**: Nome do banco de dados (use `CrudTodoList` ou o nome que você configurou).
- **`user`**: Nome do usuário MySQL.
- **`password`**: Senha do usuário MySQL.

Altere os parâmetros conforme a sua configuração.

### 3. **Abrir o Projeto no Visual Studio**

Após configurar o banco de dados, abra o projeto no **Visual Studio**:

1. Abra o **Visual Studio**.
2. Selecione **Abrir Projeto/Solução**.
3. Navegue até a pasta onde você clonou o repositório e abra o arquivo `To-Do-List.sln`.

### 4. **Executar o Projeto**

Clique em **Iniciar** ou pressione `F5` para rodar o projeto no Visual Studio. A aplicação será iniciada e você poderá começar a adicionar, editar e excluir tarefas.

---

## ⚠️ Aviso

- Este é um **pré-release** da aplicação e pode conter bugs ou funcionalidades incompletas. Fique à vontade para testar e fornecer feedback.
- Caso encontre algum erro ou queira sugerir melhorias, sinta-se à vontade para abrir um **issue** ou enviar um **pull request**.

---

## 🚧 Roadmap

- Melhorias na interface de usuário (UI) 🎨
- Funcionalidades de filtro e busca 🔍
- Suporte a autenticação de usuários 🔑

---

## 🛠️ Contribuições

1. Faça um **fork** deste repositório.
2. Crie uma nova branch (`git checkout -b feature/nova-funcionalidade`).
3. Comite suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`).
4. Faça o **push** para a sua branch (`git push origin feature/nova-funcionalidade`).
5. Abra um **pull request** para o repositório principal.

---

## 📄 Licença

Este projeto é licenciado sob a [MIT License](LICENSE). Veja o arquivo `LICENSE` para mais informações.
```
