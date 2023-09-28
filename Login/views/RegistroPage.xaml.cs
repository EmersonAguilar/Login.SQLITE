using Login.Tables;
using SQLite;
namespace Login.views;

public partial class RegistroPage : ContentPage
{
	public RegistroPage()
	{
		InitializeComponent();
	}

	

    void Button_Clicked(object sender, EventArgs e)
    {
        var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.bd");
        var db = new SQLiteConnection(dbpath);
        db.CreateTable<RegUserTable>();

        var item = new RegUserTable()
        {

            UserName = UserName.Text,
            PassWord = UserPassword.Text,
            Email = UserEmail.Text,
            PhoneNumber = UserTelefono.Text

        };

        db.Insert(item);
        Device.BeginInvokeOnMainThread(async () =>
        {

            var result = await this.DisplayAlert("Congratulation", "user Registeration Sucessfull", "Yes", "Cancel");

            if (result)
                await Navigation.PushAsync(new LoginPage());
        }); 
    }
}