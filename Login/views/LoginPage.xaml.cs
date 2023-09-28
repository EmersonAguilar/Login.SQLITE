using Login.Tables;
using SQLite;

namespace Login.views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

   async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new RegistroPage());
    }

    async void Button_Clicked_1(object sender, EventArgs e)
    {

        var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.bd");
        var db = new SQLiteConnection(dbpath);
        var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.PassWord.Equals(EntryPassword.Text)).FirstOrDefault();

        if (myquery!=null)
        {
            App.Current.MainPage = new NavigationPage(new HomePage());
        }
        else
        {
            Device.BeginInvokeOnMainThread(async () =>
            {

                var result = await this.DisplayAlert("Error", "Fall User name and Password", "Yes", "Cancel");

                if (result)
                    await Navigation.PushAsync(new LoginPage());
                else
                {
                    await Navigation.PushAsync(new LoginPage());
                }

            });
            
        }

    }
}