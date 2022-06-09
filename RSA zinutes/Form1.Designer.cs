
namespace RSA_zinutes
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
            this.B1Pal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B1ASend = new System.Windows.Forms.Button();
            this.lbKeyPrivate = new System.Windows.Forms.Label();
            this.lb1KeyPublic = new System.Windows.Forms.Label();
            this.rTxtBoxCiphTxt = new System.Windows.Forms.RichTextBox();
            this.rTxtBoxPText = new System.Windows.Forms.RichTextBox();
            this.cBoxQ = new System.Windows.Forms.ComboBox();
            this.cBoxP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.B2ASend = new System.Windows.Forms.Button();
            this.lb2KeyPublic = new System.Windows.Forms.Label();
            this.rTxtBoxSig = new System.Windows.Forms.RichTextBox();
            this.rTxtBoxMes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.B2Pal = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbSigCon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rTxtBoxMesSer = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb3KeyPublic = new System.Windows.Forms.Label();
            this.rTxtBoxSigSer = new System.Windows.Forms.RichTextBox();
            this.rTxtBoxMesEnd = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.B3Pal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // B1Pal
            // 
            this.B1Pal.Location = new System.Drawing.Point(12, 12);
            this.B1Pal.Name = "B1Pal";
            this.B1Pal.Size = new System.Drawing.Size(163, 52);
            this.B1Pal.TabIndex = 0;
            this.B1Pal.Text = "Palesti pirmaja aplikacija";
            this.B1Pal.UseVisualStyleBackColor = true;
            this.B1Pal.Click += new System.EventHandler(this.B1Pal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pirminis sk. p:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B1ASend);
            this.panel1.Controls.Add(this.lbKeyPrivate);
            this.panel1.Controls.Add(this.lb1KeyPublic);
            this.panel1.Controls.Add(this.rTxtBoxCiphTxt);
            this.panel1.Controls.Add(this.rTxtBoxPText);
            this.panel1.Controls.Add(this.cBoxQ);
            this.panel1.Controls.Add(this.cBoxP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 173);
            this.panel1.TabIndex = 2;
            // 
            // B1ASend
            // 
            this.B1ASend.Location = new System.Drawing.Point(554, 108);
            this.B1ASend.Name = "B1ASend";
            this.B1ASend.Size = new System.Drawing.Size(127, 52);
            this.B1ASend.TabIndex = 3;
            this.B1ASend.Text = "Siusti";
            this.B1ASend.UseVisualStyleBackColor = true;
            this.B1ASend.Click += new System.EventHandler(this.B1ASend_Click);
            // 
            // lbKeyPrivate
            // 
            this.lbKeyPrivate.AutoSize = true;
            this.lbKeyPrivate.Location = new System.Drawing.Point(554, 77);
            this.lbKeyPrivate.Name = "lbKeyPrivate";
            this.lbKeyPrivate.Size = new System.Drawing.Size(77, 13);
            this.lbKeyPrivate.TabIndex = 3;
            this.lbKeyPrivate.Text = "Privatus raktas";
            // 
            // lb1KeyPublic
            // 
            this.lb1KeyPublic.AutoSize = true;
            this.lb1KeyPublic.Location = new System.Drawing.Point(554, 64);
            this.lb1KeyPublic.Name = "lb1KeyPublic";
            this.lb1KeyPublic.Size = new System.Drawing.Size(70, 13);
            this.lb1KeyPublic.TabIndex = 4;
            this.lb1KeyPublic.Text = "Viesas raktas";
            // 
            // rTxtBoxCiphTxt
            // 
            this.rTxtBoxCiphTxt.Location = new System.Drawing.Point(280, 64);
            this.rTxtBoxCiphTxt.Name = "rTxtBoxCiphTxt";
            this.rTxtBoxCiphTxt.ReadOnly = true;
            this.rTxtBoxCiphTxt.Size = new System.Drawing.Size(268, 96);
            this.rTxtBoxCiphTxt.TabIndex = 6;
            this.rTxtBoxCiphTxt.Text = "";
            // 
            // rTxtBoxPText
            // 
            this.rTxtBoxPText.Location = new System.Drawing.Point(6, 64);
            this.rTxtBoxPText.Name = "rTxtBoxPText";
            this.rTxtBoxPText.Size = new System.Drawing.Size(268, 96);
            this.rTxtBoxPText.TabIndex = 5;
            this.rTxtBoxPText.Text = "";
            // 
            // cBoxQ
            // 
            this.cBoxQ.FormattingEnabled = true;
            this.cBoxQ.Location = new System.Drawing.Point(80, 37);
            this.cBoxQ.Name = "cBoxQ";
            this.cBoxQ.Size = new System.Drawing.Size(194, 21);
            this.cBoxQ.TabIndex = 4;
            // 
            // cBoxP
            // 
            this.cBoxP.FormattingEnabled = true;
            this.cBoxP.Location = new System.Drawing.Point(80, 8);
            this.cBoxP.Name = "cBoxP";
            this.cBoxP.Size = new System.Drawing.Size(194, 21);
            this.cBoxP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pirminis sk. q:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.B2ASend);
            this.panel2.Controls.Add(this.lb2KeyPublic);
            this.panel2.Controls.Add(this.rTxtBoxSig);
            this.panel2.Controls.Add(this.rTxtBoxMes);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 139);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parasas";
            // 
            // B2ASend
            // 
            this.B2ASend.Location = new System.Drawing.Point(554, 66);
            this.B2ASend.Name = "B2ASend";
            this.B2ASend.Size = new System.Drawing.Size(127, 52);
            this.B2ASend.TabIndex = 3;
            this.B2ASend.Text = "Siusti";
            this.B2ASend.UseVisualStyleBackColor = true;
            this.B2ASend.Click += new System.EventHandler(this.B2ASend_Click);
            // 
            // lb2KeyPublic
            // 
            this.lb2KeyPublic.AutoSize = true;
            this.lb2KeyPublic.Location = new System.Drawing.Point(554, 27);
            this.lb2KeyPublic.Name = "lb2KeyPublic";
            this.lb2KeyPublic.Size = new System.Drawing.Size(70, 13);
            this.lb2KeyPublic.TabIndex = 4;
            this.lb2KeyPublic.Text = "Viesas raktas";
            // 
            // rTxtBoxSig
            // 
            this.rTxtBoxSig.Location = new System.Drawing.Point(280, 27);
            this.rTxtBoxSig.Name = "rTxtBoxSig";
            this.rTxtBoxSig.Size = new System.Drawing.Size(268, 96);
            this.rTxtBoxSig.TabIndex = 6;
            this.rTxtBoxSig.Text = "";
            // 
            // rTxtBoxMes
            // 
            this.rTxtBoxMes.Location = new System.Drawing.Point(6, 27);
            this.rTxtBoxMes.Name = "rTxtBoxMes";
            this.rTxtBoxMes.ReadOnly = true;
            this.rTxtBoxMes.Size = new System.Drawing.Size(268, 96);
            this.rTxtBoxMes.TabIndex = 5;
            this.rTxtBoxMes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Zinute";
            // 
            // B2Pal
            // 
            this.B2Pal.Location = new System.Drawing.Point(12, 249);
            this.B2Pal.Name = "B2Pal";
            this.B2Pal.Size = new System.Drawing.Size(163, 52);
            this.B2Pal.TabIndex = 4;
            this.B2Pal.Text = "Palesti antraja aplikacija";
            this.B2Pal.UseVisualStyleBackColor = true;
            this.B2Pal.Click += new System.EventHandler(this.B2Pal_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbSigCon);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.rTxtBoxMesSer);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lb3KeyPublic);
            this.panel3.Controls.Add(this.rTxtBoxSigSer);
            this.panel3.Controls.Add(this.rTxtBoxMesEnd);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 135);
            this.panel3.TabIndex = 5;
            // 
            // lbSigCon
            // 
            this.lbSigCon.AutoSize = true;
            this.lbSigCon.Location = new System.Drawing.Point(831, 57);
            this.lbSigCon.Name = "lbSigCon";
            this.lbSigCon.Size = new System.Drawing.Size(111, 13);
            this.lbSigCon.TabIndex = 10;
            this.lbSigCon.Text = "Ar parasas patvirtintas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Parasas is serverio zinutes";
            // 
            // rTxtBoxMesSer
            // 
            this.rTxtBoxMesSer.Location = new System.Drawing.Point(557, 28);
            this.rTxtBoxMesSer.Name = "rTxtBoxMesSer";
            this.rTxtBoxMesSer.ReadOnly = true;
            this.rTxtBoxMesSer.Size = new System.Drawing.Size(268, 96);
            this.rTxtBoxMesSer.TabIndex = 8;
            this.rTxtBoxMesSer.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zinute is serverio";
            // 
            // lb3KeyPublic
            // 
            this.lb3KeyPublic.AutoSize = true;
            this.lb3KeyPublic.Location = new System.Drawing.Point(831, 31);
            this.lb3KeyPublic.Name = "lb3KeyPublic";
            this.lb3KeyPublic.Size = new System.Drawing.Size(70, 13);
            this.lb3KeyPublic.TabIndex = 4;
            this.lb3KeyPublic.Text = "Viesas raktas";
            // 
            // rTxtBoxSigSer
            // 
            this.rTxtBoxSigSer.Location = new System.Drawing.Point(283, 28);
            this.rTxtBoxSigSer.Name = "rTxtBoxSigSer";
            this.rTxtBoxSigSer.ReadOnly = true;
            this.rTxtBoxSigSer.Size = new System.Drawing.Size(268, 96);
            this.rTxtBoxSigSer.TabIndex = 6;
            this.rTxtBoxSigSer.Text = "";
            // 
            // rTxtBoxMesEnd
            // 
            this.rTxtBoxMesEnd.Location = new System.Drawing.Point(6, 28);
            this.rTxtBoxMesEnd.Name = "rTxtBoxMesEnd";
            this.rTxtBoxMesEnd.ReadOnly = true;
            this.rTxtBoxMesEnd.Size = new System.Drawing.Size(268, 96);
            this.rTxtBoxMesEnd.TabIndex = 5;
            this.rTxtBoxMesEnd.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Zinute";
            // 
            // B3Pal
            // 
            this.B3Pal.Location = new System.Drawing.Point(12, 452);
            this.B3Pal.Name = "B3Pal";
            this.B3Pal.Size = new System.Drawing.Size(163, 52);
            this.B3Pal.TabIndex = 6;
            this.B3Pal.Text = "Palesti Treceja aplikacija";
            this.B3Pal.UseVisualStyleBackColor = true;
            this.B3Pal.Click += new System.EventHandler(this.B3Pal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 655);
            this.Controls.Add(this.B3Pal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.B2Pal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.B1Pal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B1Pal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B1ASend;
        private System.Windows.Forms.Label lbKeyPrivate;
        private System.Windows.Forms.Label lb1KeyPublic;
        private System.Windows.Forms.RichTextBox rTxtBoxCiphTxt;
        private System.Windows.Forms.RichTextBox rTxtBoxPText;
        private System.Windows.Forms.ComboBox cBoxQ;
        private System.Windows.Forms.ComboBox cBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button B2ASend;
        private System.Windows.Forms.Label lb2KeyPublic;
        private System.Windows.Forms.RichTextBox rTxtBoxSig;
        private System.Windows.Forms.RichTextBox rTxtBoxMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B2Pal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb3KeyPublic;
        private System.Windows.Forms.RichTextBox rTxtBoxSigSer;
        private System.Windows.Forms.RichTextBox rTxtBoxMesEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button B3Pal;
        private System.Windows.Forms.Label lbSigCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rTxtBoxMesSer;
    }
}

