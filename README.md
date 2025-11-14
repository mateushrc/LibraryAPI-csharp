# 📚 LibraryAPI — API REST em C# / .NET 8

LibraryAPI é uma API REST construída com **ASP.NET Core 8**, **Entity Framework Core** e **MySQL**, criada com o objetivo de praticar desenvolvimento backend real, incluindo CRUD completo, boas práticas de arquitetura e integração com banco de dados.

---

## 🚀 Funcionalidades

- ✔️ Criar livros  
- ✔️ Listar todos os livros  
- ✔️ Buscar livro por ID  
- ✔️ Atualizar livro existente  
- ✔️ Deletar livro  
- ✔️ Documentação automática via **Swagger**  
- ✔️ Validação de dados com *Data Annotations*  
- ✔️ Operações assíncronas (async/await)

---

## 🧱 Tecnologias Utilizadas

- **C#**
- **.NET 8 Web API**
- **Entity Framework Core**
- **MySQL**
- **Swagger (OpenAPI)**
- **Dependency Injection**

---

## 🗂️ Estrutura do Projeto

```
LibraryAPI/
 ├── Controllers/
 │    └── BooksController.cs
 ├── Data/
 │    └── AppDbContext.cs
 ├── Models/
 │    └── Book.cs
 ├── appsettings.json
 └── Program.cs
```

---

## 🔌 Endpoints da API

### ➤ Criar um livro  
**POST /api/books**  
Body (JSON):
```json
{
  "name": "O Senhor dos Anéis",
  "author": "J.R.R. Tolkien"
}
```

---

### ➤ Listar todos os livros  
**GET /api/books**

---

### ➤ Buscar livro por ID  
**GET /api/books/{id}**

---

### ➤ Atualizar um livro  
**PUT /api/books/{id}**  
Body (JSON):
```json
{
  "name": "1984",
  "author": "George Orwell"
}
```

---

### ➤ Deletar um livro  
**DELETE /api/books/{id}**

---

## 🗄️ Configuração do Banco (MySQL)

No arquivo **appsettings.json**:

```json
"ConnectionStrings": {
  "AppDbConnectionString": "server=localhost;uid=root;pwd=SUA_SENHA;database=library_db"
}
```

---

## ▶️ Como Executar

```bash
# Restaurar dependências
dotnet restore

# Rodar a API
dotnet run
```

Acesse o Swagger em:  
👉 **https://localhost:PORT/swagger**

---

## 🎯 Objetivo do Projeto

Este projeto foi desenvolvido para fixar conceitos fundamentais de backend:

- Desenvolvimento de APIs REST  
- CRUD com Entity Framework Core  
- Integração com banco relacional  
- Clean code e boas práticas  
- Uso correto de HTTP verbs e status codes  
- Estrutura profissional de Web API

---

## 📌 Próximos Passos

- Implementar serviços (Service Layer) para separar responsabilidades  
- Adicionar DTOs e AutoMapper  
- Criar testes automatizados  
- Implementar autenticação JWT  

---
