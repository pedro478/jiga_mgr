using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
 

 

namespace teste_mgr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dado_recebido;

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {

            {
                dado_recebido = serialPort1.ReadExisting();

                try
                {
                    this.Invoke(new EventHandler(RecSerial));   //chama outra thread para escreve

                }
                catch
                {
                    MessageBox.Show("Erro");
                }


            }
        }

        private void RecSerial(object sender, EventArgs e)

        {

            dados_teste.Text += dado_recebido;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Config_Port

            String[] QntdPorts = SerialPort.GetPortNames();

            for (int i = 0; i < QntdPorts.Length; i++)

            {

                comb_port.Items.Add(QntdPorts[i]);
                comb_port.SelectedIndex = i;


            }



            #endregion

            #region valores_baud

            int[] ValoresBaud = { 2400, 4800, 9600, 19200, 57600, 115200 };

            for (int i = 0; i < ValoresBaud.Length; i++)

            {

                Com_BaudRate.Items.Add(ValoresBaud[i]);

            }

            Com_BaudRate.Text = "2400";

            #endregion

            #region Valores_data

            Com_Data.Items.Add("7");
            Com_Data.Items.Add("8");


            Com_Data.Text = "7";
            #endregion

            #region Valores_stop

            Com_stop.Items.Add("One");
            Com_stop.Items.Add("Two");

            Com_stop.Text = "One";

            #endregion

            #region Valores_parity

            Com_parity.Items.Add("None");
            Com_parity.Items.Add("Even");
            Com_parity.Items.Add("Odd");

            Com_parity.Text = "None";


            #endregion

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Close();

            else

            {

                serialPort1.PortName = comb_port.Text;
                serialPort1.BaudRate = int.Parse(Com_BaudRate.Text);
                serialPort1.DataBits = int.Parse(Com_Data.Text);


                if (Com_stop.SelectedIndex == 0)
                {
                    serialPort1.StopBits = StopBits.One;
                }

                else serialPort1.StopBits = StopBits.Two;



                serialPort1.Parity = (Parity)(Com_parity.SelectedIndex); 

            }


            try
            {

                serialPort1.Open();
                MessageBox.Show("Porta aberta");

                open_port.Enabled = false;
                close_port.Enabled = true;


                comb_port.Enabled = false;
                Com_BaudRate.Enabled = false;
                Com_Data.Enabled = false;
                Com_parity.Enabled = false;
                Com_stop.Enabled = false;


            }

            catch
            {

                MessageBox.Show("Erro ao abrir Porta");
            }


        }

        private void comb_port_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void close_port_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                MessageBox.Show("Porta Fechada");

                open_port.Enabled = true;
                close_port.Enabled = false;

                comb_port.Enabled = true;
                Com_BaudRate.Enabled = true;
                Com_Data.Enabled = true;
                Com_parity.Enabled = true;
                Com_stop.Enabled = true;



            }

            catch
            {
                MessageBox.Show("TEM ERRO");


            }
        }

        private void Form1_Close(object sender, EventArgs e)
        {
            serialPort1.Close();

        }

        private void teste_teclado_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)

            {
                serialPort1.Write("teste teclado");
                textBox1.Text = null;

            }

            else
            {
                MessageBox.Show("A porta não está aberta!");
            }
        }

        private void teste_display_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)

            {
                serialPort1.Write("teste display");
                textBox1.Text = null;
            }

            else
            {
                MessageBox.Show("A porta não está aberta!");
            }
        }

        private void teste_adc_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)

            {
                serialPort1.Write("teste ADC");
                textBox1.Text = null;
            }

            else
            {
                MessageBox.Show("A porta não está aberta!");
            }
        }

        private void teste_usb_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)

            {
                serialPort1.Write("teste USB");
                textBox1.Text = null;
            }

            else
            {
                MessageBox.Show("A porta não está aberta!");
            }
        }

        private void teste_bluetooth_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)

            {
                serialPort1.Write("teste bluetooh");
                textBox1.Text = null;
            }

            else
            {
                MessageBox.Show("A porta não está aberta!");
            }
        }

        private void teste_bateria_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)

            {
                serialPort1.Write("teste bateria");
                textBox1.Text = null;
            }

            else
            {
                MessageBox.Show("A porta não está aberta!");
            }
        }
    }
}
 