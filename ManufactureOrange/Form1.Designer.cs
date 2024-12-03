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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 494);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

