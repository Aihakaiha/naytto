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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace naytto_projekti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public static Window1 log_in;
        public static Window2 sign_in;


        /// <summary>
        /// Tarkistaa onko kirjautumis tai rekisteröinti ikkuna auki, jos on se kutsuu funktion "closeAll" Lue closeAll:ista lisää rivillä 94
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (log_in == null && sign_in == null)
            {
                log_in = new Window1();
                log_in.Show();
            }
            else
            {
                closeAll();
            }
        }


        /// <summary>
        /// Tarkistaa onko kirjautumis tai rekisteröinti ikkuna auki, jos on se kutsuu funktion "closeAll" Lue closeAll:ista lisää rivillä 94
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            

            if (log_in == null && sign_in == null)
            {
                log_in = new Window1();
                log_in.Show();
            }
            else
            {
                closeAll();
            }
            
        }

        /// <summary>
        /// Tarkistaa onko kirjautumis tai rekisteröinti ikkuna auki, jos on se kutsuu funktion "closeAll" Lue closeAll:ista lisää rivillä 94
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (sign_in == null && log_in == null)
            {
                Window2 sign_in = new Window2();
                sign_in.Show();
            }
            else
            {
                closeAll();
            }
            
        }


        /// <summary>
        /// Tarkistaa onko kirjautumis tai rekisteröinti ikkuna auki, jos on se kutsuu funktion "closeAll" Lue closeAll:ista lisää rivillä 94
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sign_in == null && log_in == null)
            {
                sign_in = new Window2();
                sign_in.Show();
            }
            else
            {
                closeAll();
            }
        }


        /// <summary>
        /// closeAll varoittaa käyttäjälle, että heillä on ikkuna jo auki ja kysyy tahtooko käyttäjä sulkea sen.
        /// </summary>

        private void closeAll()
        {
            MessageBoxResult res = MessageBox.Show("Sinulla on jo ikkuna auki\nSuljetaanko Ikkuna?", "Varoitus", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                foreach (Window win in Application.Current.Windows)
                {
                    if (win != this)
                    {
                        win.Close();
                    }
                }
                log_in = null;
                sign_in = null;
            }
        }
    }
}
