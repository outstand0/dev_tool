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
using System.Threading;

namespace DeviceTool_cc550bt
{
    public partial class Form1 : Form
    {
        SerialPort cc550_Uartport = new SerialPort();

        bool flag_Connect = false;
        bool flag_Disconnect = false;
        bool flag_ReadDeviceName = false;
        bool flag_WriteDeviceName = false;
        bool flag_ReadBdAddress = false;
        bool flag_WriteBdAddress = false;
        bool flag_ReadXtalFtrim = false;
        bool flag_WriteXtalFtrim = false;
        bool flag_ReadLicenseKey = false;
        bool flag_WriteLicenseKey = false;
        bool flag_ReadModeReadWrite = false;
        bool flag_WriteModeReadWrite = false;
        bool flag_ReadNrOnOff = false;
        bool flag_WriteNrOnOff = false;
        bool flag_ReadBtFwVersion = false;
        bool flag_WriteBtFwVersion = false;
        bool flag_ReadIg1505FwVersion = false;
        bool flag_WriteIg1505FwVersion = false;
        bool flag_PdlReset = false;

        public Form1()
        {
            InitializeComponent();
            string[] portNames = SerialPort.GetPortNames();
            foreach (string portnumber in portNames)
            {
                cbComport.Items.Add(portnumber);                
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            open_port();               
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            close_port();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void cc550_Uartport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
            Thread.Sleep(200);
        }

        private void MySerialReceived(object s, EventArgs e)
        {
            byte[] ReceiveBuffer = new byte[512];
            byte[] ReceiveData = new byte[64];

            //int ReceiveData = cc550_Uartport.ReadByte();
            int ReceiveDataSize = cc550_Uartport.Read(ReceiveBuffer, 0, 512);
            int ReceiveDataEndpoint = 0;
            //tbReceiveTest.Text = tbReceiveTest.Text + string.Format("{0:X2}", ReceiveData);
            for (int i = 0; i < ReceiveDataSize; i++)
            {
                if(ReceiveBuffer[i] == 0x05 && ReceiveBuffer[i + 1] == 0x5B)
                {
                    if(flag_ReadDeviceName == true && ReceiveBuffer[i+2] == 0x2C && ReceiveBuffer[i+5] == 0x0A) // Read Device Name
                    {
                        ReceiveDataEndpoint = ReceiveBuffer[i + 2];
                        for (int j = 0; j < ReceiveDataEndpoint + 1; j++)
                        {
                            ReceiveData[j] = ReceiveBuffer[i + 25];
                            i++;
                        }                       
                    }
                    else if(flag_ReadModeReadWrite == true && ReceiveBuffer[i+5] == 0x0A && ReceiveBuffer[i+6] == 0x01) // Read Mode
                    {
                        ReceiveDataEndpoint = ReceiveBuffer[i + 2];
                        for(int j = 0; j<ReceiveDataEndpoint; j++)
                        {
                            ReceiveData[j] = ReceiveBuffer[i+4];
                            i++;
                        }
                        switch(ReceiveData[4])
                        {
                            case 0:                                
                                tbModeReadWrite.Text = "Normal mode";                                
                                Console.WriteLine("Normal Mode!");
                                break;
                            case 1:
                                tbModeReadWrite.Text = "Test mode";
                                Console.WriteLine("Test Mode!");
                                break;
                            case 2:
                                tbModeReadWrite.Text = "IGO Update mode";
                                Console.WriteLine("IGO Update Mode!");
                                break;
                        }         
                    }
                    else if (flag_WriteModeReadWrite == true && ReceiveBuffer[i+4] == 0x01 && ReceiveBuffer[i+5] == 0x0A) // Check Write Mode 
                    {
                        if(ReceiveBuffer[i+6] == 0x00)
                        {
                            tbModeReadWrite.Text = "Write success";
                            Console.WriteLine("Write success");
                        }
                        else
                        {
                            tbModeReadWrite.Text = "Write fail";
                            Console.WriteLine("Write fail");
                        }                        
                    }
                    else if(flag_ReadBtFwVersion == true && ReceiveBuffer[i+5] == 0x0A && ReceiveBuffer[i+6] == 0x02) // Read BT Version
                    {
                        ReceiveDataEndpoint = ReceiveBuffer[i + 2];
                        for (int j = 0; j < ReceiveDataEndpoint; j++)
                        {
                            ReceiveData[j] = ReceiveBuffer[i + 4];
                            i++;
                        }
                        tbBtFwVersion.Text = ReceiveData[4] / 16 + ReceiveData[4] % 16 + "." + ReceiveData[5] / 16 + ReceiveData[5] % 16;
                    }
                    else if(flag_ReadNrOnOff == true && ReceiveBuffer[i+5] == 0x0A && ReceiveBuffer[i+6] == 0x01) // Read NR OnOff
                    {
                        if (ReceiveBuffer[i + 8] == 0x00)
                        {
                            tbNrOnOff.Text = "BYPASS MODE";
                            Console.WriteLine("BYPASS MODE");
                        }
                        else
                        {
                            tbNrOnOff.Text = "NR MODE";
                            Console.WriteLine("NR MODE");
                        }
                    }
                    else if (flag_WriteNrOnOff == true && ReceiveBuffer[i + 4] == 0x01 && ReceiveBuffer[i + 5] == 0x0A) // Check Write NR OnOff 
                    {
                        if (ReceiveBuffer[i + 6] == 0x00)
                        {
                            tbNrOnOff.Text = "Write success";
                            Console.WriteLine("Write success");
                        }
                        else
                        {
                            tbNrOnOff.Text = "Write fail";
                            Console.WriteLine("Write fail");
                        }
                    }
                    else
                    {
                        ReceiveDataEndpoint = ReceiveBuffer[i + 2];
                        for (int j = 0; j < ReceiveDataEndpoint + 1; j++)
                        {
                            ReceiveData[j] = ReceiveBuffer[i + 4];
                            i++;
                        }
                    }
                    flag_clear();
                    break;
                }
            }
            Console.WriteLine("{0:X2}", ReceiveDataSize);
        }
        private void open_port()
        {
            int flag_ng = 0;
            
            if(cc550_Uartport.IsOpen == false)
            {
                cc550_Uartport.PortName = cbComport.SelectedItem.ToString();
                cc550_Uartport.BaudRate = 3000000;
                cc550_Uartport.DataBits = 8;
                cc550_Uartport.StopBits = StopBits.One;
                cc550_Uartport.Parity = Parity.None;                
                
                cc550_Uartport.DataReceived += new SerialDataReceivedEventHandler(cc550_Uartport_DataReceived);

                cc550_Uartport.Open();
                Thread.Sleep(200);

                Console.WriteLine("UART is open");
            }
            else
            {
                flag_ng = 1;
                Console.WriteLine("UART is already open");                
            }
        }
        private void close_port()
        {
            int flag_ng = 0;

            if (cc550_Uartport.IsOpen == true)
            {
                cc550_Uartport.Close();
                Console.WriteLine("UART is close");
            }
            else
            {
                Console.WriteLine("UART is not open");
            }

        }

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            //cc550_Uartport.Write(tbSendTest.Text);                                              
           
            byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x03, 0x00, 0x01, 0x00, 0x04 };
                    
            cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDeviceName.Clear();
            tbBdAddress.Clear();
            tbXtalLoadcap.Clear();
            tbXtalFtrim.Clear();
            tbLicenseKey.Clear();
            tbModeReadWrite.Clear();
            tbNrOnOff.Clear();
            tbBtFwVersion.Clear();
            tbIg1505FwVersion.Clear();
            tbReceiveTest.Clear();
        }

        public void flag_clear()
        {
            flag_Connect = false;
            flag_Disconnect = false;
            flag_ReadDeviceName = false;
            flag_WriteDeviceName = false;
            flag_ReadBdAddress = false;
            flag_WriteBdAddress = false;
            flag_ReadXtalFtrim = false;
            flag_WriteXtalFtrim = false;
            flag_ReadLicenseKey = false;
            flag_WriteLicenseKey = false;
            flag_ReadModeReadWrite = false;
            flag_WriteModeReadWrite = false;
            flag_ReadNrOnOff = false;
            flag_WriteNrOnOff = false;
            flag_ReadBtFwVersion = false;
            flag_WriteBtFwVersion = false;
            flag_ReadIg1505FwVersion = false;
            flag_WriteIg1505FwVersion = false;
            flag_PdlReset = false;
        }

        private void btnDeviceNameRead_Click(object sender, EventArgs e)
        {
            flag_ReadDeviceName = true; 

            byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x06, 0x00, 0x00, 0x0A, 0x03, 0x10, 0x28, 0x00 };
            
            cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
        }
        private void btnDeviceNameWrite_Click(object sender, EventArgs e)
        {

        }

        private void btnModeReadWriteRead_Click(object sender, EventArgs e)
        {
            flag_ReadModeReadWrite = true;            
            byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x06, 0x00, 0x00, 0x0A, 0x00, 0xF5, 0x00, 0x00 };

            cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
        }

        private void btmModeReadWriteWrite_Click(object sender, EventArgs e)
        {
            flag_WriteModeReadWrite = true;

            if(tbModeReadWrite.Text == "0")
            {
                byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x05, 0x00, 0x01, 0x0A, 0x00, 0xF5, 0x00 };
                cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);                
            }
            else if(tbModeReadWrite.Text == "1")
            {
                byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x05, 0x00, 0x01, 0x0A, 0x00, 0xF5, 0x01 };
                cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
            }
            else if(tbModeReadWrite.Text =="2")
            {
                byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x05, 0x00, 0x01, 0x0A, 0x00, 0xF5, 0x02 };
                cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
            }            
        }

        private void btnBtFwVersionRead_Click(object sender, EventArgs e)
        {
            flag_ReadBtFwVersion = true;
            byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x06, 0x00, 0x00, 0x0A, 0x01, 0xF5, 0x00, 0x00 };

            cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
        }

        private void btnBtFwVersionWrite_Click(object sender, EventArgs e)
        {

        }

        private void btnIg1505FwVersionRead_Click(object sender, EventArgs e)
        {
            flag_ReadIg1505FwVersion = true;
            byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x06, 0x00, 0x00, 0x0A, 0x02, 0xF5, 0x00, 0x00 };

            cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
        }

        private void btnIg1505FwVersionWrite_Click(object sender, EventArgs e)
        {

        }

        private void btnNrOnOffRead_Click(object sender, EventArgs e)
        {
            flag_ReadNrOnOff = true;
            byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x06, 0x00, 0x00, 0x0A, 0x04, 0xF5, 0x00, 0x00 };

            cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
        }

        private void btnNrOnOffWrite_Click(object sender, EventArgs e)
        {
            flag_WriteNrOnOff = true;

            if(tbNrOnOff.Text == "0")
            {
                byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x05, 0x00, 0x01, 0x0A, 0x04, 0xF5, 0x00 };
                cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
            }
            else if(tbNrOnOff.Text == "1")
            {
                byte[] dataToSend = new byte[] { 0x05, 0x5A, 0x05, 0x00, 0x01, 0x0A, 0x04, 0xF5, 0x01 };
                cc550_Uartport.Write(dataToSend, 0, dataToSend.Length);
            }
        }


    }
}

