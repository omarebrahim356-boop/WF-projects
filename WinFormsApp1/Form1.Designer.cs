namespace WinFormsApp1
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
            t4 = new TrackBar();
            t2 = new TrackBar();
            t1 = new TrackBar();
            t3 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)t4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)t2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)t1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)t3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // t4
            // 
            t4.Cursor = Cursors.Hand;
            t4.Location = new Point(141, 318);
            t4.Maximum = 255;
            t4.Minimum = 1;
            t4.Name = "t4";
            t4.Size = new Size(614, 56);
            t4.TabIndex = 0;
            t4.TickFrequency = 5;
            t4.TickStyle = TickStyle.Both;
            t4.Value = 1;
            t4.Scroll += t4_Scroll;
            // 
            // t2
            // 
            t2.Cursor = Cursors.Hand;
            t2.Location = new Point(141, 156);
            t2.Maximum = 255;
            t2.Minimum = 1;
            t2.Name = "t2";
            t2.Size = new Size(614, 56);
            t2.TabIndex = 1;
            t2.TickFrequency = 5;
            t2.TickStyle = TickStyle.Both;
            t2.Value = 1;
            t2.Scroll += t2_Scroll;
            // 
            // t1
            // 
            t1.Cursor = Cursors.Hand;
            t1.Location = new Point(141, 81);
            t1.Maximum = 255;
            t1.Minimum = 1;
            t1.Name = "t1";
            t1.Size = new Size(614, 56);
            t1.TabIndex = 2;
            t1.TickFrequency = 5;
            t1.TickStyle = TickStyle.Both;
            t1.Value = 1;
            t1.Scroll += t1_Scroll;
            // 
            // t3
            // 
            t3.Cursor = Cursors.Hand;
            t3.Location = new Point(141, 237);
            t3.Maximum = 255;
            t3.Minimum = 1;
            t3.Name = "t3";
            t3.Size = new Size(614, 56);
            t3.TabIndex = 3;
            t3.TickFrequency = 5;
            t3.TickStyle = TickStyle.Both;
            t3.Value = 1;
            t3.Scroll += t3_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 75);
            label1.Name = "label1";
            label1.Size = new Size(39, 41);
            label1.TabIndex = 4;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 318);
            label2.Name = "label2";
            label2.Size = new Size(37, 41);
            label2.TabIndex = 5;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 237);
            label3.Name = "label3";
            label3.Size = new Size(39, 41);
            label3.TabIndex = 6;
            label3.Text = "G";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 156);
            label4.Name = "label4";
            label4.Size = new Size(38, 41);
            label4.TabIndex = 7;
            label4.Text = "R";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(802, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 266);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(392, 9);
            label5.Name = "label5";
            label5.Size = new Size(302, 38);
            label5.TabIndex = 9;
            label5.Text = "TEST ARGB (COLOUR)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 407);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(t3);
            Controls.Add(t1);
            Controls.Add(t2);
            Controls.Add(t4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)t4).EndInit();
            ((System.ComponentModel.ISupportInitialize)t2).EndInit();
            ((System.ComponentModel.ISupportInitialize)t1).EndInit();
            ((System.ComponentModel.ISupportInitialize)t3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar t4;
        private TrackBar t2;
        private TrackBar t1;
        private TrackBar t3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
