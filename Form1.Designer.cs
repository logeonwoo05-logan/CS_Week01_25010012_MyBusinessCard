namespace CS_week01_25010012_MyBusinessCard
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
            pictureBox1 = new PictureBox();
            김건우 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.스크린샷_2026_01_12_오후_4_45_58;
            pictureBox1.Location = new Point(100, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            // 
            // 김건우
            // 
            김건우.AutoSize = true;
            김건우.Font = new Font("맑은 고딕", 15F, FontStyle.Bold);
            김건우.ForeColor = SystemColors.ActiveCaptionText;
            김건우.Location = new Point(374, 99);
            김건우.Name = "김건우";
            김건우.Size = new Size(143, 54);
            김건우.TabIndex = 1;
            김건우.Text = "김건우";
            김건우.Click += label1_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11F);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(374, 167);
            label1.Name = "label1";
            label1.Size = new Size(143, 41);
            label1.TabIndex = 2;
            label1.Text = "컴퓨터sw";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11F);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(374, 225);
            label2.Name = "label2";
            label2.Size = new Size(372, 41);
            label2.TabIndex = 3;
            label2.Text = "logeonwoo05@gmail.com";
            // 
            // button1
            // 
            button1.Location = new Point(546, 369);
            button1.Name = "button1";
            button1.Size = new Size(168, 60);
            button1.TabIndex = 4;
            button1.Text = "배경색 변경";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(374, 293);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 5;
            button2.Text = "GitHub";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
            button3.Location = new Point(114, 369);
            button3.Name = "button3";
            button3.Size = new Size(196, 69);
            button3.TabIndex = 6;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(김건우);
            Controls.Add(pictureBox1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label 김건우;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
