using System;
using System.Windows;
using MahApps.Metro.Controls;

namespace MahAppsMetroHamburgerMenuNavigation.ViewModels
{
    public class MenuItem : HamburgerMenuIconItem
    {
        public static readonly DependencyProperty NavigationTargetProperty = DependencyProperty.Register(
            nameof(NavigationTarget), typeof(object), typeof(MenuItem), new PropertyMetadata(default(Type)));

        public object NavigationTarget
        {
            get => GetValue(NavigationTargetProperty);
            set => SetValue(NavigationTargetProperty, value);
        }

        public bool IsNavigation => this.NavigationTarget != null;
    }
}