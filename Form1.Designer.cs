namespace SobrecargaMetodos_2026_II
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
            btnSumar = new Button();
            label1 = new Label();
            this.txtbSumando1 = new TextBox();
            label2 = new Label();
            this.txtbSuumando2 = new TextBox();
            lbSuma = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(721, 128);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(160, 55);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 143);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 1;
            label1.Text = "+";
            // 
            // txtbSumando1
            // 
            this.txtbSumando1.Location = new Point(90, 137);
            this.txtbSumando1.Name = "txtbSumando1";
            this.txtbSumando1.Size = new Size(150, 31);
            this.txtbSumando1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 143);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 1;
            label2.Text = "=";
            // 
            // txtbSuumando2
            // 
            this.txtbSuumando2.Location = new Point(381, 137);
            this.txtbSuumando2.Name = "txtbSuumando2";
            this.txtbSuumando2.Size = new Size(150, 31);
            this.txtbSuumando2.TabIndex = 2;
            // 
            // lbSuma
            // 
            lbSuma.AutoSize = true;
            lbSuma.Location = new Point(643, 143);
            lbSuma.Name = "lbSuma";
            lbSuma.Size = new Size(22, 25);
            lbSuma.TabIndex = 1;
            lbSuma.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 356);
            Controls.Add(this.txtbSuumando2);
            Controls.Add(lbSuma);
            Controls.Add(label2);
            Controls.Add(this.txtbSumando1);
            Controls.Add(label1);
            Controls.Add(btnSumar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Label label1;
        private TextBox txtbSumando1;
        private Label label2;
        private TextBox txtbSuumando2;
        private Label lbSuma;
    }
}
