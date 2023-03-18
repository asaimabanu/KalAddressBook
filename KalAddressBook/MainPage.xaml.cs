using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using KalAddressBook.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KalAddressBook
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Contact> contacts;
        private List<MenuItem> menuItems;
        public MainPage()
        {
            this.InitializeComponent();
            contacts = new ObservableCollection<Contact>();
            ContactManager.GetAllContacts(contacts);

            menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconA.png",
                Category = ContactCategory.A
            });

            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconB.png",
                Category = ContactCategory.B
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconB.png",
                Category = ContactCategory.C
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconB.png",
                Category = ContactCategory.D
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconB.png",
                Category = ContactCategory.E
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconB.png",
                Category = ContactCategory.F
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconB.png",
                Category = ContactCategory.G
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconB.png",
                Category = ContactCategory.H
            });
            menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconB.png",
                Category = ContactCategory.I
            }); menuItems.Add(new MenuItem
            {
                IconFile = "Assets/Icons/iconB.png",
                Category = ContactCategory.J

            });
            BackButton.Visibility=Visibility.Collapsed;


        }



        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ContactManager.GetAllContacts(contacts);
            //CategoryTextBlock.Text = "All Contacts";
            BackButton.Visibility=Visibility.Collapsed;
            MenuItemsListView.SelectedItem = null;

        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)

        {
            var menuItem = (MenuItem)e.ClickedItem;
            ContactManager.GetContactsByCategory(contacts, menuItem.Category);
                //CategoryTextBlock.Text = menuItem.Category.ToString();
            BackButton.Visibility=Visibility.Visible;

        }

        private void ContactGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var contact = (Contact)e.ClickedItem;

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            ContentSplitView.IsPaneOpen = !ContentSplitView.IsPaneOpen;
        }
    }
}
