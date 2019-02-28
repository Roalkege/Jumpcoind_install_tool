namespace Jumpcoind_install
{
    partial class donate_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donate_form));
            this.label1 = new System.Windows.Forms.Label();
            this.jump_label = new System.Windows.Forms.Label();
            this.btc_label = new System.Windows.Forms.Label();
            this.eth_label = new System.Windows.Forms.Label();
            this.doge_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donate to me, click on an address to copy the address to your clipboard. ^^";
            // 
            // jump_label
            // 
            this.jump_label.AutoSize = true;
            this.jump_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jump_label.Location = new System.Drawing.Point(11, 49);
            this.jump_label.Name = "jump_label";
            this.jump_label.Size = new System.Drawing.Size(379, 20);
            this.jump_label.TabIndex = 1;
            this.jump_label.Text = "JUMP: Jh2hw7Ktifk6mMRFmBckFtyDADsNZmsDqs";
            this.jump_label.Click += new System.EventHandler(this.jump_label_Click);
            // 
            // btc_label
            // 
            this.btc_label.AutoSize = true;
            this.btc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btc_label.Location = new System.Drawing.Point(11, 80);
            this.btc_label.Name = "btc_label";
            this.btc_label.Size = new System.Drawing.Size(382, 20);
            this.btc_label.TabIndex = 2;
            this.btc_label.Text = "BTC: bc1qhj6uxhzrzp3ymcd3tf6daayvskccj35swnzyvf";
            this.btc_label.Click += new System.EventHandler(this.btc_label_Click);
            // 
            // eth_label
            // 
            this.eth_label.AutoSize = true;
            this.eth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eth_label.Location = new System.Drawing.Point(11, 109);
            this.eth_label.Name = "eth_label";
            this.eth_label.Size = new System.Drawing.Size(446, 20);
            this.eth_label.TabIndex = 3;
            this.eth_label.Text = "ETH: 0x3d4AA9B18320a8DD0587C3BC57640C9aaEb4eca4";
            this.eth_label.Click += new System.EventHandler(this.eth_label_Click);
            // 
            // doge_label
            // 
            this.doge_label.AutoSize = true;
            this.doge_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doge_label.Location = new System.Drawing.Point(11, 139);
            this.doge_label.Name = "doge_label";
            this.doge_label.Size = new System.Drawing.Size(385, 20);
            this.doge_label.TabIndex = 4;
            this.doge_label.Text = "DOGE: DTDBRFfzLVF7TrqZ7WAUKzmJjT5CSwitqR";
            this.doge_label.Click += new System.EventHandler(this.doge_label_Click);
            // 
            // donate_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 172);
            this.Controls.Add(this.doge_label);
            this.Controls.Add(this.eth_label);
            this.Controls.Add(this.btc_label);
            this.Controls.Add(this.jump_label);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "donate_form";
            this.Text = "Donate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label jump_label;
        private System.Windows.Forms.Label btc_label;
        private System.Windows.Forms.Label eth_label;
        private System.Windows.Forms.Label doge_label;
    }
}