using Login.Tables;

namespace Login.views;

public partial class PaginaInicio : ContentPage
{
	public PaginaInicio()
	{
		InitializeComponent();

        var items = new List<CollectionItem>
        {
            new CollectionItem{Imagen ="ace_rycen5.jpg", Title="Acer Gaming", Description="Tenemos lo mejor en computadoras"},
            new CollectionItem{Imagen ="dell.png",  Title="Del Rycen-i7", Description="Tenemos lo mejor en computadoras"},
            new CollectionItem{Imagen = "dell.png", Title="Dell Rycen-i3", Description="Tenemos lo mejor en computadoras"},
            new CollectionItem{Imagen ="acer_i5.jpg", Title="Acer Gaming-12Gen", Description="Tenemos lo mejor en computadoras"},
            new CollectionItem{Imagen = "ace_rycen5.jpg", Title="Acer Rycen-5", Description="Tenemos lo mejor en computadoras"},
            new CollectionItem{Imagen = "acer_i5.jpg", Title="Lenovo", Description="Tenemos lo mejor en computadoras"}
        };
        carouselView.ItemsSource = items;

    }

}