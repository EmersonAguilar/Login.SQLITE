using Login.Details;

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

    async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Detalle1());
    }

    async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Detalle2());
    }

    async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Detalle3());
    }

    async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Detalle4());
    }
}