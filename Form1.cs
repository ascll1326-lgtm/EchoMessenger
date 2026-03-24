using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Messenger : Form
    {
        public Messenger()
        {
            InitializeComponent();

        }


        string time = DateTime.Now.ToString("[HH:mm:ss]");


        private void btnSend_Click(object sender, EventArgs e)
        {

            string typed_msg;
            typed_msg = txtMessage.Text;
            if (string.IsNullOrWhiteSpace(txtMessage.Text)) { return; }
            else if (txtMessage.Text.Length > 50) { MessageBox.Show("전송할 수 없습니다.");
                return;
            }

            lstMessageData.Items.Add(time + " " + typed_msg.Trim());
            lblMessageCount.Text = "현재 대화: " + lstMessageData.Items.Count.ToString() + "개";
            txtMessage.Clear();
            txtMessage.Focus();

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstMessageData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstMessageData.SelectedIndex != -1)
            {
                lstMessageData.Items.RemoveAt(lstMessageData.SelectedIndex);
                lblMessageCount.Text = "현재 대화: " + lstMessageData.Items.Count.ToString() + "개";
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lstMessageData.Items.Clear();
            lblMessageCount.Text = null;
        }
    }
}
