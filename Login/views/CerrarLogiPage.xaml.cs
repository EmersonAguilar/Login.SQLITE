namespace Login.views;

public partial class CerrarLogiPage : ContentPage
{
	public CerrarLogiPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new LoginPage());
    }
}