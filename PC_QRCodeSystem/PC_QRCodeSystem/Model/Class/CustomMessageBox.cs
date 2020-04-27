using System.Windows.Forms;
using System;

namespace PC_QRCodeSystem.Model
{
    public static class CustomMessageBox
    {
        public static void Notice(string message)
        {
            MessageBox.Show(message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string message)
        {
            if (message.Contains(":"))
            {
                string[] errorMes = message.Split(':');
                string mes = string.Empty;
                switch(errorMes[0])
                {
                    case "23503":
                        mes = "Can't update or delete this item because it is used in another table.";
                        break;
                    default:
                        mes = errorMes[1];
                        break;
                }
                MessageBox.Show(mes, "Error - " + errorMes[0], MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Warring(string message)
        {
            return MessageBox.Show(message, "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static DialogResult Question(string message)
        {
            return MessageBox.Show(message, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
