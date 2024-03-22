namespace Quad_Design2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ExitBtn = new Button();
            StartBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 60);
            label1.Name = "label1";
            label1.Size = new Size(204, 45);
            label1.TabIndex = 0;
            label1.Text = "Quad Design";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 122);
            label2.Name = "label2";
            label2.Size = new Size(286, 21);
            label2.TabIndex = 1;
            label2.Text = "Copyrtight (c) N.Booth for Mogpie 2024";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.quad;
            pictureBox1.Location = new Point(211, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 276);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(583, 415);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 23);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(130, 415);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(75, 23);
            StartBtn.TabIndex = 4;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartBtn);
            Controls.Add(ExitBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Quad Design";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button ExitBtn;
        private Button StartBtn;
    }
}
