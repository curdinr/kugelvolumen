using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testprüfung
{
    public partial class CKugelDlg : Form
    {
        int m_intAnzahlBerechnungen = 0;
        public CKugelDlg()
        {
            InitializeComponent();
            txtAnzahl.Enabled = false;
            txtSchnittflaeche.Enabled = false;
            txtUmfang.Enabled = false;
            txtVolumen.Enabled = false;
        }

        // Methode UmfangBerechnen
        private double UmfangBerechnen(double dblRadius)
        {
            double dblUmfang;
            dblUmfang = 2 * dblRadius * Math.PI;
            return dblUmfang;
        }

        // Methode SchnittflächeBerechnen
        private double SchnittflaecheBerechnen(double dblRadius)
        {
            double dblSchnittflaeche;
            dblSchnittflaeche = Math.Pow(dblRadius, 2.0) * Math.PI;
            return dblSchnittflaeche;
        }

        // Methode KugelvolumenBerechnen
        private double KugelvolumenBerechnen(double dblRadius)
        {
            double dblKugelvolumen;
            dblKugelvolumen = 4.0 / 3.0 * Math.Pow(dblRadius, 3.0) * Math.PI;
            return dblKugelvolumen;
        }

        // Methode CheckRadiusEingabe
        private bool CheckRadiusEingabe(ref TextBox objTextBox, out double dblRadius)
        {
            string strValue = objTextBox.Text;
            bool bWertValid = double.TryParse(strValue, out dblRadius);
            if (bWertValid == false && !string.IsNullOrEmpty(strValue))
            {
                MessageBox.Show($"Die Eingabe des Radius ist nicht korrekt: '{strValue}'", "Benutzereingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                objTextBox.Focus();
                objTextBox.SelectAll();
                return false;
            }

            //double.TryParse(strTextbox, out dblRadius);
            return true;
        }


        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRadiusEingabe(ref txtRadius, out double dblRadius) == true)
                {
                    m_intAnzahlBerechnungen++;
                    txtUmfang.Text = UmfangBerechnen(dblRadius).ToString();
                    txtSchnittflaeche.Text = SchnittflaecheBerechnen(dblRadius).ToString();
                    txtVolumen.Text = KugelvolumenBerechnen(dblRadius).ToString();
                    txtAnzahl.Text = m_intAnzahlBerechnungen.ToString();
                }
                //else
                //{
                //    txtRadius.Focus();
                //    txtRadius.SelectAll();
                //}
            }

            catch (OverflowException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie die Applikation wirklich schliessen?", "Applikation schliessen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
    
}
