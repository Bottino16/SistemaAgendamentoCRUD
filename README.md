# 📅 Sistema de Agendamentos

> Aplicação web completa para gestão de clientes, serviços e agendamentos desenvolvida em **ASP.NET Core MVC** com interface em **Enterprise Dark Mode**.

---

## 🚀 Sobre o Projeto

O **Sistema de Agendamentos** foi desenvolvido para simplificar a rotina de controle de atendimentos, permitindo gerenciar em um único lugar os clientes, os serviços prestados e a agenda de horários. 

O projeto conta com uma interface moderna no padrão *Dark Mode*, navegação responsiva e integração completa com banco de dados usando **Entity Framework Core**.

---

## ✨ Funcionalidades

- **👤 Gestão de Usuários (Clientes):**
  - Cadastro, edição, visualização e exclusão de clientes.
  - Armazenamento de dados essenciais (Nome completo e Telefone/WhatsApp).

- **🛠️ Gestão de Serviços:**
  - Cadastro de modalidades de atendimento e tabela de preços.
  - Formatação monetária automática (R$).

- **📆 Gestão de Agendamentos:**
  - Criação de novos agendamentos vinculando Cliente + Serviço + Data/Horário.
  - Caixas de seleção inteligentes (Dropdowns) exibindo os **nomes** dos clientes e serviços.
  - Alertas de validação para impedir dados inconsistentes ou incorretos.

- **🎨 Dashboard & Interface Modernos:**
  - Painel principal com atalhos de acesso rápido.
  - Design limpo e padronizado com **Bootstrap 5** no estilo *Enterprise Dark Mode*.

---

## 🛠️ Tecnologias Utilizadas

- **Back-end:** C# | .NET (ASP.NET Core MVC)
- **Persistência de Dados:** Entity Framework Core
- **Banco de Dados:** SQL Server / LocalDB
- **Front-end:** HTML5, CSS3, Razor Views, Bootstrap 5, Bootstrap Icons

---

## 📂 Estrutura do Projeto

```text
SistemaAgendamentoCRUD/
├── Controllers/
│   ├── AgendamentosController.cs
│   ├── ServicosController.cs
│   └── UsuariosController.cs
├── Models/
│   ├── Agendamento.cs
│   ├── Servico.cs
│   └── Usuario.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Views/
│   ├── Agendamentos/
│   ├── Servicos/
│   ├── Usuarios/
│   ├── Home/
│   └── Shared/
└── wwwroot/
