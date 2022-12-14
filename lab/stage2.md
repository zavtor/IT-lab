## Розробка локальної версії СУТБД
### Розробка класів

**DataBase** – клас бази даних, містить поле назви Name та колекцію таблиць Tables:

- [DataBase](https://github.com/zavtor/IT-lab/blob/main/DB/Entities/DataBase.cs)

**Table** – клас таблиці, містить поле назви Name та колекції рядків Rows та стовпчиків Columns:

- [Table](https://github.com/zavtor/IT-lab/blob/main/DB/Entities/Table.cs)

**Column** – абстрактний клас стовпчика, від якого наслідуємо класи стовпчиків різних типів. Містить поле назви Name, поле типу Type та абстрактний метод валідації значень Validate, що уточнюється у нащадках відповідно до типів стовпчиків:

- [Column](https://github.com/zavtor/IT-lab/blob/main/DB/Entities/Column.cs)

**Row** – клас рядку, містить колекцію значень Values та індексатор this[i] для зручного звернення до значення за індексом:

- [Row](https://github.com/zavtor/IT-lab/blob/main/DB/Entities/Row.cs)

**DatabaseManager** – клас для керування всіма операціями над базою даних, реалізований за патерном проектування Singleton:

- [DatabaseManager](https://github.com/zavtor/IT-lab/blob/main/DB/Entities/DatabaseManager.cs)

