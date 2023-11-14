using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Graph = System.Windows.Forms.DataVisualization.Charting;
using System.IO;    //File, Directory, Path
//using System.Timers;


namespace SimpleSerial
{
    public partial class Form1 : Form
    {
        string RxString;
        string Buffer;
        string[] BufferList;
        //int ReadLog = 0;
        int[] PPB = { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                      0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                      0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                      0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                      0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                      0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,            
                    };
        //int[] PPB;
        int Display_PPB;
        //string New_Log_Filename;
        string Log_Filename;
        string EEPROM_Filename;

        public static partial class TestClass
        {
            public static String itoa(int n, int radix)
            {
                if (0 == n)
                    return "0";

                var index = 10;
                var buffer = new char[1 + index];
                var xlat = "0123456789abcdefghijklmnopqrstuvwxyz";

                for (int r = Math.Abs(n), q; r > 0; r = q)
                {
                    q = Math.DivRem(r, radix, out r);
                    buffer[index -= 1] = xlat[r];
                }

                if (n < 0)
                {
                    buffer[index -= 1] = '-';
                }

                return new String(buffer, index, buffer.Length - index);
            }

            public static void TestMethod()
            {
                Console.WriteLine("{0}", itoa(-0x12345678, 16));
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(750, 750);

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
            //t.Stop();
            //Display_PPB = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            char[] buff = new char[1];
            buff[0] = e.KeyChar;
            serialPort1.Write(buff, 0, 1);
            e.Handled = true;
        }

        private void DisplayText(object sender, EventArgs e)
        {
            textBox1.AppendText(RxString);
        }

        private void DisplayPPB(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.AppendText(BufferList[1]);
        }

        private void GraphPPB(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            int i = 600;
            while (i > 0)
            {
                chart1.Series["PPB"].Points.AddXY(i, PPB[i]);
                i--;
            }

            //chart1.Series[0].Points.Clear();
            //int i = 1;
            //while (i < 601)
            //{
            //    chart1.Series["PPB CO"].Points.AddXY(i, PPB[i]);
            //    i++;
            //}

            chart1.Series["PPB"].ChartType = SeriesChartType.Line;
            chart1.Series["PPB"].Color = Color.Red;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            try
            {
                this.Invoke(new EventHandler(DisplayText));
            }
            catch (ObjectDisposedException)
            {

            }                

            Buffer = Buffer + RxString;
            try
            {
                if (((Buffer.StartsWith("0") || (Buffer.StartsWith("1")))) && (Buffer.EndsWith("\r\n")) && (Display_PPB == 1))
                //if ((Buffer.Contains("\r\n")) && (Display_PPB == 1))
                {
                    File.AppendAllText("C:/Users/Public/Documents/KWJ/" + Log_Filename, DateTime.Now + " " + Buffer);
                    //File.AppendAllText("C:/Users/Public/Documents/KWJ/" + Log_Filename, Buffer + Environment.NewLine);
                    BufferList = Buffer.Split(',');
                    BufferList[1] = BufferList[1].Replace(" ", "");
                    int i = 0;
                    while (i < 600)
                    {
                        PPB[i] = PPB[i + 1];
                        i++;
                    }
                    PPB[600] = Int32.Parse(BufferList[1]);
                    //BufferList = Buffer.Split(',');
                    //BufferList[1] = BufferList[1].Replace(" ", "");
                    //int i = 600;
                    //while (i > 1)
                    //{
                    //    PPB[i] = PPB[i - 1];
                    //    i--;
                    //}
                    //PPB[1] = Int32.Parse(BufferList[1]); 
                    this.Invoke(new EventHandler(DisplayPPB));
                    this.Invoke(new EventHandler(GraphPPB));
                    Buffer = null;
                }
            }
            catch (NullReferenceException)
            {

            }
            catch (IndexOutOfRangeException)
            {

            }
            catch (DirectoryNotFoundException)
            {

            }
            catch (FormatException)
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Display_PPB == 0)
            {
                if (serialPort1.IsOpen) serialPort1.Close();
                Buffer = null;
            }        
        }

        private void buttonStartUART_Click(object sender, EventArgs e)
        {
            if (Display_PPB == 0)
            {
                Buffer = numericUpDown1.Text;
                Log_Filename = "COM" + Buffer + "_Log.txt";
                EEPROM_Filename = "COM" + Buffer + "_EEPROM.txt";
                serialPort1.PortName = "COM" + Buffer;
                serialPort1.BaudRate = 9600;

                if (!Directory.Exists("C:/Users/Public/Documents/KWJ/"))
                {
                    Directory.CreateDirectory("C:/Users/Public/Documents/KWJ/");
                }

                try
                {
                    serialPort1.Open();
                }
                catch (IOException)
                {
                    textBox1.AppendText("COM Port Error \r\n");
                    serialPort1.Close();
                    buttonStartUART.Enabled = true;
                    buttonStopUART.Enabled = false;
                    textBox1.ReadOnly = true;
                }

                if (serialPort1.IsOpen)
                {
                    buttonStartUART.Enabled = false;
                    buttonStopUART.Enabled = true;
                    textBox1.ReadOnly = false;

                    serialPort1.Write("\r");
                    System.Threading.Thread.Sleep(500);
                }
                this.Invoke(new EventHandler(GraphPPB));
                Buffer = null;
            }
        }

