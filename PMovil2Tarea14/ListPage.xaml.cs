using PM2E144.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using PM2E144;
using PMovil2Tarea14;


namespace PMovil2Tarea14
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            llenarDatos();
        }

        public async void llenarDatos()
        {
            var siteList = await App.DBase.GetSitesAsync();
            if (siteList != null)
            {
                lstSites.ItemsSource = siteList;
            }
        }
        private async void lstSites_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Sites)e.SelectedItem;
            if (!string.IsNullOrEmpty(obj.id.ToString()))
            {
                var site = await App.DBase.GetSitesByIdAsync(obj.id);
                if (site != null)
                {
                    ViewSite sitio = new ViewSite();
                    sitio.BindingContext = site;
                    await Navigation.PushAsync(sitio);
                }
            }
        }
    }
}