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
