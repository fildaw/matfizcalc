using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

using org.mariuszgromada.math.mxparser;

namespace ProgramMatFiz
{
    class TrigonometricCalc
    {
        Form1 mainRef;
        int lastSelectedIndex;

        public TrigonometricCalc(Form1 f)
        {
            mainRef = f;
            mainRef.angle_unit_selector.DropDownStyle = ComboBoxStyle.DropDownList;
            mainRef.angle_unit_selector.SelectedIndex = 0;
            lastSelectedIndex = 0;
        }

        private double degreesToRad(double degrees)
        {
            return (Math.PI * degrees) / 180;
        }

        private double radToDegrees(double rad)
        {
            return (rad * 180) / Math.PI;
        }

        private void disableControls()
        {
            mainRef.angle_unit_selector.Enabled = false;
            mainRef.solve_trig.Enabled = false;

            mainRef.alpha_box_trig.ReadOnly = true;
            mainRef.sin_box_trig.ReadOnly = true;
            mainRef.cos_box_trig.ReadOnly = true;
            mainRef.tg_box_trig.ReadOnly = true;
            mainRef.ctg_box_trig.ReadOnly = true;
        }

        private void enableControls()
        {
            mainRef.angle_unit_selector.Enabled = true;
            mainRef.solve_trig.Enabled = true;

            mainRef.alpha_box_trig.ReadOnly = false;
            mainRef.sin_box_trig.ReadOnly = false;
            mainRef.cos_box_trig.ReadOnly = false;
            mainRef.tg_box_trig.ReadOnly = false;
            mainRef.ctg_box_trig.ReadOnly = false;
        }

        bool isRealNumber(double d)
        {
            return !Double.IsNaN(d) && !Double.IsInfinity(d);
        }

        private void solveTrigByAlpha(bool radSelected)
        {
            if (mainRef.alpha_box_trig.TextLength > 0) //Jeśli wartość kąta alfa jest podana, obliczamy wartości funkcji trygonometrycznych
            {
                double degreeValue;
                if (radSelected)
                {
                    degreeValue = radToDegrees(Convert.ToDouble(mainRef.alpha_box_trig.Text));
                }
                else
                {
                    degreeValue = Convert.ToDouble(mainRef.alpha_box_trig.Text);
                }
                if (mainRef.sin_box_trig.TextLength == 0)
                {
                    double sin = new Expression("sin(" + degreeValue + ")").calculate();
                    if (isRealNumber(sin))
                    {
                        mainRef.sin_box_trig.Text = sin + "";
                    }
                        
                }

                if (mainRef.cos_box_trig.TextLength == 0)
                {
                    double cos = new Expression("cos(" + degreeValue + ")").calculate();
                    if (isRealNumber(cos))
                    {
                        mainRef.cos_box_trig.Text = cos + "";
                    }
                        
                }

                if (mainRef.tg_box_trig.TextLength == 0)
                {
                    double tg = new Expression("tg(" + degreeValue + ")").calculate();
                    if (isRealNumber(tg))
                    {
                        mainRef.tg_box_trig.Text = tg + "";
                    }
                        
                }

                if (mainRef.ctg_box_trig.TextLength == 0)
                {
                    double ctg = new Expression("ctg(" + degreeValue + ")").calculate();
                    if (isRealNumber(ctg))
                    {
                        mainRef.ctg_box_trig.Text = ctg + "";
                    }
                        
                }

            }
        }

        public void solve_trig_Click(object sender, EventArgs e)
        {
            bool radSelected;
            if (mainRef.angle_unit_selector.SelectedIndex == 0)
            {
                radSelected = false;
            } else
            {
                radSelected = true;
            }
            try
            {
                double alpha = Double.NaN;
                if (mainRef.sin_box_trig.TextLength > 0)
                {
                    alpha = new Expression("asin(" + Convert.ToDouble(mainRef.sin_box_trig.Text) + ")").calculate();
                } else if (mainRef.cos_box_trig.TextLength > 0)
                {
                    alpha = new Expression("acos(" + Convert.ToDouble(mainRef.cos_box_trig.Text) + ")").calculate();
                } else if (mainRef.tg_box_trig.TextLength > 0)
                {
                    alpha = new Expression("atg(" + Convert.ToDouble(mainRef.tg_box_trig.Text) + ")").calculate();
                } else if (mainRef.ctg_box_trig.TextLength > 0)
                {
                    alpha = new Expression("actg(" + Convert.ToDouble(mainRef.ctg_box_trig.Text) + ")").calculate();
                }

                if (isRealNumber(alpha))
                {
                    if (radSelected)
                    {
                        mainRef.alpha_box_trig.Text = degreesToRad(alpha) + "";
                    }
                    else
                    {
                        mainRef.alpha_box_trig.Text = alpha + "";
                    }
                }
                solveTrigByAlpha(radSelected);


                disableControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void angle_unit_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nowSelectedIndex = mainRef.angle_unit_selector.SelectedIndex;
            if (lastSelectedIndex == nowSelectedIndex)
            { //Wybrany index tak naprawdę nie zmienił się
                return;
            }
            if (mainRef.alpha_box_trig.TextLength > 0)
            {
                if (nowSelectedIndex == 0) //From rad to degrees (zostały ustawione stopnie)
                {
                    try
                    {
                        double rad = Convert.ToDouble(mainRef.alpha_box_trig.Text);
                        mainRef.alpha_box_trig.Text = radToDegrees(rad) + "";
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        mainRef.angle_unit_selector.SelectedIndex = 1;
                    }
                } else if (nowSelectedIndex == 1) //From degrees to rad
                {
                    try
                    {
                        double degree = Convert.ToDouble(mainRef.alpha_box_trig.Text);
                        mainRef.alpha_box_trig.Text = degreesToRad(degree) + "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        mainRef.angle_unit_selector.SelectedIndex = 0;
                    }
                }  
            }
            lastSelectedIndex = nowSelectedIndex;
        }

        public void clear_trig_Click(object sender, EventArgs e)
        {
            enableControls();
            mainRef.angle_unit_selector.SelectedIndex = 0;
            lastSelectedIndex = 0;

            mainRef.alpha_box_trig.Text = "";
            mainRef.sin_box_trig.Text = "";
            mainRef.cos_box_trig.Clear();
            mainRef.tg_box_trig.Clear();
            mainRef.ctg_box_trig.Clear();
        }

        public void help_trig_Click(object sender, EventArgs e)
        {
            HelpTrig ht = new HelpTrig();
            ht.Show();
        }
    }
}
