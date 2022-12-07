public class Table {
    public string Name { get; set; }
    public List<Row> Rows { get; set; } = new List<Row>();
    public List<Column> Columns { get; set; } = new List<Column>();

    public Table(string name) {
    Name = name;
    }
}
