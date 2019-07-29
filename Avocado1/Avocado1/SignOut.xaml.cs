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
    public partial class SignOut : ContentPage
    {
        public SignOut()
        {
            InitializeComponent();
        }

        private void SignOutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}