public abstract class Column {
    public string Name { get; set; }
    public string Type { get; } = "";

    public Column(string name) {
    Name = name;
    }

    public abstract bool Validate(string value);
}

public class IntColumn : Column {
    public new string Type { get; } = "INT";
    public IntColumn(string name) : base(name) { }

    public override bool Validate(string value) => int.TryParse(value, out _);
}

public class RealColumn : Column {
    public new string Type { get; }  = "REAL";
    public RealColumn(string name) : base(name) { }

    public override bool Validate(string value) => double.TryParse(value, out _);
}

public class CharColumn : Column {
    public new string Type { get; } = "CHAR";
    public CharColumn(string name) : base(name) { }

    public override bool Validate(string value) => char.TryParse(value, out _);
}

public class StringColumn : Column {
    public new string Type { get; } = "STRING";
    public StringColumn(string name) : base(name) { }

    public override bool Validate(string value) => true;
}

public class MoneyFileColumn : Column {
    public new string Type { get; }  = "MONEY";
    public MineyFileColumn(string name) : base(name) { }

    public override bool Validate(string value) => int.TryParse(value, out _);
}
