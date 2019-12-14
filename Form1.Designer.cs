namespace colors
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbred = new System.Windows.Forms.TrackBar();
            this.tbgreen = new System.Windows.Forms.TrackBar();
            this.tbblue = new System.Windows.Forms.TrackBar();
            this.lblred = new System.Windows.Forms.Label();
            this.lblgreen = new System.Windows.Forms.Label();
            this.lblblue = new System.Windows.Forms.Label();
            this.pbcolor = new System.Windows.Forms.PictureBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.lbldoescolorexist = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncopy = new System.Windows.Forms.Button();
            this.btncolorpicker = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncopyhex = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.lblprimarycolor2 = new System.Windows.Forms.Label();
            this.lblprimarycolor1 = new System.Windows.Forms.Label();
            this.btnswap = new System.Windows.Forms.Button();
            this.cb2colors = new System.Windows.Forms.CheckBox();
            this.pbcolor2 = new System.Windows.Forms.PictureBox();
            this.lbldoeshexexist = new System.Windows.Forms.Label();
            this.txthex = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbgreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcolor)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcolor2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbred
            // 
            this.tbred.Location = new System.Drawing.Point(54, 52);
            this.tbred.Maximum = 255;
            this.tbred.Name = "tbred";
            this.tbred.Size = new System.Drawing.Size(225, 45);
            this.tbred.TabIndex = 0;
            this.tbred.Scroll += new System.EventHandler(this.Tbred_Scroll);
            // 
            // tbgreen
            // 
            this.tbgreen.Location = new System.Drawing.Point(54, 103);
            this.tbgreen.Maximum = 255;
            this.tbgreen.Name = "tbgreen";
            this.tbgreen.Size = new System.Drawing.Size(225, 45);
            this.tbgreen.TabIndex = 1;
            this.tbgreen.Scroll += new System.EventHandler(this.Tbgreen_Scroll);
            // 
            // tbblue
            // 
            this.tbblue.Location = new System.Drawing.Point(54, 154);
            this.tbblue.Maximum = 255;
            this.tbblue.Name = "tbblue";
            this.tbblue.Size = new System.Drawing.Size(225, 45);
            this.tbblue.TabIndex = 2;
            this.tbblue.Scroll += new System.EventHandler(this.Tbblue_Scroll);
            // 
            // lblred
            // 
            this.lblred.AutoSize = true;
            this.lblred.ForeColor = System.Drawing.Color.White;
            this.lblred.Location = new System.Drawing.Point(286, 60);
            this.lblred.Name = "lblred";
            this.lblred.Size = new System.Drawing.Size(28, 13);
            this.lblred.TabIndex = 3;
            this.lblred.Text = "(red)";
            this.lblred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblgreen
            // 
            this.lblgreen.AutoSize = true;
            this.lblgreen.ForeColor = System.Drawing.Color.White;
            this.lblgreen.Location = new System.Drawing.Point(286, 109);
            this.lblgreen.Name = "lblgreen";
            this.lblgreen.Size = new System.Drawing.Size(40, 13);
            this.lblgreen.TabIndex = 4;
            this.lblgreen.Text = "(green)";
            this.lblgreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblblue
            // 
            this.lblblue.AutoSize = true;
            this.lblblue.ForeColor = System.Drawing.Color.White;
            this.lblblue.Location = new System.Drawing.Point(286, 164);
            this.lblblue.Name = "lblblue";
            this.lblblue.Size = new System.Drawing.Size(33, 13);
            this.lblblue.TabIndex = 5;
            this.lblblue.Text = "(blue)";
            this.lblblue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbcolor
            // 
            this.pbcolor.Location = new System.Drawing.Point(363, 49);
            this.pbcolor.Name = "pbcolor";
            this.pbcolor.Size = new System.Drawing.Size(166, 150);
            this.pbcolor.TabIndex = 6;
            this.pbcolor.TabStop = false;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(111, 199);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(100, 20);
            this.txtcolor.TabIndex = 7;
            this.txtcolor.TextChanged += new System.EventHandler(this.Txtcolor_TextChanged);
            // 
            // lbldoescolorexist
            // 
            this.lbldoescolorexist.AutoSize = true;
            this.lbldoescolorexist.ForeColor = System.Drawing.Color.White;
            this.lbldoescolorexist.Location = new System.Drawing.Point(222, 202);
            this.lbldoescolorexist.Name = "lbldoescolorexist";
            this.lbldoescolorexist.Size = new System.Drawing.Size(92, 13);
            this.lbldoescolorexist.TabIndex = 8;
            this.lbldoescolorexist.Text = "(does color exist?)";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Teal;
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(229, 224);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 75);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // btncopy
            // 
            this.btncopy.BackColor = System.Drawing.Color.Teal;
            this.btncopy.ForeColor = System.Drawing.Color.White;
            this.btncopy.Location = new System.Drawing.Point(310, 224);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(75, 75);
            this.btncopy.TabIndex = 11;
            this.btncopy.Text = "Copy RGB code";
            this.btncopy.UseVisualStyleBackColor = false;
            this.btncopy.Click += new System.EventHandler(this.Btncopy_Click);
            // 
            // btncolorpicker
            // 
            this.btncolorpicker.BackColor = System.Drawing.Color.Teal;
            this.btncolorpicker.ForeColor = System.Drawing.Color.White;
            this.btncolorpicker.Location = new System.Drawing.Point(472, 224);
            this.btncolorpicker.Name = "btncolorpicker";
            this.btncolorpicker.Size = new System.Drawing.Size(75, 75);
            this.btncolorpicker.TabIndex = 12;
            this.btncolorpicker.Text = "Color picker";
            this.btncolorpicker.UseVisualStyleBackColor = false;
            this.btncolorpicker.Click += new System.EventHandler(this.Btncolorpicker_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 31);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color picker";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(550, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 3);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Green:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Blue:";
            // 
            // btncopyhex
            // 
            this.btncopyhex.BackColor = System.Drawing.Color.Teal;
            this.btncopyhex.ForeColor = System.Drawing.Color.White;
            this.btncopyhex.Location = new System.Drawing.Point(391, 224);
            this.btncopyhex.Name = "btncopyhex";
            this.btncopyhex.Size = new System.Drawing.Size(75, 75);
            this.btncopyhex.TabIndex = 19;
            this.btncopyhex.Text = "Copy HEX code";
            this.btncopyhex.UseVisualStyleBackColor = false;
            this.btncopyhex.Click += new System.EventHandler(this.Btncopyhex_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Voer een naam in:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "HEX code:";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblprimarycolor2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblprimarycolor1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnswap);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cb2colors);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pbcolor2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lbldoeshexexist);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txthex);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btncopyhex);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btncolorpicker);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btncopy);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnclear);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lbldoescolorexist);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtcolor);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pbcolor);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblblue);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblgreen);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblred);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbblue);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbgreen);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbred);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(578, 311);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(578, 311);
            this.toolStripContainer1.TabIndex = 22;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // lblprimarycolor2
            // 
            this.lblprimarycolor2.AutoSize = true;
            this.lblprimarycolor2.Location = new System.Drawing.Point(337, 122);
            this.lblprimarycolor2.Name = "lblprimarycolor2";
            this.lblprimarycolor2.Size = new System.Drawing.Size(33, 13);
            this.lblprimarycolor2.TabIndex = 29;
            this.lblprimarycolor2.Text = "color:";
            this.lblprimarycolor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblprimarycolor1
            // 
            this.lblprimarycolor1.AutoSize = true;
            this.lblprimarycolor1.Location = new System.Drawing.Point(329, 109);
            this.lblprimarycolor1.Name = "lblprimarycolor1";
            this.lblprimarycolor1.Size = new System.Drawing.Size(41, 13);
            this.lblprimarycolor1.TabIndex = 28;
            this.lblprimarycolor1.Text = "Primary";
            this.lblprimarycolor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnswap
            // 
            this.btnswap.Location = new System.Drawing.Point(408, 60);
            this.btnswap.Name = "btnswap";
            this.btnswap.Size = new System.Drawing.Size(91, 23);
            this.btnswap.TabIndex = 27;
            this.btnswap.Text = "swap";
            this.btnswap.UseVisualStyleBackColor = true;
            this.btnswap.Click += new System.EventHandler(this.Btnswap_Click);
            // 
            // cb2colors
            // 
            this.cb2colors.AutoSize = true;
            this.cb2colors.Location = new System.Drawing.Point(408, 205);
            this.cb2colors.Name = "cb2colors";
            this.cb2colors.Size = new System.Drawing.Size(63, 17);
            this.cb2colors.TabIndex = 26;
            this.cb2colors.Text = "2 colors";
            this.cb2colors.UseVisualStyleBackColor = true;
            this.cb2colors.CheckedChanged += new System.EventHandler(this.Cb2colors_CheckedChanged);
            // 
            // pbcolor2
            // 
            this.pbcolor2.Location = new System.Drawing.Point(500, 88);
            this.pbcolor2.Name = "pbcolor2";
            this.pbcolor2.Size = new System.Drawing.Size(75, 75);
            this.pbcolor2.TabIndex = 25;
            this.pbcolor2.TabStop = false;
            // 
            // lbldoeshexexist
            // 
            this.lbldoeshexexist.AutoSize = true;
            this.lbldoeshexexist.ForeColor = System.Drawing.Color.White;
            this.lbldoeshexexist.Location = new System.Drawing.Point(111, 264);
            this.lbldoeshexexist.Name = "lbldoeshexexist";
            this.lbldoeshexexist.Size = new System.Drawing.Size(86, 13);
            this.lbldoeshexexist.TabIndex = 23;
            this.lbldoeshexexist.Text = "(does hex exist?)";
            // 
            // txthex
            // 
            this.txthex.Location = new System.Drawing.Point(111, 237);
            this.txthex.Name = "txthex";
            this.txthex.Size = new System.Drawing.Size(100, 20);
            this.txthex.TabIndex = 22;
            this.txthex.TextChanged += new System.EventHandler(this.Txthex_TextChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(494, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(522, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 30;
            this.button3.Text = "☐";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(578, 311);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbgreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcolor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcolor2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbred;
        private System.Windows.Forms.TrackBar tbgreen;
        private System.Windows.Forms.TrackBar tbblue;
        private System.Windows.Forms.Label lblred;
        private System.Windows.Forms.Label lblgreen;
        private System.Windows.Forms.Label lblblue;
        private System.Windows.Forms.PictureBox pbcolor;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label lbldoescolorexist;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.Button btncolorpicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncopyhex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox txthex;
        private System.Windows.Forms.Label lbldoeshexexist;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbcolor2;
        private System.Windows.Forms.CheckBox cb2colors;
        private System.Windows.Forms.Button btnswap;
        private System.Windows.Forms.Label lblprimarycolor1;
        private System.Windows.Forms.Label lblprimarycolor2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

