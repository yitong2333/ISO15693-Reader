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
            rbtnAntenna1.Checked = true;
            int[] index = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int i in index)
            {
                cmbStartIndex.Items.Add(i);
                cmbStopIndex.Items.Add(i);
            }
            cmbStopIndex.SelectedIndex = 0;
            cmbStopIndex.SelectedIndex = 0;

        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            rbtFsk.Checked = true;
            rtbMultiple.Checked = true;
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
                    btnSelectTag.Enabled = false;
                    btnReadData.Enabled = false;
                    btnWriteData.Enabled = false;
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

        private void btnReadData_Click(object sender, EventArgs e)
        {
            try
            {
                string tagName = txtTagNum.Text;
                byte count = Convert.ToByte(txtCount.Text);
                byte[] data = new byte[count];
                byte addr = Convert.ToByte(txtAddress.Text);
                byte result = reader.ReadMultiBlock(tagName,BlockLength.ShortBlock4Byte, addr, count,ref data);
                if (result == 0x00)
                {
                    //MessageBox.Show("读取数据成功");
                    //txtReadData.Text = Convert.ToString(data[0]);
                    // 将十六进制字符串转换为整数
                    string hexString = BitConverter.ToString(data).Replace("-", "");
                    MessageBox.Show("读取数据成功");
                    txtReadData.Text = hexString;
                }
                else
                {
                    MessageBox.Show("读取数据失败");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetAntenna_Click(object sender, EventArgs e)
        {
            try
            {
                byte index = 0x01;
                if (rbtnAntenna1.Checked)
                {
                    index = 0x01;
                }
                if (rbtnAntenna2.Checked)
                {
                    index = 0x02;
                }
                if (rbtnAntenna3.Checked)
                {
                    index = 0x03;
                }
                if (rbtnAntenna4.Checked)
                {
                    index = 0x04;
                }
                if (rbtnAntenna5.Checked)
                {
                    index = 0x05;
                }
                if (rbtnAntenna6.Checked)
                {
                    index = 0x06;
                }
                if (rbtnAntenna7.Checked)
                {
                    index = 0x08;
                }
                if (rbtnAntenna8.Checked)
                {
                    index = 0x08;
                }
                byte result = reader.SetAntanna(index);
                
                if (!chkChangeAndRead.Checked)
                {
                    switch (result)
                    {
                        case 0x00:
                            rtbReceiveData.AppendText(index.ToString() + "号天线切换成功\n");
                            break;
                        case 0x01:
                            rtbReceiveData.AppendText("串口未打开！，切换失败！\n");
                            break;
                        case 0x08:
                            rtbReceiveData.AppendText("天线序号不在范围内，切换失败！\n");
                            break;
                        case 0x29:
                            rtbReceiveData.AppendText("串口接收发接受超时，切换失败！\n");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    //相当于if和else
                    ModulateMethod mm = rbtFsk.Checked ? ModulateMethod.FSK : ModulateMethod.ASK;
                    InventoryModel im = rtbMultiple.Checked ? InventoryModel.Multiple : InventoryModel.Single;
                    int tagCount = 0;
                    string[] tagNumber = new string[tagCount];
                    byte res = reader.Inventory(mm, im, ref tagCount, ref tagNumber);//读卡方法
                    if (res == 0x00)
                    {
                        rtbReceiveData.AppendText(tagNumber[0]);
                        rtbReceiveData.AppendText(index.ToString() + "号天线切换成功\n");
                        //switch (result)
                        //{
                        //    case 0x00:
                        //        rtbReceiveData.AppendText(index.ToString() + "号天线切换成功\n");
                        //        break;
                        //    case 0x01:
                        //        rtbReceiveData.AppendText("串口未打开！，切换失败！\n");
                        //        break;
                        //    case 0x08:
                        //        rtbReceiveData.AppendText("天线序号不在范围内，切换失败！\n");
                        //        break;
                        //    case 0x29:
                        //        rtbReceiveData.AppendText("串口接收发接受超时，切换失败！\n");
                        //        break;
                        //    default:
                        //        break;
                        //}
                    }
                    else
                    {

                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnReaderTag_Click(object sender, EventArgs e)
        {
            int startIndex = Convert.ToInt32(cmbStartIndex.Text);
            int stopIndex = Convert.ToInt32(cmbStopIndex.Text);
            int tagCount = 0;
            string[] tagNumber = new string[tagCount];
            for (int i = startIndex; i < stopIndex; i++)
            {
                byte resAnt =reader.SetAntanna(Convert.ToByte(i));
                byte resInv= reader.Inventory(ModulateMethod.FSK,InventoryModel.Multiple,ref tagCount,ref tagNumber);
                if (resAnt == 0x00&& resInv == 0x00)
                {
                    rtbReceiveData.AppendText(i.ToString()+"切换天线成功！"+"标签号"+tagNumber[0]);
                }
                else
                {
                    rtbReceiveData.AppendText("切换天线或读卡失败！\n");
                }
            }
        }
    }
}
