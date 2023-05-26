namespace Bibliotek_UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Panel();
            this.RegBtn = new System.Windows.Forms.Button();
            this.RegPass = new System.Windows.Forms.TextBox();
            this.RegNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangePass = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Choice = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Register.SuspendLayout();
            this.Login.SuspendLayout();
            this.Search.SuspendLayout();
            this.ChangePass.SuspendLayout();
            this.Choice.SuspendLayout();
            this.Return.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka Classico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(290, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 52);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "personnummer";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(290, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 52);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "lösenord";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(290, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 83);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logga in";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Register.Controls.Add(this.RegBtn);
            this.Register.Controls.Add(this.RegPass);
            this.Register.Controls.Add(this.RegNum);
            this.Register.Controls.Add(this.label2);
            this.Register.Location = new System.Drawing.Point(0, 0);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(794, 442);
            this.Register.TabIndex = 4;
            // 
            // RegBtn
            // 
            this.RegBtn.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegBtn.Location = new System.Drawing.Point(255, 249);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(265, 80);
            this.RegBtn.TabIndex = 3;
            this.RegBtn.Text = "Registrera";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegPass
            // 
            this.RegPass.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegPass.Location = new System.Drawing.Point(272, 191);
            this.RegPass.Name = "RegPass";
            this.RegPass.Size = new System.Drawing.Size(231, 52);
            this.RegPass.TabIndex = 2;
            this.RegPass.Text = "lösenord";
            // 
            // RegNum
            // 
            this.RegNum.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegNum.Location = new System.Drawing.Point(272, 133);
            this.RegNum.Name = "RegNum";
            this.RegNum.Size = new System.Drawing.Size(231, 52);
            this.RegNum.TabIndex = 1;
            this.RegNum.Text = "personnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(208, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 67);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registrera konto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(591, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 61);
            this.button2.TabIndex = 4;
            this.button2.Text = "Registrera";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.Login.Controls.Add(this.label3);
            this.Login.Controls.Add(this.button2);
            this.Login.Controls.Add(this.button1);
            this.Login.Controls.Add(this.textBox2);
            this.Login.Controls.Add(this.textBox1);
            this.Login.Controls.Add(this.label1);
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(802, 445);
            this.Login.TabIndex = 5;
            this.Login.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(603, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inget konto?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Search
            // 
            this.Search.Controls.Add(this.button4);
            this.Search.Controls.Add(this.textBox5);
            this.Search.Controls.Add(this.label5);
            this.Search.Location = new System.Drawing.Point(0, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(802, 445);
            this.Search.TabIndex = 6;
            this.Search.Paint += new System.Windows.Forms.PaintEventHandler(this.Search_Paint_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(509, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sök";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(229, 194);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(274, 56);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(243, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 67);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sök efter bok";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // ChangePass
            // 
            this.ChangePass.Controls.Add(this.button5);
            this.ChangePass.Controls.Add(this.textBox7);
            this.ChangePass.Controls.Add(this.textBox6);
            this.ChangePass.Controls.Add(this.label7);
            this.ChangePass.Controls.Add(this.label6);
            this.ChangePass.Controls.Add(this.label4);
            this.ChangePass.Location = new System.Drawing.Point(0, 0);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(802, 445);
            this.ChangePass.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(325, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "Confirm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(272, 274);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(261, 52);
            this.textBox7.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(272, 171);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(261, 52);
            this.textBox6.TabIndex = 3;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(290, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 46);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nytt lösenord";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(243, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nuvarande lösenord";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(221, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 67);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ändra Lösenord";
            // 
            // Choice
            // 
            this.Choice.Controls.Add(this.label8);
            this.Choice.Controls.Add(this.button7);
            this.Choice.Controls.Add(this.button6);
            this.Choice.Location = new System.Drawing.Point(0, 0);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(799, 454);
            this.Choice.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(197, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(419, 67);
            this.label8.TabIndex = 2;
            this.label8.Text = "Vad vill du göra?";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(221, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(348, 77);
            this.button7.TabIndex = 1;
            this.button7.Text = "Returnera bok";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(276, 137);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(239, 77);
            this.button6.TabIndex = 0;
            this.button6.Text = "Låna bok";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Controls.Add(this.button8);
            this.Return.Controls.Add(this.label10);
            this.Return.Controls.Add(this.textBox8);
            this.Return.Controls.Add(this.label9);
            this.Return.Location = new System.Drawing.Point(0, 0);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(796, 448);
            this.Return.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(272, 285);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(260, 79);
            this.button8.TabIndex = 3;
            this.button8.Text = "Returnera";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(290, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 46);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bok namn/id";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(197, 212);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(401, 52);
            this.textBox8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(180, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(436, 67);
            this.label9.TabIndex = 0;
            this.label9.Text = "Returnera en bok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ChangePass.ResumeLayout(false);
            this.ChangePass.PerformLayout();
            this.Choice.ResumeLayout(false);
            this.Choice.PerformLayout();
            this.Return.ResumeLayout(false);
            this.Return.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Panel Register;
        private Button button2;
        private Panel Login;
        private Label label2;
        private Button RegBtn;
        private TextBox RegPass;
        private TextBox RegNum;
        private Label label3;
        private Panel Search;
        private TextBox textBox5;
        private Label label5;
        private Button button4;
        private Panel ChangePass;
        private Label label6;
        private Label label4;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private Button button5;
        private Panel Choice;
        private Label label8;
        private Button button7;
        private Button button6;
        private Panel Return;
        private Button button8;
        private Label label10;
        private TextBox textBox8;
        private Label label9;
    }
}