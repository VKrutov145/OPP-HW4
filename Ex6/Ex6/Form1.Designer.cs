namespace Ex6
{
    partial class Form1
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
            this.comboBoxChoseTriangle = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtbxEdgeA = new System.Windows.Forms.TextBox();
            this.txtbxEdgeB = new System.Windows.Forms.TextBox();
            this.lblEdgeB = new System.Windows.Forms.Label();
            this.lblEdgeA = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtbxAngle = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAreaResult = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblPerimeterResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxChoseTriangle
            // 
            this.comboBoxChoseTriangle.FormattingEnabled = true;
            this.comboBoxChoseTriangle.Items.AddRange(new object[] {"Isosceles Triangle", "Right Triangle"});
            this.comboBoxChoseTriangle.Location = new System.Drawing.Point(28, 47);
            this.comboBoxChoseTriangle.Name = "comboBoxChoseTriangle";
            this.comboBoxChoseTriangle.Size = new System.Drawing.Size(322, 28);
            this.comboBoxChoseTriangle.TabIndex = 0;
            this.comboBoxChoseTriangle.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoseTriangle_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalculate.Location = new System.Drawing.Point(453, 27);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(292, 47);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtbxEdgeA
            // 
            this.txtbxEdgeA.Location = new System.Drawing.Point(28, 158);
            this.txtbxEdgeA.Name = "txtbxEdgeA";
            this.txtbxEdgeA.Size = new System.Drawing.Size(321, 26);
            this.txtbxEdgeA.TabIndex = 2;
            this.txtbxEdgeA.TextChanged += new System.EventHandler(this.txtbxEdgeA_TextChanged);
            // 
            // txtbxEdgeB
            // 
            this.txtbxEdgeB.Location = new System.Drawing.Point(28, 219);
            this.txtbxEdgeB.Name = "txtbxEdgeB";
            this.txtbxEdgeB.Size = new System.Drawing.Size(321, 26);
            this.txtbxEdgeB.TabIndex = 3;
            this.txtbxEdgeB.TextChanged += new System.EventHandler(this.txtbxEdgeB_TextChanged);
            // 
            // lblEdgeB
            // 
            this.lblEdgeB.Location = new System.Drawing.Point(29, 195);
            this.lblEdgeB.Name = "lblEdgeB";
            this.lblEdgeB.Size = new System.Drawing.Size(321, 21);
            this.lblEdgeB.TabIndex = 4;
            this.lblEdgeB.Text = "Edge B";
            this.lblEdgeB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblEdgeA
            // 
            this.lblEdgeA.Location = new System.Drawing.Point(29, 126);
            this.lblEdgeA.Name = "lblEdgeA";
            this.lblEdgeA.Size = new System.Drawing.Size(321, 29);
            this.lblEdgeA.TabIndex = 5;
            this.lblEdgeA.Text = "Edge A";
            this.lblEdgeA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblAngle
            // 
            this.lblAngle.Location = new System.Drawing.Point(29, 254);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(321, 29);
            this.lblAngle.TabIndex = 7;
            this.lblAngle.Text = "Angle between A and B";
            this.lblAngle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtbxAngle
            // 
            this.txtbxAngle.Location = new System.Drawing.Point(28, 286);
            this.txtbxAngle.Name = "txtbxAngle";
            this.txtbxAngle.Size = new System.Drawing.Size(321, 26);
            this.txtbxAngle.TabIndex = 6;
            this.txtbxAngle.TextChanged += new System.EventHandler(this.txtbxAngle_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.Location = new System.Drawing.Point(453, 120);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(145, 64);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area:";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAreaResult
            // 
            this.lblAreaResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblAreaResult.Location = new System.Drawing.Point(600, 120);
            this.lblAreaResult.Name = "lblAreaResult";
            this.lblAreaResult.Size = new System.Drawing.Size(145, 64);
            this.lblAreaResult.TabIndex = 9;
            this.lblAreaResult.Text = "0";
            this.lblAreaResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.Location = new System.Drawing.Point(453, 195);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(145, 64);
            this.lblPerimeter.TabIndex = 10;
            this.lblPerimeter.Text = "Perimeter:";
            this.lblPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPerimeterResult
            // 
            this.lblPerimeterResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPerimeterResult.Location = new System.Drawing.Point(600, 195);
            this.lblPerimeterResult.Name = "lblPerimeterResult";
            this.lblPerimeterResult.Size = new System.Drawing.Size(145, 64);
            this.lblPerimeterResult.TabIndex = 11;
            this.lblPerimeterResult.Text = "0";
            this.lblPerimeterResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPerimeterResult);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblAreaResult);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.txtbxAngle);
            this.Controls.Add(this.lblEdgeA);
            this.Controls.Add(this.lblEdgeB);
            this.Controls.Add(this.txtbxEdgeB);
            this.Controls.Add(this.txtbxEdgeA);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.comboBoxChoseTriangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblArea;

        private System.Windows.Forms.Label lblAreaResult;
        private System.Windows.Forms.Label lblPerimeterResult;

        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblEdgeA;
        private System.Windows.Forms.Label lblEdgeB;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtbxAngle;
        private System.Windows.Forms.TextBox txtbxEdgeA;
        private System.Windows.Forms.TextBox txtbxEdgeB;

        private System.Windows.Forms.Button btnCalculate;

        private System.Windows.Forms.ComboBox comboBoxChoseTriangle;

        #endregion
    }
}