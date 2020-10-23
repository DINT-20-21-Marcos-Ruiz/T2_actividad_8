using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace actividad_UT2_8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NombreApellido_KeyDown(object sender, KeyEventArgs args)
        {
            if (args.Key == Key.F1)
            {
                if(sender == nombreTextoBox)
                {
                    if(avisoNombreTextBlock.Text != "") avisoNombreTextBlock.Text = "";
                    else avisoNombreTextBlock.Text = "Nombre del cliente";

                }
                if((sender == apellidoTextoBox))
                {
                    if(avisoApellidoTextBlock.Text != "") avisoApellidoTextBlock.Text = "";
                    else avisoApellidoTextBlock.Text = "Apellido del cliente";
                }
                
               
            }
        }

  
        private void Edad_KeyDown(object sender, KeyEventArgs args)
        {
            if (args.Key == Key.F2)
            {
                int temp = 0;
                if (!int.TryParse(edadTextoBox.Text, out temp))
                {
                    avisoEdadTextBlock.Text = "Edad incorrecta";
                    avisoEdadTextBlock.Foreground = Brushes.Red;

                }
                else avisoEdadTextBlock.Text = "";
            }
        }
    }
}
