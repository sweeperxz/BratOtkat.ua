# BratOtkat — Микросервисная платформа (демо)

## О проекте

BratOtkat — учебный проект на ASP.NET 9, реализующий микросервисную архитектуру с чистым разделением слоёв. В текущей реализации есть сервис управления должностями (Position Service) с базовой CRUD-логикой, PostgreSQL и контейнеризацией через Docker Compose.

---

## Структура решения

- **BratOtkat.Core/** — бизнес-логика (PositionService)
- **BratOtkat.Domain/** — доменные модели (Position), интерфейсы репозиториев
- **BratOtkat.Infostructure/** — реализация репозиториев (PositionRepository), контекст БД (AppDbContext)
- **BratOtkat.WebApi/** — ASP.NET Web API, контроллер PositionsController, точка входа, настройки
- **compose.yaml** — запуск WebApi и PostgreSQL в Docker

---

## Технологии

- ASP.NET 9 Web API
- Entity Framework Core + Npgsql
- PostgreSQL
- Docker, Docker Compose
- Чистая архитектура (Domain/Core/Infrastructure/WebApi)

---

## Быстрый старт

1. Убедитесь, что установлен Docker и .NET 9 SDK
2. Склонируйте репозиторий и перейдите в папку проекта
3. Запустите сервисы:

```bash
docker compose up --build
```

Web API будет доступен на http://localhost:5000/swagger

---

## Основные файлы и папки

- **BratOtkat.Domain/Models/Position.cs** — модель должности
- **BratOtkat.Domain/Repositories/IPositionRepository.cs** — интерфейс репозитория
- **BratOtkat.Core/PositionService.cs** — бизнес-логика
- **BratOtkat.Infostructure/PositionRepository.cs** — реализация репозитория
- **BratOtkat.Infostructure/AppDbContext.cs** — контекст EF Core
- **BratOtkat.WebApi/PositionsController.cs** — API-контроллер
- **BratOtkat.WebApi/appsettings.json** — строка подключения к БД
- **BratOtkat.WebApi/Dockerfile** — сборка WebApi
- **compose.yaml** — запуск WebApi и PostgreSQL

---

## Пример запроса

- Получить все должности:
  GET http://localhost:5000/api/positions

---

## Лицензия
MIT. Проект для обучения и демонстрации архитектурных подходов.
