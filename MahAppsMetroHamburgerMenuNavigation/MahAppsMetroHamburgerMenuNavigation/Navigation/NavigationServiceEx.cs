using System.Windows.Controls;
using System.Windows.Navigation;

namespace MahAppsMetroHamburgerMenuNavigation.Navigation
{
    public class NavigationServiceEx
    {
        public event NavigatedEventHandler Navigated;

        private Frame _frame;

        public Frame Frame
        {
            get
            {
                if (this._frame == null)
                {
                    this._frame = new Frame() { NavigationUIVisibility = NavigationUIVisibility.Hidden };
                    this.RegisterFrameEvents();
                }

                return this._frame;
            }
            set
            {
                this.UnregisterFrameEvents();
                this._frame = value;
                this.RegisterFrameEvents();
            }
        }

        public bool Navigate(object navigationTarget)
        {
            if (this.Frame.NavigationService.Content != navigationTarget)
            {
                return Frame.Navigate(navigationTarget);
            }

            return false;
        }

        private void RegisterFrameEvents()
        {
            if (this._frame != null)
            {
                this._frame.Navigated += this.Frame_Navigated;
            }
        }

        private void UnregisterFrameEvents()
        {
            if (this._frame != null)
            {
                this._frame.Navigated -= this.Frame_Navigated;
            }
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e) => this.Navigated?.Invoke(sender, e);
    }
}