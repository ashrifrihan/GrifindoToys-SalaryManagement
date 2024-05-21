using System.Windows.Forms;

namespace Project_Grifindo_Toys.Class
{
    public class ValidateCombo
    {
        public TextBox myInputTextBox { get; set; }
        
        public Label myValidationText { get; set; }

        public ValidateCombo(TextBox _myInputBox, Label _myvalidationText) 
        {
            myInputTextBox = myInputTextBox;
            myValidationText = myValidationText;
        }
    }
}