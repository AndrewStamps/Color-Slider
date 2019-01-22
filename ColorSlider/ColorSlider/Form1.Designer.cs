namespace ColorSlider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picSwatch = new System.Windows.Forms.PictureBox();
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.hsbGrn = new System.Windows.Forms.HScrollBar();
            this.hsbBlu = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBlu = new System.Windows.Forms.Label();
            this.lblGrn = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.grp_info = new System.Windows.Forms.GroupBox();
            this.lblAlp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hsbAlp = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.picSwatch)).BeginInit();
            this.grp_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSwatch
            // 
            this.picSwatch.BackColor = System.Drawing.Color.Black;
            this.picSwatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSwatch.Location = new System.Drawing.Point(93, 69);
            this.picSwatch.Name = "picSwatch";
            this.picSwatch.Size = new System.Drawing.Size(772, 609);
            this.picSwatch.TabIndex = 0;
            this.picSwatch.TabStop = false;
            // 
            // hsbRed
            // 
            this.hsbRed.LargeChange = 1;
            this.hsbRed.Location = new System.Drawing.Point(210, 800);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(532, 40);
            this.hsbRed.TabIndex = 1;
            this.hsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_changed);
            // 
            // hsbGrn
            // 
            this.hsbGrn.LargeChange = 1;
            this.hsbGrn.Location = new System.Drawing.Point(210, 869);
            this.hsbGrn.Maximum = 255;
            this.hsbGrn.Name = "hsbGrn";
            this.hsbGrn.Size = new System.Drawing.Size(532, 40);
            this.hsbGrn.TabIndex = 2;
            this.hsbGrn.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_changed);
            // 
            // hsbBlu
            // 
            this.hsbBlu.LargeChange = 1;
            this.hsbBlu.Location = new System.Drawing.Point(210, 938);
            this.hsbBlu.Maximum = 255;
            this.hsbBlu.Name = "hsbBlu";
            this.hsbBlu.Size = new System.Drawing.Size(532, 40);
            this.hsbBlu.TabIndex = 3;
            this.hsbBlu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(84, 814);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(84, 882);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(84, 949);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "BLUE";
            // 
            // lblBlu
            // 
            this.lblBlu.AutoSize = true;
            this.lblBlu.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlu.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBlu.Location = new System.Drawing.Point(795, 952);
            this.lblBlu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlu.Name = "lblBlu";
            this.lblBlu.Size = new System.Drawing.Size(68, 48);
            this.lblBlu.TabIndex = 9;
            this.lblBlu.Text = "000";
            // 
            // lblGrn
            // 
            this.lblGrn.AutoSize = true;
            this.lblGrn.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGrn.Location = new System.Drawing.Point(795, 885);
            this.lblGrn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrn.Name = "lblGrn";
            this.lblGrn.Size = new System.Drawing.Size(68, 48);
            this.lblGrn.TabIndex = 8;
            this.lblGrn.Text = "000";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(795, 817);
            this.lblRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(68, 48);
            this.lblRed.TabIndex = 7;
            this.lblRed.Text = "000";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHex.Location = new System.Drawing.Point(38, 103);
            this.lblHex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(244, 48);
            this.lblHex.TabIndex = 10;
            this.lblHex.Text = "HEX = FF000000";
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBin.Location = new System.Drawing.Point(38, 152);
            this.lblBin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(468, 48);
            this.lblBin.TabIndex = 11;
            this.lblBin.Text = "BIN = 1111111100000000000000";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInt.Location = new System.Drawing.Point(38, 54);
            this.lblInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(276, 48);
            this.lblInt.TabIndex = 12;
            this.lblInt.Text = "INT = 4278190080";
            // 
            // grp_info
            // 
            this.grp_info.Controls.Add(this.lblInt);
            this.grp_info.Controls.Add(this.lblBin);
            this.grp_info.Controls.Add(this.lblHex);
            this.grp_info.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_info.Location = new System.Drawing.Point(93, 1040);
            this.grp_info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_info.Name = "grp_info";
            this.grp_info.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_info.Size = new System.Drawing.Size(774, 222);
            this.grp_info.TabIndex = 13;
            this.grp_info.TabStop = false;
            this.grp_info.Text = "Info";
            // 
            // lblAlp
            // 
            this.lblAlp.AutoSize = true;
            this.lblAlp.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlp.ForeColor = System.Drawing.Color.Black;
            this.lblAlp.Location = new System.Drawing.Point(795, 749);
            this.lblAlp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlp.Name = "lblAlp";
            this.lblAlp.Size = new System.Drawing.Size(68, 48);
            this.lblAlp.TabIndex = 16;
            this.lblAlp.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Typewriter_Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(84, 746);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 48);
            this.label5.TabIndex = 15;
            this.label5.Text = "ALPHA";
            // 
            // hsbAlp
            // 
            this.hsbAlp.LargeChange = 1;
            this.hsbAlp.Location = new System.Drawing.Point(210, 732);
            this.hsbAlp.Maximum = 255;
            this.hsbAlp.Name = "hsbAlp";
            this.hsbAlp.Size = new System.Drawing.Size(532, 40);
            this.hsbAlp.TabIndex = 14;
            this.hsbAlp.Value = 255;
            this.hsbAlp.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 1312);
            this.Controls.Add(this.lblAlp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hsbAlp);
            this.Controls.Add(this.grp_info);
            this.Controls.Add(this.lblBlu);
            this.Controls.Add(this.lblGrn);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hsbBlu);
            this.Controls.Add(this.hsbGrn);
            this.Controls.Add(this.hsbRed);
            this.Controls.Add(this.picSwatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ColorMaker";
            ((System.ComponentModel.ISupportInitialize)(this.picSwatch)).EndInit();
            this.grp_info.ResumeLayout(false);
            this.grp_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSwatch;
        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.HScrollBar hsbGrn;
        private System.Windows.Forms.HScrollBar hsbBlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBlu;
        private System.Windows.Forms.Label lblGrn;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.GroupBox grp_info;
        private System.Windows.Forms.Label lblAlp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hsbAlp;
    }
}

