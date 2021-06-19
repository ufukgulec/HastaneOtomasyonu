using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Business
{
    public class ComboBoxItem
    {
        private string display;
        private int value;

        public ComboBoxItem(string display, int value)
        {
            this.display = display;
            this.value = value;
        }
        public string Display
        {
            set { display = value; }
            get { return display; }
        }

        public int Value
        {
            set { this.value = value; }
            get { return value; }
        }

    }
}
