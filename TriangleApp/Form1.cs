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
        public TriangleApp()
        {
            InitializeComponent();
            Triangle.Triangle tri = new Triangle.Triangle();

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

        }
    }
}
