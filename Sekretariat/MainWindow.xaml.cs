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

            dataUrodzeniaN.DisplayDateStart = System.DateTime.Today.AddYears(-65);
            dataUrodzeniaP.DisplayDateStart = System.DateTime.Today.AddYears(-65);
            dataUrodzeniaU.DisplayDateStart = System.DateTime.Today.AddYears(-25);
            dataUrodzeniaN.DisplayDateEnd = System.DateTime.Today.AddYears(-30);
            dataUrodzeniaU.DisplayDateEnd = System.DateTime.Today.AddYears(-14);
            dataUrodzeniaP.DisplayDateEnd = System.DateTime.Today.AddYears(-25);

            peselN.MaxLength = 11;
            peselP.MaxLength = 11;
            peselU.MaxLength = 11;

            imieN.MaxLength = 20;
            imieU.MaxLength = 20;
            imieP.MaxLength = 20;

            drugieImieN.MaxLength = 20;
            drugieImieU.MaxLength = 20;
            drugieImieP.MaxLength = 20;

            nazwiskoN.MaxLength = 20;
            nazwiskoP.MaxLength = 20;
            nazwiskoU.MaxLength = 20;

            nazwiskoPanienskieN.MaxLength = 20;
            nazwiskoPanienskieU.MaxLength = 20;
            nazwiskoPanienskieP.MaxLength = 20;

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
            public DateTime dataUrodzenia { get; set; }
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
            public DateTime dataUrodzenia { get; set; }
            public string pesel { get; set; }
            public string zdjecie { get; set; }
            public string plec { get; set; }
            public string wychowawstwo { get; set; }
            public string nauczanePrzedmioty { get; set; }
            public DateTime dataZatrudnienia { get; set; }
        }
        public class pracownik
        {
            public string imie { get; set; }
            public string drugieImie { get; set; }
            public string nazwisko { get; set; }
            public string nazwiskoPanienskie { get; set; }
            public string imionaRodzicow { get; set; }
            public DateTime dataUrodzenia { get; set; }
            public string pesel { get; set; }
            public string zdjecie { get; set; }
            public string plec { get; set; }
            public string etat { get; set; }
            public string opis { get; set; }
            public DateTime dataZatrudnienia { get; set; }
        }
        

        private void dodajUcznia(object sender, RoutedEventArgs e)
        {

        licznikUczniow++;

            String imieUcznia = imieU.Text;
            String drugieImieUcznia = drugieImieU.Text;
            String nazwiskoUcznia = nazwiskoU.Text;
            String nazwiskoPanieniskieUcznia = nazwiskoPanienskieU.Text;
            String imionaRodzicowUcznia = imonaRodzicowU.Text;
            DateTime dataUrodzeniaUcznia = dataUrodzeniaU.SelectedDate.Value;
            String peselUcznia = peselU.Text;
            //BitmapImage zdjecieUcznia = zdjecieU.Text;
            String plecUcznia = plecU.Text;
            String klasaUcznia = doKlasyU.Text;
            String grupaUcznia = doGrupyU.Text;
            uczniowie.Add(new uczen() { imie = imieUcznia, drugieImie = drugieImieUcznia, nazwisko = nazwiskoUcznia, nazwiskoPanienskie = nazwiskoPanieniskieUcznia, imionaRodzicow = imionaRodzicowUcznia, dataUrodzenia = dataUrodzeniaUcznia, pesel = peselUcznia, plec = plecUcznia, klasa = klasaUcznia, grupa = grupaUcznia }) ;

            MessageBox.Show("Dodano ucznia" + licznikUczniow);
        }
        public void wyczyscUcznia(object sender, RoutedEventArgs e)
        {
            imieU.Text = " ";
            drugieImieU.Text = " ";
            nazwiskoU.Text = " ";
            nazwiskoPanienskieU.Text = " ";
            imonaRodzicowU.Text = " ";
            peselU.Text = " ";
            plecU.Text = " ";
            doKlasyU.Text = " ";
            doGrupyU.Text = " ";
        }
        
        private void dodajNauczyciela(object sender, RoutedEventArgs e)
        {
            
        licznikNauczycieli++;

            String imieNauczyciela = imieN.Text;
            String drugieImieNauczyciela = drugieImieN.Text;
            String nazwiskoNauczyciela = nazwiskoN.Text;
            String nazwiskoPanieniskieNauczyciela = nazwiskoPanienskieN.Text;
            String imionaRodzicowNauczyciela = imonaRodzicowN.Text;
            DateTime dataUrodzeniaNauczyciela = dataUrodzeniaN.SelectedDate.Value;
            String peselNauczyciela = peselN.Text;
            String zdjecieNauczyciela = zdjecieN.Text;
            String plecNauczyciela = plecN.Text;
            String wychowawstwoNauczyciela = WychowawstwoN.Text;
            String nauczanePrzedmiotyNauczyciela = przedmiotyNauczania.Text;
            DateTime dataZatrudnieniaNauczyciela = DataZatrudnienaN.SelectedDate.Value;
            nauczyciele.Add(new nauczyciel() { dataZatrudnienia = dataZatrudnieniaNauczyciela, nauczanePrzedmioty = nauczanePrzedmiotyNauczyciela, wychowawstwo = wychowawstwoNauczyciela, plec = plecNauczyciela, imie = imieNauczyciela, drugieImie = drugieImieNauczyciela, nazwisko = nazwiskoNauczyciela, nazwiskoPanienskie = nazwiskoPanieniskieNauczyciela, imionaRodzicow = imionaRodzicowNauczyciela, dataUrodzenia = dataUrodzeniaNauczyciela, pesel = peselNauczyciela }); 


            MessageBox.Show("Dodano nauczyciela " + licznikNauczycieli);
        }
        public void wyczyscNauczyciela(object sender, RoutedEventArgs e)
        {
            imieN.Text = " ";
            drugieImieN.Text = " ";
            nazwiskoN.Text = " ";
            nazwiskoPanienskieN.Text = " ";
            imonaRodzicowN.Text = " ";
            peselN.Text = " ";
            plecN.Text = " ";
            WychowawstwoN.Text = " ";
            przedmiotyNauczania.Text = " ";

        }
        
        private void dodajPracownika(object sender, RoutedEventArgs e)
        {
            licznikPracownikow++;


            String imiePracownika = imieP.Text;
            String drugieImiePracownika = drugieImieP.Text;
            String nazwiskoPracownika = nazwiskoP.Text;
            String nazwiskoPanienskiePracownika = nazwiskoPanienskieP.Text;
            String imonaRodzicowPracownika = imonaRodzicowP.Text;
            DateTime dataUrodzeniaPracownika = dataUrodzeniaP.SelectedDate.Value;
            String peselPracownika = peselP.Text;
            String plecPracownika = plecP.Text;
            String etatPracownika = etat.Text;
            String opisPracownika = Opis.Text;
            DateTime dataZatrudnieniaPracownika = DataZatrudnienaP.SelectedDate.Value;
            
            pracownicy.Add(new pracownik() { opis = opisPracownika, etat = etatPracownika, dataZatrudnienia = dataZatrudnieniaPracownika, plec = plecPracownika, imie = imiePracownika, drugieImie = drugieImiePracownika, nazwisko = nazwiskoPracownika, nazwiskoPanienskie = nazwiskoPanienskiePracownika, imionaRodzicow = imonaRodzicowPracownika, dataUrodzenia = dataUrodzeniaPracownika, pesel = peselPracownika });


            MessageBox.Show("Dodano pracownika " + licznikPracownikow);
        }
        
        public void wyczyscPracownika(object sender, RoutedEventArgs e)
        {
            imieP.Text = " ";
            drugieImieP.Text = " ";
            nazwiskoP.Text = " ";
            nazwiskoPanienskieP.Text = " ";
            imonaRodzicowP.Text = " ";
            peselP.Text = " ";
            plecP.Text = " ";
            etat.Text = " ";
            Opis.Text = " ";
        }
    }
}