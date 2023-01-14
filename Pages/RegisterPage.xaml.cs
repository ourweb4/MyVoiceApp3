using MyVoiceApp3.Utitlys;
using MyVoiceApp3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyVoiceApp3.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        private Api api = new Api();

        private RegisterVM registerdata = new RegisterVM();


        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = registerdata;
        }

        private async void btnregister_Clicked(object sender, EventArgs e)
        {
            if (registerdata.email == null
                       || registerdata.password == null
                       || registerdata.lastname == null
                       || registerdata.fristname == null)
            {
                ErrPopup popup = new ErrPopup(Message_Box.Blankfield);
                await DisplayAlert("Error", popup.message, "Ok");
            }
            else
            {
                CheckEmeil checker = new CheckEmeil();
                if (checker.IsValidEmail(registerdata.email) == false)
                {
                    ErrPopup popup = new ErrPopup(Message_Box.Notemail);
                    await DisplayAlert("Error", popup.message, "Ok");

                }
                else
                {
                    var message = await api.Register(registerdata);
                    if (api.IsOk())
                    {
                        await Shell.Current.GoToAsync($"//{nameof(UserPage)}");

                    } else
                        await DisplayAlert("Error", message, "Ok");
                }


            }
        }
    }
}