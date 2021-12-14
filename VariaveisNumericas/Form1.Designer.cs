namespace VariaveisNumericas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.somar = new System.Windows.Forms.Button();
            this.iblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(40, 61);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(150, 31);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.Text = "txtNum1";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(291, 61);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(150, 31);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.Text = "txtNum2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2:";
            // 
            // somar
            // 
            this.somar.Location = new System.Drawing.Point(40, 142);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(401, 34);
            this.somar.TabIndex = 4;
            this.somar.Text = "Somar";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.button1_Click);
            // 
            // iblRes
            // 
            this.iblRes.AutoSize = true;
            this.iblRes.Location = new System.Drawing.Point(40, 245);
            this.iblRes.Name = "iblRes";
            this.iblRes.Size = new System.Drawing.Size(58, 25);
            this.iblRes.TabIndex = 5;
            this.iblRes.Text = "iblRes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iblRes);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Label iblRes;
    }
}
