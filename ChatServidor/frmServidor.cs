using System;
using System.Net;
using System.Windows.Forms;

namespace ChatServidor
{
    public partial class frmServidor : Form
    {

        private delegate void AtualizaStatusCallback(string strMensagem);

        public frmServidor()
        {
            InitializeComponent();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            // Analisa o endereço IP do servidor informado no textbox
            IPAddress enderecoIP = IPAddress.Parse(txtIP.Text);

            // Cria uma nova instância do objeto ChatServidor
            ChatServidor mainServidor = new ChatServidor(enderecoIP);

            // Vincula o tratamento de evento StatusChanged a mainServer_StatusChanged
            ChatServidor.StatusChanged += new StatusChangedEventHandler(mainServer_StatusChanged);

            // Inicia o atendimento das conexões
            mainServidor.IniciaAtendimento();

            // Mostra que nos iniciamos o atendimento para conexões
            txtLog.AppendText("Monitorando as conexões...\r\n");
        }

        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Chama o método que atualiza o formulário
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
        }

        private void AtualizaStatus(string strMensagem)
        {
            // Atualiza o logo com mensagens
            txtLog.AppendText(strMensagem + "\r\n");
        }
    }
}
