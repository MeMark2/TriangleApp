using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleApp
{
    public partial class TriangleApp : Form
    {
        Triangle.Triangle tri;

        public TriangleApp()
        {
            InitializeComponent();
            tri = new Triangle.Triangle();

            SetAngleLabels(tri.AB, tri.BC, tri.CA);
            SetSideLabels(tri.A, tri.B, tri.C);
        }


        private void SetAngleLabels(double AB, double BC, double CA)
        {
            triangleAngleAB.Text = "Triangle Angle AB: " + AB.ToString();
            triangleAngleBC.Text = "Triangle Angle BC: " + BC.ToString();
            triangleAngleCA.Text = "Triangle Angle CA: " + CA.ToString();
        }

        private void SetSideLabels(double A, double B, double C)
        {
            sideALabel.Text = "Triangle Side A: " + A.ToString();
            sideBLabel.Text = "Triangle Side B: " + B.ToString();
            sideCLabel.Text = "Triangle Side C: " + C.ToString();
        }


        private void setAnglesButton_Click(object sender, EventArgs e)
        {
            tri.SetTriangleAngles((double)setABBox.Value, (double)setBCBox.Value);
            SetAngleLabels(tri.AB, tri.BC, tri.CA);

            if (tri.AB == 90.0)
            {
                side1Label.Text = "Side A:";
                side2Label.Text = "Side B:";
                rightTrianglePanel.Enabled = true;
            }
            else if (tri.BC == 90.0)
            {
                side1Label.Text = "Side B:";
                side2Label.Text = "Side C:";
                rightTrianglePanel.Enabled = true;
            }
            else if (tri.CA == 90.0)
            {
                side1Label.Text = "Side C:";
                side2Label.Text = "Side A:";
                rightTrianglePanel.Enabled = true;
            }
            else
            {
                rightTrianglePanel.Enabled = false;
            }
        }

        private void setSidesButton_Click(object sender, EventArgs e)
        {
            tri.SetRightTriangleSides((double)setSide1Box.Value, (double)setSide2Box.Value);
            SetSideLabels(tri.A, tri.B, tri.C);
        }

        private void calcAreaButton_Click(object sender, EventArgs e)
        {
            if (tri.AB == 90.0)
            {
                areaLabel.Text = "Area: " + tri.RightCalcArea(tri.A, tri.B).ToString();
            }
            else if (tri.BC == 90.0)
            {
                areaLabel.Text = "Area: " + tri.RightCalcArea(tri.B, tri.C).ToString();
            }
            else if (tri.CA == 90.0)
            {
                areaLabel.Text = "Area: " + tri.RightCalcArea(tri.C, tri.A).ToString();
            }
        }
    }
}
