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
