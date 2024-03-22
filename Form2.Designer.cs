namespace Quad_Design2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FreqIn = new TextBox();
            R1 = new TextBox();
            R2 = new TextBox();
            R3 = new TextBox();
            R4 = new TextBox();
            R5 = new TextBox();
            CalcBtn = new Button();
            ResetBtn = new Button();
            CloseBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 0;
            label1.Text = "Frequency in Mhz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 1;
            label2.Text = "L1 Reflector:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 2;
            label3.Text = "L2 Driven:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 3;
            label4.Text = "L3 Director 1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 4;
            label5.Text = "L4 Director 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 267);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 5;
            label6.Text = "Spacing";
            // 
            // FreqIn
            // 
            FreqIn.Location = new Point(154, 45);
            FreqIn.Name = "FreqIn";
            FreqIn.Size = new Size(100, 23);
            FreqIn.TabIndex = 6;
            // 
            // R1
            // 
            R1.Location = new Point(154, 87);
            R1.Name = "R1";
            R1.ReadOnly = true;
            R1.Size = new Size(100, 23);
            R1.TabIndex = 7;
            // 
            // R2
            // 
            R2.Location = new Point(154, 130);
            R2.Name = "R2";
            R2.ReadOnly = true;
            R2.Size = new Size(100, 23);
            R2.TabIndex = 8;
            // 
            // R3
            // 
            R3.Location = new Point(154, 177);
            R3.Name = "R3";
            R3.ReadOnly = true;
            R3.Size = new Size(100, 23);
            R3.TabIndex = 9;
            // 
            // R4
            // 
            R4.Location = new Point(154, 221);
            R4.Name = "R4";
            R4.ReadOnly = true;
            R4.Size = new Size(100, 23);
            R4.TabIndex = 10;
            // 
            // R5
            // 
            R5.Location = new Point(154, 269);
            R5.Name = "R5";
            R5.ReadOnly = true;
            R5.Size = new Size(100, 23);
            R5.TabIndex = 11;
            // 
            // CalcBtn
            // 
            CalcBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalcBtn.Location = new Point(154, 329);
            CalcBtn.Name = "CalcBtn";
            CalcBtn.Size = new Size(75, 23);
            CalcBtn.TabIndex = 12;
            CalcBtn.Text = "Calculate";
            CalcBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.Location = new Point(247, 329);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(75, 23);
            ResetBtn.TabIndex = 13;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CloseBtn.Location = new Point(344, 329);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 23);
            CloseBtn.TabIndex = 14;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.quad;
            pictureBox1.Location = new Point(420, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 280);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(CloseBtn);
            Controls.Add(ResetBtn);
            Controls.Add(CalcBtn);
            Controls.Add(R5);
            Controls.Add(R4);
            Controls.Add(R3);
            Controls.Add(R2);
            Controls.Add(R1);
            Controls.Add(FreqIn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Quad Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox FreqIn;
        private TextBox R1;
        private TextBox R2;
        private TextBox R3;
        private TextBox R4;
        private TextBox R5;
        private Button CalcBtn;
        private Button ResetBtn;
        private Button CloseBtn;
        private PictureBox pictureBox1;
    }
}