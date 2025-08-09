namespace Voting_application
{
    partial class Registration_Form
    {


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SkyBlue;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(279, 28);
            label4.Name = "label4";
            label4.Size = new Size(242, 38);
            label4.TabIndex = 8;
            label4.Text = "User Registration";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Location = new Point(59, 117);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 9;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Location = new Point(59, 192);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.Location = new Point(59, 350);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 11;
            label3.Text = "ConfirmPassword";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SkyBlue;
            label5.Location = new Point(59, 268);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 12;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SkyBlue;
            label6.Location = new Point(59, 422);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 13;
            label6.Text = "Unique_ID(CNIC)";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 117);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your name";
            textBox1.Size = new Size(393, 31);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(257, 188);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your email";
            textBox2.Size = new Size(393, 31);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(257, 265);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter your Password";
            textBox3.Size = new Size(393, 31);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(257, 347);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Confirm your password";
            textBox4.Size = new Size(393, 31);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(257, 418);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter a Unique ID";
            textBox5.Size = new Size(393, 31);
            textBox5.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Location = new Point(140, 552);
            button2.Name = "button2";
            button2.Size = new Size(181, 48);
            button2.TabIndex = 20;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Location = new Point(501, 552);
            button3.Name = "button3";
            button3.Size = new Size(181, 43);
            button3.TabIndex = 21;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(823, 613);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "Registration_Form";
            Text = "Registration_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private Button button3;
    }
}