using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Home : ContentPage
    {
        SqlHelper db = new SqlHelper();
        public Home(string userId)  
        {  
            InitializeComponent();  
            GetUserDetail(userId);  
        }  
        RegEntity userDetail;  
        public void GetUserDetail(string userId)  
        {  
            userDetail = db.GetItem(userId);  
            txtname.Text = userDetail.Name;  
            txtuserid.Text = userDetail.Username;  
            txtpassword.Text = userDetail.Password;  
        }  
        async void Click_UpdateProfile(object sender, EventArgs e)  
        {  
            int i = -1;  
            if (txtname.Text != "" && txtpassword.Text != "" && txtuserid.Text != "")  
            {  
                userDetail.Name = txtname.Text;  
                userDetail.Username = txtuserid.Text;  
                userDetail.Password = txtpassword.Text;  
                 i = db.SaveItem(userDetail);  
            }  
  
  
            if (i < 0)  
            {  
                await DisplayAlert("Update Profile", "Update Fail .. Please try again ", "OK");  
            }  
            else  
            {  
                await DisplayAlert("Update Profile", "Profile update Success . ", "OK");  
            }  
        }  
          
        async void Click_Login(object sender, EventArgs e)  
        {  
            await Navigation.PushModalAsync(new MainPage());  
        }  
    }  
}  