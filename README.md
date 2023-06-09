# CRUD приложение для создания, удаления и редактирования заказов

Цель этого проекта - написать простое CRUD приложение, для создания, удаления и редактирования заказов. Приложение должно использовать предоставленную ниже схему БД и выполнено на ASP.NET Core. Это проект для претендентов на позицию junior developer.

## Функциональные требования

Приложение должно содержать минимум 3 формы:

### Главная страница

-   кнопка для добавления заказов
-   период в виде двух дат и мульти фильтры с выпадающим списком для фильтрации заказов
-   таблица с заказами
-   кнопка для применения фильтрации

### Форма просмотра (попадаем после нажатия на строчку таблицы заказов)

-   информация о заказе
-   кнопка для редактирования
-   кнопка для удаления

### Форма создания/редактирования (можно раздельно)

-   кнопка для сохранения
-   все редактируемые поля
-   кнопка для добавления новых строчек в заказ
-   кнопка для удаления строки из заказа

## Структура БД

Существуют 3 таблицы:

### Order (заказ)

-   Id (int)
-   Number (nvarchar(max)) *редактируется *используется для фильтрации
-   Date (datetime2(7)) *редактируется *используется для фильтрации
-   ProviderId (int) *редактируется *используется для фильтрации

### OrderItem (элемент заказа)

-   Id (int)
-   OrderId (int)
-   Name (nvarchar(max)) *редактируется *используется для фильтрации
-   Quantity decimal(18, 3) *редактируется
-   Unit (nvarchar(max)) *редактируется *используется для фильтрации

### Provider (поставщик, заполнена изначально, нигде не редактируется)

-   Id (int)
-   Name (nvarchar(max)) *используется для фильтрации
