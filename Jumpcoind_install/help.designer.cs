namespace Jumpcoind_install
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.label1 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.donate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 156);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // close_button
            // 
            this.close_button.AutoSize = true;
            this.close_button.Location = new System.Drawing.Point(145, 194);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(124, 26);
            this.close_button.TabIndex = 1;
            this.close_button.Text = "Close window";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // donate_button
            // 
            this.donate_button.Location = new System.Drawing.Point(15, 194);
            this.donate_button.Name = "donate_button";
            this.donate_button.Size = new System.Drawing.Size(124, 26);
            this.donate_button.TabIndex = 2;
            this.donate_button.Text = "Donate";
            this.donate_button.UseVisualStyleBackColor = true;
            this.donate_button.Click += new System.EventHandler(this.donate_button_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 232);
            this.Controls.Add(this.donate_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button donate_button;
    }
}