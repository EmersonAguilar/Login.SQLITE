using Login.views;

namespace Login.Details;

public partial class Detalle4 : ContentPage
{
	public Detalle4()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormularioCompra());
    }
}