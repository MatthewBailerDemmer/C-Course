using System.IO.Ports;
namespace ComunicacaoArduino

{
    public partial class Form1 : Form
    {
        SerialPort minhaSerial;
        public Form1()
        {
            InitializeComponent();
            minhaSerial = new SerialPort();
        }
        private void UpdateRichTextBox(string pTexto)
        {
            if (richTextBoxDadosRecebidos.InvokeRequired == true)
                richTextBoxDadosRecebidos.Invoke((MethodInvoker)(() => UpdateRichTextBox(pTexto)));
            else
                richTextBoxDadosRecebidos.Text += pTexto;
        }

        public void eventoDadosRecebidosSerial(object sender, SerialDataReceivedEventArgs e)
        {
            if (minhaSerial.IsOpen)
            {
                string dadosRecebidos = minhaSerial.ReadExisting();
                UpdateRichTextBox(dadosRecebidos);
            }
        }

        public void AbreSerial(string comSTR, int velocidade)
        {
            if (comSTR != "")
            {
                if (!minhaSerial.IsOpen)
                {
                    minhaSerial = new SerialPort(comSTR, velocidade);
                    minhaSerial.Open();
                    minhaSerial.DataReceived += eventoDadosRecebidosSerial;
                }
                else
                    MessageBox.Show("Serial já conectada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Escolha uma porta COM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void FechaSerial()
        {
            if (!minhaSerial.IsOpen)
            {
                minhaSerial.DataReceived -= eventoDadosRecebidosSerial;
                minhaSerial.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] coms = SerialPort.GetPortNames();
            if (coms.Count() > 0)
            {
                string conteudoAntigo = comboBoxComs.Text;
                comboBoxComs.Items.Clear();
                comboBoxComs.Items.AddRange(coms);
                if (comboBoxComs.Items.Contains(conteudoAntigo))
                {
                    comboBoxComs.SelectedIndex = comboBoxComs.Items.IndexOf(conteudoAntigo);
                }
                else
                {
                    comboBoxComs.Text = "";
                    FechaSerial();
                }
            }
            else
            {
                comboBoxComs.Items.Clear();
                comboBoxComs.Text = "";
                FechaSerial();
            }
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            AbreSerial(comboBoxComs.Text, 9600);
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (minhaSerial.IsOpen)
            {
                minhaSerial.Write(textBoxDadosEnviados.Text);
            }
            else
                MessageBox.Show("Serial Desconectada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FechaSerial();
        }
    }
}