using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeric_pro
{
    public partial class Numeric_pro :NumericUpDown
    {
        public Numeric_pro()
        {
            InitializeComponent();
        }
        string n;


        public Color colFColor;
        public Color colBColor;

        public Color ClockBackColor
        {
            // Retrieves the value of the private variable colBColor.  
            get
            {
                return colBColor;
            }
            // Stores the selected value in the private variable colBColor, and   
            // updates the background color of the label control lblDisplay.  
            set
            {
                colBColor = value;

            }
        }

        public Color ClockForeColor
        {
            get
            {
                return colFColor;
            }
            set
            {
                colFColor = value;

            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
                return;
            }


            n = this.Value.ToString();
            int i = n.CompareTo(n);
            string j = "";
            if (e.KeyCode == Keys.Back && i == -1)
            {


            }
            else if (e.KeyCode == Keys.Back && i == 0)
            {

                j = string.Copy(n);
            }
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (this.Value != 0)
            {
                n = this.Value.ToString();
                ToolTip t = new ToolTip();
                t.SetToolTip(this, "تاریخ رو خالی نگذارید");
                this.ResetText();
                this.ForeColor = colFColor;

                this.BackColor = colBColor;
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (n == this.Value.ToString())
            {
                this.Focus();
            }
        }
    }
}
