namespace Views;

public partial class LabelEntryRow : ContentView
{
    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(
            nameof(Value),
            typeof(string),
            typeof(LabelEntryRow),
            string.Empty,
            BindingMode.TwoWay);

    public static readonly BindableProperty IsValidProperty =
        BindableProperty.Create(
            nameof(IsValid),
            typeof(bool),
            typeof(LabelEntryRow),
            true);

    public LabelEntryRow()
    {
        InitializeComponent();
    }

    public string Value
    {
        get => (string)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public bool IsValid
    {
        get => (bool)GetValue(IsValidProperty);
        set => SetValue(IsValidProperty, value);
    }

    
}
