namespace Game_of_Life
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            START_STOP = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            RESET = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // START_STOP
            // 
            START_STOP.Location = new Point(618, 12);
            START_STOP.Name = "START_STOP";
            START_STOP.Size = new Size(152, 60);
            START_STOP.TabIndex = 1;
            START_STOP.Text = "START";
            START_STOP.UseVisualStyleBackColor = true;
            START_STOP.Click += START_STOP_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(618, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "200";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RESET
            // 
            RESET.Location = new Point(618, 107);
            RESET.Name = "RESET";
            RESET.Size = new Size(152, 60);
            RESET.TabIndex = 3;
            RESET.Text = "RESET";
            RESET.UseVisualStyleBackColor = true;
            RESET.Click += RESET_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 626);
            Controls.Add(RESET);
            Controls.Add(textBox1);
            Controls.Add(START_STOP);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button START_STOP;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Button RESET;
    }
}