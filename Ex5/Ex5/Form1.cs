using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    abstract class Figure
    {
        protected double area;
        protected double perimeter;

        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual double CalculatePerimeter()
        {
            return 0;
        }
    }
    class Triangle : Figure
    {
        protected double edgeA;
        protected double edgeB;
        protected double edgeC;

        public new double CalculateArea()
        {
            double semiPerimeter = (edgeA + edgeB + edgeC) / 2;
            return Math.Sqrt(
                semiPerimeter *
                (semiPerimeter - edgeA) *
                (semiPerimeter - edgeB) *
                (semiPerimeter - edgeC)
            );
        }

        public new double CalculatePerimeter()
        {
            return edgeA + edgeB + edgeC;
        }
        public void ChangeEdgeA(double newEdgeA)
        {
            edgeA = newEdgeA;
        }
        public void ChangeEdgeB(double newEdgeB)
        {
            edgeB = newEdgeB;
        }
        public void ChangeEdgeC(double newEdgeC)
        {
            edgeC = newEdgeC;
        }

        public bool CheckExistence()
        {
            double a = edgeA;
            double b = edgeB;
            double c = edgeC;
            return (((a+b)>c)&&((b+c)>a)&&((a+c)>b)&&(a>0)&&(b>0)&&(c>0));
        }
    }
    class Circle : Figure
    {
        private double radius;

        public new double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public new double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }      
        
        public void ChangeRadius(double newRadius)
        {
            radius = newRadius;
        }
    }
    class Square : Figure
    {
        private double edgeA;


        public new double CalculateArea()
        {
            return edgeA * edgeA;
        }

        public new double CalculatePerimeter()
        {
            return 4 * edgeA;
        }
        public void ChangeEdgeA(double newEdgeA)
        {
            edgeA = newEdgeA;
        }
    }
    class Rectangle : Figure
    {
        private double edgeA;
        private double edgeB;

        public new double CalculateArea()
        {
            return edgeA * edgeB;
        }

        public new double CalculatePerimeter()
        {
            return 2 * edgeA + 2 * edgeB;
        }
                
        public void ChangeEdgeA(double newEdgeA)
        {
            edgeA = newEdgeA;
        }
        public void ChangeEdgeB(double newEdgeB)
        {
            edgeB = newEdgeB;
        }
    }
    class Rhombus : Figure
    {
        private double edgeA;
        private double smallerAngle;

        public new double CalculateArea()
        {
            return edgeA * edgeA * Math.Sin(smallerAngle);
        }

        public new double CalculatePerimeter()
        {
            return 4 * edgeA;
        }
        public void ChangeEdgeA(double newEdgeA)
        {
            edgeA = newEdgeA;
        }
        public void ChangeSmallerAngle(double newSmallerAngle)
        {
            smallerAngle = newSmallerAngle;
        }
    }

    public partial class Form1 : Form
    {
/*
            txtbxEdgeAOrRadius != null && !string.IsNullOrWhiteSpace(txtbxEdgeAOrRadius.Text) &&
            txtbxEdgeBOrAngle != null && !string.IsNullOrWhiteSpace(txtbxEdgeBOrAngle.Text) &&
            txtbxEdgeC != null && !string.IsNullOrWhiteSpace(txtbxEdgeC.Text);
*/
        
        private string lastComboBoxIndex;

        Rectangle rectangle1 = new Rectangle();
        Circle circle1 = new Circle();
        Square square1 = new Square();
        Triangle triangle1 = new Triangle();
        Rhombus rhombus1 = new Rhombus();
        
        public Form1()
        {
            InitializeComponent();

            labelArea.Hide();
            labelPerimeter.Hide();
            labelAreaResult.Hide();
            labelPerimeterResult.Hide();

            buttonCalculate.Hide();

            lblEdgeAOrRadius.Hide();
            lblEdgeBOrAngle.Hide();
            lblEdgeC.Hide();
            txtbxEdgeAOrRadius.Hide();
            txtbxEdgeBOrAngle.Hide();
            txtbxEdgeC.Hide();
        }

        private void txtbxEdgeAOrRadius_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxFigure.Text)
            {
                case "Rectangle":
                {
                    if (txtbxEdgeAOrRadius != null && !string.IsNullOrWhiteSpace(txtbxEdgeAOrRadius.Text))
                    {
                        rectangle1.ChangeEdgeA(Convert.ToDouble(txtbxEdgeAOrRadius.Text));
                    }
                    break;
                }
                case "Square":
                {
                    if (txtbxEdgeAOrRadius != null && !string.IsNullOrWhiteSpace(txtbxEdgeAOrRadius.Text))
                    {
                        square1.ChangeEdgeA(Convert.ToDouble(txtbxEdgeAOrRadius.Text));
                    }
                    break;
                }
                case "Circle":
                {
                    if (txtbxEdgeAOrRadius != null && !string.IsNullOrWhiteSpace(txtbxEdgeAOrRadius.Text))
                    {
                        circle1.ChangeRadius(Convert.ToDouble(txtbxEdgeAOrRadius.Text));
                    }
                    break;
                }
                case "Rhombus":
                {
                    if (txtbxEdgeAOrRadius != null && !string.IsNullOrWhiteSpace(txtbxEdgeAOrRadius.Text))
                    {
                        rhombus1.ChangeEdgeA(Convert.ToDouble(txtbxEdgeAOrRadius.Text));
                    }
                    break;
                }
                case "Triangle":
                {
                    if (txtbxEdgeAOrRadius != null && !string.IsNullOrWhiteSpace(txtbxEdgeAOrRadius.Text))
                    {
                        triangle1.ChangeEdgeA(Convert.ToDouble(txtbxEdgeAOrRadius.Text));
                    }
                    break;
                }
            }
        }
        private void txtbxEdgeBOrAngle_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxFigure.Text)
            {
                case "Rectangle":
                {
                    if (txtbxEdgeBOrAngle != null && !string.IsNullOrWhiteSpace(txtbxEdgeBOrAngle.Text))
                    {
                        rectangle1.ChangeEdgeB(Convert.ToDouble(txtbxEdgeBOrAngle.Text));
                    }
                    break;
                }
                case "Rhombus":
                {
                    if (txtbxEdgeBOrAngle != null && !string.IsNullOrWhiteSpace(txtbxEdgeBOrAngle.Text))
                    {
                        double degrees = Convert.ToDouble(txtbxEdgeBOrAngle.Text);
                        double radians = degrees * Math.PI / 180;
                        rhombus1.ChangeSmallerAngle(radians);
                    }
                    break;
                }
                case "Triangle":
                {
                    if (txtbxEdgeBOrAngle != null && !string.IsNullOrWhiteSpace(txtbxEdgeBOrAngle.Text))
                    {
                        triangle1.ChangeEdgeB(Convert.ToDouble(txtbxEdgeBOrAngle.Text));
                    }
                    break;
                }
            }
        }
        private void txtbxEdgeC_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxFigure.Text)
            {
                case "Triangle":
                {
                    if (txtbxEdgeC != null && !string.IsNullOrWhiteSpace(txtbxEdgeC.Text))
                    {
                        triangle1.ChangeEdgeC(Convert.ToDouble(txtbxEdgeC.Text));
                    }
                    break;
                }
            }
        }
        
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            switch (comboBoxFigure.Text)
            {
                case "Rectangle":
                {
                    labelAreaResult.Text = rectangle1.CalculateArea().ToString("##.##");
                    labelPerimeterResult.Text = rectangle1.CalculatePerimeter().ToString("##.##");
                    break;
                }
                case "Circle":
                {
                    labelAreaResult.Text = circle1.CalculateArea().ToString("##.##");
                    labelPerimeterResult.Text = circle1.CalculatePerimeter().ToString("##.##");
                    break;
                }
                case "Square":
                {
                    labelAreaResult.Text = square1.CalculateArea().ToString("##.##");
                    labelPerimeterResult.Text = square1.CalculatePerimeter().ToString("##.##");
                    break;
                }
                case "Rhombus":
                {
                    labelAreaResult.Text = rhombus1.CalculateArea().ToString("##.##");
                    labelPerimeterResult.Text = rhombus1.CalculatePerimeter().ToString("##.##");
                    break;
                }
                case "Triangle":
                {
                    if (triangle1.CheckExistence())
                    {
                        labelAreaResult.Text = triangle1.CalculateArea().ToString("##.##");
                        labelPerimeterResult.Text = triangle1.CalculatePerimeter().ToString("##.##");
                    }
                    else
                    {
                        MessageBox.Show("Triangle does not exist, check input numbers");
                    }
                    break;
                }
            }
        }
        private void comboBoxFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEdgeAOrRadius.Hide();
            lblEdgeBOrAngle.Hide();
            lblEdgeC.Hide();
            txtbxEdgeAOrRadius.Hide();
            txtbxEdgeBOrAngle.Hide();
            txtbxEdgeC.Hide();
            
            buttonCalculate.Show();
            labelArea.Show();
            labelPerimeter.Show();
            labelAreaResult.Show();
            labelPerimeterResult.Show();

            if (lastComboBoxIndex != comboBoxFigure.Text)
            {
                txtbxEdgeAOrRadius.Clear(); 
                txtbxEdgeBOrAngle.Clear();
                txtbxEdgeC.Clear();
                
                labelAreaResult.Text = "0";
                labelPerimeterResult.Text = "0";
                lastComboBoxIndex = comboBoxFigure.Text;
            }
            
            switch (comboBoxFigure.Text)
            {
                case "Rectangle":
                {
                    lblEdgeAOrRadius.Text = "Edge A";
                    lblEdgeAOrRadius.Show();
                    txtbxEdgeAOrRadius.Show();
                    lblEdgeBOrAngle.Text = "Edge B";
                    lblEdgeBOrAngle.Show();
                    txtbxEdgeBOrAngle.Show();
                    
                    break;
                }
                case "Square":
                {
                    lblEdgeAOrRadius.Text = "Edge A";
                    lblEdgeAOrRadius.Show();
                    txtbxEdgeAOrRadius.Show();
                    break;
                }
                case "Circle":
                {
                    lblEdgeAOrRadius.Text = "Radius R";
                    lblEdgeAOrRadius.Show();
                    txtbxEdgeAOrRadius.Show();
                    break;
                }
                case "Rhombus":
                {
                    lblEdgeAOrRadius.Text = "Edge A";
                    lblEdgeAOrRadius.Show();
                    txtbxEdgeAOrRadius.Show();
                    lblEdgeBOrAngle.Text = "Smaller angle α°";
                    lblEdgeBOrAngle.Show();
                    txtbxEdgeBOrAngle.Show();
                    break;
                }
                case "Triangle":
                {
                    lblEdgeAOrRadius.Text = "Edge A";
                    lblEdgeAOrRadius.Show();
                    txtbxEdgeAOrRadius.Show();
                    lblEdgeBOrAngle.Text = "Edge B";
                    lblEdgeBOrAngle.Show();
                    txtbxEdgeBOrAngle.Show();
                    lblEdgeC.Text = "Edge C";
                    lblEdgeC.Show();
                    txtbxEdgeC.Show();
                    break;
                }
            }
        }
    }
}