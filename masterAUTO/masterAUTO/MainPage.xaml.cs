using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace masterAUTO
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("bmw.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.spisok);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        public List<MasterMenuItems> GetMenuList()
        {
            
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "BMW",
                Detail = "Модель, Цена",
                ImagePath = "bmwlogo.jpg",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Audi",
                Detail = "Модель, Цена",
                ImagePath = "audi.jpg",
                TargetPage = typeof(Views.audi)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Mercedes",
                Detail = "Модель, Цена",
                ImagePath = "merc.jpg",
                TargetPage = typeof(Views.mercedes)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Volkswagen",
                Detail = "Модель, Цена",
                ImagePath = "volks.jpg",
                TargetPage = typeof(Views.volkswagen)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Toyota",
                Detail = "Модель, Цена",
                ImagePath = "toyota.jpg",
                TargetPage = typeof(Views.toyota)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Nissan",
                Detail = "Модель, Цена",
                ImagePath = "nissan.jpg",
                TargetPage = typeof(Views.nissan)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Mini",
                Detail = "Модель, Цена",
                ImagePath = "mini.jpg",
                TargetPage = typeof(Views.mini)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Saab",
                Detail = "Модель, Цена",
                ImagePath = "saab.png",
                TargetPage = typeof(Views.saab)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Volvo",
                Detail = "Модель, Цена",
                ImagePath = "volvo.jpg",
                TargetPage = typeof(Views.volvo)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Lada",
                Detail = "Модель, Цена",
                ImagePath = "lada.jpg",
                TargetPage = typeof(Views.lada)

            });
            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selected = (MasterMenuItems)e.SelectedItem;
            Type selectedpage = selected.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
}
