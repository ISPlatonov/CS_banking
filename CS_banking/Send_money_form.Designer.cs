namespace CS_banking
{
    partial class Send_money_form
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
            recipient_combobox = new ComboBox();
            send_button = new Button();
            amount_textbox = new TextBox();
            SuspendLayout();
            // 
            // recipient_combobox
            // 
            recipient_combobox.FormattingEnabled = true;
            recipient_combobox.Location = new Point(234, 116);
            recipient_combobox.Name = "recipient_combobox";
            recipient_combobox.Size = new Size(342, 40);
            recipient_combobox.TabIndex = 0;
            // 
            // send_button
            // 
            send_button.Location = new Point(322, 275);
            send_button.Name = "send_button";
            send_button.Size = new Size(150, 46);
            send_button.TabIndex = 1;
            send_button.Text = "send";
            send_button.UseVisualStyleBackColor = true;
            // 
            // amount_textbox
            // 
            amount_textbox.Location = new Point(234, 186);
            amount_textbox.Name = "amount_textbox";
            amount_textbox.PlaceholderText = "amount";
            amount_textbox.Size = new Size(342, 39);
            amount_textbox.TabIndex = 2;
            // 
            // Send_money_form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(amount_textbox);
            Controls.Add(send_button);
            Controls.Add(recipient_combobox);
            Name = "Send_money_form";
            Text = "Send_money_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox recipient_combobox;
        private Button send_button;
        private TextBox amount_textbox;
    }
}