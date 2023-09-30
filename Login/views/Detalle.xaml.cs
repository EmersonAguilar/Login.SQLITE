namespace Login.views;

public partial class Detalle : ContentPage
{
	public Detalle()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new FormularioCompra());
    }
}