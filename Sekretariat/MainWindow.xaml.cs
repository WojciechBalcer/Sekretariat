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
        List<nauczyciel> nauczyciele;
        List<pracownik> pracownicy;

        int licznikUczniow = 0;
        int licznikNauczycieli = 0;
        int licznikPracownikow = 0;

        public MainWindow()
        {
            InitializeComponent();
            uczniowie = new List<uczen>();
            nauczyciele = new List<nauczyciel>();
            pracownicy = new List<pracownik>();

            listaUczniow.ItemsSource = uczniowie;
            listaNauczycieli.ItemsSource = nauczyciele;
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
        public class nauczyciel
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
            public string wychowawstwo { get; set; }
            public string nauczanePrzedmioty { get; set; }
            public string dataZatrudnienia { get; set; }
        }
        public class pracownik
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
            public string etat { get; set; }
            public string opis { get; set; }
            public string dataZatrudnienia { get; set; }
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
            uczniowie.Add(new uczen() { imie = imieUcznia, drugieImie = drugieImieUcznia, nazwisko = nazwiskoUcznia, nazwiskoPanienskie = nazwiskoPanieniskieUcznia, imionaRodzicow = imionaRodzicowUcznia,  dataUrodzenia = dataUrodzeniaUcznia, pesel = peselUcznia, klasa = klasaUcznia }); ;

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
            nauczyciele.Add(new nauczyciel() { imie = imieNauczyciela, drugieImie = drugieImieNauczyciela, nazwisko = nazwiskoNauczyciela, nazwiskoPanienskie = nazwiskoPanieniskieNauczyciela, imionaRodzicow = imionaRodzicowNauczyciela, dataUrodzenia = dataUrodzeniaNauczyciela, pesel = peselNauczyciela }); 


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
        /*
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