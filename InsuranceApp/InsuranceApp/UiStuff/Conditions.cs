using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.UiStuff
{
   class AdreserCondition : MainWindow
    {
        ListFields.ChoseOption RecipientType1 = AdreserType.SelectedItem as ListFields.ChoseOption;

        SecondPartOfMail = " \rPrzygotowana w: ";

                if (AdreserType.SelectedIndex != 0 && Type.Text != "")
                {
                   
                    FirstPartOfMail = "\nOferta Ubezpieczenia dla pojazdu:  ";
                    Recpient = RecipientType1.Second;
                   
                }
                else
                {
                    Recpient = "";
                    FirstPartOfMail = "";
                }
    }
}
