using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static bool _continue;
        static SerialPort _serialPort;
        //static StringComparer _stringComparer;
        //static Thread _readThread;
        public Form1()
        {
            InitializeComponent();
            _serialPort = new SerialPort();
            //_stringComparer = StringComparer.OrdinalIgnoreCase;
            //_readThread = new Thread(Read);
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            
            string[] baudRates = new string[] { "19200", "9600" };
            BaudRateComboBox.Items.AddRange(baudRates);
            BaudRateComboBox.SelectedIndex = 1;

            string[] dataBits = new string[] { "5", "6","7","8"};
            DataBitComboBox.Items.AddRange(dataBits);
            DataBitComboBox.SelectedIndex = 3;

     

            //_serialPort = new SerialPort();

            _serialPort.PortName = SetPortName(_serialPort.PortName, PortNameComboBox);
            _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate, BaudRateComboBox);
            _serialPort.Parity = SetPortParity(_serialPort.Parity, ParityComboBox);
            _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits, DataBitComboBox);

            //bunları eklemesek de olur
            _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            _serialPort.ReadTimeout = 500;
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.DataTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.DataTextBox.Text = text;
            }
        }

        
        public void Read(object sender, SerialDataReceivedEventArgs e)
        {
            string message = _serialPort.ReadExisting().ToString();
            ShowRead(message);
        }
        
        public void ShowRead(string data)
        {
            SetText(data);
        }
        public static string SetPortName(string defaultPortName,ComboBox comboBox)
        {
            string portName;

            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox.Items.Add(s);
            }
            comboBox.SelectedIndex = 1;
            portName = comboBox.SelectedIndex.ToString();

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

            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                comboBox.Items.Add(s);
            }
            comboBox.SelectedIndex = 0; 

            parity = comboBox.SelectedIndex.ToString();

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

            //bu kısım duruma göre ayarlanabilir !!!
            /*
            Console.WriteLine("Available StopBits options:");
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                Console.WriteLine("   {0}", s);
            }
            
            Console.Write("Enter StopBits value (None is not supported and \n" +
             "raises an ArgumentOutOfRangeException. \n (Default: {0}):", defaultPortStopBits.ToString());
            stopBits = Console.ReadLine();
            */
            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }
        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake ="";
            // burası duruma göre ayarlanabilir
            /*
            Console.WriteLine("Available Handshake options:");
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter Handshake value (Default: {0}):", defaultPortHandshake.ToString());
            handshake = Console.ReadLine();
            */
            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(Read);
            _serialPort.Open();

            _continue = true;
            ControlLabel.Text = "Acik";
            //_readThread.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //_readThread.Join();
            ControlLabel.Text = "Kapali";

            _continue = false;
            _serialPort.Close();
        }
    }
}
