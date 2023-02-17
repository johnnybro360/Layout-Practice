namespace MauiApp1;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
        Title.Text = "Razor Sharp Spinning Emitting Thing Company - New Client";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alert", Entry1.Text + " " + Entry2.Text, "OK");
        
    }

  
}