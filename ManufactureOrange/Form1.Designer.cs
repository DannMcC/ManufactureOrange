namespace ManufactureOrange
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
            this.comboBoxInput1 = new System.Windows.Forms.ComboBox();
            this.labelInput1 = new System.Windows.Forms.Label();
            this.submitButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxInput1
            // 
            this.comboBoxInput1.FormattingEnabled = true;
            this.comboBoxInput1.Location = new System.Drawing.Point(149, 36);
            this.comboBoxInput1.Name = "comboBoxInput1";
            this.comboBoxInput1.Size = new System.Drawing.Size(121, 24);
            this.comboBoxInput1.TabIndex = 0;
            this.comboBoxInput1.SelectedIndexChanged += new System.EventHandler(this.comboBoxInput1_SelectedIndexChanged);
            // 
            // labelInput1
            // 
            this.labelInput1.AutoSize = true;
            this.labelInput1.Location = new System.Drawing.Point(62, 39);
            this.labelInput1.Name = "labelInput1";
            this.labelInput1.Size = new System.Drawing.Size(81, 16);
            this.labelInput1.TabIndex = 1;
            this.labelInput1.Text = "Metal Select";
            // 
            // submitButton1
            // 
            this.submitButton1.Location = new System.Drawing.Point(195, 184);
            this.submitButton1.Name = "submitButton1";
            this.submitButton1.Size = new System.Drawing.Size(75, 23);
            this.submitButton1.TabIndex = 2;
            this.submitButton1.Text = "Submit";
            this.submitButton1.UseVisualStyleBackColor = true;
            this.submitButton1.Click += new System.EventHandler(this.submitButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton1);
            this.Controls.Add(this.labelInput1);
            this.Controls.Add(this.comboBoxInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInput1;
        private System.Windows.Forms.Label labelInput1;
        private System.Windows.Forms.Button submitButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

