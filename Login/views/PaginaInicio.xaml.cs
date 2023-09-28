using Login.Tables;

namespace Login.views;

public partial class PaginaInicio : ContentPage
{
	public PaginaInicio()
	{
		InitializeComponent();

        var items = new List<CollectionItem>
        {
            new CollectionItem{Imagen ="ace_rycen5.jpg", Title="Coding Droplets", Description="Welcome to coding droplets"},
            new CollectionItem{Imagen ="dell.png",  Title="Title 2", Description="Description 2"},
            new CollectionItem{Imagen = "dell.png", Title="Title 3", Description="Description 3"},
            new CollectionItem{Imagen ="acer_i5.jpg", Title="Title 4", Description="Description 4"},
            new CollectionItem{Imagen = "ace_rycen5.jpg", Title="Title 5", Description="Description 5"},
            new CollectionItem{Imagen = "acer_i5.jpg", Title="Title 5", Description="Description 5"}
        };
        carouselView.ItemsSource = items;

    }
}