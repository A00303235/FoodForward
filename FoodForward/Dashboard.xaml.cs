using Microsoft.Maui.Storage;
using Newtonsoft.Json;

namespace FoodForward;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Dashboard : ContentView
{
    private object UserEmail;

    public Dashboard()
    {
            InitializeComponent();
            GetProfileInfo();
        }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void GetProfileInfo()
        {
            var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FreshFirebaseToken", ""));
            UserEmail = userInfo.User;
        }
    }
