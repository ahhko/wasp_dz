namespace MauiApp1;

public partial class MainPage : ContentPage
{
	string _PIN = "1234";

	public MainPage()
	{
		InitializeComponent();
	}

	private void DigitClicked(object sender, EventArgs e)
	{
		if (DisplayLabel.Text != "PIN введен верно!")
			DisplayLabel.Text += (sender as Button).Text;
	}

    private void ClearClicked(object sender, EventArgs e)
    {
        if (DisplayLabel.Text != "PIN введен верно!")
            DisplayLabel.Text = "";
    }

    private void CheckClicked(object sender, EventArgs e)
    {
        if (DisplayLabel.Text != "PIN введен верно!")
            if (DisplayLabel.Text == _PIN)
			{
				DisplayLabel.Text = "PIN введен верно!";
			}
			else DisplayLabel.Text = "";
    }
}

