using PM2E144.Models;
using PMovil2Tarea14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E144
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewSite : ContentPage
    {
        public ViewSite()
        {
            InitializeComponent();
        }

        private async void btneliminar_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayAlert("ADVERTENCIA", "Desea eliminar el sitio?", "Yes", "No");
            if (action)
            {
                var site = await App.DBase.GetSitesByIdAsync(Int32.Parse(txtid.Text));
                if (site != null)
                {
                    await App.DBase.DeleteSiteAsync(site);
                    await DisplayAlert("Eliminado", "Se elimino de manera exitosa!", "Ok");
                    await Navigation.PopToRootAsync();
                }
            }
        }


    }
}