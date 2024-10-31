# 📚 BookManagerGraphQL

> **BookManagerGraphQL** — мощный сервер на базе **GraphQL** и **ASP.NET**, разработанный для удобного и эффективного управления книгами и их авторами. Этот проект предоставляет API для выполнения основных CRUD-операций, что делает его отличной базой для организации каталога книг или библиотеки.

![GraphQL](https://img.shields.io/badge/GraphQL-API-informational?style=flat&logo=graphql&color=E10098)
![ASP.NET](https://img.shields.io/badge/ASP.NET-Core-informational?style=flat&logo=dotnet&color=512BD4)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-Database-informational?style=flat&logo=postgresql&color=336791)

---

## 📋 Оглавление
- [📑 Функционал](#📑-Функционал)
- [💻 Технологии](#💻-Технологии)
- [⚙️ Требования](#⚙️-Требования)
- [🚀 Установка](#🚀-Установка)
- [▶️ Запуск](#▶️-Запуск)
- [🕹️ Использование API](#🕹️-Использование-API)
- [📞 Поддержка](#📞-Поддержка)
- [📜 Лицензия](#📜-Лицензия)

---

## 📑 Функционал

BookManagerGraphQL предоставляет следующие возможности:
- 📘 **Добавление** новой книги и автора
- 🔍 **Получение** списка книг и информации о каждом элементе
- ✏️ **Редактирование** данных о книгах и авторах
- ❌ **Удаление** книг и авторов

## 💻 Технологии

Проект построен с использованием следующих технологий:
- **ASP.NET Core** — фреймворк для создания высокопроизводительных веб-приложений
- **GraphQL** — мощный язык запросов для работы с API
- **HotChocolate 14** — библиотека для интеграции проекта с языком запросов GraphQL 
- **PostgreSQL** — реляционная база данных для хранения данных о книгах и авторах
- **Entity Framework Core** — ORM для взаимодействия с PostgreSQL из ASP.NET, обеспечивающая легкость работы с базой данных

## ⚙️ Требования

Перед началом работы убедитесь, что у вас установлены:
- **.NET SDK** версии 6.0 или выше
- **PostgreSQL** — для подключения к базе данных локально или удаленно

## 🚀 Установка

1. **Клонируйте репозиторий**:  
   ```bash
   git clone https://github.com/1EgoPingvina1/BookManagerGraphQL.git
   cd BookManagerGraphQL

2. **Настройте строку подключения** к базе данных PostgreSQL в файле `appsettings.json`:  
   ```json  
   "ConnectionStrings": {
     "DefaultConnection": "Host=localhost,5432;Database=BookBase;Username=yourusername;Password=yourpassword"
   }
   
3. **Примените миграции** для создания базы данных и необходимых таблиц:
   ```bash  
    dotnet ef database update --project ..\BookManagerGraphQL.Infrastructure\ --startup-project ..\BookManagerGraphQL.API\ 

