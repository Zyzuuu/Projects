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


namespace InsuranceApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string InsuranceCompany = "";
        string Recpient = "";
        string CarBrand = "";
        string CarType = "";
        string DiscountOC = "";
        string CarPriceAC = "";
        string GrossNetAC = "";
        string OwnContributionAC = "";
        string DiscountAC = "";
        string ValuationTypeAC = "";
        string NnwTypes = "";
        string AssistanceRange = "";
        string CarGlass = "";
        string InsurancePriceEnd = "";
        string Sender = "";
        string AssistanceTypeCompany = "";
        string InsuranceChange = "";
        string FirstPartOfMail = "";
        string SecondPartOfMail = "";
        string ThirdPartOfMail = "";
        string FourthPartOfMail = "";
        string FourthAndHalfPartOFMail = "";
        string FifthPartOfMail = "";
        string SixthPartOfMail = "";
        string SeventhPartOfMail = "";
        string EightPartOfMail = "";
        string AtHomeLimitation = "";
        string KmLimitation = "";
        string BorderRangePl = "";
        int id = 0;

        #region Navigation buttons - close, minimize

        //Button with X, for window close
        private void CloseWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //Button with _, for window minimize
        private void MinimizeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        //Move / drag / float window at taskbar mouse clicking
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch (Exception ex)
            {
                ;
            }
        }

        #endregion

        #region MainWindow, initialized lists and clear method


        public MainWindow()
        {
            InitializeComponent();

            rtb.Document.Blocks.Clear(); //clear richbox window before starts generate any text

            //Recipient ComboBox list - [WITAM - welcome, PAN - mr, PANI, mrs, PAŃSTWO - madam/sir]
            List<ListFields.ChoseOption> RecipientType = new List<ListFields.ChoseOption>();
            RecipientType.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            RecipientType.Add(new ListFields.ChoseOption() { First = "Witam", Second = "Witam," });
            RecipientType.Add(new ListFields.ChoseOption() { First = "Pan", Second = "Szanowny Panie," });
            RecipientType.Add(new ListFields.ChoseOption() { First = "Pani", Second = "Szanowna Pani," });
            RecipientType.Add(new ListFields.ChoseOption() { First = "Państwo", Second = "Szanowni Państwo," });
            AdreserType.ItemsSource = RecipientType;
            AdreserType.DisplayMemberPath = "First";
            AdreserType.SelectedIndex = 0;

            //OC ComboBox list
            List<ListFields.ChoseOption> DiscountProtectOC = new List<ListFields.ChoseOption>();
            DiscountProtectOC.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            DiscountProtectOC.Add(new ListFields.ChoseOption() { First = "TAK", Second = "-ochrona zniżki po jednej szkodzie wprowadzona" });
            DiscountProtectOC.Add(new ListFields.ChoseOption() { First = "NIE", Second = "-brak ochrony zniżki po jednej szkodzie" });
            OcComboBox.ItemsSource = DiscountProtectOC;
            OcComboBox.DisplayMemberPath = "First";
            OcComboBox.SelectedIndex = 0;

            //########################## AC LISTS ###########################

            //AC ComboBoxList - Car price with tax and w/o tax [BRUTTO - with tax, NETTO - w/o tax]
            List<ListFields.ChoseOption> GrossNet = new List<ListFields.ChoseOption>();
            GrossNet.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            GrossNet.Add(new ListFields.ChoseOption() { First = "Brutto", Second = " BRUTTO" });
            GrossNet.Add(new ListFields.ChoseOption() { First = "Netto", Second = " NETTO" });
            GrNet.ItemsSource = GrossNet;
            GrNet.DisplayMemberPath = "First";
            GrNet.SelectedIndex = 0;

            //AC ComboBoxList - Own Contribution if yes is introduced, if no is abolished [WPROWADZONY - yes, ZNIESIONY - no]
            List<ListFields.ChoseOption> OwnContribution = new List<ListFields.ChoseOption>();
            OwnContribution.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            OwnContribution.Add(new ListFields.ChoseOption() { First = "Wprowadzony", Second = "-udział własny wprowadzony" });
            OwnContribution.Add(new ListFields.ChoseOption() { First = "Zniesiony", Second = "-udział własny zniesiony" });
            OwnCont.ItemsSource = OwnContribution;
            OwnCont.DisplayMemberPath = "First";
            OwnCont.SelectedIndex = 0;

            //AC ComboBoxList - DiscountProtectAC it yes discount protect is on, if no is off [TAK - yes, NIE - no]
            List<ListFields.ChoseOption> DiscountProtectAC = new List<ListFields.ChoseOption>();
            DiscountProtectAC.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            DiscountProtectAC.Add(new ListFields.ChoseOption() { First = "Tak", Second = "-ochrona zniżki po jednej szkodzie wprowadzona" });
            DiscountProtectAC.Add(new ListFields.ChoseOption() { First = "Nie", Second = "-brak ochrony zniżki po jednej szkodzie" });
            AcDisc.ItemsSource = DiscountProtectAC;
            AcDisc.DisplayMemberPath = "First";
            AcDisc.SelectedIndex = 0;

            //AC ComboBoxList - ValuationType of insurance(repair by service or noservice) [SERWISOWY - service, KOSZTORYSOWY - estimate/noservice]
            List<ListFields.ChoseOption> ValuationType = new List<ListFields.ChoseOption>();
            ValuationType.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            ValuationType.Add(new ListFields.ChoseOption() { First = "Serwisowy", Second = "-naprawa na podstawie faktury w ASO przy użyciu części nowych, oryginalnych" });
            ValuationType.Add(new ListFields.ChoseOption() { First = "Kosztorysowy", Second = "-naprawa na podstawie wyceny rzeczoznawcy i częściach zamiennych" });
            ValType.ItemsSource = ValuationType;
            ValType.DisplayMemberPath = "First";
            ValType.SelectedIndex = 0;

            //AC ComboBoxList - if insurance change value is introduced than sum of insurance doesen't decreases relative to the initial value of insurance value
            //if it's abolished than it's decreases, and if at start sum of insurance of car was 30k, after car crash it will be reduced by paid compensation.
            //[WPROWADZONA - introduced, ZNIESIONA - abolished]
            List<ListFields.ChoseOption> InsuranceChangeValue = new List<ListFields.ChoseOption>();
            InsuranceChangeValue.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            InsuranceChangeValue.Add(new ListFields.ChoseOption() { First = "Wprowadzona", Second = "-niepomniejszanie sumy ubezpieczenia po szkodzie" });
            InsuranceChangeValue.Add(new ListFields.ChoseOption() { First = "Zniesiona", Second = "-pomniejszanie sumy ubezpieczenia po każdej zaistniałej szkodzie" });
            ConstInsuranceValue.ItemsSource = InsuranceChangeValue;
            ConstInsuranceValue.DisplayMemberPath = "First";
            ConstInsuranceValue.SelectedIndex = 0;

            //########################## END OF AC LISTS ###########################

            //NNW ComboBoxList - values options in nnw insurance
            List<ListFields.ChoseOption> NnwType = new List<ListFields.ChoseOption>();
            NnwType.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            NnwType.Add(new ListFields.ChoseOption() { First = "5 000,- PLN", Second = "5 000,- PLN" });
            NnwType.Add(new ListFields.ChoseOption() { First = "10 000,- PLN", Second = "10 000,- PLN" });
            NnwType.Add(new ListFields.ChoseOption() { First = "15 000,- PLN", Second = "15 000,- PLN" });
            NnwType.Add(new ListFields.ChoseOption() { First = "20 000,- PLN", Second = "20 000,- PLN" });
            NnwPrice.ItemsSource = NnwType;
            NnwPrice.DisplayMemberPath = "First";
            NnwPrice.SelectedIndex = 0;

            //Glass ComboBoxList - values option in glass insurance
            List<ListFields.ChoseOption> CarGlasses = new List<ListFields.ChoseOption>();
            CarGlasses.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            CarGlasses.Add(new ListFields.ChoseOption() { First = "1 000,- PLN", Second = "1000,- PLN" });
            CarGlasses.Add(new ListFields.ChoseOption() { First = "2 000,- PLN", Second = "2000,- PLN" });
            CarGlasses.Add(new ListFields.ChoseOption() { First = "3 000,- PLN", Second = "3000,- PLN" });
            CarGlasses.Add(new ListFields.ChoseOption() { First = "4 000,- PLN", Second = "4000,- PLN" });
            CarGlasses.Add(new ListFields.ChoseOption() { First = "5 000,- PLN", Second = "5000,- PLN" });
            GlassPrice.ItemsSource = CarGlasses;
            GlassPrice.DisplayMemberPath = "First";
            GlassPrice.SelectedIndex = 0;

            //Name ComboBoxLit - name and surname signs
            List<ListFields.ChoseOption> NameList = new List<ListFields.ChoseOption>();
            NameList.Add(new ListFields.ChoseOption() { First = "Wybierz", Second = "" });
            NameList.Add(new ListFields.ChoseOption() { First = "Piotr Urbański", Second = "Piotr Urbański" });
            NameList.Add(new ListFields.ChoseOption() { First = "Radosław Biegaj", Second = "Radosław Biegaj" });
            NameList.Add(new ListFields.ChoseOption() { First = "Kamil Bartoń", Second = "Kamil Bartoń" });
            NameList.Add(new ListFields.ChoseOption() { First = "Michał Mrowiński", Second = "Michał Mrowiński" });
            NameList.Add(new ListFields.ChoseOption() { First = "Bartosz Kołakowski", Second = "Bartosz Kołakowski" });
            SenderName.ItemsSource = NameList;
            SenderName.DisplayMemberPath = "First";
            SenderName.SelectedIndex = 0;

        }
        #endregion

        #region Left menu buttons
        //Buttons which changing assistance types in combobox with assistance plus it's changing insurance company name in richbox
        private void Button_PZU(object sender, RoutedEventArgs e)
        {
            //PZU Assistance LIST
            List<ListFields.ChoseOption> PzuAssistance = new List<ListFields.ChoseOption>();
            PzuAssistance.Add(new ListFields.ChoseOption() { First = "PZU", Second = "" });
            PzuAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Komfort",
                Second = "-holowanie pojazdu w razie wypadku do 150km w kraju\r"

            });
            PzuAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Super",
                Second = "-holowanie pojazdu w razie wypadku/awarii do 150km w kraju\r"
                       + "-pojazd zastępczy w razie:\r"
                       + ">>wypadku na czas naprawy do 10 dni\r"
                       + ">>kradzieży do czasu jesgo odzyskania do 10 dni\r"

            });
            AssistanceType.ItemsSource = PzuAssistance;
            AssistanceType.DisplayMemberPath = "First";
            AssistanceType.SelectedIndex = 0;

            InsuranceCompany = "PZU S.A.\r";
            SecondPartOfMail = " \rPrzygotowana w: ";

        }
        private void Button_WARTA(object sender, RoutedEventArgs e)
        {
            //WARTA Assistance LIST
            List<ListFields.ChoseOption> WartaAssistance = new List<ListFields.ChoseOption>();
            WartaAssistance.Add(new ListFields.ChoseOption() { First = "WARTA", Second = "" });
            WartaAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Standard",
                Second = "-holowanie w razie wypadku (kraj/zagranica) do 100km\n"

            });
            WartaAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Złoty",
                Second = "-holowanie w razie wypadku/awarii (kraj/zagranica) do 200km\r"
                       + "-pojazd zastępczy po wypadku/kradzieży do 5 dni\r"
                       + "-wprowadzona franszyza kilometrowa - holowanie od 25km\r"
                       + "-suma ubezpieczenia do 10 000,- PLN"
            });
            WartaAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Złoty+",
                Second = "-holowanie w razie wypadku/awarii (kraj/zagranica) do 400km\r"
                       + "-pojazd zastępczy po wypadku/kradzieży do 10 dni\r"
                       + "-pojazd zastępczy po awarii do 5 dni\r"
                       + "-franszyza kilometrowa zniesiona - holowanie spod domu\r"
                       + "-suma ubezpieczenia do 20 000,- PLN"
            });
            WartaAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Platynowy",
                Second = "-holowanie w razie wypadku/awarii (kraj bez limitu / zagranica 1200km)\r"
                       + "-pojazd zastępczy przy naprawie w ASO do 30 dni\r"
                       + "-pojazd zastępczy w innych przypadkach niż naprawa w ASO do 15 dni\r"
                       + "-pojazd zastępczy po kradzieży do 15 dni\r"
                       + "-pojazd zastępczy po wypadku/kradzieży do 10 dni\r"
                       + "-zakwaterowanie do 5 osób\r"
                       + "-franszyza kilometrowa zniesiona - holowanie spod domu\r"
                       + "-suma ubezpieczenia do 50 000,- PLN"
            });
            AssistanceType.ItemsSource = WartaAssistance;
            AssistanceType.DisplayMemberPath = "First";
            AssistanceType.SelectedIndex = 0;

            InsuranceCompany = "TUiR WARTA S.A.\r";
            SecondPartOfMail = " \rPrzygotowana w: ";

        }
        private void Button_HDI(object sender, RoutedEventArgs e)
        {
            //HDI Assistance LIST
            List<ListFields.ChoseOption> HdiAssistance = new List<ListFields.ChoseOption>();
            HdiAssistance.Add(new ListFields.ChoseOption() { First = "HDI", Second = "" });
            HdiAssistance.Add(new ListFields.ChoseOption() { First = "Standard", Second = "-holowanie w razie wypadku (kraj/zagranica) do 100km" });
            HdiAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Złoty",
                Second = "-holowanie w razie wypadku/awarii (kraj/zagranica) do 200km\r"
                       + "-pojazd zastępczy po wypadku/kradzieży do 5 dni\r"
                       + "-wprowadzona franszyza kilometrowa - holowanie od 25km\r"
                       + "-suma ubezpieczenia do 10 000,- PLN"
            });
            HdiAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Złoty+",
                Second = "-holowanie w razie wypadku/awarii (kraj/zagranica) do 400km\r"
                       + "-pojazd zastępczy po wypadku/kradzieży do 10 dni\r"
                       + "-pojazd zastępczy po awarii do 5 dni\n"
                       + "-franszyza kilometrowa zniesiona - holowanie spod domu\r"
                       + "-suma ubezpieczenia do 20 000,- PLN"
            });
            AssistanceType.ItemsSource = HdiAssistance;
            AssistanceType.DisplayMemberPath = "First";
            AssistanceType.SelectedIndex = 0;

            InsuranceCompany = "HDI S.A.\r";
            SecondPartOfMail = " \rPrzygotowana w: ";
        }
        private void Button_HESTIA(object sender, RoutedEventArgs e)
        {
            //HESTIA Assistance LIST
            List<ListFields.ChoseOption> HestiaAssistance = new List<ListFields.ChoseOption>();
            HestiaAssistance.Add(new ListFields.ChoseOption() { First = "HESTIA", Second = "" });
            HestiaAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Mini",
                Second = "-holowanie w razie wypadku (kraj) do 100km\r"
                       + "-suma ubezpieczenia do 5 000,- PLN"
            });
            HestiaAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Standard",
                Second = "-holowanie w razie wypadku/awarii (kraj/zagranica) do 150km\r"
                       + "-transport przyczepy do 150km w kraju\r"
                       + "-pojazd zastępczy segment B po kradzieży do 2 dni\r"
                       + "-suma ubezpieczenia do 15 000,- PLN"
            });
            HestiaAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Premium",
                Second = "-holowanie w razie wypadku/awarii(kraj/zagranica) do 250km\r"
                       + "-transport przyczepy do 250km w kraju\r"
                       + "-pojazd zastępczy segment B kradzież/wypadek do 5 dni\r"
                       + "-zakwaterowanie do 2 dni\r"
                       + "-suma ubezpieczenia do 15 000,- PLN"
            });
            HestiaAssistance.Add(new ListFields.ChoseOption()
            {
                First = "Prestiż",
                Second = "-holowanie w razie wypadku/awarii(kraj bez limitu / zagranica do 500km)\r"
                       + "-transport przyczepy w kraju bez limitu / zagranica do 500km\r"
                       + "-pojazd zastępczy segment C dla poj. D i D dla poj. D+\r"
                       + "-pojazd zastępczy po wypadku do 10 dni\r"
                       + "-pojazd zastępczy po kradzieży do 15 dni\r"
                       + "-pojazd zastępczy po awarii do 5 dni\r"
                       + "-zakwaterowanie do 3 dni\n" + "-suma ubezpieczenia do 15 000,-PLN"
            });

            AssistanceType.ItemsSource = HestiaAssistance;
            AssistanceType.DisplayMemberPath = "First";
            AssistanceType.SelectedIndex = 0;

            InsuranceCompany = "ERGO HESTIA S.A.\r";
            SecondPartOfMail = " \rPrzygotowana w: ";
        }


        #endregion


        #region Mail generator

        //Button which generates all elements and shows them as ToString in rtb richbox ;
        private void Button_Mail_Generator(object sender, EventArgs e)
        {
            //######################## LISTS INSTANCES ###############################################

            //TextBoxes Lists
            ListFields.ChoseOption NameList = SenderName.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption ValuationType = ValType.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption InsuranceChangeValue = ConstInsuranceValue.SelectedItem as ListFields.ChoseOption;

            //Comboboxes Lists
            ListFields.ChoseOption CarGlasses = GlassPrice.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption RecipientType1 = AdreserType.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption DiscountProtectOC = OcComboBox.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption GrossNet = GrNet.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption OwnContribution = OwnCont.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption DiscountProtectAC = AcDisc.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption NnwType = NnwPrice.SelectedItem as ListFields.ChoseOption;

            //Assistance Lists
            ListFields.ChoseOption PzuAssistance = AssistanceType.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption WartaAssistance = AssistanceType.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption HdiAssistance = AssistanceType.SelectedItem as ListFields.ChoseOption;
            ListFields.ChoseOption HestiaAssistance = AssistanceType.SelectedItem as ListFields.ChoseOption;

            //Condition checking richbox is clear, if clear than generate text in richbox, if not clear than cant generate text in richbox
            if (rtb.Document.Blocks.Count == 0)
            {
               

                if (AdreserType.SelectedIndex != 0 && Type.Text != "" || Brand.Text != "")
                {
                    
                    FirstPartOfMail = "\nOferta Ubezpieczenia dla pojazdu:  ";
                    Recpient = RecipientType1.Second;
                    CarBrand = Brand.Text + " ";
                    CarType = Type.Text;
                }

                if (OcCheckBox.IsChecked == true && OcComboBox.SelectedIndex >= 0)
                {
                    id++;
                    ThirdPartOfMail = "\r" + id + ") Ubezpieczenie OC pojazdu\r";
                    DiscountOC = DiscountProtectOC.Second + "\r";
                }

                if (AcCheckBox.IsChecked == true)
                {
                    id++;
                    FourthPartOfMail = id + ") Ubezpieczenie AC\r";
                }

                if (CarPrice.Text != "" || GrNet.SelectedIndex > 0)
                {
                    FourthAndHalfPartOFMail = "\rSuma ubezpieczenenia pojazdu: ";
                    CarPriceAC = CarPrice.Text + ",- PLN";
                    GrossNetAC = GrossNet.Second + "\n";
                }

                if (OwnCont.SelectedIndex > 0)
                {
                    OwnContributionAC = OwnContribution.Second + "\r";
                }

                if (AcDisc.SelectedIndex > 0)
                {
                    DiscountAC = DiscountProtectAC.Second + "\r";
                }

                if (ValType.SelectedIndex > 0)
                {
                    ValuationTypeAC = ValuationType.Second + "\r";
                }

                if (ConstInsuranceValue.SelectedIndex > 0)
                {
                    InsuranceChange = InsuranceChangeValue.Second + "\r";
                }
            

                if (NnwCheckBox.IsChecked == true || NnwPrice.SelectedIndex > 0)
                {
                    id++;
                    FifthPartOfMail = id + ") Ubezpieczenie NNW ";
                    NnwTypes = NnwType.Second + "\r";
                }

                //Assistance checkbox and types of assistance by left menu button click [CONDITIONS]

                if (AssCheckBox.IsChecked == true && AssistanceType.SelectedIndex > 0)
                {
                    id++;
                    SixthPartOfMail = id + ") Ubezpieczenie Assistance w wariancie: ";

                    if (PzuButton.IsPressed == false)
                    {
                        AssistanceRange = PzuAssistance.Second;
                        AssistanceTypeCompany = PzuAssistance.First.ToUpper() + "\r";
                    }
                    else if (WartaButton.IsPressed == false)
                    {
                        AssistanceRange = WartaAssistance.Second;
                        AssistanceTypeCompany = WartaAssistance.First.ToUpper() + "\r";
                    }
                    else if (HdiButton.IsPressed == false)
                    {
                        AssistanceRange = HdiAssistance.Second;
                        AssistanceTypeCompany = HdiAssistance.First.ToUpper() + "\r";
                    }
                    else if (HestiaButton.IsPressed == false)
                    {
                        AssistanceRange = HestiaAssistance.Second;
                        AssistanceTypeCompany = HestiaAssistance.First.ToUpper() + "\r";
                    }
                }

                if (GlassCheckBox.IsChecked == true && GlassPrice.SelectedIndex > 0)
                {
                    id++;
                    SeventhPartOfMail = id + ") Ubezpieczenie Szyb niezależnie od AC na sumę do: ";
                    CarGlass = CarGlasses.Second + "\r";
                }

                if (InsurancePrice.Text != "")
                {
                    InsurancePriceEnd = "\n\rSkładka: " + InsurancePrice.Text + ",- PLN ";
                }

                if (SenderName.SelectedIndex > 0)
                {
                    EightPartOfMail = "\n\rPozdrawiam,\r";
                    Sender = NameList.Second;
                }
                //Additional assistance option for assistance Super PZU [CONDIDTIONS]
                if (AtHomeLimit.IsChecked == true)
                {
                    AtHomeLimitation = "-zniesienie franszyzy 25km, tj. assistance działa spod domu\r";
                }

                if (KmLimit.IsChecked == true)
                {
                    KmLimitation = "-rozszerzenie limitu holowania do 1000km w PL i 200km za granicą\r";
                }

                if (BorderRange.IsChecked == true)
                {
                    BorderRangePl = "-rozszerzenie zakresu terytorialnego PL + EU\r";
                }

                rtb.AppendText(ToString());
            }
        }

        //ToString Mail generator, where all generated texts are laid into formated text .
        public override string ToString()
        {
            return Recpient.ToString() + FirstPartOfMail.ToString() + CarBrand.ToUpper() + CarType.ToUpper() + SecondPartOfMail.ToString()
            + InsuranceCompany.ToString() + FourthAndHalfPartOFMail.ToString() + CarPriceAC.ToString() + GrossNetAC.ToString()
            + ThirdPartOfMail.ToString() + DiscountOC.ToString() + FourthPartOfMail.ToString() + OwnContributionAC.ToString()
            + DiscountAC.ToString() + ValuationTypeAC.ToString() + InsuranceChange.ToString() + FifthPartOfMail.ToString()
            + NnwTypes.ToString() + SixthPartOfMail.ToString() + AssistanceTypeCompany.ToString() + AssistanceRange.ToString()
            + AtHomeLimitation.ToString() + KmLimitation.ToString() + BorderRangePl.ToString() + SeventhPartOfMail.ToString()
            + CarGlass.ToString() + InsurancePriceEnd.ToString() + EightPartOfMail.ToString() + Sender.ToString();
        }

        //Clear All items, comboboxes, checkboxes etc...
        private void ClearListButton_Click(object sender, RoutedEventArgs e)
        {

            rtb.Document.Blocks.Clear();
            CarPrice.Clear();
            InsurancePrice.Clear();
            Brand.Clear();
            Type.Clear();
            SenderName.SelectedIndex = 0;
            AssistanceType.SelectedIndex = 0;
            AdreserType.SelectedIndex = 0;
            GlassPrice.SelectedIndex = 0;
            NnwPrice.SelectedIndex = 0;
            ValType.SelectedIndex = 0;
            AcDisc.SelectedIndex = 0;
            OwnCont.SelectedIndex = 0;
            GrNet.SelectedIndex = 0;
            OcComboBox.SelectedIndex = 0;
            ConstInsuranceValue.SelectedIndex = 0;
            OcCheckBox.IsChecked = false;
            AcCheckBox.IsChecked = false;
            NnwCheckBox.IsChecked = false;
            GlassCheckBox.IsChecked = false;
            AssCheckBox.IsChecked = false;
            AtHomeLimit.IsChecked = false;
            KmLimit.IsChecked = false;
            BorderRange.IsChecked = false;
            InsuranceCompany = "";
            Recpient = "";
            CarBrand = "";
            CarType = "";
            DiscountOC = "";
            CarPriceAC = "";
            GrossNetAC = "";
            OwnContributionAC = "";
            DiscountAC = "";
            ValuationTypeAC = "";
            NnwTypes = "";
            AssistanceRange = "";
            CarGlass = "";
            InsurancePriceEnd = "";
            Sender = "";
            AssistanceTypeCompany = "";
            InsuranceChange = "";
            FirstPartOfMail = "";
            SecondPartOfMail = "";
            ThirdPartOfMail = "";
            FourthPartOfMail = "";
            FourthAndHalfPartOFMail = "";
            FifthPartOfMail = "";
            SixthPartOfMail = "";
            SeventhPartOfMail = "";
            EightPartOfMail = "";
            AtHomeLimitation = "";
            KmLimitation = "";
            BorderRangePl = "";
            id = 0;
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rtb.Focus();
            rtb.SelectAll();
            rtb.Copy();
        }

       
    }


}



