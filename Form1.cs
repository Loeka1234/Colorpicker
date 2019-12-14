//Loeka Lievens
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace colors
{
    public partial class Form1 : Form
    {
        //Voor het bewegen van de custom form
        private bool mouseDown;
        private Point lastLocation;


        public Form1()
        {
            InitializeComponent();
            lblred.Text = "0";
            lblgreen.Text = "0";
            lblblue.Text = "0";
            pbcolor.BackColor = Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value);
            lbldoescolorexist.Text = "";

            txthex.Text = ColorTranslator.ToHtml(Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value)); //HEX code


            pbcolor2.Visible = false;
            btnswap.Visible = false;
            lblprimarycolor1.Visible = false;
            lblprimarycolor2.Visible = false;

        }


        private void Tbred_Scroll(object sender, EventArgs e)
        {
            lblred.Text = tbred.Value.ToString();
            pbcolor.BackColor = Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value);
            txtcolor.Text = null;
            txthex.Text = ColorTranslator.ToHtml(Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value)); //HEX code
        }

        private void Tbgreen_Scroll(object sender, EventArgs e)
        {
            lblgreen.Text = tbgreen.Value.ToString();
            pbcolor.BackColor = Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value);
            txtcolor.Text = null;
            txthex.Text = ColorTranslator.ToHtml(Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value)); //HEX code
        }

        private void Tbblue_Scroll(object sender, EventArgs e)
        {
            lblblue.Text = tbblue.Value.ToString();
            pbcolor.BackColor = Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value);
            txtcolor.Text = null;
            txthex.Text = ColorTranslator.ToHtml(Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value)); //HEX code
        }

        private void Txtcolor_TextChanged(object sender, EventArgs e)
        {
            //Checken of dit kleur bestaat
            Color c = Color.FromName(txtcolor.Text);
            if(c.IsKnownColor)
            {
                lbldoescolorexist.Text = null;

                //RGB waarden weergeven
                string red = c.R.ToString();
                string green = c.G.ToString();
                string blue = c.B.ToString();
                tbred.Value = int.Parse(red);
                tbgreen.Value = int.Parse(green);
                tbblue.Value = int.Parse(blue);

                lblred.Text = red;
                lblgreen.Text = green;
                lblblue.Text = blue;

                pbcolor.BackColor = c;

    
                txthex.Text = ColorTranslator.ToHtml(Color.FromArgb(int.Parse(red), int.Parse(green), int.Parse(blue))); //HEX code
            }
            else if(txtcolor.Text == "")
            {
                lbldoescolorexist.Text = null;
            }else
            {
                lbldoescolorexist.Text = "This is not a color";
            }
            

            
        }
        private void Txthex_TextChanged(object sender, EventArgs e)
        {   
            if(txthex.Text.Length == 0 || txthex.Text[0].ToString() != "#") 
            {
                txthex.Text = "#";

                //Laat je niet voor de # typen
                txthex.SelectionStart = txthex.Text.Length;
                txthex.SelectionLength = 0;
            }
            //Van de leerkracht :p
            try {
                Color c = System.Drawing.ColorTranslator.FromHtml(txthex.Text);
                lblred.Text = c.R.ToString();
                tbred.Value = c.R;
                lblgreen.Text = c.G.ToString();
                tbgreen.Value = c.G;
                lblblue.Text = c.B.ToString();
                tbblue.Value = c.B;
                pbcolor.BackColor = c;
                lbldoeshexexist.Text = "";
            }
            catch(Exception)
            {
                lbldoeshexexist.Text = "Not a valid hex";
            }
            //#ff bijv. geeft blijkbaar geen error ook al is dit geen hex color code
            if(txthex.Text.Length != 7)
            {
                lbldoeshexexist.Text = "Not a valid hex";
            }

        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            txtcolor.Text = "";
            lbldoescolorexist.Text = null;
            tbred.Value = 0;
            tbgreen.Value = 0;
            tbblue.Value = 0;
            lblred.Text = "0";
            lblgreen.Text = "0";
            lblblue.Text = "0";
            pbcolor.BackColor = Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value);
            txthex.Text = ColorTranslator.ToHtml(Color.FromArgb(tbred.Value, tbgreen.Value, tbblue.Value)); //HEX code
        }

        private void Btncopy_Click(object sender, EventArgs e) //copy rgb code
        {
            Clipboard.SetText("rgb(" + lblred.Text + ", " + lblgreen.Text + ", " + lblblue.Text + ")");
        }
        private void Btncopyhex_Click(object sender, EventArgs e) //copy HEX code
        {
            Clipboard.SetText(txthex.Text);
        }

        private void Btncolorpicker_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            pbcolor.BackColor = c;

            string red = c.R.ToString();
            string green = c.G.ToString();
            string blue = c.B.ToString();
            tbred.Value = int.Parse(red);
            tbgreen.Value = int.Parse(green);
            tbblue.Value = int.Parse(blue);

            lblred.Text = red;
            lblgreen.Text = green;
            lblblue.Text = blue;

            txthex.Text = ColorTranslator.ToHtml(Color.FromArgb(int.Parse(red), int.Parse(green), int.Parse(blue))); //HEX code
        }
        //close form als je op kruisje klikt
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Minimize form
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        //Hieronder (niet mijn code) laat de custom form bewegen!
        private void move_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void move_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void move_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        private void Cb2colors_CheckedChanged(object sender, EventArgs e) //Laat kleurenvergelijker weergeven
        {
            if (cb2colors.Checked)
            {

                pbcolor2.BackColor = Color.Red;
                pbcolor2.Visible = true;
                pbcolor2.Location = new Point(454, 85);

                pbcolor.Size = new Size(75, 75);
                pbcolor.Location = new Point(379, 85);

                btnswap.Visible = true;

                lblprimarycolor1.Visible = true;
                lblprimarycolor2.Visible = true;
            } else
            {
                pbcolor2.Visible = false;

                pbcolor.Size = new Size(166, 150);
                pbcolor.Location = new Point(363, 49);

                btnswap.Visible = false;

                lblprimarycolor1.Visible = false;
                lblprimarycolor2.Visible = false;
            }
        }

        private void Btnswap_Click(object sender, EventArgs e) //Swap kleuren in kleurenvergelijker
        {
            Color color1 = pbcolor.BackColor;
            Color color2 = pbcolor2.BackColor;
            pbcolor.BackColor = color2;
            pbcolor2.BackColor = color1;
        }


    }
}
