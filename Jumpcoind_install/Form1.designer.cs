namespace Jumpcoin_install_win
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.create_masternode = new System.Windows.Forms.Button();
            this.ip_feld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_feld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password_feld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.port_feld = new System.Windows.Forms.TextBox();
            this.check_masternode = new System.Windows.Forms.Button();
            this.restart_masternode = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.log_feld = new System.Windows.Forms.TextBox();
            this.startup_checkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RpcUser_feld = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RpcPassword_feld = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_masternode
            // 
            this.create_masternode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.create_masternode.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.create_masternode.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.create_masternode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.create_masternode.Location = new System.Drawing.Point(359, 100);
            this.create_masternode.Name = "create_masternode";
            this.create_masternode.Size = new System.Drawing.Size(334, 44);
            this.create_masternode.TabIndex = 0;
            this.create_masternode.Text = "Install Wallet";
            this.create_masternode.UseVisualStyleBackColor = false;
            this.create_masternode.Click += new System.EventHandler(this.button1_Click);
            // 
            // ip_feld
            // 
            this.ip_feld.Location = new System.Drawing.Point(101, 22);
            this.ip_feld.Name = "ip_feld";
            this.ip_feld.Size = new System.Drawing.Size(100, 20);
            this.ip_feld.TabIndex = 1;
            this.ip_feld.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // username_feld
            // 
            this.username_feld.Location = new System.Drawing.Point(101, 48);
            this.username_feld.Name = "username_feld";
            this.username_feld.Size = new System.Drawing.Size(100, 20);
            this.username_feld.TabIndex = 5;
            this.username_feld.Text = "root";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "User Password";
            // 
            // password_feld
            // 
            this.password_feld.Location = new System.Drawing.Point(320, 48);
            this.password_feld.Name = "password_feld";
            this.password_feld.Size = new System.Drawing.Size(258, 20);
            this.password_feld.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Server port";
            // 
            // port_feld
            // 
            this.port_feld.Location = new System.Drawing.Point(320, 22);
            this.port_feld.Name = "port_feld";
            this.port_feld.Size = new System.Drawing.Size(100, 20);
            this.port_feld.TabIndex = 9;
            this.port_feld.Text = "22";
            // 
            // check_masternode
            // 
            this.check_masternode.Location = new System.Drawing.Point(19, 150);
            this.check_masternode.Name = "check_masternode";
            this.check_masternode.Size = new System.Drawing.Size(334, 44);
            this.check_masternode.TabIndex = 19;
            this.check_masternode.Text = "Check Blockcount";
            this.check_masternode.UseVisualStyleBackColor = true;
            this.check_masternode.Click += new System.EventHandler(this.button2_Click);
            // 
            // restart_masternode
            // 
            this.restart_masternode.Location = new System.Drawing.Point(359, 150);
            this.restart_masternode.Name = "restart_masternode";
            this.restart_masternode.Size = new System.Drawing.Size(334, 44);
            this.restart_masternode.TabIndex = 20;
            this.restart_masternode.Text = "(Re)Start Wallet   ***Beta***";
            this.restart_masternode.UseVisualStyleBackColor = true;
            this.restart_masternode.Click += new System.EventHandler(this.restart_masternode_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(584, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 44);
            this.button4.TabIndex = 21;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // log_feld
            // 
            this.log_feld.Location = new System.Drawing.Point(19, 200);
            this.log_feld.MaxLength = 2147483647;
            this.log_feld.Multiline = true;
            this.log_feld.Name = "log_feld";
            this.log_feld.ReadOnly = true;
            this.log_feld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_feld.Size = new System.Drawing.Size(674, 351);
            this.log_feld.TabIndex = 22;
            this.log_feld.Text = "Server Log";
            // 
            // startup_checkbox
            // 
            this.startup_checkbox.AutoSize = true;
            this.startup_checkbox.Location = new System.Drawing.Point(19, 115);
            this.startup_checkbox.Name = "startup_checkbox";
            this.startup_checkbox.Size = new System.Drawing.Size(238, 17);
            this.startup_checkbox.TabIndex = 25;
            this.startup_checkbox.Text = "Enable wallet startup and cronjob   ***Beta***";
            this.startup_checkbox.UseVisualStyleBackColor = true;
            this.startup_checkbox.CheckedChanged += new System.EventHandler(this.startup_checkbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "RpcUser";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RpcUser_feld
            // 
            this.RpcUser_feld.Location = new System.Drawing.Point(101, 74);
            this.RpcUser_feld.Name = "RpcUser_feld";
            this.RpcUser_feld.Size = new System.Drawing.Size(100, 20);
            this.RpcUser_feld.TabIndex = 26;
            this.RpcUser_feld.Text = "JumpcoinUser";
            this.RpcUser_feld.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "RpcPassword";
            // 
            // RpcPassword_feld
            // 
            this.RpcPassword_feld.Location = new System.Drawing.Point(320, 74);
            this.RpcPassword_feld.Name = "RpcPassword_feld";
            this.RpcPassword_feld.Size = new System.Drawing.Size(258, 20);
            this.RpcPassword_feld.TabIndex = 28;
            this.RpcPassword_feld.Text = "hufwer5er49f3r9wd59fsdfsdDE45vc5asdfjwdi85489";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(584, 20);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(111, 23);
            this.update_button.TabIndex = 30;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 561);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RpcPassword_feld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RpcUser_feld);
            this.Controls.Add(this.startup_checkbox);
            this.Controls.Add(this.log_feld);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.restart_masternode);
            this.Controls.Add(this.check_masternode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.port_feld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_feld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_feld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ip_feld);
            this.Controls.Add(this.create_masternode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JUMP Wallet installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_masternode;
        private System.Windows.Forms.TextBox ip_feld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_feld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_feld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox port_feld;
        private System.Windows.Forms.Button check_masternode;
        private System.Windows.Forms.Button restart_masternode;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox log_feld;
        private System.Windows.Forms.CheckBox startup_checkbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RpcUser_feld;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RpcPassword_feld;
        private System.Windows.Forms.Button update_button;
    }
}

