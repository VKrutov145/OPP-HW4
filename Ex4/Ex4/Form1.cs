using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ex4
{
  class Triangle
  {
    protected double edgeA;
    protected double edgeB;
    protected double edgeC;

    public bool IsEquilateralTriangle()
    {
      return (edgeA == edgeB) && (edgeB == edgeC) && (edgeA == edgeC);
    }

    public bool CheckTriangleInequalities(double a, double b, double c)
    {
      bool result = (((a + b) > c) && ((b + c) > a) && ((a + c) > b)&&(a>0)&&(b>0)&&(c>0));
      return result;
    }
    private double FindAngleByLawOfCosine(double oppositeEdge, double sideEdge1, double sideEdge2)
    {
      double c = oppositeEdge;
      double a = sideEdge1;
      double b = sideEdge2;
      return Math.Acos((a*a+b*b-c*c)/(2*a*b));
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
    public double[] CalculateAngles()
    {
      double[] resultingAngels;
      resultingAngels = new double[3];

      resultingAngels[0] = FindAngleByLawOfCosine(edgeA, edgeB, edgeC)*360/2/Math.PI;
      resultingAngels[1] = FindAngleByLawOfCosine(edgeB, edgeA, edgeC)*360/2/Math.PI;
      resultingAngels[2] = FindAngleByLawOfCosine(edgeC, edgeA, edgeB)*360/2/Math.PI;
      
      return resultingAngels;
    }
    public double CalculatePerimeter()
    {
      return edgeA + edgeB + edgeC;
    }
    public bool CheckTriangleExistence()
    {
      if (CheckTriangleInequalities(edgeA,edgeB,edgeC))
      {
        return true;
      } else
      {
        return false;
      }
    }

    public double GetEdgeA()
    {
      return edgeA;
    }
    public double GetEdgeB()
    {
      return edgeB;
    }
    public double GetEdgeC()
    {
      return edgeC;
    }
    public Triangle()
    {
      edgeA = 0;
      edgeB = 0;
      edgeC = 0;
    }
  }

  class EquilateralTriangle : Triangle
  {
    private double area;
    private new double edgeA;
    private new double edgeB;
    private new double edgeC;

    public double CalculateArea()
    {

      double a = edgeA, b = edgeB, c = edgeC;
      
      double semiPerimeter = (a + b + c) / 2;
      area = Math.Sqrt(semiPerimeter*(semiPerimeter-a)*(semiPerimeter-b)*(semiPerimeter-c));
      return area;
    }

    public EquilateralTriangle(double newEdgeA, double newEdgeB, double newEdgeC)
    {
      edgeA = newEdgeA;
      edgeB = newEdgeB;
      edgeC = newEdgeC;
    }

  }
  public partial class Form1 : Form
  {
    
    Triangle triangle1 = new Triangle();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      buttonCalculateAngles.Visible = false;
      buttonCalculatePerimeter.Visible = false;
      perimeterBox.Visible = false;
      anglesBox.Visible = false;
      edgeABox.Hide();
      edgeALabel.Hide();
      edgeBBox.Hide();
      edgeBLabel.Hide();
      edgeCBox.Hide();
      edgeCLabel.Hide();
      buttonCalculateArea.Hide();
      areaBox.Hide();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      buttonStart.Hide();
      buttonCalculateAngles.Show();
      buttonCalculatePerimeter.Show();
      perimeterBox.Show();
      anglesBox.Show();
      edgeABox.Show();
      edgeALabel.Show();
      edgeBBox.Show();
      edgeBLabel.Show();
      edgeCBox.Show();
      edgeCLabel.Show();
    }

    private void buttonCalculatePerimeter_Click(object sender, EventArgs e)
    {
      if (triangle1.CheckTriangleExistence())
      {
        perimeterBox.Text = triangle1.CalculatePerimeter().ToString();
      }
      else
      {
        MessageBox.Show("Triangle does not exist");
      }
    }

    private void buttonCalculateAngles_Click(object sender, EventArgs e)
    {
      if (triangle1.CheckTriangleExistence())
      {
        double[] angles = triangle1.CalculateAngles();
        anglesBox.Text = angles[0].ToString("##.##") + "°| "
                                                     + angles[1].ToString("##.##") + "°| "
                                                     + angles[2].ToString("##.##") + "° ";
      }
      else
      {
        MessageBox.Show("Triangle does not exist");
      }
    }

    private void edgeABox_TextChanged(object sender, EventArgs e)
    {
      if (edgeABox != null && !string.IsNullOrWhiteSpace(edgeABox.Text))
      {
        triangle1.ChangeEdgeA(Convert.ToDouble(edgeABox.Text));
        if (triangle1.IsEquilateralTriangle())
        {
          areaBox.Show();
          buttonCalculateArea.Show();
        } else
        {
          areaBox.Hide();
          buttonCalculateArea.Hide();
          areaBox.Clear();
        }
      }
    }

    private void edgeBBox_TextChanged(object sender, EventArgs e)
    {
      if (edgeBBox != null && !string.IsNullOrWhiteSpace(edgeBBox.Text))
      {
        triangle1.ChangeEdgeB(Convert.ToDouble(edgeBBox.Text));
        if (triangle1.IsEquilateralTriangle())
        {
          areaBox.Show();
          buttonCalculateArea.Show();
        } else
        {
          areaBox.Hide();
          buttonCalculateArea.Hide();
          areaBox.Clear();
        }
      }
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
      if (edgeCBox != null && !string.IsNullOrWhiteSpace(edgeCBox.Text))
      {
        triangle1.ChangeEdgeC(Convert.ToDouble(edgeCBox.Text));
        if (triangle1.IsEquilateralTriangle())
        {
          areaBox.Show();
          buttonCalculateArea.Show();
        }
        else
        {
          areaBox.Hide();
          buttonCalculateArea.Hide();
          areaBox.Clear();
        }
      }
    }

    private void buttonCalculateArea_Click(object sender, EventArgs e)
    {
      EquilateralTriangle eqTriangle1 = new EquilateralTriangle(
        triangle1.GetEdgeA(),
        triangle1.GetEdgeB(),
        triangle1.GetEdgeC()
        );
      areaBox.Text = eqTriangle1.CalculateArea().ToString("##.###");
    }
  }
}
