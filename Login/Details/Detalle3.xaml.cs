using Login.views;

namespace Login.Details;

public partial class Detalle3 : ContentPage
{
	public Detalle3()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormularioCompra());
    }
}