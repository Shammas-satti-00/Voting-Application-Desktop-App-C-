namespace Voting_application
{
    partial class Election_form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Election_form));
            label4 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(306, 20);
            label4.Name = "label4";
            label4.Size = new Size(165, 40);
            label4.TabIndex = 9;
            label4.Text = "Voting Day";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            radioButton4.Location = new Point(0, 0);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(104, 24);
            radioButton4.TabIndex = 0;
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(0, 0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(104, 24);
            radioButton3.TabIndex = 0;
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(0, 0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 24);
            radioButton2.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(0, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 24);
            radioButton1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(223, 32);
            label3.Name = "label3";
            label3.Size = new Size(155, 50);
            label3.TabIndex = 10;
            label3.Text = "Election";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SkyBlue;
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(116, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 279);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Candidates";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.ForeColor = Color.White;
            radioButton8.Location = new Point(107, 229);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(127, 29);
            radioButton8.TabIndex = 3;
            radioButton8.TabStop = true;
            radioButton8.Text = "Candidate4";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.ForeColor = Color.White;
            radioButton7.Location = new Point(107, 172);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(127, 29);
            radioButton7.TabIndex = 2;
            radioButton7.TabStop = true;
            radioButton7.Text = "Candidate3";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.ForeColor = Color.White;
            radioButton6.Location = new Point(107, 115);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(127, 29);
            radioButton6.TabIndex = 1;
            radioButton6.TabStop = true;
            radioButton6.Text = "Candidate2";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.ForeColor = Color.White;
            radioButton5.Location = new Point(107, 56);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(127, 29);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "Candidate1";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.ForeColor = Color.White;
            button3.Location = new Point(133, 506);
            button3.Name = "button3";
            button3.Size = new Size(145, 45);
            button3.TabIndex = 12;
            button3.Text = "Submit Vote";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.ForeColor = Color.White;
            button4.Location = new Point(356, 506);
            button4.Name = "button4";
            button4.Size = new Size(111, 45);
            button4.TabIndex = 13;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SkyBlue;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(197, 448);
            label5.Name = "label5";
            label5.Size = new Size(231, 25);
            label5.TabIndex = 14;
            label5.Text = "Vote Successfully casted!!";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SkyBlue;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(127, 103);
            label6.Name = "label6";
            label6.Size = new Size(371, 25);
            label6.TabIndex = 15;
            label6.Text = "Submit Your Vote (you can vote only once)";
            // 
            // Election_form
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(823, 613);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Name = "Election_form";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label label6;
    }
}
