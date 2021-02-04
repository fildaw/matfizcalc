using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using org.mariuszgromada.math.mxparser;

namespace ProgramMatFiz
{
    
    public partial class Form1 : Form
    {
        class Wzor
        {
            public string wzor;
            public string[] zaleznosci;

            public Wzor(string wzor, string[] zaleznosci)
            {
                this.wzor = wzor;
                this.zaleznosci = zaleznosci;
            }
        }

        Dictionary<string, Wzor[]> zmiennaWzory = new Dictionary<string, Wzor[]>();
        Dictionary<string, double> zmiennaWynik;

        TrigonometricCalc trigCalc;
        QuadraticCalc quadCalc;

        List<String> aktualneSzukane;

        public Form1()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


            Wzor[] v0_wzory = { new Wzor("sqrt(vx^2+vy^2)", new string[] { "vx", "vy" }), new Wzor("vy/sin", new string[] { "vy", "sin" }), new Wzor("vx/cos", new string[] { "vx", "cos" }) };
            Wzor[] vx_wzory = { new Wzor("sqrt(v0^2-vy^2)", new string[] { "v0", "vy" }), new Wzor("v0*cos", new string[] { "v0", "cos" }), new Wzor("vy/tg", new string[] { "vy", "tg" }), new Wzor("ctg*vy", new string[] { "ctg", "vy" }) };
            Wzor[] vy_wzory = { new Wzor("sqrt(v0^2-vx^2)", new string[] { "v0", "vx" }), new Wzor("v0*sin", new string[] { "v0", "sin" }), new Wzor("vx*tg", new string[] { "vx", "tg" }), new Wzor("vx/ctg", new string[] { "vx", "ctg" }) };
            Wzor[] sin_wzor = { new Wzor("vy/v0", new string[] { "vy", "v0" }) };
            Wzor[] cos_wzor = { new Wzor("vx/v0", new string[] { "vx", "v0" }) };
            Wzor[] tg_wzor = { new Wzor("vy/vx", new string[] { "vy", "vx" }) };
            Wzor[] ctg_wzor = { new Wzor("vx/vy", new string[] { "vx", "vy" }) };

            zmiennaWzory["v0"] = v0_wzory;
            zmiennaWzory["vx"] = vx_wzory;
            zmiennaWzory["vy"] = vy_wzory;
            zmiennaWzory["sin"] = sin_wzor;
            zmiennaWzory["cos"] = cos_wzor;
            zmiennaWzory["tg"] = tg_wzor;
            zmiennaWzory["ctg"] = ctg_wzor;

            mXparser.setDegreesMode();
            InitializeComponent();
            trigCalc = new TrigonometricCalc(this);
            quadCalc = new QuadraticCalc(this);
        }

        void solveTrigByAlpha()
        {
            if (zmiennaWynik.ContainsKey("alpha"))
            {
                Expression sin = new Expression("sin(" + zmiennaWynik["alpha"] + ")");
                zmiennaWynik["sin"] = sin.calculate();
                Expression cos = new Expression("cos(" + zmiennaWynik["alpha"] + ")");
                zmiennaWynik["cos"] = cos.calculate();
                Expression tg = new Expression("tg(" + zmiennaWynik["alpha"] + ")");
                zmiennaWynik["tg"] = tg.calculate();
                Expression ctg = new Expression("ctg(" + zmiennaWynik["alpha"] + ")");
                zmiennaWynik["ctg"] = ctg.calculate();
            }
        }

        string replaceAll(string wzor)
        {
            if (zmiennaWynik.ContainsKey("v0")) {
                wzor = wzor.Replace("v0", zmiennaWynik["v0"] + "");
            }

            if (zmiennaWynik.ContainsKey("vx"))
            {
                wzor = wzor.Replace("vx", zmiennaWynik["vx"] + "");
            }

            if (zmiennaWynik.ContainsKey("vy"))
            {
                wzor = wzor.Replace("vy", zmiennaWynik["vy"] + "");
            }

            if (zmiennaWynik.ContainsKey("sin"))
            {
                wzor = wzor.Replace("sin", zmiennaWynik["sin"] + "");
            }

            if (zmiennaWynik.ContainsKey("cos"))
            {
                wzor = wzor.Replace("cos", zmiennaWynik["cos"] + "");
            }

            if (zmiennaWynik.ContainsKey("tg"))
            {
                wzor = wzor.Replace("tg", zmiennaWynik["tg"] + "");
            }

            if (zmiennaWynik.ContainsKey("ctg"))
            {
                wzor = wzor.Replace("ctg", zmiennaWynik["ctg"] + "");
            }

            return wzor;
        }

