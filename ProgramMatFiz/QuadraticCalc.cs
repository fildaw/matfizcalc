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
    class QuadraticCalc
    {
        Form1 mainRef;
        public QuadraticCalc(Form1 mainRef)
        {
            this.mainRef = mainRef;
        }

        private void disableControls()
        {
            mainRef.quad_a.ReadOnly = true;
            mainRef.quad_b.ReadOnly = true;
            mainRef.quad_c.ReadOnly = true;


            mainRef.solve_quadratic.Enabled = false;
        }

        private void enableControls()
        {
            mainRef.quad_a.ReadOnly = false;
            mainRef.quad_b.ReadOnly = false;
            mainRef.quad_c.ReadOnly = false;

            mainRef.solve_quadratic.Enabled = true;
        }

        public void solve_quadratic_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;
            try
            {
                a = Convert.ToDouble(mainRef.quad_a.Text);
                b = Convert.ToDouble(mainRef.quad_b.Text);
                c = Convert.ToDouble(mainRef.quad_c.Text);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            double delta = b * b - 4 * a * c;
            mainRef.quad_result.Text += "Δ = b^2-4ac = " + delta + "\r\n";
            if (delta < 0)
            {
                mainRef.quad_result.Text += "Brak rozwiązań (Δ < 0)";
            } else if (delta == 0)
            {
                mainRef.quad_result.Text += "Jedno rozwiązanie (Δ = 0):\r\nx0 = -b/2a = " + (-1*b)/(2*a);
            } else
            {
                double sqrtDelta = Math.Sqrt(delta);
                mainRef.quad_result.Text += "√Δ = " + sqrtDelta + "\r\n\r\nDwa rozwiązania (Δ > 0):\r\n";
                mainRef.quad_result.Text += "x1 = (-b-√Δ)/2a =\r\n= " + (-1 * b - sqrtDelta) / (2 * a) + "\r\n\r\n";
                mainRef.quad_result.Text += "x2 = (-b+√Δ)/2a =\r\n= " + (-1 * b + sqrtDelta) / (2 * a);
            }

            disableControls();
        }

        public void clear_quadratic_Click(object sender, EventArgs e)
        {
            mainRef.quad_a.Clear();
            mainRef.quad_b.Clear();
            mainRef.quad_c.Clear();

            mainRef.quad_result.Clear();

            enableControls();
        }

        public void quad_result_Enter(object sender, EventArgs e)
        {
            mainRef.ActiveControl = mainRef.label1;
        }
    }
}
