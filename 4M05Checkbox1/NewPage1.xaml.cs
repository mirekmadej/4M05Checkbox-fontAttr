namespace _4M05Checkbox1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	private void chkBoldChecked(object sender, EventArgs e)
	{
		var checkBox = (CheckBox)sender;
		if(checkBox.IsChecked)
			lblTest.FontAttributes |= FontAttributes.Bold;
		else
			lblTest.FontAttributes &= ~FontAttributes.Bold;
	}
	private void chkItalicChecked(object sender, EventArgs e)
	{
		var checkBox = (CheckBox)sender;
		if(checkBox.IsChecked)
			lblTest.FontAttributes |= FontAttributes.Italic;
		else
			lblTest.FontAttributes &= ~FontAttributes.Italic;
	}
	private void chkBoldItalicChecked(object sender, EventArgs e)
	{
		var checkBox = (CheckBox)sender;
		if(checkBox.IsChecked)
			lblTest.FontAttributes = FontAttributes.Italic | FontAttributes.Bold;
		else
			lblTest.FontAttributes = FontAttributes.None;
	}

}