        double calculateVariable(Wzor[] wzory)
        {
            foreach (Wzor wzor in wzory)
            {
                string[] zaleznosci = wzor.zaleznosci;
                Boolean allDepsFound = true;
                foreach (string zaleznosc in zaleznosci)
                {
                    if (!zmiennaWynik.ContainsKey(zaleznosc))
                    {
                        double ret = solveVar(zaleznosc);
                        if (!isRealNumber(ret))
                        {
                            allDepsFound = false;
                            break;
                        }
                        else
                        {
                            zmiennaWynik[zaleznosc] = ret;
                        }
                    }
                }

                if (allDepsFound)
                {
                    string wzorReplaced = replaceAll(wzor.wzor);
                    return new Expression(wzorReplaced).calculate();
                }
            }

            return double.NaN;
        }

        double solveVar(string variable)
        {
            if (!aktualneSzukane.Contains(variable) && !zmiennaWynik.ContainsKey(variable))
            {
                aktualneSzukane.Add(variable);
                Wzor[] wzory_v0 = zmiennaWzory[variable];

                double wynik = calculateVariable(wzory_v0);
                if (isRealNumber(wynik))
                {
                    zmiennaWynik[variable] = wynik;
                    return wynik;
                }
            }

            return double.NaN;
        }

        double solveAlpha()
        {
            double wynik = double.NaN;
            if (zmiennaWynik.ContainsKey("sin"))
            {
                wynik = new Expression("asin(" + zmiennaWynik["sin"] + ")").calculate();
                zmiennaWynik["alpha"] = wynik;
            }
            else if (zmiennaWynik.ContainsKey("cos"))
            {
                wynik = new Expression("acos(" + zmiennaWynik["cos"] + ")").calculate();
                zmiennaWynik["alpha"] = wynik;
            }
            else if (zmiennaWynik.ContainsKey("tg"))
            {
                wynik = new Expression("atg(" + zmiennaWynik["tg"] + ")").calculate();
                zmiennaWynik["alpha"] = wynik;
            }
            else if (zmiennaWynik.ContainsKey("ctg"))
            {
                wynik = new Expression("actg(" + zmiennaWynik["ctg"] + ")").calculate();
                zmiennaWynik["alpha"] = wynik;
            }

            return wynik;
        }

        bool isRealNumber(double d)
        {
            return !Double.IsNaN(d) && !Double.IsInfinity(d);
        }

        void preCheckEnteredValues()
        {
            if (zmiennaWynik.ContainsKey("v0") && zmiennaWynik.ContainsKey("vx") && zmiennaWynik.ContainsKey("vy"))
            {
                if (zmiennaWynik["vx"]*zmiennaWynik["vx"] + zmiennaWynik["vy"]*zmiennaWynik["vy"] != zmiennaWynik["v0"]*zmiennaWynik["v0"])
                {
                    MessageBox.Show("Uwaga: vx^2+vy^2 ≠ v0^2 - twierdzenie Pitagorasa nie zachodzi dla podanych danych!\r\n\r\nSprawdź ponownie wpisane dane\r\n\r\nMoże być to kwestia zaokrągleń, jednak w takim przypadku program może nie zwrócić dokładnych wyników!");
                }
            }

            if (zmiennaWynik.ContainsKey("sin"))
            {
                if (zmiennaWynik["sin"] > 1 || zmiennaWynik["sin"] < 0)
                {
                    MessageBox.Show("Wartość sin 𝛼 powinna się zawierać w przedziale [0, 1]!");
                }
            }

            if (zmiennaWynik.ContainsKey("cos"))
            {
                if (zmiennaWynik["cos"] > 1 || zmiennaWynik["cos"] < 0)
                {
                    MessageBox.Show("Wartość cos 𝛼 powinna się zawierać w przedziale [0, 1]!");
                }
            }

            if (zmiennaWynik.ContainsKey("alpha"))
            {
                if (zmiennaWynik["alpha"] > 90 || zmiennaWynik["alpha"] < 0)
                {
                    MessageBox.Show("Wartość kąta 𝛼 powinna się zawierać w przedziale [0°, 90°]!");
                }
            }

        }

