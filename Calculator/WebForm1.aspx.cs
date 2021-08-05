using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    

    public partial class WebForm1 : System.Web.UI.Page
    {
        String mem1;
        String mem2;
        String x;


        public double raiz(double num1)
        {
            double res = Math.Sqrt(num1);
            return res;
        }
        
        public double al_cuadrado(double num1)
        {
            double res = Math.Pow(num1,2);
            return res;
        }

        public double log_nat(double num1)
        {
            double res = Math.Log(num1);
            return res;
        }
        public double sen(double num1)
        {
            double res = Math.Sin(num1);
            return res;
        }

        public double cos(double num1)
        {
            double res = Math.Cos(num1);
            return res;
        }

        public double sumar(double num1, double num2)
        {

            double res = num1 + num2;
            return res;

        }

        public double restar(double num1, double num2)
        {

            double res = num1 - num2;
            return res;

        }

        public double multiplicar(double num1, double num2)
        {

            double res = num1 * num2;
            return res;

        }

        public double dividir(double num1, double num2)
        {

            double res = num1 / num2;
            return res;

        }


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }

            x = TextBox2.Text;
            x = Convert.ToString(ViewState["opc"]);

            mem1 = Convert.ToString(ViewState["mem1S"]);

            //ViewState["resta"] = TextBox1.Text;
            //ViewState["div"] = TextBox1.Text;
            //ViewState["x"] = TextBox1.Text;

        }

        protected void Btn_1_Click(object sender, EventArgs e) // Boton # 1
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "1";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "1";
            }


        }




        protected void Btn_2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "2";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "2";
            }

        }

        protected void Btn_3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "3";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "3";
            }

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "4";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "4";
            }

        }

        protected void Btn_5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "5";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "5";
            }

        }

        protected void Btn_6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "6";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "6";
            }

        }

        protected void Btn_7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "7";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "7";
            }

        }

        protected void Btn_8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "8";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "8";
            }

        }

        protected void Btn_9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "9";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "9";
            }

        }

        protected void Button16_Click(object sender, EventArgs e) // Boton #0
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
                TextBox1.Text = "0";

            }
            else
            {
                TextBox1.Text = TextBox1.Text + "0";
            }
        }

        protected void Btn_igu_Click(object sender, EventArgs e)
        {
            mem2 = TextBox1.Text;
            x = TextBox2.Text;
           
            switch (x)
            {
                case "+":

                    double x = Convert.ToDouble(mem1);
                    double y = Convert.ToDouble(mem2);
                    double res = sumar(x, y);

                    String cadena = Convert.ToString(res);
                    TextBox3.Text = cadena;

                    break;

                case "-":

                    double x_2 = Convert.ToDouble(mem1);
                    double y_2 = Convert.ToDouble(mem2);
                    double res_2 = restar(x_2, y_2);

                    String cadena_2 = Convert.ToString(res_2);
                    TextBox3.Text = cadena_2;

                    break;

                case "x":

                    double x_3 = Convert.ToDouble(mem1);
                    double y_3 = Convert.ToDouble(mem2);
                    double res_3 = multiplicar(x_3, y_3);

                    String cadena_3 = Convert.ToString(res_3);
                    TextBox3.Text = cadena_3;

                    break;

                case "/":

                    double x_4 = Convert.ToDouble(mem1);
                    double y_4 = Convert.ToDouble(mem2);

                    if(y_4 == 0)
                    {
                        TextBox3.Text = "No se puede dividir entre 0 lampara :v";
                    }
                    else
                    {
                        double res_4 = dividir(x_4, y_4);
                        String cadena_4 = Convert.ToString(res_4);
                        TextBox3.Text = cadena_4;
                    }
                    
                                    

                    break;

            }
        }

        protected void Btn_sum_Click(object sender, EventArgs e)
        {
            ViewState["mem1S"] = TextBox1.Text;
            TextBox2.Text = "+";
            TextBox1.Text = "";

        }

        protected void Btn_men_Click(object sender, EventArgs e)
        {
            ViewState["mem1S"] = TextBox1.Text;
            TextBox2.Text = "-";
            TextBox1.Text = "";
        }

        protected void Btn_div_Click(object sender, EventArgs e)
        {
            ViewState["mem1S"] = TextBox1.Text;
            TextBox2.Text = "/";
            TextBox1.Text = "";
        }

       protected void Button5_Click(object sender, EventArgs e)// Boton AC de borrado total
        {
            TextBox1.Text = "0";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Btn_x_Click(object sender, EventArgs e)
        {
            ViewState["mem1S"] = TextBox1.Text;
            TextBox2.Text = "x";
            TextBox1.Text = "";
        }

        protected void Btn_raiz_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["mem1S"] = TextBox1.Text;
            TextBox2.Text = ("sqrt (" + ViewState["mem1S"] + ")");

            double x = Convert.ToDouble(ViewState["mem1S"]);

            if(x < 0)
            {
                TextBox3.Text = "Entrada invalida lampara :v";
            }
            else
            {
                double res = raiz(x);
                TextBox3.Text = Convert.ToString(res);
            }
        }

        protected void Btn_al_cuad_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["mem1S"] = TextBox1.Text;
            TextBox2.Text = ("(" + ViewState["mem1S"] + ")^2");

            double x = Convert.ToDouble(ViewState["mem1S"]);

            double res = al_cuadrado(x);
            TextBox3.Text = Convert.ToString(res);
        }

        protected void Btn_Log_Click(object sender, EventArgs e)
        {
            ViewState["mem1S"] = TextBox1.Text;
            TextBox2.Text = ("Ln (" + ViewState["mem1S"] + ")");

            double x = Convert.ToDouble(ViewState["mem1S"]);

            if (x <= 0)
            {
                TextBox3.Text = "Entrada invalida lampara :v";
            }
            else
            {
                double res = log_nat(x);
                TextBox3.Text = Convert.ToString(res);
            }
        }

        protected void Btn_sen_Click(object sender, EventArgs e)
        {
            ViewState["mem1S"] = TextBox1.Text;
            TextBox2.Text = ("sen (" + ViewState["mem1S"] + ")");

            double x = Convert.ToDouble(ViewState["mem1S"]);

            double res = sen(x);
            TextBox3.Text = ("Rad "+ Convert.ToString(res));
        }

        protected void Btn_cos_Click(object sender, EventArgs e)
        {
            ViewState["mem1S"] = TextBox1.Text;
            TextBox2.Text = ("cos (" + ViewState["mem1S"] + ")");

            double x = Convert.ToDouble(ViewState["mem1S"]);

            double res = cos(x);
            TextBox3.Text = ("Rad " + Convert.ToString(res));
        }

        protected void Btn_pun_Click(object sender, EventArgs e)
        {
            String x = TextBox1.Text;
            
            if (x.Contains("."))
            {
                TextBox1.Text = TextBox1.Text + "";
            }

            else
            {
                TextBox1.Text = TextBox1.Text + ".";
            }

        }

        protected void Btn_DEL_Click(object sender, EventArgs e)
        {
            String x = TextBox1.Text;
            
            int size = x.Length;

            TextBox1.Text = x.Remove(size-1, 1);
        }

        protected void Btn_pi_Click(object sender, EventArgs e)// Boton de signo
        {
            String x = TextBox1.Text;

            if (x.Contains("-"))
            {
                x = x.Replace("-", "");
                TextBox1.Text = x;
            }
            else
            {
                TextBox1.Text = ("-" + TextBox1.Text);
                
            }
        }
    }
}