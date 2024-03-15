namespace CS_banking
{
    partial class DB_connect_form
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
            groupBox1 = new GroupBox();
            db_address = new TextBox();
            textBox_password = new TextBox();
            textBox_username = new TextBox();
            label1 = new Label();
            db_connect_button = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(db_address);
            groupBox1.Controls.Add(textBox_password);
            groupBox1.Controls.Add(textBox_username);
            groupBox1.Location = new Point(235, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 255);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "DB data";
            // 
            // db_address
            // 
            db_address.Location = new Point(45, 186);
            db_address.Name = "db_address";
            db_address.PlaceholderText = "DB address";
            db_address.Size = new Size(200, 39);
            db_address.TabIndex = 6;
            db_address.Text = "localhost";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.Location = new Point(167, 58);
            label1.Name = "label1";
            label1.Size = new Size(462, 65);
            label1.TabIndex = 5;
            label1.Text = "Connect to database";
            // 
            // db_connect_button
            // 
            db_connect_button.Location = new Point(598, 354);
            db_connect_button.Name = "db_connect_button";
            db_connect_button.Size = new Size(150, 46);
            db_connect_button.TabIndex = 4;
            db_connect_button.Text = "sign in";
            db_connect_button.UseVisualStyleBackColor = true;
            // 
            // DB_connect_form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(db_connect_button);
            Name = "DB_connect_form";
            Text = "DB_connect_form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox db_address;
        private TextBox textBox_password;
        private TextBox textBox_username;
        private Label label1;
        private Button db_connect_button;
    }
}