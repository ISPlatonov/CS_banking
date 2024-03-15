namespace CS_banking
{
    partial class Sign_in_form
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
            button_sign_in = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox_password = new TextBox();
            textBox_username = new TextBox();
            button_cancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button_sign_in
            // 
            button_sign_in.Location = new Point(620, 373);
            button_sign_in.Name = "button_sign_in";
            button_sign_in.Size = new Size(150, 46);
            button_sign_in.TabIndex = 0;
            button_sign_in.Text = "sign in";
            button_sign_in.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.Location = new Point(316, 69);
            label1.Name = "label1";
            label1.Size = new Size(173, 65);
            label1.TabIndex = 1;
            label1.Text = "Sign in";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_password);
            groupBox1.Controls.Add(textBox_username);
            groupBox1.Location = new Point(257, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 170);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign in form";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(45, 112);
            textBox_password.Name = "textBox_password";
            textBox_password.PlaceholderText = "password";
            textBox_password.Size = new Size(200, 39);
            textBox_password.TabIndex = 5;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(45, 38);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "username";
            textBox_username.Size = new Size(200, 39);
            textBox_username.TabIndex = 4;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(74, 373);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(150, 46);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "cancel";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancel);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button_sign_in);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_sign_in;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox_username;
        private Button button_cancel;
        private TextBox textBox_password;
    }
}
