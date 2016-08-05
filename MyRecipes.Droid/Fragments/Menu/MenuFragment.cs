using System;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MyRecipes.Core.ViewModels.Main;
using MyRecipes.Core.ViewModels.Menu;

namespace MyRecipes.Droid.Fragments.Menu
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.navigation_frame)]
    [Register("myrecipes.droid.fragments.menu.MenuFragment")]
    public class MenuFragment : MvxFragment<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        private NavigationView _navigationView;
        private IMenuItem _previousMenuItem;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.fragment_navigation, null);

            _navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
            _navigationView.SetNavigationItemSelectedListener(this);
            _navigationView.Menu.FindItem(Resource.Id.nav_categories).SetChecked(true);

            return view;
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            if (item != _previousMenuItem)
            {
                _previousMenuItem?.SetChecked(false);
            }

            item.SetCheckable(true);
            item.SetChecked(true);

            _previousMenuItem = item;

            Navigate(item.ItemId);

            return true;
        }

        private async Task Navigate(int itemId)
        {
            ((MainActivity)Activity).DrawerLayout.CloseDrawers();

            // add a small delay to prevent any UI issues
            await Task.Delay(TimeSpan.FromMilliseconds(250));

            switch (itemId)
            {
                case Resource.Id.nav_categories:
                    ViewModel.ShowCategoriesCommand.Execute();
                    break;
                case Resource.Id.nav_all_dishes:
                    //ViewModel.ShowDishesCommand.Execute();
                    break;
                case Resource.Id.nav_favorites_dishes:
                    ViewModel.ShowFavoritesDishesCommand.Execute();
                    break;
                case Resource.Id.nav_products:
                    ViewModel.ShowProductsCommand.Execute();
                    break;
                case Resource.Id.nav_settings:
                    //ViewModel.ShowSettingCommand.Execute();
                    break;
                case Resource.Id.nav_helpfeedback:
                    //ViewModel.ShowHelpCommand.Execute();
                    break;
            }
        }
    }
}