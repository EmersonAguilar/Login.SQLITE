namespace Login.views;

public partial class Producto : ContentPage
{
	public Producto()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Detalle());
    }
}