using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSlider {
    public partial class Form1 : Form {

        public Form1()  {
            InitializeComponent();
        }//end constructor

        private void scroll_changed(object sender, ScrollEventArgs e) {
            //CTREATE COLOR FROM SCROLLBAR VALUES
                Color col_new = Color.FromArgb(hsbAlp.Value,hsbRed.Value,hsbGrn.Value,hsbBlu.Value);
                int  int_color = color_to_int(col_new);

            //UPDATE PICTUREBOX
                picSwatch.BackColor = col_new;

            //UPDATE COMPONENT LABELS
                lblAlp.Text = hsbAlp.Value.ToString().PadLeft(3,'0');
                lblRed.Text = hsbRed.Value.ToString().PadLeft(3,'0');
                lblGrn.Text = hsbGrn.Value.ToString().PadLeft(3,'0');
                lblBlu.Text = hsbBlu.Value.ToString().PadLeft(3,'0');

            //UPDATE INT LABEL
                string integer_string = "INT = ";
                integer_string += Convert.ToString((uint)int_color).PadLeft(10,'0');
                lblInt.Text = integer_string;

            //UPDATE HEX LABEL
                string hexadecimal_string = "HEX = ";
                hexadecimal_string += Convert.ToString(int_color,16).PadLeft(8,'0');
                lblHex.Text = hexadecimal_string;

            //UPDATE BINARY LABEL
                string binary_string = "BIN = ";
                binary_string += Convert.ToString(int_color,2).PadLeft(24,'0');
                lblBin.Text = binary_string;
        }//end method

        private int color_to_int(Color col_temp) {
            int colorval = (col_temp.A << 24) | (col_temp.R << 16) |  (col_temp.G << 8)  | (col_temp.B << 0);
            return colorval;
        }//end method


    }//end class
}//end namespace
