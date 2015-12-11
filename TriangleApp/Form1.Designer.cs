namespace TriangleApp
{
    partial class TriangleApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideALabel = new System.Windows.Forms.Label();
            this.sideCLabel = new System.Windows.Forms.Label();
            this.sideBLabel = new System.Windows.Forms.Label();
            this.triangleAngleBC = new System.Windows.Forms.Label();
            this.triangleAngleCA = new System.Windows.Forms.Label();
            this.triangleAngleAB = new System.Windows.Forms.Label();
            this.setAnglesPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.setAnglesLabel = new System.Windows.Forms.Label();
            this.setAngleABLabel = new System.Windows.Forms.Label();
            this.setAngleBCLabel = new System.Windows.Forms.Label();
            this.setABBox = new System.Windows.Forms.NumericUpDown();
            this.B = new System.Windows.Forms.NumericUpDown();
            this.rightTriangleLabel = new System.Windows.Forms.Label();
            this.setSide1Box = new System.Windows.Forms.NumericUpDown();
            this.side1Label = new System.Windows.Forms.Label();
            this.setSide2Box = new System.Windows.Forms.NumericUpDown();
            this.side2Label = new System.Windows.Forms.Label();
            this.setAnglesButton = new System.Windows.Forms.Button();
            this.setSidesButton = new System.Windows.Forms.Button();
            this.calcAreaButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.setAnglesPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setABBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSide1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSide2Box)).BeginInit();
            this.SuspendLayout();
            // 
            // sideALabel
            // 
            this.sideALabel.AutoSize = true;
            this.sideALabel.Location = new System.Drawing.Point(348, 166);
            this.sideALabel.Name = "sideALabel";
            this.sideALabel.Size = new System.Drawing.Size(85, 13);
            this.sideALabel.TabIndex = 0;
            this.sideALabel.Text = "Triangle Side A: ";
            // 
            // sideCLabel
            // 
            this.sideCLabel.AutoSize = true;
            this.sideCLabel.Location = new System.Drawing.Point(348, 233);
            this.sideCLabel.Name = "sideCLabel";
            this.sideCLabel.Size = new System.Drawing.Size(85, 13);
            this.sideCLabel.TabIndex = 1;
            this.sideCLabel.Text = "Triangle Side C: ";
            // 
            // sideBLabel
            // 
            this.sideBLabel.AutoSize = true;
            this.sideBLabel.Location = new System.Drawing.Point(348, 199);
            this.sideBLabel.Name = "sideBLabel";
            this.sideBLabel.Size = new System.Drawing.Size(85, 13);
            this.sideBLabel.TabIndex = 2;
            this.sideBLabel.Text = "Triangle Side B: ";
            // 
            // triangleAngleBC
            // 
            this.triangleAngleBC.AutoSize = true;
            this.triangleAngleBC.Location = new System.Drawing.Point(348, 64);
            this.triangleAngleBC.Name = "triangleAngleBC";
            this.triangleAngleBC.Size = new System.Drawing.Size(95, 13);
            this.triangleAngleBC.TabIndex = 5;
            this.triangleAngleBC.Text = "Triangle Angle BC:";
            // 
            // triangleAngleCA
            // 
            this.triangleAngleCA.AutoSize = true;
            this.triangleAngleCA.Location = new System.Drawing.Point(348, 98);
            this.triangleAngleCA.Name = "triangleAngleCA";
            this.triangleAngleCA.Size = new System.Drawing.Size(95, 13);
            this.triangleAngleCA.TabIndex = 4;
            this.triangleAngleCA.Text = "Triangle Angle CA:";
            // 
            // triangleAngleAB
            // 
            this.triangleAngleAB.AutoSize = true;
            this.triangleAngleAB.Location = new System.Drawing.Point(348, 31);
            this.triangleAngleAB.Name = "triangleAngleAB";
            this.triangleAngleAB.Size = new System.Drawing.Size(95, 13);
            this.triangleAngleAB.TabIndex = 3;
            this.triangleAngleAB.Text = "Triangle Angle AB:";
            // 
            // setAnglesPanel
            // 
            this.setAnglesPanel.Controls.Add(this.setAnglesButton);
            this.setAnglesPanel.Controls.Add(this.B);
            this.setAnglesPanel.Controls.Add(this.setABBox);
            this.setAnglesPanel.Controls.Add(this.setAngleBCLabel);
            this.setAnglesPanel.Controls.Add(this.setAngleABLabel);
            this.setAnglesPanel.Controls.Add(this.setAnglesLabel);
            this.setAnglesPanel.Location = new System.Drawing.Point(23, 24);
            this.setAnglesPanel.Name = "setAnglesPanel";
            this.setAnglesPanel.Size = new System.Drawing.Size(298, 125);
            this.setAnglesPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.areaLabel);
            this.panel2.Controls.Add(this.calcAreaButton);
            this.panel2.Controls.Add(this.setSidesButton);
            this.panel2.Controls.Add(this.setSide2Box);
            this.panel2.Controls.Add(this.side2Label);
            this.panel2.Controls.Add(this.setSide1Box);
            this.panel2.Controls.Add(this.rightTriangleLabel);
            this.panel2.Controls.Add(this.side1Label);
            this.panel2.Location = new System.Drawing.Point(23, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 134);
            this.panel2.TabIndex = 7;
            // 
            // setAnglesLabel
            // 
            this.setAnglesLabel.AutoSize = true;
            this.setAnglesLabel.Location = new System.Drawing.Point(3, 7);
            this.setAnglesLabel.Name = "setAnglesLabel";
            this.setAnglesLabel.Size = new System.Drawing.Size(102, 13);
            this.setAnglesLabel.TabIndex = 0;
            this.setAnglesLabel.Text = "Set Triangle Angles:";
            // 
            // setAngleABLabel
            // 
            this.setAngleABLabel.AutoSize = true;
            this.setAngleABLabel.Location = new System.Drawing.Point(6, 40);
            this.setAngleABLabel.Name = "setAngleABLabel";
            this.setAngleABLabel.Size = new System.Drawing.Size(73, 13);
            this.setAngleABLabel.TabIndex = 1;
            this.setAngleABLabel.Text = "Set Angle AB:";
            // 
            // setAngleBCLabel
            // 
            this.setAngleBCLabel.AutoSize = true;
            this.setAngleBCLabel.Location = new System.Drawing.Point(6, 74);
            this.setAngleBCLabel.Name = "setAngleBCLabel";
            this.setAngleBCLabel.Size = new System.Drawing.Size(73, 13);
            this.setAngleBCLabel.TabIndex = 2;
            this.setAngleBCLabel.Text = "Set Angle BC:";
            // 
            // setABBox
            // 
            this.setABBox.DecimalPlaces = 1;
            this.setABBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.setABBox.Location = new System.Drawing.Point(117, 38);
            this.setABBox.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.setABBox.Name = "setABBox";
            this.setABBox.Size = new System.Drawing.Size(120, 20);
            this.setABBox.TabIndex = 3;
            // 
            // B
            // 
            this.B.DecimalPlaces = 1;
            this.B.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.B.Location = new System.Drawing.Point(117, 72);
            this.B.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(120, 20);
            this.B.TabIndex = 4;
            // 
            // rightTriangleLabel
            // 
            this.rightTriangleLabel.AutoSize = true;
            this.rightTriangleLabel.Location = new System.Drawing.Point(9, 11);
            this.rightTriangleLabel.Name = "rightTriangleLabel";
            this.rightTriangleLabel.Size = new System.Drawing.Size(115, 13);
            this.rightTriangleLabel.TabIndex = 0;
            this.rightTriangleLabel.Text = "Right Triangle Options:";
            // 
            // setSide1Box
            // 
            this.setSide1Box.DecimalPlaces = 1;
            this.setSide1Box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.setSide1Box.Location = new System.Drawing.Point(120, 42);
            this.setSide1Box.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.setSide1Box.Name = "setSide1Box";
            this.setSide1Box.Size = new System.Drawing.Size(120, 20);
            this.setSide1Box.TabIndex = 6;
            // 
            // side1Label
            // 
            this.side1Label.AutoSize = true;
            this.side1Label.Location = new System.Drawing.Point(9, 44);
            this.side1Label.Name = "side1Label";
            this.side1Label.Size = new System.Drawing.Size(41, 13);
            this.side1Label.TabIndex = 5;
            this.side1Label.Text = "Side A:";
            // 
            // setSide2Box
            // 
            this.setSide2Box.DecimalPlaces = 1;
            this.setSide2Box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.setSide2Box.Location = new System.Drawing.Point(120, 76);
            this.setSide2Box.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.setSide2Box.Name = "setSide2Box";
            this.setSide2Box.Size = new System.Drawing.Size(120, 20);
            this.setSide2Box.TabIndex = 8;
            // 
            // side2Label
            // 
            this.side2Label.AutoSize = true;
            this.side2Label.Location = new System.Drawing.Point(9, 78);
            this.side2Label.Name = "side2Label";
            this.side2Label.Size = new System.Drawing.Size(41, 13);
            this.side2Label.TabIndex = 7;
            this.side2Label.Text = "Side B:";
            // 
            // setAnglesButton
            // 
            this.setAnglesButton.Location = new System.Drawing.Point(6, 99);
            this.setAnglesButton.Name = "setAnglesButton";
            this.setAnglesButton.Size = new System.Drawing.Size(75, 23);
            this.setAnglesButton.TabIndex = 5;
            this.setAnglesButton.Text = "Set Angles";
            this.setAnglesButton.UseVisualStyleBackColor = true;
            // 
            // setSidesButton
            // 
            this.setSidesButton.Location = new System.Drawing.Point(6, 104);
            this.setSidesButton.Name = "setSidesButton";
            this.setSidesButton.Size = new System.Drawing.Size(75, 23);
            this.setSidesButton.TabIndex = 6;
            this.setSidesButton.Text = "Set Sides";
            this.setSidesButton.UseVisualStyleBackColor = true;
            // 
            // calcAreaButton
            // 
            this.calcAreaButton.Location = new System.Drawing.Point(87, 104);
            this.calcAreaButton.Name = "calcAreaButton";
            this.calcAreaButton.Size = new System.Drawing.Size(95, 23);
            this.calcAreaButton.TabIndex = 9;
            this.calcAreaButton.Text = "Calculate Area";
            this.calcAreaButton.UseVisualStyleBackColor = true;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(188, 109);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(35, 13);
            this.areaLabel.TabIndex = 10;
            this.areaLabel.Text = "Area: ";
            // 
            // TriangleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 310);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.setAnglesPanel);
            this.Controls.Add(this.triangleAngleBC);
            this.Controls.Add(this.triangleAngleCA);
            this.Controls.Add(this.triangleAngleAB);
            this.Controls.Add(this.sideBLabel);
            this.Controls.Add(this.sideCLabel);
            this.Controls.Add(this.sideALabel);
            this.Name = "TriangleApp";
            this.Text = "Triangle App";
            this.setAnglesPanel.ResumeLayout(false);
            this.setAnglesPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setABBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSide1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSide2Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sideALabel;
        private System.Windows.Forms.Label sideCLabel;
        private System.Windows.Forms.Label sideBLabel;
        private System.Windows.Forms.Label triangleAngleBC;
        private System.Windows.Forms.Label triangleAngleCA;
        private System.Windows.Forms.Label triangleAngleAB;
        private System.Windows.Forms.Panel setAnglesPanel;
        private System.Windows.Forms.Label setAnglesLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown setABBox;
        private System.Windows.Forms.Label setAngleBCLabel;
        private System.Windows.Forms.Label setAngleABLabel;
        private System.Windows.Forms.NumericUpDown B;
        private System.Windows.Forms.NumericUpDown setSide1Box;
        private System.Windows.Forms.Label rightTriangleLabel;
        private System.Windows.Forms.Label side1Label;
        private System.Windows.Forms.NumericUpDown setSide2Box;
        private System.Windows.Forms.Label side2Label;
        private System.Windows.Forms.Button setAnglesButton;
        private System.Windows.Forms.Button setSidesButton;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Button calcAreaButton;
    }
}

