using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
    abstract class Triangle
    {
        protected double edgeA;
        protected double edgeB;
        protected double angleBetweenAB;

        protected double FindEdgeByLawOfCosine(double oppositeAngleToEdge, double sideEdge1, double sideEdge2)
        {
            double gamma = oppositeAngleToEdge * Math.PI / 180;
            double a = sideEdge1;
            double b = sideEdge2;
            return Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(gamma));
        }

        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual double CalculatePerimeter()
        {
            return 0;
        }
    }

    class RightTriangle : Triangle
    {
        private new double edgeA;
        private new double edgeB;
        private new double angleBetweenAB;

        public new double CalculateArea()
        {
            return edgeA * edgeB * Math.Sin(angleBetweenAB * Math.PI / 180);
        }

        public new double CalculatePerimeter()
        {
            return edgeA + edgeB + FindEdgeByLawOfCosine(angleBetweenAB, edgeA, edgeB);
        }

        public void ChangeEdgeA(double newEdgeA)
        {
            edgeA = newEdgeA;
        }

        public void ChangeEdgeB(double newEdgeB)
        {
            edgeB = newEdgeB;
        }

        public void ChangeAngleBetweenAB(double newAngleBetweenAB)
        {
            angleBetweenAB = newAngleBetweenAB;
        }

        public bool CheckExistence()
        {
            double a = edgeA;
            double b = edgeB;
            double c = FindEdgeByLawOfCosine(angleBetweenAB, edgeA, edgeB);
            
            double TOLERANCE = 0.001;
            return ((Math.Abs(a * a - (b * b + c * c)) < TOLERANCE) ||
                    (Math.Abs(b * b - (a * a + c * c)) < TOLERANCE) ||
                    (Math.Abs(c * c - (a * a + b * b)) < TOLERANCE)) &&
                   (a > 0) &&
                   (b > 0) && 
                   (c > 0);
        }
    }

    class IsoscelesTriangle : Triangle
    {
        private new double edgeA;
        private new double edgeB;
        private new double angleBetweenAB;

        public new double CalculateArea()
        {
            return edgeA * edgeB * Math.Sin(angleBetweenAB * Math.PI / 180);
        }

        public new double CalculatePerimeter()
        {
            return edgeA + edgeB + FindEdgeByLawOfCosine(angleBetweenAB, edgeA, edgeB);
        }

        public void ChangeEdgeA(double newEdgeA)
        {
            edgeA = newEdgeA;
        }

        public void ChangeEdgeB(double newEdgeB)
        {
            edgeB = newEdgeB;
        }

        public void ChangeAngleBetweenAB(double newAngleBetweenAB)
        {
            angleBetweenAB = newAngleBetweenAB;
        }
        public bool CheckExistence()
        {
            double a = edgeA;
            double b = edgeB;
            double c = FindEdgeByLawOfCosine(angleBetweenAB, edgeA, edgeB);
            return ((a+b)>c || (a+c)>b || (b+c)>a) && (a > 0) &&
                   (b > 0) && (c > 0) && ((a==b)||(b==c)||(a==c));
        }
    }

    public partial class Form1 : Form
    {
        private string _lastComboBoxIndex;
        private RightTriangle rightTriangle1 = new RightTriangle();
        private IsoscelesTriangle isoscelesTriangle1 = new IsoscelesTriangle();

        public Form1()
        {
            InitializeComponent();
            lblAngle.Hide();
            lblEdgeA.Hide();
            lblEdgeB.Hide();

            txtbxAngle.Hide();
            txtbxEdgeA.Hide();
            txtbxEdgeB.Hide();

            lblArea.Hide();
            lblPerimeter.Hide();
            lblAreaResult.Hide();
            lblPerimeterResult.Hide();
            btnCalculate.Hide();
        }

        private void comboBoxChoseTriangle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lastComboBoxIndex == null)
            {
                lblAngle.Show();
                lblEdgeA.Show();
                lblEdgeB.Show();

                txtbxAngle.Show();
                txtbxEdgeA.Show();
                txtbxEdgeB.Show();

                lblArea.Show();
                lblPerimeter.Show();
                lblAreaResult.Show();
                lblPerimeterResult.Show();
                btnCalculate.Show();
            }

            if (_lastComboBoxIndex != comboBoxChoseTriangle.Text)
            {
                lblAreaResult.Text = "0";
                lblPerimeterResult.Text = "0";

                txtbxAngle.Clear();
                txtbxEdgeA.Clear();
                txtbxEdgeB.Clear();

                _lastComboBoxIndex = comboBoxChoseTriangle.Text;
            }
        }

        private void txtbxEdgeA_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxChoseTriangle.Text)
            {
                case "Isosceles Triangle":
                {
                    if (txtbxEdgeA != null && !string.IsNullOrWhiteSpace(txtbxEdgeA.Text))
                    {
                        isoscelesTriangle1.ChangeEdgeA(Convert.ToDouble(txtbxEdgeA.Text));
                    }

                    break;
                }
                case "Right Triangle":
                {
                    if (txtbxEdgeA != null && !string.IsNullOrWhiteSpace(txtbxEdgeA.Text))
                    {
                        rightTriangle1.ChangeEdgeA(Convert.ToDouble(txtbxEdgeA.Text));
                    }

                    break;
                }
            }
        }

        private void txtbxEdgeB_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxChoseTriangle.Text)
            {
                case "Isosceles Triangle":
                {
                    if (txtbxEdgeB != null && !string.IsNullOrWhiteSpace(txtbxEdgeB.Text))
                    {
                        isoscelesTriangle1.ChangeEdgeB(Convert.ToDouble(txtbxEdgeB.Text));
                    }

                    break;
                }
                case "Right Triangle":
                {
                    if (txtbxEdgeB != null && !string.IsNullOrWhiteSpace(txtbxEdgeB.Text))
                    {
                        rightTriangle1.ChangeEdgeB(Convert.ToDouble(txtbxEdgeB.Text));
                    }

                    break;
                }
            }
        }

        private void txtbxAngle_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxChoseTriangle.Text)
            {
                case "Isosceles Triangle":
                {
                    if (txtbxAngle != null && !string.IsNullOrWhiteSpace(txtbxAngle.Text))
                    {
                        isoscelesTriangle1.ChangeAngleBetweenAB(Convert.ToDouble(txtbxAngle.Text));
                    }

                    break;
                }
                case "Right Triangle":
                {
                    if (txtbxAngle != null && !string.IsNullOrWhiteSpace(txtbxAngle.Text))
                    {
                        rightTriangle1.ChangeAngleBetweenAB(Convert.ToDouble(txtbxAngle.Text));
                    }

                    break;
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            switch (comboBoxChoseTriangle.Text)
            {
                case "Isosceles Triangle":
                {
                    if (isoscelesTriangle1.CheckExistence())
                    {
                        lblAreaResult.Text = isoscelesTriangle1.CalculateArea().ToString("##.##");
                        lblPerimeterResult.Text = isoscelesTriangle1.CalculatePerimeter().ToString("##.##");
                    }
                    else
                    {
                        MessageBox.Show("Isosceles triangle does not exist");
                    }
                    break;
                }
                case "Right Triangle":
                {
                    if (rightTriangle1.CheckExistence())
                    {
                        lblAreaResult.Text = rightTriangle1.CalculateArea().ToString("##.##");
                        lblPerimeterResult.Text = rightTriangle1.CalculatePerimeter().ToString("##.##");
                    }
                    else
                    {
                        MessageBox.Show("Right triangle does not exist");
                    }

                    break;
                }
            }
        }
    }
}
