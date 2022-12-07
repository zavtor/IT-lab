## Варіант проекту з використанням реляційної СУБД

В якості СУБД візьмемо MS SQL Server, використавши її в нашому попередньому проекті. Тепер, окрім зберігання стану БД як стану наших програмних сутностей, ми також відправляємо відповідні запити до SQL Server Management Studio (SSMS): при створенні бази даних у нашій програмі створюється також база даних в SSMS, при створенні таблиці – таблиця додається до відповідної бази даних в SSMS тощо. Також можна відкрити вже збережену в SSMS базу даних (буде запропонований випадний список з усіма наявними, окрім, звісно, системних):

![](https://github.com/zavtor/IT-lab/blob/main/png/stage24/1.png)

При створенні таблиць слід врахувати, що в SSMS створена таблиця повинна мати принаймні один стовпчик. Тому ми одразу додаємо до всіх таблиць ключовий атрибут id з автоінкрементом:
  public bool AddTable(string name) {
    if (GetTableNames().Contains(name)) {
        return false;
    }

    var table = new Table(Database.Tables.Count, name);
    table.Columns.Add(new IntColumn(0, "id"));
    Database.Tables.Add(table);
    _lastIds.Add(0);

    string query = $"CREATE TABLE {name} (id INT IDENTITY(1,1) PRIMARY KEY)";
    ExecuteSqlQuery(query, _connectionStr);

    return true;
  }


При збереженні та відкритті бази даних потрібно врахувати інформацію про типи стовпчиків. Тому для цього побудуємо наступну відповідність між типами стовпчиків у нашій програмі та типами стовпчиків в SSMS:
  public static string SqlServerColumnType(string type) {
    return type switch {
        "INT" => "INT",
        "REAL" => "REAL",
        "CHAR" => "CHAR(1)",
        "MONEY" => "MONEY",
        
        _ => null
    };
  }
        
  public static string ColumnType(string sqlServerType) {
    return sqlServerType switch {
        "int" => "INT",
        "real" => "REAL",
        "char" => "CHAR",
        "nvarchar" => "STRING",
        "money" => "MONEY",
        
        _ => null
    };
  }
