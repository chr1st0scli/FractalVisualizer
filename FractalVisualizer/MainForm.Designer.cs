namespace FractalVisualizer
{
    partial class MainForm
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
            this.levelNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.color1TextBox = new System.Windows.Forms.TextBox();
            this.color2TextBox = new System.Windows.Forms.TextBox();
            this.color1Button = new System.Windows.Forms.Button();
            this.color2Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.redNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fractalComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.levelNumUpDown)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // levelNumUpDown
            // 
            this.levelNumUpDown.Location = new System.Drawing.Point(303, 17);
            this.levelNumUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.levelNumUpDown.Name = "levelNumUpDown";
            this.levelNumUpDown.Size = new System.Drawing.Size(40, 20);
            this.levelNumUpDown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Level";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(492, 299);
            this.panel.TabIndex = 0;
            // 
            // color1TextBox
            // 
            this.color1TextBox.Location = new System.Drawing.Point(48, 17);
            this.color1TextBox.Name = "color1TextBox";
            this.color1TextBox.ReadOnly = true;
            this.color1TextBox.Size = new System.Drawing.Size(71, 20);
            this.color1TextBox.TabIndex = 1;
            // 
            // color2TextBox
            // 
            this.color2TextBox.Location = new System.Drawing.Point(156, 17);
            this.color2TextBox.Name = "color2TextBox";
            this.color2TextBox.ReadOnly = true;
            this.color2TextBox.Size = new System.Drawing.Size(71, 20);
            this.color2TextBox.TabIndex = 3;
            // 
            // color1Button
            // 
            this.color1Button.Location = new System.Drawing.Point(125, 15);
            this.color1Button.Name = "color1Button";
            this.color1Button.Size = new System.Drawing.Size(25, 23);
            this.color1Button.TabIndex = 2;
            this.color1Button.Text = "...";
            this.color1Button.UseVisualStyleBackColor = true;
            this.color1Button.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // color2Button
            // 
            this.color2Button.Location = new System.Drawing.Point(233, 15);
            this.color2Button.Name = "color2Button";
            this.color2Button.Size = new System.Drawing.Size(25, 23);
            this.color2Button.TabIndex = 4;
            this.color2Button.Text = "...";
            this.color2Button.UseVisualStyleBackColor = true;
            this.color2Button.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Colors";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 317);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(491, 78);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.levelNumUpDown);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.color2TextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.color1Button);
            this.tabPage1.Controls.Add(this.color2Button);
            this.tabPage1.Controls.Add(this.color1TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 52);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sierpinski Triangle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.blueNumericUpDown);
            this.tabPage2.Controls.Add(this.greenNumericUpDown);
            this.tabPage2.Controls.Add(this.redNumericUpDown);
            this.tabPage2.Controls.Add(this.fractalComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(437, 52);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Divergent Fractals, Zn+1 = Zn^2 + C";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "R";
            // 
            // blueNumericUpDown
            // 
            this.blueNumericUpDown.Location = new System.Drawing.Point(355, 16);
            this.blueNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.blueNumericUpDown.Name = "blueNumericUpDown";
            this.blueNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.blueNumericUpDown.TabIndex = 6;
            // 
            // greenNumericUpDown
            // 
            this.greenNumericUpDown.Location = new System.Drawing.Point(291, 16);
            this.greenNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.greenNumericUpDown.Name = "greenNumericUpDown";
            this.greenNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.greenNumericUpDown.TabIndex = 4;
            // 
            // redNumericUpDown
            // 
            this.redNumericUpDown.Location = new System.Drawing.Point(226, 16);
            this.redNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.redNumericUpDown.Name = "redNumericUpDown";
            this.redNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.redNumericUpDown.TabIndex = 2;
            // 
            // fractalComboBox
            // 
            this.fractalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fractalComboBox.FormattingEnabled = true;
            this.fractalComboBox.Location = new System.Drawing.Point(6, 16);
            this.fractalComboBox.Name = "fractalComboBox";
            this.fractalComboBox.Size = new System.Drawing.Size(193, 21);
            this.fractalComboBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 398);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FractalVisualizer";
            ((System.ComponentModel.ISupportInitialize)(this.levelNumUpDown)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown levelNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox color1TextBox;
        private System.Windows.Forms.TextBox color2TextBox;
        private System.Windows.Forms.Button color1Button;
        private System.Windows.Forms.Button color2Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox fractalComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown blueNumericUpDown;
        private System.Windows.Forms.NumericUpDown greenNumericUpDown;
        private System.Windows.Forms.NumericUpDown redNumericUpDown;
    }
}

