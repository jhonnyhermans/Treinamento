namespace Treinamento.App.ChldForms
{
    partial class CustomerForm
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
            this.commonListUserControl1 = new Treinamento.App.UserControls.CommonListUserControl();
            this.SuspendLayout();
            // 
            // commonListUserControl1
            // 
            this.commonListUserControl1.Location = new System.Drawing.Point(21, 12);
            this.commonListUserControl1.Name = "commonListUserControl1";
            this.commonListUserControl1.Size = new System.Drawing.Size(899, 254);
            this.commonListUserControl1.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 401);
            this.Controls.Add(this.commonListUserControl1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.CommonListUserControl commonListUserControl1;
    }
}