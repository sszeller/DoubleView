using System.Collections.ObjectModel;
using MahApps.Metro.IconPacks;
using MahAppsMetroHamburgerMenuNavigation.Mvvm;

namespace MahAppsMetroHamburgerMenuNavigation.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        private static readonly ObservableCollection<MenuItem> AppMenu = new ObservableCollection<MenuItem>();
        private static readonly ObservableCollection<MenuItem> AppOptionsMenu = new ObservableCollection<MenuItem>();

        public ObservableCollection<MenuItem> Menu => AppMenu;

        public ObservableCollection<MenuItem> OptionsMenu => AppOptionsMenu;

        public ShellViewModel()
        {
            // Build the menus
            this.Menu.Add(new MenuItem()
                          {
                              Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.BugSolid },
                              NavigationTarget = new BugsViewModel()
                          });
            this.Menu.Add(new MenuItem()
                          {
                              Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.UserSolid },
                              NavigationTarget = new UserViewModel()
            });
            this.Menu.Add(new MenuItem()
                          {
                              Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.CoffeeSolid },
                              NavigationTarget = new BreakModel()
            });
            this.Menu.Add(new MenuItem()
                          {
                              Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.FontAwesomeBrands },
                              NavigationTarget = new AwesomeViewModel()
            });

            this.OptionsMenu.Add(new MenuItem()
                                 {
                                     Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.CogsSolid },
                                     NavigationTarget = new SettingsViewModel()
            });
            this.OptionsMenu.Add(new MenuItem()
                                 {
                                     Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.InfoCircleSolid },
                                     NavigationTarget = new AboutViewModel()
            });
        }
    }
}