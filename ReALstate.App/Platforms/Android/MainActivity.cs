using Android.App;
using Android.Content.PM;
using Android.OS;

namespace ReALstate.App.Platforms.Android
{
    [Activity(Theme = "@style/GradientSplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}