        public void resetAktualneSzukane()
        {
            aktualneSzukane.Clear();
        }

        private void calc1_Click(object sender, EventArgs e)
        {
            zmiennaWynik = new Dictionary<string, double>();
            aktualneSzukane = new List<String>();
            try
            {
                if (vx_box.TextLength > 0)
                {
                    zmiennaWynik["vx"] = Math.Abs(Convert.ToDouble(vx_box.Text));
                }

                if (vy_box.TextLength > 0)
                {
                    zmiennaWynik["vy"] = Math.Abs(Convert.ToDouble(vy_box.Text));
                }

                if (v0_box.TextLength > 0)
                {
                    zmiennaWynik["v0"] = Math.Abs(Convert.ToDouble(v0_box.Text));
                }

                if (sin_box.TextLength > 0)
                {
                    zmiennaWynik["sin"] = Convert.ToDouble(sin_box.Text);
                }

                if (cos_box.TextLength > 0)
                {
                    zmiennaWynik["cos"] = Convert.ToDouble(cos_box.Text);
                }

                if (tg_box.TextLength > 0)
                {
                    zmiennaWynik["tg"] = Convert.ToDouble(tg_box.Text);
                }

                if (ctg_box.TextLength > 0)
                {
                    zmiennaWynik["ctg"] = Convert.ToDouble(ctg_box.Text);
                }

                if (alpha_box.TextLength > 0)
                {
                    zmiennaWynik["alpha"] = Convert.ToDouble(alpha_box.Text);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            preCheckEnteredValues();

            solveTrigByAlpha();
            solveVar("v0");
            resetAktualneSzukane();
            solveVar("vx");
            resetAktualneSzukane();
            solveVar("vy");
            resetAktualneSzukane();
            solveVar("sin");
            resetAktualneSzukane();
            solveVar("cos");
            resetAktualneSzukane();
            solveVar("tg");
            resetAktualneSzukane();
            solveVar("ctg");
            resetAktualneSzukane();
            if (!zmiennaWynik.ContainsKey("alpha"))
            {
                solveAlpha();
            }
            
            foreach (string zmienna in zmiennaWynik.Keys)
            {
                if (zmienna.Equals("v0") && isRealNumber(zmiennaWynik["v0"]))
                {
                    v0_box.Text = zmiennaWynik["v0"] + "";
                }
                else if (zmienna.Equals("vx") && isRealNumber(zmiennaWynik["vx"]))
                {
                    vx_box.Text = zmiennaWynik["vx"] + "";
                }
                else if (zmienna.Equals("vy") && isRealNumber(zmiennaWynik["vy"]))
                {
                    vy_box.Text = zmiennaWynik["vy"] + "";
                }
                else if (zmienna.Equals("sin") && isRealNumber(zmiennaWynik["sin"]))
                {
                    sin_box.Text = zmiennaWynik["sin"] + "";
                }
                else if (zmienna.Equals("cos") && isRealNumber(zmiennaWynik["cos"]))
                {
                    cos_box.Text = zmiennaWynik["cos"] + "";
                }
                else if (zmienna.Equals("tg") && isRealNumber(zmiennaWynik["tg"]))
                {
                    tg_box.Text = zmiennaWynik["tg"] + "";
                }
                else if (zmienna.Equals("ctg") && isRealNumber(zmiennaWynik["ctg"]))
                {
                    ctg_box.Text = zmiennaWynik["ctg"] + "";
                }
                else if (zmienna.Equals("alpha") && isRealNumber(zmiennaWynik["alpha"]))
                {
                    alpha_box.Text = zmiennaWynik["alpha"] + "";
                }
            }
            v0_box.ReadOnly = true;
            vx_box.ReadOnly = true;
            vy_box.ReadOnly = true;
            sin_box.ReadOnly = true;
            cos_box.ReadOnly = true;
            tg_box.ReadOnly = true;
            ctg_box.ReadOnly = true;
            alpha_box.ReadOnly = true;

            calc1.Enabled = false;
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            v0_box.Clear();
            vx_box.Clear();
            vy_box.Clear();
            sin_box.Clear();
            cos_box.Clear();
            tg_box.Clear();
            ctg_box.Clear();
            alpha_box.Clear();

            v0_box.ReadOnly = false;
            vx_box.ReadOnly = false;
            vy_box.ReadOnly = false;
            sin_box.ReadOnly = false;
            cos_box.ReadOnly = false;
            tg_box.ReadOnly = false;
            ctg_box.ReadOnly = false;
            alpha_box.ReadOnly = false;

            calc1.Enabled = true;
        }

        private void help_vectors_Click(object sender, EventArgs e)
        {
            Wektory_help wh = new Wektory_help();
            wh.Show();
        }

        private void angle_unit_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trigCalc != null)
            {
                trigCalc.angle_unit_selector_SelectedIndexChanged(sender, e);
            }
            
        }

