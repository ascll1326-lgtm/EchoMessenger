namespace EchoMessenger
{
    partial class Messenger
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
            btnSend = new Button();
            lblAppName = new Label();
            txtMessage = new TextBox();
            lstMessageData = new ListBox();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(1179, 744);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(135, 46);
            btnSend.TabIndex = 0;
            btnSend.Text = "button1";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(399, 26);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(589, 101);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Echo Messenger";
            lblAppName.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(91, 751);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(1085, 39);
            txtMessage.TabIndex = 2;
            txtMessage.TextChanged += textBox1_TextChanged;
            // 
            // lstMessageData
            // 
            lstMessageData.FormattingEnabled = true;
            lstMessageData.Location = new Point(91, 130);
            lstMessageData.Name = "lstMessageData";
            lstMessageData.Size = new Size(1223, 580);
            lstMessageData.TabIndex = 3;
            // 
            // Messenger
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 838);
            Controls.Add(lstMessageData);
            Controls.Add(txtMessage);
            Controls.Add(lblAppName);
            Controls.Add(btnSend);
            Name = "Messenger";
            Text = "My Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Button btnSend;
        private Label lblAppName;
        private TextBox txtMessage;
        private ListBox lstMessageData;
    }
}
