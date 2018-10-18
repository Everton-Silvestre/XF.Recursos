using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;

namespace XF.Recursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
        public ListView ListView { get { return lstMenu; } }
        public MenuView()
        {
            InitializeComponent();

            ObservableCollection<OpcoesMenu> menuItems = new ObservableCollection<OpcoesMenu>();
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Home",
                Icone = "home.png",
                TargetType = typeof(HomeView)
            });

            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Editor",
                //Icone = "Home.png",
                TargetType = typeof(Controles.EditorView)
            });

            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Controle de Data",
                //Icone = "Home.png",
                TargetType = typeof(Controles.PickerView)
            });


            lstMenu.ItemsSource = menuItems;
        }
    }
}