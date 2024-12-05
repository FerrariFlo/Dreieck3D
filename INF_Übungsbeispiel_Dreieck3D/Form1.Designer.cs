namespace INF_Übungsbeispiel_Dreieck3D
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAX = new TextBox();
            txtAY = new TextBox();
            txtAZ = new TextBox();
            txtBZ = new TextBox();
            txtBY = new TextBox();
            txtBX = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnBerechnen = new Button();
            label9 = new Label();
            lblErgebnis = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 70);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 0;
            label1.Text = "Punkt A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 70);
            label2.Name = "label2";
            label2.Size = new Size(106, 37);
            label2.TabIndex = 1;
            label2.Text = "Punkt B";
            // 
            // txtAX
            // 
            txtAX.Location = new Point(265, 135);
            txtAX.Name = "txtAX";
            txtAX.Size = new Size(126, 43);
            txtAX.TabIndex = 1;
            txtAX.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAY
            // 
            txtAY.Location = new Point(265, 193);
            txtAY.Name = "txtAY";
            txtAY.Size = new Size(126, 43);
            txtAY.TabIndex = 2;
            txtAY.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAZ
            // 
            txtAZ.Location = new Point(265, 256);
            txtAZ.Name = "txtAZ";
            txtAZ.Size = new Size(126, 43);
            txtAZ.TabIndex = 3;
            txtAZ.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBZ
            // 
            txtBZ.Location = new Point(654, 256);
            txtBZ.Name = "txtBZ";
            txtBZ.Size = new Size(126, 43);
            txtBZ.TabIndex = 6;
            txtBZ.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBY
            // 
            txtBY.Location = new Point(654, 193);
            txtBY.Name = "txtBY";
            txtBY.Size = new Size(126, 43);
            txtBY.TabIndex = 5;
            txtBY.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBX
            // 
            txtBX.Location = new Point(654, 135);
            txtBX.Name = "txtBX";
            txtBX.Size = new Size(126, 43);
            txtBX.TabIndex = 4;
            txtBX.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 135);
            label3.Name = "label3";
            label3.Size = new Size(39, 37);
            label3.TabIndex = 8;
            label3.Text = "X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(609, 138);
            label4.Name = "label4";
            label4.Size = new Size(39, 37);
            label4.TabIndex = 9;
            label4.Text = "X:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 196);
            label5.Name = "label5";
            label5.Size = new Size(38, 37);
            label5.TabIndex = 10;
            label5.Text = "Y:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(220, 259);
            label6.Name = "label6";
            label6.Size = new Size(38, 37);
            label6.TabIndex = 11;
            label6.Text = "Z:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(609, 196);
            label7.Name = "label7";
            label7.Size = new Size(38, 37);
            label7.TabIndex = 12;
            label7.Text = "Y:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(609, 259);
            label8.Name = "label8";
            label8.Size = new Size(38, 37);
            label8.TabIndex = 13;
            label8.Text = "Z:";
            // 
            // btnBerechnen
            // 
            btnBerechnen.Location = new Point(428, 357);
            btnBerechnen.Name = "btnBerechnen";
            btnBerechnen.Size = new Size(169, 52);
            btnBerechnen.TabIndex = 14;
            btnBerechnen.Text = "&Berechnen";
            btnBerechnen.UseVisualStyleBackColor = true;
            btnBerechnen.Click += btnBerechnen_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(328, 440);
            label9.Name = "label9";
            label9.Size = new Size(125, 37);
            label9.TabIndex = 15;
            label9.Text = "Ergebnis:";
            // 
            // lblErgebnis
            // 
            lblErgebnis.AutoSize = true;
            lblErgebnis.Location = new Point(471, 440);
            lblErgebnis.Name = "lblErgebnis";
            lblErgebnis.Size = new Size(24, 37);
            lblErgebnis.TabIndex = 16;
            lblErgebnis.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 826);
            Controls.Add(lblErgebnis);
            Controls.Add(label9);
            Controls.Add(btnBerechnen);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBZ);
            Controls.Add(txtBY);
            Controls.Add(txtBX);
            Controls.Add(txtAZ);
            Controls.Add(txtAY);
            Controls.Add(txtAX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAX;
        private TextBox txtAY;
        private TextBox txtAZ;
        private TextBox txtBZ;
        private TextBox txtBY;
        private TextBox txtBX;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnBerechnen;
        private Label label9;
        private Label lblErgebnis;
    }
}
