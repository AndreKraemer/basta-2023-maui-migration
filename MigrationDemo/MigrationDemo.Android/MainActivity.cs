using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace MigrationDemo.Droid
{
    [Activity(Label = "MigrationDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : MauiAppCompatActivity
    {
       
    }
}