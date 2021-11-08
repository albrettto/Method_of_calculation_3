using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method_of_calculation_3
{
    public partial class Main_Form : Form
    {
        double J, h;
        double eps = 1e-6;
        int n, k = 4;
        public Main_Form()
        {

            InitializeComponent();

        }

        public double funct(double x)
        {
            if (rd_Btn1.Checked)
                return 6 * Math.Pow(x, 5);
            else
                return Math.Pow(x, (1.0 / 30.0)) * Math.Sqrt(1 + Math.Pow(x, 2));
        }

        public double calcParabol(double h, double a, double b)
        {
            double sum = 0;
            sum = sum + funct(a) + funct(b);
            double S = 0;
            for (int i = 1; i < (b - a) / h; i++)
            {
                S += funct(i * h + a);
            }
            sum += 2 * S;
            S = 0;
            for (int i = 0; i < (b - a) / h; i++)
            {
                S += funct(i * h + a + h / 2);
            }
            sum += 4 * S;
            sum *= h / 6;
            return sum;
        }
        public double calcKD(double h, double a, double b)
        {
            return (calcParabol((h / 2), a, b) - calcParabol(h, a, b)) / (calcParabol((h / 4), a, b) - calcParabol((h / 2), a, b));
        }
        public double calcDR(double h, double a, double b)
        {
            return (calcParabol(h / 2, a, b) - calcParabol(h, a, b)) / (Math.Pow(2, k) - 1);
        }
        public double calcDT(double h, double c)
        {
            return c * Math.Pow(h, k);
        }
        public double calcDE(double h, double a, double b)
        {
            return J - calcParabol(h, a, b);
        }
        private void Result_btn_Click(object sender, EventArgs e)
        {
            double a, b;
            dtGdVw.Rows.Clear();
            if (rd_Btn1.Checked)
            {
                a = 0;
                b = 1;
                J = 1;
                double c = 1.0 / 4;

                for (n = 1; n <= 65536; n *= 2)
                {
                    h = (b - a) / n;
                    dtGdVw.Rows.Add(n, calcKD(h * 4, a, b), calcDE(h, a, b), calcDR(h * 2, a, b), calcDT(h, c));

                    if (n == 1)
                    {
                        dtGdVw.Rows[0].Cells[1].Value = "-";
                        dtGdVw.Rows[0].Cells[3].Value = "-";
                    }
                    if (n == 2)
                        dtGdVw.Rows[1].Cells[1].Value = "-";
                }
            }

            else
            {
                if (rd_Btn2.Checked)
                {
                    a = 0;
                    b = 1.5;
                    for (n = 2; Math.Abs(calcDR(((b - a) * 2 / n), a, b)) >= eps; n *= 2)
                    {
                        h = (b - a) / n;
                        dtGdVw.Rows.Add(n, calcKD(h * 4, a, b), "-", calcDR(h * 2, a, b), "-");
                        if (n == 2)
                            dtGdVw.Rows[0].Cells[1].Value = "-";
                    }
                }

                if (rd_Btn3.Checked)
                {
                    a = 0.001;
                    b = 1.5;
                    for (n = 2; Math.Abs(calcDR(((b - a) * 2 / n), a, b)) >= eps; n *= 2)
                    {
                        h = (b - a) / n;
                        dtGdVw.Rows.Add(n, calcKD(h * 4, a, b), "-", calcDR(h * 2, a, b), "-");
                        if (n == 2)
                            dtGdVw.Rows[0].Cells[1].Value = "-";
                    }
                }
            }
        }
    }
}
