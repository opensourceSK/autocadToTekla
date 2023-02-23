namespace AutoCADToTeklaConversion
{
    partial class MainView
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
            this.ConvertModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertModel
            // 
            this.ConvertModel.Location = new System.Drawing.Point(360, 239);
            this.ConvertModel.Name = "ConvertModel";
            this.ConvertModel.Size = new System.Drawing.Size(146, 23);
            this.ConvertModel.TabIndex = 0;
            this.ConvertModel.Text = "ConvertToTekla";
            this.ConvertModel.UseVisualStyleBackColor = true;
            this.ConvertModel.Click += new System.EventHandler(this.ConvertModel_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 292);
            this.Controls.Add(this.ConvertModel);
            this.Name = "MainView";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConvertModel;
    }
}

