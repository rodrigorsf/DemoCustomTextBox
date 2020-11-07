namespace DemoCustomTextBox
{
    partial class FormExample
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
            this.customTextBox1 = new DemoCustomTextBox.CustomTextBox();
            this.customTextBox2 = new DemoCustomTextBox.CustomTextBox();
            this.customTextBox3 = new DemoCustomTextBox.CustomTextBox();
            this.SuspendLayout();
            // 
            // customTextBox1
            // 
            this.customTextBox1.FocusColor = System.Drawing.Color.Red;
            this.customTextBox1.Location = new System.Drawing.Point(216, 40);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(126, 20);
            this.customTextBox1.TabIndex = 0;
            // 
            // customTextBox2
            // 
            this.customTextBox2.FocusColor = System.Drawing.Color.Yellow;
            this.customTextBox2.Location = new System.Drawing.Point(216, 87);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Size = new System.Drawing.Size(126, 20);
            this.customTextBox2.TabIndex = 1;
            // 
            // customTextBox3
            // 
            this.customTextBox3.FocusColor = System.Drawing.Color.Blue;
            this.customTextBox3.Location = new System.Drawing.Point(216, 134);
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Size = new System.Drawing.Size(126, 20);
            this.customTextBox3.TabIndex = 2;
            // 
            // FormExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Name = "FormExample";
            this.Text = "FormExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox3;
    }
}