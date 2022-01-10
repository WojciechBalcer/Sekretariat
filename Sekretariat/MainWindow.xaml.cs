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
        List<uczen> uczniowie;

        //int licznikUczniow = 0;
        //int licznikNauczycieli = 0;
        //int licznikPracownikow = 0;

        public MainWindow()
        {
            InitializeComponent();
            uczniowie = new List<uczen>();
        }
        public class uczen
        {
            public string imie { get; set; }
            public string drugieImie { get; set; }
            public string nazwisko { get; set; }
            public string nazwiskoPanienskie { get; set; }
            public string imionaRodzicow { get; set; }
            public string dataUrodzenia { get; set; }
            public string pesel { get; set; }
            public string zdjecie { get; set; }
            public string plec { get; set; }
            public string klasa { get; set; }
            public string grupa { get; set; }
        }
        public void dodajU(object sender, RoutedEventArgs e)
        {

           // imie = textImie.Text;
            //uczniowie.Add(new uczen() { Imie = imie, DrugieImie = drugieImie, Nazwisko = nazwisko, NazwiskoRodowe = nazwiskoRodowe, Pesel = pesel, Zdjecie = zdjecie, Plec = plec[0], ImieMatki = imieMatki, ImieOjca = imieOjca, DataUrodzenia = dataUrodzenia, Klasa = klasa, Grupy = grupy });
        }
        
        /*private void dodajUcznia(object sender, RoutedEventArgs e)
        {
            licznikUczniow++;
            licznikNauczycieli++;

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
        /*public void wyczyscUcznia(object sender, RoutedEventArgs e)
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
        private void dodajNauczyciela(object sender, RoutedEventArgs e)
        {
            licznikNauczycieli++;

            String imieNauczyciela = imieN.Text;
            String drugieImieNauczyciela = drugieImieN.Text;
            String nazwiskoNauczyciela = nazwiskoN.Text;
            String nazwiskoPanieniskieNauczyciela = nazwiskoPanienskieN.Text;
            String imionaRodzicowNauczyciela = imonaRodzicowN.Text;
            String dataUrodzeniaNauczyciela = dataUrodzeniaN.Text;
            String peselNauczyciela = peselN.Text;


            if (licznikNauczycieli == 1)
            {

                imieN1.Text = imieNauczyciela;
                drugieImieN1.Text = drugieImieNauczyciela;
                nazwiskoN1.Text = nazwiskoNauczyciela;
                panienskieNazwiskoN1.Text = nazwiskoPanieniskieNauczyciela;
                imionaRodzicowN1.Text = imionaRodzicowNauczyciela;
                datUrN1.Text = dataUrodzeniaNauczyciela;
                peselN1.Text = peselNauczyciela;
            }
            if (licznikNauczycieli == 2)
            {

                imieN2.Text = imieNauczyciela;
                drugieImieN2.Text = drugieImieNauczyciela;
                nazwiskoN2.Text = nazwiskoNauczyciela;
                panienskieNazwiskoN2.Text = nazwiskoPanieniskieNauczyciela;
                imionaRodzicowN2.Text = imionaRodzicowNauczyciela;
                datUrN2.Text = dataUrodzeniaNauczyciela;
                peselN2.Text = peselNauczyciela;
            }
            if (licznikNauczycieli == 3)
            {

                imieN3.Text = imieNauczyciela;
                drugieImieN3.Text = drugieImieNauczyciela;
                nazwiskoN3.Text = nazwiskoNauczyciela;
                panienskieNazwiskoN3.Text = nazwiskoPanieniskieNauczyciela;
                imionaRodzicowN3.Text = imionaRodzicowNauczyciela;
                datUrN3.Text = dataUrodzeniaNauczyciela;
                peselN3.Text = peselNauczyciela;
            }
            if (licznikNauczycieli == 4)
            {

                imieN4.Text = imieNauczyciela;
                drugieImieN4.Text = drugieImieNauczyciela;
                nazwiskoN4.Text = nazwiskoNauczyciela;
                panienskieNazwiskoN4.Text = nazwiskoPanieniskieNauczyciela;
                imionaRodzicowN4.Text = imionaRodzicowNauczyciela;
                datUrN4.Text = dataUrodzeniaNauczyciela;
                peselN4.Text = peselNauczyciela;
            }
            if (licznikNauczycieli == 5)
            {

                imieN5.Text = imieNauczyciela;
                drugieImieN5.Text = drugieImieNauczyciela;
                nazwiskoN5.Text = nazwiskoNauczyciela;
                panienskieNazwiskoN5.Text = nazwiskoPanieniskieNauczyciela;
                imionaRodzicowN5.Text = imionaRodzicowNauczyciela;
                datUrN5.Text = dataUrodzeniaNauczyciela;
                peselN5.Text = peselNauczyciela;
            }
            MessageBox.Show("Dodano nauczyciela " + licznikNauczycieli);
        }
        public void wyczyscNauczyciela(object sender, RoutedEventArgs e)
        {
            imieN.Text = " ";
            drugieImieN.Text = " ";
            nazwiskoN.Text = " ";
            nazwiskoPanienskieN.Text = " ";
            imonaRodzicowN.Text = " ";
            dataUrodzeniaN.Text = " ";
            peselN.Text = " ";
        }
        private void dodajPracownika(object sender, RoutedEventArgs e)
        {
            licznikPracownikow++;

            String imiePracownika = imieP.Text;
            String drugieImiePracownika = drugieImieP.Text;
            String nazwiskoPracownika = nazwiskoP.Text;
            String nazwiskoPanienskiePracownika = nazwiskoPanienskieP.Text;
            String imonaRodzicowPracownika = imonaRodzicowP.Text;
            String dataUrodzeniaPracownika = dataUrodzeniaP.Text;
            String peselNauczyciela = peselP.Text;


            if (licznikPracownikow == 1)
            {

                imieP1.Text = imiePracownika;
                drugieImieP1.Text = drugieImiePracownika;
                nazwiskoP1.Text = nazwiskoPracownika;
                panienskieNazwiskoP1.Text = nazwiskoPanienskiePracownika;
                imionaRodzicowP1.Text = imonaRodzicowPracownika;
                datUrP1.Text = dataUrodzeniaPracownika;
                peselP1.Text = peselNauczyciela;
            }
            if (licznikPracownikow == 2)
            {

                imieP2.Text = imiePracownika;
                drugieImieP2.Text = drugieImiePracownika;
                nazwiskoP2.Text = nazwiskoPracownika;
                panienskieNazwiskoP2.Text = nazwiskoPanienskiePracownika;
                imionaRodzicowP2.Text = imonaRodzicowPracownika;
                datUrP2.Text = dataUrodzeniaPracownika;
                peselP2.Text = peselNauczyciela;
            }
            if (licznikPracownikow == 3)
            {

                imieP3.Text = imiePracownika;
                drugieImieP3.Text = drugieImiePracownika;
                nazwiskoP3.Text = nazwiskoPracownika;
                panienskieNazwiskoP3.Text = nazwiskoPanienskiePracownika;
                imionaRodzicowP3.Text = imonaRodzicowPracownika;
                datUrP3.Text = dataUrodzeniaPracownika;
                peselP3.Text = peselNauczyciela;
            }
            if (licznikPracownikow == 4)
            {

                imieP4.Text = imiePracownika;
                drugieImieP4.Text = drugieImiePracownika;
                nazwiskoP4.Text = nazwiskoPracownika;
                panienskieNazwiskoP4.Text = nazwiskoPanienskiePracownika;
                imionaRodzicowP4.Text = imonaRodzicowPracownika;
                datUrP4.Text = dataUrodzeniaPracownika;
                peselP4.Text = peselNauczyciela;
            }
            if (licznikPracownikow == 5)
            {

                imieP5.Text = imiePracownika;
                drugieImieP5.Text = drugieImiePracownika;
                nazwiskoP5.Text = nazwiskoPracownika;
                panienskieNazwiskoP5.Text = nazwiskoPanienskiePracownika;
                imionaRodzicowP5.Text = imonaRodzicowPracownika;
                datUrP5.Text = dataUrodzeniaPracownika;
                peselP5.Text = peselNauczyciela;
            }
            MessageBox.Show("Dodano pracownika " + licznikPracownikow);
        }
        public void wyczyscPracownika(object sender, RoutedEventArgs e)
        {
            imieP.Text = " ";
            drugieImieP.Text = " ";
            nazwiskoP.Text = " ";
            nazwiskoPanienskieP.Text = " ";
            imonaRodzicowP.Text = " ";
            dataUrodzeniaP.Text = " ";
            peselP.Text = " ";
        }*/
    }
}