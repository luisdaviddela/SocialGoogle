using Plugin.GoogleClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using Xamarin.Forms;
namespace GoogleClientPlugin
{
    class VM_LoginPage: INotifyPropertyChanged
    {
        public GoogleUser User { get; set; } = new GoogleUser();
        public string Name
        {
            get => User.Name;
            set => User.Name = value;
        }

        public string Email
        {
            get => User.Email;
            set => User.Email = value;
        }

        public Uri Picture
        {
            get => User.Picture;
            set => User.Picture = value;
        }

        //--------------------------------------
        public bool IsLoggedIn { get; set; }

        public ICommand LoginCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        private readonly IGoogleClientManager _googleClientManager;
        public event PropertyChangedEventHandler PropertyChanged;
        //------------------------------------------
        public VM_LoginPage()
        {
            LoginCommand = new Command(LoginAsync);
            LogoutCommand = new Command(Logout);
            _googleClientManager = CrossGoogleClient.Current;
            IsLoggedIn = false;
        }
        //--------------------------------------------METODOS
        public async void LoginAsync()
        {
            //_googleClientManager.OnLogin += OnLoginCompleted;
           
        }


        private void OnLoginCompleted(object sender, GoogleClientResultEventArgs<GoogleUser> loginEventArgs)
        {
           
        }

        public void Logout()
        {
            _googleClientManager.OnLogout += OnLogoutCompleted;
            _googleClientManager.Logout();
        }

        private void OnLogoutCompleted(object sender, EventArgs loginEventArgs)
        {
            IsLoggedIn = false;
            User.Email = "Offline";
            _googleClientManager.OnLogout -= OnLogoutCompleted;
        }
    }
}
