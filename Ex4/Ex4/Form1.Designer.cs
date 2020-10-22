namespace Ex4
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
      this.buttonStart = new System.Windows.Forms.Button();
      this.buttonCalculatePerimeter = new System.Windows.Forms.Button();
      this.buttonCalculateAngles = new System.Windows.Forms.Button();
      this.perimeterBox = new System.Windows.Forms.TextBox();
      this.anglesBox = new System.Windows.Forms.TextBox();
      this.edgeABox = new System.Windows.Forms.TextBox();
      this.edgeBBox = new System.Windows.Forms.TextBox();
      this.edgeCBox = new System.Windows.Forms.TextBox();
      this.edgeALabel = new System.Windows.Forms.Label();
      this.edgeBLabel = new System.Windows.Forms.Label();
      this.edgeCLabel = new System.Windows.Forms.Label();
      this.buttonCalculateArea = new System.Windows.Forms.Button();
      this.areaBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // buttonStart
      // 
      this.buttonStart.BackColor = System.Drawing.SystemColors.ControlDark;
      this.buttonStart.Location = new System.Drawing.Point(319, 143);
      this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(380, 109);
      this.buttonStart.TabIndex = 0;
      this.buttonStart.Text = "START";
      this.buttonStart.UseVisualStyleBackColor = false;
      this.buttonStart.Click += new System.EventHandler(this.button1_Click);
      // 
      // buttonCalculatePerimeter
      // 
      this.buttonCalculatePerimeter.Location = new System.Drawing.Point(16, 26);
      this.buttonCalculatePerimeter.Name = "buttonCalculatePerimeter";
      this.buttonCalculatePerimeter.Size = new System.Drawing.Size(138, 53);
      this.buttonCalculatePerimeter.TabIndex = 1;
      this.buttonCalculatePerimeter.Text = "Calculate Perimeter";
      this.buttonCalculatePerimeter.UseVisualStyleBackColor = true;
      this.buttonCalculatePerimeter.Click += new System.EventHandler(this.buttonCalculatePerimeter_Click);
      // 
      // buttonCalculateAngles
      // 
      this.buttonCalculateAngles.Location = new System.Drawing.Point(183, 26);
      this.buttonCalculateAngles.Name = "buttonCalculateAngles";
      this.buttonCalculateAngles.Size = new System.Drawing.Size(138, 53);
      this.buttonCalculateAngles.TabIndex = 2;
      this.buttonCalculateAngles.Text = "Calculate Angles";
      this.buttonCalculateAngles.UseVisualStyleBackColor = true;
      this.buttonCalculateAngles.Click += new System.EventHandler(this.buttonCalculateAngles_Click);
      // 
      // perimeterBox
      // 
      this.perimeterBox.Location = new System.Drawing.Point(16, 99);
      this.perimeterBox.Name = "perimeterBox";
      this.perimeterBox.Size = new System.Drawing.Size(137, 27);
      this.perimeterBox.TabIndex = 3;
      // 
      // anglesBox
      // 
      this.anglesBox.Location = new System.Drawing.Point(184, 99);
      this.anglesBox.Name = "anglesBox";
      this.anglesBox.Size = new System.Drawing.Size(137, 27);
      this.anglesBox.TabIndex = 4;
      // 
      // edgeABox
      // 
      this.edgeABox.Location = new System.Drawing.Point(494, 99);
      this.edgeABox.Name = "edgeABox";
      this.edgeABox.Size = new System.Drawing.Size(137, 27);
      this.edgeABox.TabIndex = 5;
      this.edgeABox.TextChanged += new System.EventHandler(this.edgeABox_TextChanged);
      // 
      // edgeBBox
      // 
      this.edgeBBox.Location = new System.Drawing.Point(659, 99);
      this.edgeBBox.Name = "edgeBBox";
      this.edgeBBox.Size = new System.Drawing.Size(137, 27);
      this.edgeBBox.TabIndex = 6;
      this.edgeBBox.TextChanged += new System.EventHandler(this.edgeBBox_TextChanged);
      // 
      // edgeCBox
      // 
      this.edgeCBox.Location = new System.Drawing.Point(829, 99);
      this.edgeCBox.Name = "edgeCBox";
      this.edgeCBox.Size = new System.Drawing.Size(137, 27);
      this.edgeCBox.TabIndex = 7;
      this.edgeCBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
      // 
      // edgeALabel
      // 
      this.edgeALabel.Location = new System.Drawing.Point(494, 66);
      this.edgeALabel.Name = "edgeALabel";
      this.edgeALabel.Size = new System.Drawing.Size(136, 33);
      this.edgeALabel.TabIndex = 8;
      this.edgeALabel.Text = "Edge A";
      // 
      // edgeBLabel
      // 
      this.edgeBLabel.Location = new System.Drawing.Point(659, 66);
      this.edgeBLabel.Name = "edgeBLabel";
      this.edgeBLabel.Size = new System.Drawing.Size(136, 33);
      this.edgeBLabel.TabIndex = 9;
      this.edgeBLabel.Text = "Edge B";
      // 
      // edgeCLabel
      // 
      this.edgeCLabel.Location = new System.Drawing.Point(829, 66);
      this.edgeCLabel.Name = "edgeCLabel";
      this.edgeCLabel.Size = new System.Drawing.Size(136, 33);
      this.edgeCLabel.TabIndex = 10;
      this.edgeCLabel.Text = "Edge C";
      // 
      // buttonCalculateArea
      // 
      this.buttonCalculateArea.Location = new System.Drawing.Point(16, 143);
      this.buttonCalculateArea.Name = "buttonCalculateArea";
      this.buttonCalculateArea.Size = new System.Drawing.Size(138, 53);
      this.buttonCalculateArea.TabIndex = 11;
      this.buttonCalculateArea.Text = "Calculate Area";
      this.buttonCalculateArea.UseVisualStyleBackColor = true;
      this.buttonCalculateArea.Click += new System.EventHandler(this.buttonCalculateArea_Click);
      // 
      // areaBox
      // 
      this.areaBox.Location = new System.Drawing.Point(17, 211);
      this.areaBox.Name = "areaBox";
      this.areaBox.Size = new System.Drawing.Size(137, 27);
      this.areaBox.TabIndex = 12;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(978, 405);
      this.Controls.Add(this.areaBox);
      this.Controls.Add(this.buttonCalculateArea);
      this.Controls.Add(this.edgeCLabel);
      this.Controls.Add(this.edgeBLabel);
      this.Controls.Add(this.edgeALabel);
      this.Controls.Add(this.edgeCBox);
      this.Controls.Add(this.edgeBBox);
      this.Controls.Add(this.edgeABox);
      this.Controls.Add(this.anglesBox);
      this.Controls.Add(this.perimeterBox);
      this.Controls.Add(this.buttonCalculateAngles);
      this.Controls.Add(this.buttonCalculatePerimeter);
      this.Controls.Add(this.buttonStart);
      this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.TextBox areaBox;
    private System.Windows.Forms.Button buttonCalculateArea;

    private System.Windows.Forms.Label edgeALabel;
    private System.Windows.Forms.Label edgeBLabel;
    private System.Windows.Forms.TextBox edgeCBox;
    private System.Windows.Forms.Label edgeCLabel;

    private System.Windows.Forms.TextBox edgeABox;
    private System.Windows.Forms.TextBox edgeBBox;

    private System.Windows.Forms.TextBox anglesBox;
    private System.Windows.Forms.TextBox perimeterBox;

    private System.Windows.Forms.Button buttonCalculateAngles;

    private System.Windows.Forms.Button buttonCalculatePerimeter;

    private System.Windows.Forms.Button buttonStart;

    #endregion
  }
}

