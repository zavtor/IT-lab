
## Web-проект (ASP.NET MVC)

В рамках даного шаблону потрібно забезпечити класи моделей, класи-контролери та представлення для веб-сторінок. Відповідними моделями зробимо наші класи Database, Table, Column та Row, додавши їх у папку Models.
Для виконання CRUD-операцій над цими сутностями нам знадобляться контролери (папка Controllers), у яких прописуємо необхідні дії в action-методах з урахуванням валідації даних: якщо користувач відправив некоректні дані, ми маємо відхилити запит до дії та повернути повідомлення про помилку. Приклад контролера:

- [TablesController](https://github.com/zavtor/IT-lab/blob/main/Containers/ASP.NET/TablesController.cs)

Веб-сторінки для необхідних операцій знаходяться у папці Views. В шаблоні проекту ASP.NET MVC вони умовно поділяються на 4 основні типи: Index (перегляд), Create (створення), Edit (редагування) та Delete (видалення). Проте для зручності ми не будемо виносити видалення сутностей на окрему сторінку, натомість реалізувавши його як спливне вікно з попередженням та кнопками «Так/Ні» на поточній сторінці:

При завантаженні текстових файлів вони зберігаються на сервері й перейменовуються за наступною схемою: TableName_ColumnName_RowId_FileName. Зважаючи на те, що імена таблиць та стовпчиків у даній таблиці не можуть повторюватися, а ідентифікатор для кожного рядку присвоюється за принципом автоінкременту, суперечливості не виникає.
Завантажити з/на сервер можна також і базу даних:
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Open(IFormFile fileTdb) {
        using (var stream = new FileStream(_tmpFilePath, FileMode.Create)) {
        fileTdb.CopyTo(stream);
    }

    _dbManager.OpenDatabase(_tmpFilePath);
    return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Save() {
        _dbManager.SaveDatabase(_tmpFilePath);
        
    byte[] dbBytes = System.IO.File.ReadAllBytes(_tmpFilePath);
    string fileName = $"{_dbManager.Database.Name}.tdb";

     return File(dbBytes, "application/octet-stream", fileName);
    } 



У даному Web-проекті використовується тема Sketchy із сайту bootswatch.com. Для того щоб змінити тему проекту, потрібно завантажити файли теми bootstrap.css та bootstrap.min.css і помістити їх у папку wwwroot/lib/bootstrap/dist/css.
