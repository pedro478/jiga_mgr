namespace teste_mgr
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.close_port = new System.Windows.Forms.Button();
            this.open_port = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Com_parity = new System.Windows.Forms.ComboBox();
            this.Com_stop = new System.Windows.Forms.ComboBox();
            this.Com_Data = new System.Windows.Forms.ComboBox();
            this.Com_BaudRate = new System.Windows.Forms.ComboBox();
            this.comb_port = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dados_teste = new System.Windows.Forms.TextBox();
            this.teste_bateria = new System.Windows.Forms.Button();
            this.teste_bluetooth = new System.Windows.Forms.Button();
            this.teste_usb = new System.Windows.Forms.Button();
            this.teste_adc = new System.Windows.Forms.Button();
            this.teste_display = new System.Windows.Forms.Button();
            this.teste_teclado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 144);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(233, 79);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Reparo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(233, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Ativação";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modelo PCI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fornecedor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados da PCI";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 171);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 275);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.close_port);
            this.tabPage1.Controls.Add(this.open_port);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Com_parity);
            this.tabPage1.Controls.Add(this.Com_stop);
            this.tabPage1.Controls.Add(this.Com_Data);
            this.tabPage1.Controls.Add(this.Com_BaudRate);
            this.tabPage1.Controls.Add(this.comb_port);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Configuração";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // close_port
            // 
            this.close_port.Location = new System.Drawing.Point(151, 209);
            this.close_port.Name = "close_port";
            this.close_port.Size = new System.Drawing.Size(75, 23);
            this.close_port.TabIndex = 21;
            this.close_port.Text = "Close Port";
            this.close_port.UseVisualStyleBackColor = true;
            this.close_port.Click += new System.EventHandler(this.close_port_Click);
            // 
            // open_port
            // 
            this.open_port.Location = new System.Drawing.Point(151, 165);
            this.open_port.Name = "open_port";
            this.open_port.Size = new System.Drawing.Size(75, 23);
            this.open_port.TabIndex = 12;
            this.open_port.Text = "Open Port";
            this.open_port.UseVisualStyleBackColor = true;
            this.open_port.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Parity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stop Bits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Data Bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Baud Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "COM Port";
            // 
            // Com_parity
            // 
            this.Com_parity.FormattingEnabled = true;
            this.Com_parity.Location = new System.Drawing.Point(17, 209);
            this.Com_parity.Name = "Com_parity";
            this.Com_parity.Size = new System.Drawing.Size(100, 21);
            this.Com_parity.TabIndex = 16;
            // 
            // Com_stop
            // 
            this.Com_stop.FormattingEnabled = true;
            this.Com_stop.Location = new System.Drawing.Point(17, 165);
            this.Com_stop.Name = "Com_stop";
            this.Com_stop.Size = new System.Drawing.Size(100, 21);
            this.Com_stop.TabIndex = 15;
            // 
            // Com_Data
            // 
            this.Com_Data.FormattingEnabled = true;
            this.Com_Data.Location = new System.Drawing.Point(17, 120);
            this.Com_Data.Name = "Com_Data";
            this.Com_Data.Size = new System.Drawing.Size(100, 21);
            this.Com_Data.TabIndex = 14;
            // 
            // Com_BaudRate
            // 
            this.Com_BaudRate.FormattingEnabled = true;
            this.Com_BaudRate.Location = new System.Drawing.Point(17, 73);
            this.Com_BaudRate.Name = "Com_BaudRate";
            this.Com_BaudRate.Size = new System.Drawing.Size(100, 21);
            this.Com_BaudRate.TabIndex = 13;
            // 
            // comb_port
            // 
            this.comb_port.FormattingEnabled = true;
            this.comb_port.Location = new System.Drawing.Point(17, 27);
            this.comb_port.Name = "comb_port";
            this.comb_port.Size = new System.Drawing.Size(100, 21);
            this.comb_port.TabIndex = 12;
            this.comb_port.SelectedIndexChanged += new System.EventHandler(this.comb_port_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.dados_teste);
            this.tabPage2.Controls.Add(this.teste_bateria);
            this.tabPage2.Controls.Add(this.teste_bluetooth);
            this.tabPage2.Controls.Add(this.teste_usb);
            this.tabPage2.Controls.Add(this.teste_adc);
            this.tabPage2.Controls.Add(this.teste_display);
            this.tabPage2.Controls.Add(this.teste_teclado);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teste Funcional";
            // 
            // dados_teste
            // 
            this.dados_teste.Location = new System.Drawing.Point(160, 16);
            this.dados_teste.Multiline = true;
            this.dados_teste.Name = "dados_teste";
            this.dados_teste.Size = new System.Drawing.Size(344, 215);
            this.dados_teste.TabIndex = 6;
            // 
            // teste_bateria
            // 
            this.teste_bateria.Location = new System.Drawing.Point(17, 208);
            this.teste_bateria.Name = "teste_bateria";
            this.teste_bateria.Size = new System.Drawing.Size(103, 23);
            this.teste_bateria.TabIndex = 5;
            this.teste_bateria.Text = "Teste Bateria";
            this.teste_bateria.UseVisualStyleBackColor = true;
            this.teste_bateria.Click += new System.EventHandler(this.teste_bateria_Click);
            // 
            // teste_bluetooth
            // 
            this.teste_bluetooth.Location = new System.Drawing.Point(17, 170);
            this.teste_bluetooth.Name = "teste_bluetooth";
            this.teste_bluetooth.Size = new System.Drawing.Size(103, 23);
            this.teste_bluetooth.TabIndex = 4;
            this.teste_bluetooth.Text = "Teste Bluetooh";
            this.teste_bluetooth.UseVisualStyleBackColor = true;
            this.teste_bluetooth.Click += new System.EventHandler(this.teste_bluetooth_Click);
            // 
            // teste_usb
            // 
            this.teste_usb.Location = new System.Drawing.Point(17, 131);
            this.teste_usb.Name = "teste_usb";
            this.teste_usb.Size = new System.Drawing.Size(103, 23);
            this.teste_usb.TabIndex = 3;
            this.teste_usb.Text = "Teste USB";
            this.teste_usb.UseVisualStyleBackColor = true;
            this.teste_usb.Click += new System.EventHandler(this.teste_usb_Click);
            // 
            // teste_adc
            // 
            this.teste_adc.Location = new System.Drawing.Point(17, 93);
            this.teste_adc.Name = "teste_adc";
            this.teste_adc.Size = new System.Drawing.Size(103, 23);
            this.teste_adc.TabIndex = 2;
            this.teste_adc.Text = "Teste ADC";
            this.teste_adc.UseVisualStyleBackColor = true;
            this.teste_adc.Click += new System.EventHandler(this.teste_adc_Click);
            // 
            // teste_display
            // 
            this.teste_display.Location = new System.Drawing.Point(17, 54);
            this.teste_display.Name = "teste_display";
            this.teste_display.Size = new System.Drawing.Size(103, 23);
            this.teste_display.TabIndex = 1;
            this.teste_display.Text = "Teste Display";
            this.teste_display.UseVisualStyleBackColor = true;
            this.teste_display.Click += new System.EventHandler(this.teste_display_Click);
            // 
            // teste_teclado
            // 
            this.teste_teclado.Location = new System.Drawing.Point(17, 16);
            this.teste_teclado.Name = "teste_teclado";
            this.teste_teclado.Size = new System.Drawing.Size(103, 23);
            this.teste_teclado.TabIndex = 0;
            this.teste_teclado.Text = "Teste Teclado";
            this.teste_teclado.UseVisualStyleBackColor = true;
            this.teste_teclado.Click += new System.EventHandler(this.teste_teclado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 475);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button close_port;
        private System.Windows.Forms.Button open_port;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Com_parity;
        private System.Windows.Forms.ComboBox Com_stop;
        private System.Windows.Forms.ComboBox Com_Data;
        private System.Windows.Forms.ComboBox Com_BaudRate;
        private System.Windows.Forms.ComboBox comb_port;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button teste_bateria;
        private System.Windows.Forms.Button teste_bluetooth;
        private System.Windows.Forms.Button teste_usb;
        private System.Windows.Forms.Button teste_adc;
        private System.Windows.Forms.Button teste_display;
        private System.Windows.Forms.Button teste_teclado;
        private System.Windows.Forms.TextBox dados_teste;
    }
}

