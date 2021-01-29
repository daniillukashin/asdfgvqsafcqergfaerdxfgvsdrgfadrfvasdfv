using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterAUTO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class volkswagen : ContentPage
    {
        public volkswagen()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "Модель:" + picker.Items[picker.SelectedIndex];
        }
    }
}