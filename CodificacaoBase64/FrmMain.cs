using System;
using System.Windows.Forms;


namespace CodificacaoBase64 {

    public partial class FrmMain : Form {

        private Cripto b;

        public FrmMain() {
            InitializeComponent();
            b = new Cripto();
        }

        private void btnEncode_Click(object sender, EventArgs e) {
            txtEncode.Text = b.Base64Encode(txtEncode.Text);

        }

        private void btnDecode_Click(object sender, EventArgs e) {
            txtDecode.Text = b.Base64Decode(txtDecode.Text);
        }
    }
}
