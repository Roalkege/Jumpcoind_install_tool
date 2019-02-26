using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jumpcoind_install
{
    public partial class Help : Form
    {
        public string language_info;
        public Help()
        {
            InitializeComponent();
            language_info = System.Globalization.CultureInfo.CurrentCulture.ThreeLetterISOLanguageName;
            if (language_info == "deu")
            {
                this.Name = "Hilfe";
                this.Text = "Hilfe";
                this.close_button.Text = "Schließe Fenster";
                this.label1.Text = "Sie benötigen ein VPS" + "\r\n" + "\r\n"
                      + "Du musst  die Felder IP, Benutzername (Standard: root) und Benutzerpasswort ausfüllen." + "\r\n"
                      + "Dies ist erforderlich, um eine Verbindung zu Ihrem VPS herzustellen." + "\r\n"
                      + "Wenn Sie ein neues Wallet installieren möchten, aktivieren Sie(wenn Sie möchten) das Kontrollkästchen für den Cronjob." + "\r\n"
                      + "Der Cronjob überprüft alle fünf Minuten, ob die Wallet läuft." + "\r\n"
                      + "Ändern Sie den RpcUser und das RpcPasswort und speichern Sie die Eingaben, wenn Sie ein Faucet einrichten möchten." + "\r\n" + "\r\n"
                      + "Wenn Sie die Wallet überprüfen möchten, oder die Wallet neu starten möchten, müssen Sie nur Ihre IP, Ihren Benutzer und Ihr Passwort eingeben." + "\r\n" + "\r\n"
                      + "Blockhöhe überprüfen gibt Ihnen die aktuelle Blockhöhe wieder. Wenn die Ausgabe Null ist, läuft die Wallet nicht." + "\r\n"
                      + "Wenn Sie auf Neustart klicken, wird die Wallet gestoppt und gestartet." + "\r\n" + "\r\n"
                      + "Viel Spaß ^^";

            }

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
