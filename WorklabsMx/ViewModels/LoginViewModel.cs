using System.Threading.Tasks;
using System.Windows.Input;

namespace WorklabsMx
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            Title = "Iniciar Sesión";
        }

        string message = string.Empty;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(); }
        }

        public ICommand ForgotCommand { get; }
        public ICommand SignInCommand { get; }
        public ICommand RegisterCommand { get;}

        public async Task SignIn()
        {
            try
            {
                IsBusy = true;
                Message = "Iniciando sesión...";

                // Log the user in
                await TryLoginAsync();
            }
            finally
            {
                Message = string.Empty;
                IsBusy = false;

            }
        }


        public static async Task<bool> TryLoginAsync()
        {
            
            return true;
        }
    }
}
