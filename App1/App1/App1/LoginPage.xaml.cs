using System;
using Xamarin.Forms;

namespace App1
{
    public partial class LoginPage : ContentPage
    {
        SqlHelper db = new SqlHelper();
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Click_Reg(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Registration());
        }

        async void Click_Login(object sender, EventArgs e)
        {
            RegEntity userDetail = db.GetItem(txtuserid.Text, txtpassword.Text);

            if (userDetail != null)
            {
                if (txtuserid.Text != userDetail.Username && txtpassword.Text != userDetail.Password)
                {
                    await DisplayAlert("Login", "Login failed .. Please try again ", "OK");
                }
                else
                {
                    await DisplayAlert("Registrtion", "Login Success ... Now Edit your profile ", "OK");
                    await Navigation.PushModalAsync(new Home(txtuserid.Text));
                }
            }
            else
            {
                await DisplayAlert("Login", "Login failed .. Please try again ", "OK");
            }


        }

    }
}