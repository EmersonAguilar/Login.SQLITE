using Login.views;

namespace Login.Details;

public partial class Detalle1 : ContentPage
{
	public Detalle1()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormularioCompra());
    }
}