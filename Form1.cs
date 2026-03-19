using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Messenger : Form
    {
        public Messenger()
        {
            InitializeComponent();
        }



        private void btnSend_Click(object sender, EventArgs e)
        {

            string typed_msg;
            typed_msg = txtMessage.Text;
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                return;
            }
                lstMessageData.Items.Add(typed_msg);
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
    }
}
