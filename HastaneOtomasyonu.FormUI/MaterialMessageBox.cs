using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.FormUI
{
    public static class MaterialMessageBox
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons buttons)
        {
            DialogResult result = DialogResult.None;
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    break;
                case MessageBoxButtons.OKCancel:
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    break;
                case MessageBoxButtons.YesNoCancel:
                    break;
                case MessageBoxButtons.YesNo:
                    using (frmYesNo yesNo = new frmYesNo())
                    {
                        yesNo.Text = caption;
                        yesNo.Message = message;
                        result = yesNo.ShowDialog();
                    }
                    break;
                case MessageBoxButtons.RetryCancel:
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
