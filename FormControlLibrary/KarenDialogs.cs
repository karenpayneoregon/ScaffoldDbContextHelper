using System.Windows.Forms;

namespace FormControlLibrary
{
    public static class KarenDialogs
    {
        public static bool Question(string pText)
        {
            return (MessageBox.Show(
                        pText, 
                        "Question", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question, 
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}
