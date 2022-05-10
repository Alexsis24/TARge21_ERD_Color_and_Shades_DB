
namespace ColorsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.listPrimaryColors = new System.Windows.Forms.ListBox();
            this.listShades = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PrimaryColors";
            // 
            // listPrimaryColors
            // 
            this.listPrimaryColors.FormattingEnabled = true;
            this.listPrimaryColors.ItemHeight = 16;
            this.listPrimaryColors.Location = new System.Drawing.Point(75, 97);
            this.listPrimaryColors.Name = "listPrimaryColors";
            this.listPrimaryColors.Size = new System.Drawing.Size(120, 84);
            this.listPrimaryColors.TabIndex = 1;
            this.listPrimaryColors.SelectedIndexChanged += new System.EventHandler(this.listPrimaryColors_SelectedIndexChanged);
            // 
            // listShades
            // 
            this.listShades.FormattingEnabled = true;
            this.listShades.ItemHeight = 16;
            this.listShades.Location = new System.Drawing.Point(242, 97);
            this.listShades.Name = "listShades";
            this.listShades.Size = new System.Drawing.Size(120, 84);
            this.listShades.TabIndex = 3;
            this.listShades.SelectedIndexChanged += new System.EventHandler(this.listShades_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listShades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPrimaryColors);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPrimaryColors;
        private System.Windows.Forms.ListBox listShades;
        private System.Windows.Forms.Label label2;
    }
}

