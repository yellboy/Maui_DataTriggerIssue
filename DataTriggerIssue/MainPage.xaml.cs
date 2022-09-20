using System.ComponentModel;

namespace DataTriggerIssue;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
	private int _value;

	public int Value 
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
			OnPropertyChanged(nameof(IsValid));
        }
	}

	public bool IsValid => _value < 5;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}

