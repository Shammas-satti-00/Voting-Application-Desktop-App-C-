namespace Voting_application
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(49, 153);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(49, 253);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 152);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your email";
            textBox1.Size = new Size(393, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 252);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Password";
            textBox2.Size = new Size(393, 31);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(220, 362);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 4;
            button1.Text = "Login(User)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(300, 477);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 5;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.Location = new Point(340, 423);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 6;
            label3.Text = "OR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SkyBlue;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(331, 48);
            label4.Name = "label4";
            label4.Size = new Size(124, 48);
            label4.TabIndex = 7;
            label4.Text = "Login ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SkyBlue;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(296, 311);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 8;
            label5.Text = "Invalid Credentials";
            label5.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(383, 362);
            button3.Name = "button3";
            button3.Size = new Size(144, 43);
            button3.TabIndex = 9;
            button3.Text = "Login(Admin)";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(823, 533);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
    }
}