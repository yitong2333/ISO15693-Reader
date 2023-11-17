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
using KV_ISO15693;

namespace ISO15693
{
    public partial class Form1 : Form
    {
        Reader reader = new Reader();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] portName = SerialPort.GetPortNames();
            if (portName.Length > 0)
            {
                foreach (string s in portName)
                {
                    cmbPortName.Items.Add(s);
                }
                cmbPortName.SelectedIndex = 0;
                btnSelectTag.Enabled = false;
                btnWriteData.Enabled = false;

            }
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (btnOpenPort.Text == "打开串口")
            {
                reader.OpenSerialPort(cmbPortName.Text);
                btnOpenPort.Text = "关闭串口";
                MessageBox.Show("串口已打开");
                btnSelectTag.Enabled = true;
                btnWriteData.Enabled = true;
            }
            else
            {
                if (reader.IsOpen)
                {
                    reader.CloseSerialPort();
                    btnOpenPort.Text = "打开串口";
                }
            }
        }

        private void btnSelectTag_Click(object sender, EventArgs e)
        {
            try
            {
                int tagCount = 0;
                string[] tagNuber = null;
                byte result = reader.Inventory(ModulateMethod.FSK, InventoryModel.Multiple,ref tagCount,ref tagNuber);
                if (result == 0x00)
                {
                    txtTagNum.Text = tagNuber[0];
                    btnReadData.Enabled = true;
                    btnWriteData.Enabled = true;
                }
                else
                {
                    MessageBox.Show("读卡失败");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            try
            {
                string tagNumber = txtTagNum.Text;
                byte addr = Convert.ToByte(txtAddress.Text);
                //byte data = Convert.ToByte(txtWriteData.Text);
                byte[]data=reader.StringToByteArray(txtWriteData.Text);
                byte result = reader.WriteSingleBlock(tagNumber, BlockLength.ShortBlock4Byte, addr, data);
                if (result == 0x00)
                {
                    MessageBox.Show("数据写入成功！");
                }
                else
                {
                    MessageBox.Show("数据写入失败");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
