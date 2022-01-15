﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
            dataUrodzeniaU.DisplayDate = System.DateTime.Today;
            dataUrodzeniaN.DisplayDate = System.DateTime.Today;
            dataUrodzeniaP.DisplayDate = System.DateTime.Today;
            dataUrodzeniaN.DisplayDateEnd = System.DateTime.Today.AddYears(-30);
            dataUrodzeniaU.DisplayDateEnd = System.DateTime.Today.AddYears(-14);
            dataUrodzeniaP.DisplayDateEnd = System.DateTime.Today.AddYears(-25);

            DataZatrudnienaN.DisplayDate = System.DateTime.Today;            
            DataZatrudnienaN.DisplayDateStart = System.DateTime.Today.AddYears(-65);

            DataZatrudnienaP.DisplayDate = System.DateTime.Today;
            DataZatrudnienaP.DisplayDateStart = System.DateTime.Today.AddYears(-65);

            plecN.Items.Add("męższczyzna");
            plecN.Items.Add("kobieta");
            plecN.Items.Add("nie chce podawać");

            plecU.Items.Add("męższczyzna");
            plecU.Items.Add("kobieta");
            plecU.Items.Add("nie chce podawać");

            plecP.Items.Add("męższczyzna");
            plecP.Items.Add("kobieta");
            plecP.Items.Add("nie chce podawać");

            etat.Items.Add("pełen etat");
            etat.Items.Add("1/2 etatu");
            etat.Items.Add("1/4 etatu");
            etat.Items.Add("1/8 etatu");
            etat.Items.Add("3/8 etatu");
            etat.Items.Add("5/8 etatu");
            etat.Items.Add("7/8 etatu");
            etat.Items.Add("3/4 etatu");
            etat.Items.Add("1/3 etatu");
            etat.Items.Add("2/3 etatu");
            etat.Items.Add("1/5 etatu");
            etat.Items.Add("2/5 etatu");
            etat.Items.Add("3/5 etatu");
            etat.Items.Add("4/5 etatu");

            etat.Items.Add("etatu");

            WychowawstwoN.Items.Add("IA");
            WychowawstwoN.Items.Add("IB");
            WychowawstwoN.Items.Add("IC");
            WychowawstwoN.Items.Add("ID");
            WychowawstwoN.Items.Add("IE");
            WychowawstwoN.Items.Add("IIA");
            WychowawstwoN.Items.Add("IIB");
            WychowawstwoN.Items.Add("IIC");
            WychowawstwoN.Items.Add("IID");
            WychowawstwoN.Items.Add("IIE");
            WychowawstwoN.Items.Add("IIIA");
            WychowawstwoN.Items.Add("IIIB");
            WychowawstwoN.Items.Add("IIIC");
            WychowawstwoN.Items.Add("IIID");
            WychowawstwoN.Items.Add("IIIE");
            WychowawstwoN.Items.Add("IVA");
            WychowawstwoN.Items.Add("IVB");
            WychowawstwoN.Items.Add("IVC");
            WychowawstwoN.Items.Add("IVD");
            WychowawstwoN.Items.Add("IVE");

            doKlasyU.Items.Add("IA");
            doKlasyU.Items.Add("IB");
            doKlasyU.Items.Add("IC");
            doKlasyU.Items.Add("ID");
            doKlasyU.Items.Add("IE");
            doKlasyU.Items.Add("IIA");
            doKlasyU.Items.Add("IIB");
            doKlasyU.Items.Add("IIC");
            doKlasyU.Items.Add("IID");
            doKlasyU.Items.Add("IIE");
            doKlasyU.Items.Add("IIIA");
            doKlasyU.Items.Add("IIIB");
            doKlasyU.Items.Add("IIIC");
            doKlasyU.Items.Add("IIID");
            doKlasyU.Items.Add("IIIE");
            doKlasyU.Items.Add("IVA");
            doKlasyU.Items.Add("IVB");
            doKlasyU.Items.Add("IVC");
            doKlasyU.Items.Add("IVD");
            doKlasyU.Items.Add("IVE");


            przedmiotyNauczania.Items.Add("Matematyka");
            przedmiotyNauczania.Items.Add("Informatyka");
            przedmiotyNauczania.Items.Add("Polski");
            przedmiotyNauczania.Items.Add("Angielski");
            przedmiotyNauczania.Items.Add("Niemiecki");
            przedmiotyNauczania.Items.Add("Wf");
            przedmiotyNauczania.Items.Add("Historia");
            przedmiotyNauczania.Items.Add("EDB");
            przedmiotyNauczania.Items.Add("Biologia");
            przedmiotyNauczania.Items.Add("Fizyka");


            doGrupyU.Items.Add("pierwsza grupa językowa");
            doGrupyU.Items.Add("druga grupa językowa");
            doGrupyU.Items.Add("kółko teatralne");
            doGrupyU.Items.Add("kółko matematyczne");
            doGrupyU.Items.Add("kółko przyrodnicze");
            doGrupyU.Items.Add("kółko fotograficzne");
            doGrupyU.Items.Add("SKS-y");
            doGrupyU.Items.Add("kółko meterologiczne");
            doGrupyU.Items.Add("kółko medyczne");

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
            public String dataUrodzenia { get; set; }
            public string pesel { get; set; }
            public string zdjecie { get; set; }
            public String plec { get; set; }
            public String klasa { get; set; }
            public String grupa { get; set; }
        }
        public class nauczyciel
        {
            public string imie { get; set; }
            public string drugieImie { get; set; }
            public string nazwisko { get; set; }
            public string nazwiskoPanienskie { get; set; }
            public string imionaRodzicow { get; set; }
            public String dataUrodzenia { get; set; }
            public string pesel { get; set; }
            public string zdjecie { get; set; }
            public String plec { get; set; }
            public String wychowawstwo { get; set; }
            public String nauczanePrzedmioty { get; set; }
            public String dataZatrudnienia { get; set; }
            
        }
        public class pracownik
        {
            public string imie { get; set; }
            public string drugieImie { get; set; }
            public string nazwisko { get; set; }
            public string nazwiskoPanienskie { get; set; }
            public string imionaRodzicow { get; set; }
            public String dataUrodzenia { get; set; }
            public string pesel { get; set; }
            public string zdjecie { get; set; }
            public String plec { get; set; }
            public String etat { get; set; }
            public string opis { get; set; }
            public String dataZatrudnienia { get; set; }
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
            //BitmapImage zdjecieUcznia = zdjecieU.Text;
            String plecUcznia = plecU.Text;
            String klasaUcznia = doKlasyU.Text;
            String grupaUcznia = "";

            foreach (var Item in doGrupyU.SelectedItems)
            {
                grupaUcznia +=  Item.ToString()+", " ;
            }

            uczniowie.Add(new uczen() { imie = imieUcznia, drugieImie = drugieImieUcznia, nazwisko = nazwiskoUcznia, nazwiskoPanienskie = nazwiskoPanieniskieUcznia, imionaRodzicow = imionaRodzicowUcznia, dataUrodzenia = dataUrodzeniaUcznia, pesel = peselUcznia, plec = plecUcznia , klasa = klasaUcznia, grupa = grupaUcznia }) ;
            
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
            String zdjecieNauczyciela = zdjecieN.Text;
            String plecNauczyciela = plecN.Text;
            String wychowawstwoNauczyciela = WychowawstwoN.Text;
            String nauczanePrzedmiotyNauczyciela = "";
            String dataZatrudnieniaNauczyciela = DataZatrudnienaN.Text;

            foreach(var Item in przedmiotyNauczania.SelectedItems)
            {
                nauczanePrzedmiotyNauczyciela += Item.ToString()+", " ;
            }

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
            WychowawstwoN.Text = " ";


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
            String peselPracownika = peselP.Text;
            String plecPracownika = plecP.Text;
            String etatPracownika = etat.Text;
            String opisPracownika = Opis.Text;
            String dataZatrudnieniaPracownika = DataZatrudnienaP.Text;
            
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
            etat.Text = " ";
            Opis.Text = " ";
        }
        private void zapisz(object sender, RoutedEventArgs e)
        {
            string zapis = "";

            

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.FileName = $"zapis.txt";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (saveFileDialog.ShowDialog() == true)
            {
                
                    foreach (uczen u in listaUczniow.ItemsSource)
                        zapis += $"uczen ;{u.imie};{u.drugieImie};{u.nazwisko};{u.nazwiskoPanienskie};{u.pesel};{u.plec};{u.imionaRodzicow};{u.dataUrodzenia};{u.klasa};{u.grupa}\n";

                
                    foreach (nauczyciel n in listaNauczycieli.ItemsSource)
                        zapis += $"nauczyciel ;{n.imie};{n.drugieImie};{n.nazwisko};{n.nazwiskoPanienskie};{n.pesel};{n.plec};{n.imionaRodzicow};{n.dataUrodzenia};{n.wychowawstwo};{n.nauczanePrzedmioty};{n.dataZatrudnienia}\n";

                
                    //foreach (pracownik p in listaPracownikow.ItemsSource)
                        //zapis += $"pracownik ;{p.imie};{p.drugieImie};{p.nazwisko};{p.nazwiskoPanienskie};{p.pesel};{p.plec};{p.imionaRodzicow};{p.dataUrodzenia};{p.etat};{p.opis};{p.dataZatrudnienia}\n";

                File.WriteAllText(saveFileDialog.FileName, zapis + " ");
            }
        }
    }
}