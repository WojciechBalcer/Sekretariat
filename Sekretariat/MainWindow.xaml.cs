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

namespace Sekretariat
{
    public partial class MainWindow : Window
    {
        int licznikUczniow = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void dodajUcznia(object sender, RoutedEventArgs e)
        {
            licznikUczniow++;

            String imieUcznia = imieU.Text;
            String drugieImieUcznia = drugieImieU.Text;
            String nazwiskoUcznia = nazwiskoU.Text;
            String nazwiskoPanieniskieUcznia = nazwiskoPanienskieU.Text;
            String imionaRodzicowUcznia = imonaRodzicowU.Text;
            String dataUrodzeniaUcznia = dataUrodzeniaU.Text;
            String peselUcznia = peselU.Text;
            String klasaUcznia = doKlasyU.Text;


            if (licznikUczniow == 1)
            {

                imieU1.Text = imieUcznia;
                drugieImieU1.Text = drugieImieUcznia;
                nazwiskoU1.Text = nazwiskoUcznia;
                panienskieNazwiskoU1.Text = nazwiskoPanieniskieUcznia;
                imionaRodzicowU1.Text = imionaRodzicowUcznia;
                datUrU1.Text = dataUrodzeniaUcznia;
                peselU1.Text = peselUcznia;
                klasaU1.Text = klasaUcznia;
            }
            if (licznikUczniow == 2)
            {

                imieU2.Text = imieUcznia;
                drugieImieU2.Text = drugieImieUcznia;
                nazwiskoU2.Text = nazwiskoUcznia;
                panienskieNazwiskoU2.Text = nazwiskoPanieniskieUcznia;
                imionaRodzicowU2.Text = imionaRodzicowUcznia;
                datUrU2.Text = dataUrodzeniaUcznia;
                peselU2.Text = peselUcznia;
                klasaU2.Text = klasaUcznia;
            }
            if (licznikUczniow == 3)
            {

                imieU3.Text = imieUcznia;
                drugieImieU3.Text = drugieImieUcznia;
                nazwiskoU3.Text = nazwiskoUcznia;
                panienskieNazwiskoU3.Text = nazwiskoPanieniskieUcznia;
                imionaRodzicowU3.Text = imionaRodzicowUcznia;
                datUrU3.Text = dataUrodzeniaUcznia;
                peselU3.Text = peselUcznia;
                klasaU3.Text = klasaUcznia;
            }
            if (licznikUczniow == 4)
            {

                imieU4.Text = imieUcznia;
                drugieImieU4.Text = drugieImieUcznia;
                nazwiskoU4.Text = nazwiskoUcznia;
                panienskieNazwiskoU4.Text = nazwiskoPanieniskieUcznia;
                imionaRodzicowU4.Text = imionaRodzicowUcznia;
                datUrU4.Text = dataUrodzeniaUcznia;
                peselU4.Text = peselUcznia;
                klasaU4.Text = klasaUcznia;
            }
            if (licznikUczniow == 5)
            {

                imieU5.Text = imieUcznia;
                drugieImieU5.Text = drugieImieUcznia;
                nazwiskoU5.Text = nazwiskoUcznia;
                panienskieNazwiskoU5.Text = nazwiskoPanieniskieUcznia;
                imionaRodzicowU5.Text = imionaRodzicowUcznia;
                datUrU5.Text = dataUrodzeniaUcznia;
                peselU5.Text = peselUcznia;
                klasaU5.Text = klasaUcznia;
            }


            MessageBox.Show("Dodano ucznia" + licznikUczniow);
        }
        public void wyczyscUcznia(object sender, RoutedEventArgs e)
        {
            imieU.Text = " ";
            drugieImieU.Text = " ";
            nazwiskoU.Text = " ";
            nazwiskoPanienskieU.Text = " ";
            imonaRodzicowU.Text = " ";
            dataUrodzeniaU.Text = " ";
            peselU.Text = " ";
            doKlasyU.Text = " ";
        }
    }
}