using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGestaoAcademia
{
    public class Calendario : DateTimePicker
    {
        public Calendario()
        {
            this.CustomFormat = " ";
            this.Format = DateTimePickerFormat.Custom;
            this.ShowCheckBox = true;
            this.Checked = false;
            this.Width = 112;
        }
        protected override void OnValueChanged(EventArgs eventargs)
        {
            if (this.Checked)
            {
                //this.CalendarForeColor = Color.Black;
                this.CustomFormat = null;
            }
            else
            {
                //this.CalendarForeColor = Color.White;
                this.CustomFormat = " ";
            }
        }
    }
}
