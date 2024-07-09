namespace Login
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
            txtPass = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(116, 102);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(126, 22);
            txtPass.TabIndex = 0;
            txtPass.UseSystemPasswordChar = true;
            txtPass.TextChanged += textBox1_TextChanged;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(116, 40);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(126, 22);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(116, 147);
            button1.Name = "button1";
            button1.Size = new Size(108, 38);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 42);
            label2.Name = "label2";
            label2.Size = new Size(68, 16);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 104);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(686, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private TextBox txtUser;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}
