# Система учёта транспортных средств и их владельцев -  Traffic Ledger

Traffic Ledger — это настольное/Web приложение, разработанное на Базе .NET 8 с использованием Entity Framework Core.
Оно предназначено для учёта транспортных средств, их владельцев, водительских удостоверений, управления штрафами за нарушения ПДД, а также оплаты платных парковок.

Приложение поддерживает три роли пользователей:

* Default — обычный водитель: может просматривать и оплачивать свои штрафы.
* TrafficPolice — сотрудник ДПС: создаёт новые штрафы и имеет права обычного водителя.
* Admin — администратор: привязывает автомобили к владельцам, создаёт и подтверждает водительские удостоверения, а также просматривает аналитические отчёты.

## Начало работы

1. Клонирование репозитория

Откройте терминал и выполните:

```bash
git clone https://github.com/CasCadeVR/TrafficLedger.git
cd TrafficLedger
```

2. Открытие проекта в Visual Studio

    1. Запустите Visual Studio.
    2. Выберите "Открыть проект или решение".
    3. Укажите путь к файлу TrafficLedger.sln.

### Необходимые условия

Для разработки приложения вам понадобится:

* Windows 10 или новее
* Visual Studio 2022 (Community и выше)
* .NET 8 Sdk
* SQL Server Express (или локальный/удалённый SQL Server)
* Git (для клонирования репозитория)

### Установка

Приложение использует Code First подход с миграциями EF6. База данных создаётся автоматически при первом запуске или может быть инициализирована вручную.

Шаг 1: Настройка строки подключения
Откройте файл App.config в корне проекта и отредактируйте строку подключения:

```xml
  <connectionStrings>
    <add name="TrafficLedgerConnectionString"
		 connectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrafficLedgerDBStorage;Integrated Security=True;"
		 providerName="System.Data.SqlClient" />
  </connectionStrings>
```

Шаг 2: Включение миграций (если ещё не включены)
В Консоли диспетчера пакетов (Package Manager Console) в Visual Studio выполните:

```powershell
Enable-Migrations
```

Шаг 3: Применение миграции к базе данных

```powershell
Update-Database -ProjectName TrafficLedger.Context -StartUpProjectName TrafficLedger.Context
```

### Запуск приложения

1. Убедитесь, что проект TrafficLedger установлен как стартовый (правой кнопкой → "Назначить запускаемым проектом").
2. Нажмите F5 или выберите Отладка → Запуск без отладки.

### Демонстрация функционала

После запуска:

1. Войдите под учётной записью:
* Admin: логин admin, пароль admin
* TrafficPolice: создайте через админа или проверьте тестовые данные
* Default: зарегистрированный водитель

2. Протестируйте сценарии:
* Админ: привяжите автомобиль к водителю
* ДПС: создайте штраф за превышение скорости
* Водитель: найдите штраф и оплатите его

### Стек технологий

* Фронтенд: Windows Forms (.NET 8)
* ORM: Entity Framework Core (Code First)
* База данных: Microsoft SQL Server (LocalDB / Express / Full)
* Миграции: EFCore tools Migrations
* Аутентификация: Ролевая модель на основе пользовательских таблиц

## Авторы

* **Турчанинов Андрей ИП-23-3 tg: @Cas_Cade** - *Инициализация проекта* - [TrafficLedger](https://github.com/CasCadeVR/TrafficLedger)
