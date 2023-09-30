using Login.views;

namespace Login.Details;

public partial class Detalle2 : ContentPage
{
	public Detalle2()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormularioCompra());
    }
}