namespace GraphicsInterface
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
            this.graphicsOutput = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.EntitySelected = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowFrontR = new System.Windows.Forms.RadioButton();
            this.ShowFrontC = new System.Windows.Forms.RadioButton();
            this.ShowHittingLines = new System.Windows.Forms.CheckBox();
            this.ShowAllLines = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsOutput)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphicsOutput
            // 
            this.graphicsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphicsOutput.Location = new System.Drawing.Point(12, 12);
            this.graphicsOutput.Name = "graphicsOutput";
            this.graphicsOutput.Size = new System.Drawing.Size(1000, 1000);
            this.graphicsOutput.TabIndex = 0;
            this.graphicsOutput.TabStop = false;
            this.graphicsOutput.Click += new System.EventHandler(this.graphicsOutput_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Jump";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(3, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 45);
            this.panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gen";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 27);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 27);
            this.panel3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tick";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(1040, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 548);
            this.panel4.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "Unselect";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // EntitySelected
            // 
            this.EntitySelected.FormattingEnabled = true;
            this.EntitySelected.Location = new System.Drawing.Point(3, 3);
            this.EntitySelected.Name = "EntitySelected";
            this.EntitySelected.Size = new System.Drawing.Size(169, 147);
            this.EntitySelected.TabIndex = 7;
            this.EntitySelected.SelectedIndexChanged += new System.EventHandler(this.EntitySelected_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.EntitySelected);
            this.panel5.Location = new System.Drawing.Point(1040, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(432, 202);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.ShowHittingLines);
            this.panel6.Controls.Add(this.ShowAllLines);
            this.panel6.Location = new System.Drawing.Point(178, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 194);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.radioButton1);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.ShowFrontR);
            this.panel7.Controls.Add(this.ShowFrontC);
            this.panel7.Location = new System.Drawing.Point(7, 49);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(88, 92);
            this.panel7.TabIndex = 16;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "None";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Show Front As:";
            // 
            // ShowFrontR
            // 
            this.ShowFrontR.AutoSize = true;
            this.ShowFrontR.Location = new System.Drawing.Point(4, 67);
            this.ShowFrontR.Name = "ShowFrontR";
            this.ShowFrontR.Size = new System.Drawing.Size(74, 17);
            this.ShowFrontR.TabIndex = 13;
            this.ShowFrontR.TabStop = true;
            this.ShowFrontR.Text = "Rectangle";
            this.ShowFrontR.UseVisualStyleBackColor = true;
            this.ShowFrontR.CheckedChanged += new System.EventHandler(this.ShowFrontR_CheckedChanged);
            // 
            // ShowFrontC
            // 
            this.ShowFrontC.AutoSize = true;
            this.ShowFrontC.Location = new System.Drawing.Point(4, 44);
            this.ShowFrontC.Name = "ShowFrontC";
            this.ShowFrontC.Size = new System.Drawing.Size(51, 17);
            this.ShowFrontC.TabIndex = 12;
            this.ShowFrontC.TabStop = true;
            this.ShowFrontC.Text = "Circle";
            this.ShowFrontC.UseVisualStyleBackColor = true;
            this.ShowFrontC.CheckedChanged += new System.EventHandler(this.ShowFrontC_CheckedChanged);
            // 
            // ShowHittingLines
            // 
            this.ShowHittingLines.AutoSize = true;
            this.ShowHittingLines.Location = new System.Drawing.Point(7, 26);
            this.ShowHittingLines.Name = "ShowHittingLines";
            this.ShowHittingLines.Size = new System.Drawing.Size(67, 17);
            this.ShowHittingLines.TabIndex = 11;
            this.ShowHittingLines.Text = "Hit Lines";
            this.ShowHittingLines.UseVisualStyleBackColor = true;
            // 
            // ShowAllLines
            // 
            this.ShowAllLines.AutoSize = true;
            this.ShowAllLines.Location = new System.Drawing.Point(7, 3);
            this.ShowAllLines.Name = "ShowAllLines";
            this.ShowAllLines.Size = new System.Drawing.Size(82, 17);
            this.ShowAllLines.TabIndex = 10;
            this.ShowAllLines.Text = "Vision Lines";
            this.ShowAllLines.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 1022);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.graphicsOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphicsOutput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graphicsOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox EntitySelected;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox ShowAllLines;
        private System.Windows.Forms.CheckBox ShowHittingLines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ShowFrontR;
        private System.Windows.Forms.RadioButton ShowFrontC;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel7;
    }
}