        private void solve_trig_Click(object sender, EventArgs e)
        {
            if (trigCalc != null)
            {
                trigCalc.solve_trig_Click(sender, e);
            }
            
        }

        private void clear_trig_Click(object sender, EventArgs e)
        {
            if (trigCalc != null)
            {
                trigCalc.clear_trig_Click(sender, e);
            }
        }

        private void help_trig_Click(object sender, EventArgs e)
        {
            if (trigCalc != null)
            {
                trigCalc.help_trig_Click(sender, e);
            }
        }

        private void solve_quadratic_Click(object sender, EventArgs e)
        {
            if (quadCalc != null)
            {
                quadCalc.solve_quadratic_Click(sender, e);
            }
        }

        private void clear_quadratic_Click(object sender, EventArgs e)
        {
            if (quadCalc != null)
            {
                quadCalc.clear_quadratic_Click(sender, e);
            }
        }

        private void quad_result_Enter(object sender, EventArgs e)
        {
            if (quadCalc != null)
            {
                quadCalc.quad_result_Enter(sender, e);
            }
        }

        private void help_quadratic_Click(object sender, EventArgs e)
        {
            HelpQuadratic hq = new HelpQuadratic();
            hq.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wolframalpha.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.geogebra.org/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://matematykaszkolna.pl/"); 
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://oeis.org"); 
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cke.gov.pl/images/_EGZAMIN_MATURALNY_OD_2015/Informatory/2015/MATURA_2015_Wybrane_wzory_matematyczne.pdf"); 
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.pl/"); 
        }

        private void obliczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    calc1_Click(sender, e);
                    break;
                case 1:
                    solve_trig_Click(sender, e);
                    break;
                case 2:
                    solve_quadratic_Click(sender, e);
                    break;
            }
        }

        private void czyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    clear1_Click(sender, e);
                    break;
                case 1:
                    clear_trig_Click(sender, e);
                    break;
                case 2:
                    clear_quadratic_Click(sender, e);
                    break;
            }
        }

        private void pomocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    help_vectors_Click(sender, e);
                    break;
                case 1:
                    help_trig_Click(sender, e);
                    break;
                case 2:
                    help_quadratic_Click(sender, e);
                    break;
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void obliczToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            obliczToolStripMenuItem_Click(sender, e);
        }

        private void czyśćToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            czyśćToolStripMenuItem_Click(sender, e);
        }

        private void pomocToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pomocToolStripMenuItem1_Click(sender, e);
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2021 Filip Dawidowski @ VLO Gdańsk");
        }
    }
}
