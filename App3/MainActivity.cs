using System;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Nightonke.Boommenu;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);
                SetContentView(Resource.Layout.activity_main);


                Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
                SetSupportActionBar(toolbar);


                //BoomMenuButton boot = FindViewById<BoomMenuButton>(Resource.Id.bmb);


                BoomMenuButton boot = FindViewById<BoomMenuButton>(Resource.Id.boomButton1);

                //FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
                //fab.Click += FabOnClick;



                Android.Runtime.AndroidEnvironment.UnhandledExceptionRaiser += MyApp_UnhandledExceptionHandler;
                System.AppDomain.CurrentDomain.UnhandledException += HandleUnhandledException;
                System.Threading.Tasks.TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;


            }
            catch
            { }
        }


        private void TaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs args)
        {
            System.Exception e = args.Exception;
        }

        protected void HandleUnhandledException(object sender, System.UnhandledExceptionEventArgs args)
        {
            System.Exception e = (System.Exception)args.ExceptionObject;
        }

        void MyApp_UnhandledExceptionHandler(object sender, Android.Runtime.RaiseThrowableEventArgs e)
        {
            string ex = e.Exception.Message;
            e.Handled = true;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

