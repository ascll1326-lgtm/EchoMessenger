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
            lblMessageCount = new Label();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(192, 255, 192);
            btnSend.Cursor = Cursors.Hand;
            btnSend.Location = new Point(1179, 726);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(135, 46);
            btnSend.TabIndex = 0;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
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
            txtMessage.BackColor = Color.White;
            txtMessage.Cursor = Cursors.IBeam;
            txtMessage.Location = new Point(88, 733);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(1085, 39);
            txtMessage.TabIndex = 2;
            txtMessage.TextChanged += textBox1_TextChanged;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // lstMessageData
            // 
            lstMessageData.BackColor = Color.White;
            lstMessageData.FormattingEnabled = true;
            lstMessageData.Location = new Point(91, 130);
            lstMessageData.Name = "lstMessageData";
            lstMessageData.Size = new Size(1223, 580);
            lstMessageData.TabIndex = 3;
            lstMessageData.SelectedIndexChanged += lstMessageData_SelectedIndexChanged;
            // 
            // lblMessageCount
            // 
            lblMessageCount.BackColor = Color.White;
            lblMessageCount.Location = new Point(1128, 630);
            lblMessageCount.Name = "lblMessageCount";
            lblMessageCount.Size = new Size(150, 50);
            lblMessageCount.TabIndex = 4;
            lblMessageCount.TextChanged += label1_TextChanged;
            lblMessageCount.Click += label1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(1179, 778);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 48);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.Black;
            btnDeleteAll.Cursor = Cursors.Hand;
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(1104, 66);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(210, 58);
            btnDeleteAll.TabIndex = 6;
            btnDeleteAll.Text = "대화 기록 삭제";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // Messenger
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1390, 838);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(lblMessageCount);
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
            if (txtMessage.Text.Length > 50) { MessageBox.Show(" 최대 글자 수는 50자 입니다."); }
        }

        #endregion

        private Button btnSend;
        private Label lblAppName;
        private TextBox txtMessage;
        private ListBox lstMessageData;
        private Label lblMessageCount;
        private Button btnDelete;
        private Button btnDeleteAll;
    }
}
