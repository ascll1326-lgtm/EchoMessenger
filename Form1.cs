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
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
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
    }
}
