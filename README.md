# PizzaStore

## Небольшое учебное приложение на ASP.NET веб магазин пиццы

Использовались
- ASP.NET MVC
- Entity Framework Core


---
> ### Схема базы данных
>```mermaid 
>erDiagram
>    Categories {
>        string Name PK
>    }
>
>    Products {
>        int Id PK
>        string Name
>        string Description
>        string ImageSource
>        float Price
>        int Discount
>        int InStock
>    }
>
>    Products }|--o{ Categories : has
>
>    Orders {
>        int ID PK
>        string CustomerName
>        string Address
>        string PhoneNumber
>        bool Completed
>    }
>
>    Orders ||--|{ OrderItems : has
>
>    Products ||--o{ OrderItems : in
>
>    OrderItems {
>        int Id PK
>        int ProductId FK
>        int Count
>        int OrderId FK
>    }
>```