using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Avocado1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage: ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty= string.IsNullOrEmpty(emailEntry.Text);
            bool isPassEmpty = string.IsNullOrEmpty(passEntry.Text);

            if(isEmailEmpty==true || isPassEmpty == true)
            {
                ErrorLable.Text = "Please Enter Email and Password";
                
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }

        private void SignupBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}