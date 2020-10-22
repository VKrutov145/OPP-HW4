namespace Ex5
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
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelPerimeterResult = new System.Windows.Forms.Label();
            this.labelAreaResult = new System.Windows.Forms.Label();
            this.txtbxEdgeAOrRadius = new System.Windows.Forms.TextBox();
            this.lblEdgeAOrRadius = new System.Windows.Forms.Label();
            this.lblEdgeBOrAngle = new System.Windows.Forms.Label();
            this.txtbxEdgeBOrAngle = new System.Windows.Forms.TextBox();
            this.lblEdgeC = new System.Windows.Forms.Label();
            this.txtbxEdgeC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {"Square", "Rectangle", "Circle", "Rhombus", "Triangle"});
            this.comboBoxFigure.Location = new System.Drawing.Point(31, 56);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(296, 28);
            this.comboBoxFigure.TabIndex = 0;
            this.comboBoxFigure.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigure_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose figure";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(419, 23);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(327, 60);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelArea
            // 
            this.labelArea.Location = new System.Drawing.Point(419, 122);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(111, 26);
            this.labelArea.TabIndex = 3;
            this.labelArea.Text = "Area:";
            this.labelArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.Location = new System.Drawing.Point(419, 148);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(111, 26);
            this.labelPerimeter.TabIndex = 4;
            this.labelPerimeter.Text = "Perimeter:";
            this.labelPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPerimeterResult
            // 
            this.labelPerimeterResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPerimeterResult.Location = new System.Drawing.Point(536, 148);
            this.labelPerimeterResult.Name = "labelPerimeterResult";
            this.labelPerimeterResult.Size = new System.Drawing.Size(111, 26);
            this.labelPerimeterResult.TabIndex = 6;
            this.labelPerimeterResult.Text = "0";
            this.labelPerimeterResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAreaResult
            // 
            this.labelAreaResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelAreaResult.Location = new System.Drawing.Point(536, 122);
            this.labelAreaResult.Name = "labelAreaResult";
            this.labelAreaResult.Size = new System.Drawing.Size(111, 26);
            this.labelAreaResult.TabIndex = 7;
            this.labelAreaResult.Text = "0";
            this.labelAreaResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxEdgeAOrRadius
            // 
            this.txtbxEdgeAOrRadius.Location = new System.Drawing.Point(31, 148);
            this.txtbxEdgeAOrRadius.Name = "txtbxEdgeAOrRadius";
            this.txtbxEdgeAOrRadius.Size = new System.Drawing.Size(296, 26);
            this.txtbxEdgeAOrRadius.TabIndex = 8;
            this.txtbxEdgeAOrRadius.TextChanged += new System.EventHandler(this.txtbxEdgeAOrRadius_TextChanged);
            // 
            // lblEdgeAOrRadius
            // 
            this.lblEdgeAOrRadius.Location = new System.Drawing.Point(31, 122);
            this.lblEdgeAOrRadius.Name = "lblEdgeAOrRadius";
            this.lblEdgeAOrRadius.Size = new System.Drawing.Size(296, 26);
            this.lblEdgeAOrRadius.TabIndex = 9;
            this.lblEdgeAOrRadius.Text = "Edge A";
            this.lblEdgeAOrRadius.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblEdgeBOrAngle
            // 
            this.lblEdgeBOrAngle.Location = new System.Drawing.Point(31, 177);
            this.lblEdgeBOrAngle.Name = "lblEdgeBOrAngle";
            this.lblEdgeBOrAngle.Size = new System.Drawing.Size(296, 26);
            this.lblEdgeBOrAngle.TabIndex = 11;
            this.lblEdgeBOrAngle.Text = "Edge B";
            this.lblEdgeBOrAngle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtbxEdgeBOrAngle
            // 
            this.txtbxEdgeBOrAngle.Location = new System.Drawing.Point(31, 203);
            this.txtbxEdgeBOrAngle.Name = "txtbxEdgeBOrAngle";
            this.txtbxEdgeBOrAngle.Size = new System.Drawing.Size(296, 26);
            this.txtbxEdgeBOrAngle.TabIndex = 10;
            this.txtbxEdgeBOrAngle.TextChanged += new System.EventHandler(this.txtbxEdgeBOrAngle_TextChanged);
            // 
            // lblEdgeC
            // 
            this.lblEdgeC.Location = new System.Drawing.Point(31, 232);
            this.lblEdgeC.Name = "lblEdgeC";
            this.lblEdgeC.Size = new System.Drawing.Size(296, 26);
            this.lblEdgeC.TabIndex = 13;
            this.lblEdgeC.Text = "Edge C";
            this.lblEdgeC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtbxEdgeC
            // 
            this.txtbxEdgeC.Location = new System.Drawing.Point(31, 258);
            this.txtbxEdgeC.Name = "txtbxEdgeC";
            this.txtbxEdgeC.Size = new System.Drawing.Size(296, 26);
            this.txtbxEdgeC.TabIndex = 12;
            this.txtbxEdgeC.TextChanged += new System.EventHandler(this.txtbxEdgeC_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEdgeC);
            this.Controls.Add(this.txtbxEdgeC);
            this.Controls.Add(this.lblEdgeBOrAngle);
            this.Controls.Add(this.txtbxEdgeBOrAngle);
            this.Controls.Add(this.lblEdgeAOrRadius);
            this.Controls.Add(this.txtbxEdgeAOrRadius);
            this.Controls.Add(this.labelAreaResult);
            this.Controls.Add(this.labelPerimeterResult);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFigure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblEdgeAOrRadius;
        private System.Windows.Forms.Label lblEdgeBOrAngle;
        private System.Windows.Forms.Label lblEdgeC;
        private System.Windows.Forms.TextBox txtbxEdgeBOrAngle;
        private System.Windows.Forms.TextBox txtbxEdgeC;

        private System.Windows.Forms.TextBox txtbxEdgeAOrRadius;

        private System.Windows.Forms.Label labelAreaResult;

        private System.Windows.Forms.Label labelPerimeterResult;

        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelPerimeter;

        private System.Windows.Forms.Button buttonCalculate;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox comboBoxFigure;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}