        private void buttonStopUART_Click(object sender, EventArgs e)
        {
            Display_PPB = 0;
            serialPort1.Write("s");
            System.Threading.Thread.Sleep(500);

            serialPort1.Close();
            buttonStartUART.Enabled = true;
            buttonStopUART.Enabled = false;
            textBox1.ReadOnly = true;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (Display_PPB == 0)
            {
                try
                {
                    serialPort1.Write("\r");
                }
                catch (InvalidOperationException)
                {
                    textBox1.AppendText("COM Port Error \r\n");
                    serialPort1.Close();
                    buttonStartUART.Enabled = true;
                    buttonStopUART.Enabled = false;
                    textBox1.ReadOnly = true;
                }
                Buffer = null;
            } 
        }

        private void buttonZero_Click_1(object sender, EventArgs e)
        {
            if (Display_PPB == 0)
            {
                try
                {
                    serialPort1.Write("Z");
                }
                catch (InvalidOperationException)
                {
                    textBox1.AppendText("COM Port Error \r\n");
                    serialPort1.Close();
                    buttonStartUART.Enabled = true;
                    buttonStopUART.Enabled = false;
                    textBox1.ReadOnly = true;
                }
                Buffer = null;
            }       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        public void slow_write_to_serial_port()
        {
            int i;
            int Buffer_Length = Buffer.Length;
            string Buffer0;

            i = 0;
            while (i < Buffer_Length)
            {
                Buffer0 = Buffer.Substring(i, 1);
                serialPort1.Write(Buffer0);
                System.Threading.Thread.Sleep(100);
                i++;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEEPROM_Click(object sender, EventArgs e)
        {
            if (Display_PPB == 0)
            {
                try
                {
                    serialPort1.Write("e");
                }
                catch (InvalidOperationException)
                {
                    textBox1.AppendText("COM Port Error \r\n");
                    serialPort1.Close();
                    buttonStartUART.Enabled = true;
                    buttonStopUART.Enabled = false;
                    textBox1.ReadOnly = true;
                }
                Buffer = null;
            }     
        }

        private void buttonBarCode_Click(object sender, EventArgs e)
        {
            if (Display_PPB == 0)
            {
                try
                {
                    serialPort1.Write("B");
                    System.Threading.Thread.Sleep(1000);

                    Buffer = textBox2.Text;
                    slow_write_to_serial_port();

                    System.Threading.Thread.Sleep(1000);
                    serialPort1.Write("\r");
                    System.Threading.Thread.Sleep(1000);
                }
                catch (InvalidOperationException)
                {
                    textBox1.AppendText("COM Port Error \r\n");
                    serialPort1.Close();
                    buttonStartUART.Enabled = true;
                    buttonStopUART.Enabled = false;
                    textBox1.ReadOnly = true;
                }
                Buffer = null;
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonContinuousRead_Click(object sender, EventArgs e)
        {
            if (Display_PPB == 0)
            {
                Display_PPB = 1;
                Buffer = null;
            }
            else
            {
                Display_PPB = 0;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (Display_PPB == 1)
            {
                try
                {
                    serialPort1.Write("\r");
                }
                catch (InvalidOperationException)
                {
                    Display_PPB = 0;
                    textBox1.AppendText("COM Port Error \r\n");
                    serialPort1.Close();
                    buttonStartUART.Enabled = true;
                    buttonStopUART.Enabled = false;
                    textBox1.ReadOnly = true;
                }
                Buffer = null;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAveraging_Click(object sender, EventArgs e)
        {
            if (Display_PPB == 0)
            {
                try
                {
                    serialPort1.Write("A");
                    System.Threading.Thread.Sleep(1000);

                    Buffer = textBox4.Text;
                    slow_write_to_serial_port();

                    System.Threading.Thread.Sleep(1000);
                    serialPort1.Write("\r");
                    System.Threading.Thread.Sleep(1000);
                }
                catch (InvalidOperationException)
                {
                    textBox1.AppendText("COM Port Error \r\n");
                    serialPort1.Close();
                    buttonStartUART.Enabled = true;
                    buttonStopUART.Enabled = false;
                    textBox1.ReadOnly = true;
                }
                Buffer = null;
            }
        }

        private void buttonReadLMP_Click(object sender, EventArgs e)
        {
            if (Display_PPB == 0)
            {
                try
                {
                    serialPort1.Write("l");
                }
                catch (InvalidOperationException)
                {
                    textBox1.AppendText("COM Port Error \r\n");
                    serialPort1.Close();
                    buttonStartUART.Enabled = true;
                    buttonStopUART.Enabled = false;
                    textBox1.ReadOnly = true;
                }
                Buffer = null;
            }     
        }

        private void buttonSpan_Click(object sender, EventArgs e)
        {
            if (Display_PPB == 0)
            {
                try
                {
                    serialPort1.Write("S");
                    System.Threading.Thread.Sleep(1000);

                    Buffer = textBox5.Text;
                    slow_write_to_serial_port();

                    System.Threading.Thread.Sleep(1000);
                    serialPort1.Write("\r");
                    System.Threading.Thread.Sleep(1000);
                }
                catch (InvalidOperationException)
                {
                    textBox1.AppendText("COM Port Error \r\n");
                    serialPort1.Close();
                    buttonStartUART.Enabled = true;
                    buttonStopUART.Enabled = false;
                    textBox1.ReadOnly = true;
                }
                Buffer = null;
            }  
        }              
    }
}
