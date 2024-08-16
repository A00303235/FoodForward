using FoodForward.ViewModels;
using static FoodForward.ViewModels.RegisterViewModel;

namespace RegisterPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel(Navigation);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}