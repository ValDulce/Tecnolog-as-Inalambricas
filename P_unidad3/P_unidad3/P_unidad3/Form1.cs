using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_unidad3
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Port;
        bool isClosed = false;
        public Form1()
        {
            InitializeComponent();

            Port = new System.IO.Ports.SerialPort();
            Port.PortName = "COM3"; /*Checar el com */
            Port.BaudRate = 9600;
            Port.ReadTimeout = 500;
            try
            {
                Port.Open();
            }
            catch { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        Thread Hilo = new Thread(EsucharSerial);
                Hilo.Start();
            }
        private void BtnCon_Click(object sender, EventArgs e)
        {
               BtnCon.Enabled = false;
                BtnCon.SendToBack();

            }

            private void EsucharSerial()

            {
                while (!isClosed)
                {
                    try
                    {
                        string cadena = Port.ReadLine();
                        txtAlgo.Invoke(new MethodInvoker(
                            delegate
                            {
                                txtAlgo.Text = cadena;

                            }

                            ));

                    }
                    catch { }
                }
            }

            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                isClosed = true;
                Close();
        }

        
    }

    }
