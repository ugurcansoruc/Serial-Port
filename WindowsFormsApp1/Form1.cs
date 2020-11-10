using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
 
        public Form1()
        {
            InitializeComponent();
        }
        
        public void Form1_Load(object sender, EventArgs e)
        {
            InitializeCombobox();
        }

        public void InitializeCombobox()
        {
            string[] baudRates = new string[] { "19200", "9600" };
            BaudRateComboBox.Items.AddRange(baudRates);
            BaudRateComboBox.SelectedIndex = 1;

            string[] dataBits = new string[] { "5", "6", "7", "8" };
            DataBitComboBox.Items.AddRange(dataBits);
            DataBitComboBox.SelectedIndex = 3;

            foreach (string s in SerialPort.GetPortNames())
            {
                PortNameComboBox.Items.Add(s);
            }
            PortNameComboBox.SelectedIndex = 1;

            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                ParityComboBox.Items.Add(s);
            }
            ParityComboBox.SelectedIndex = 0;
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                ShowRead(text);
            }
        }

        
        public void Read(object sender, SerialDataReceivedEventArgs e)
        {
            string message = _serialPort.ReadExisting().ToString();
            SetText(message);
        }
        
        public void ShowRead(string data)
        {
            string[] splittedDatas;
            splittedDatas = data.Split(',');

            DataTextBox.Text = data;

            int data1 = Int16.Parse(splittedDatas[0]);
            int data2 = Int16.Parse(splittedDatas[1]);

            Data1Chart.Series["Data1"].Points.Add(data1);
            Data2Chart.Series["Data2"].Points.Add(data2);
        }
        public static string SetPortName(string defaultPortName,ComboBox comboBox)
        {
            string portName;
            
            portName = comboBox.SelectedItem.ToString();

            if (portName == "" || !(portName.ToLower()).StartsWith("com"))
            {
                portName = defaultPortName;
            }
            return portName;
        }

        public static int SetPortBaudRate(int defaultPortBaudRate, ComboBox comboBox)
        {
            string baudRate;

            baudRate = comboBox.SelectedItem.ToString();

            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }

        public static Parity SetPortParity(Parity defaultPortParity, ComboBox comboBox)
        {
            string parity;
            
            parity = comboBox.SelectedItem.ToString();

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }

        public static int SetPortDataBits(int defaultPortDataBits, ComboBox comboBox)
        {
            string dataBits;

            dataBits = comboBox.SelectedItem.ToString();

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits.ToUpperInvariant());
        }

        public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits = "";

            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }
        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake ="";
            
            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }
        public void InitializeSerialPort()
        {
            _serialPort = new SerialPort();

            _serialPort.PortName = SetPortName(_serialPort.PortName, PortNameComboBox);
            _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate, BaudRateComboBox);
            _serialPort.Parity = SetPortParity(_serialPort.Parity, ParityComboBox);
            _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits, DataBitComboBox);
            _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            //_serialPort.ReadTimeout = 500;

            _serialPort.DataReceived += new SerialDataReceivedEventHandler(Read);
            _serialPort.Open();
        }
        public void TerminateSerialPort()
        {
            _serialPort.Close();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            InitializeSerialPort();
            ControlLabel.Text = "Acik";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            TerminateSerialPort();
            ControlLabel.Text = "Kapali";
        }

        private void Data1Button_Click(object sender, EventArgs e)
        {
            Data1Chart.BringToFront();
        }

        private void Data2Button_Click(object sender, EventArgs e)
        {
            Data2Chart.BringToFront();

        }
    }
}
