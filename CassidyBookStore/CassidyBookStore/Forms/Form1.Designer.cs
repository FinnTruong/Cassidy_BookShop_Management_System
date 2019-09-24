namespace CassidyBookStore
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
            this.uC_SlideUpLogin2 = new CassidyBookStore.UC_SlideUpLogin();
            this.SuspendLayout();
            // 
            // uC_SlideUpLogin2
            // 
            this.uC_SlideUpLogin2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_SlideUpLogin2.Location = new System.Drawing.Point(0, 0);
            this.uC_SlideUpLogin2.Name = "uC_SlideUpLogin2";
            this.uC_SlideUpLogin2.Size = new System.Drawing.Size(600, 900);
            this.uC_SlideUpLogin2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.uC_SlideUpLogin2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_SlideUpLogin uC_SlideUpLogin2;
    }
}

