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
            lstMessageData.Items.Add(typed_msg);
            txtMessage.Clear();
            
        }
    }
}
