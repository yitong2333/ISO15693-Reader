
namespace ISO15693
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectTag = new System.Windows.Forms.Button();
            this.txtTagNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtFsk = new System.Windows.Forms.RadioButton();
            this.rbtnPsk = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReadData = new System.Windows.Forms.Button();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.txtReadData = new System.Windows.Forms.TextBox();
            this.txtWriteData = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbMultiple = new System.Windows.Forms.RadioButton();
            this.rtbSingle = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReaderTag = new System.Windows.Forms.Button();
            this.cmbStopIndex = new System.Windows.Forms.ComboBox();
            this.cmbStartIndex = new System.Windows.Forms.ComboBox();
            this.btnSetAntenna = new System.Windows.Forms.Button();
            this.rtbReceiveData = new System.Windows.Forms.RichTextBox();
            this.chkChangeAndRead = new System.Windows.Forms.CheckBox();
            this.rbtnAntenna6 = new System.Windows.Forms.RadioButton();
            this.rbtnAntenna7 = new System.Windows.Forms.RadioButton();
            this.rbtnAntenna2 = new System.Windows.Forms.RadioButton();
            this.rbtnAntenna3 = new System.Windows.Forms.RadioButton();
            this.rbtnAntenna4 = new System.Windows.Forms.RadioButton();
            this.rbtnAntenna8 = new System.Windows.Forms.RadioButton();
            this.rbtnAntenna5 = new System.Windows.Forms.RadioButton();
            this.rbtnAntenna1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectTag);
            this.groupBox1.Controls.Add(this.txtTagNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPortName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口操作";
            // 
            // btnSelectTag
            // 
            this.btnSelectTag.Location = new System.Drawing.Point(322, 80);
            this.btnSelectTag.Name = "btnSelectTag";
            this.btnSelectTag.Size = new System.Drawing.Size(96, 37);
            this.btnSelectTag.TabIndex = 5;
            this.btnSelectTag.Text = "寻卡操作";
            this.btnSelectTag.UseVisualStyleBackColor = true;
            this.btnSelectTag.Click += new System.EventHandler(this.btnSelectTag_Click);
            // 
            // txtTagNum
            // 
            this.txtTagNum.Location = new System.Drawing.Point(126, 88);
            this.txtTagNum.Name = "txtTagNum";
            this.txtTagNum.Size = new System.Drawing.Size(190, 25);
            this.txtTagNum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "读取卡号：";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(322, 15);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(96, 35);
            this.btnOpenPort.TabIndex = 2;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号：";
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(126, 22);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(190, 23);
            this.cmbPortName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rbtFsk);
            this.groupBox2.Controls.Add(this.rbtnPsk);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数设置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "调制模式：";
            // 
            // rbtFsk
            // 
            this.rbtFsk.AutoSize = true;
            this.rbtFsk.Location = new System.Drawing.Point(310, 34);
            this.rbtFsk.Name = "rbtFsk";
            this.rbtFsk.Size = new System.Drawing.Size(52, 19);
            this.rbtFsk.TabIndex = 1;
            this.rbtFsk.TabStop = true;
            this.rbtFsk.Text = "ASK";
            this.rbtFsk.UseVisualStyleBackColor = true;
            // 
            // rbtnPsk
            // 
            this.rbtnPsk.AutoSize = true;
            this.rbtnPsk.Location = new System.Drawing.Point(140, 34);
            this.rbtnPsk.Name = "rbtnPsk";
            this.rbtnPsk.Size = new System.Drawing.Size(52, 19);
            this.rbtnPsk.TabIndex = 0;
            this.rbtnPsk.TabStop = true;
            this.rbtnPsk.Text = "PSK";
            this.rbtnPsk.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReadData);
            this.groupBox3.Controls.Add(this.btnWriteData);
            this.groupBox3.Controls.Add(this.txtReadData);
            this.groupBox3.Controls.Add(this.txtWriteData);
            this.groupBox3.Controls.Add(this.txtCount);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 264);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "读写操作";
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(327, 168);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(75, 32);
            this.btnReadData.TabIndex = 9;
            this.btnReadData.Text = "读取";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // btnWriteData
            // 
            this.btnWriteData.Location = new System.Drawing.Point(327, 105);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(75, 25);
            this.btnWriteData.TabIndex = 8;
            this.btnWriteData.Text = "写入";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // txtReadData
            // 
            this.txtReadData.Location = new System.Drawing.Point(106, 170);
            this.txtReadData.Name = "txtReadData";
            this.txtReadData.Size = new System.Drawing.Size(177, 25);
            this.txtReadData.TabIndex = 7;
            // 
            // txtWriteData
            // 
            this.txtWriteData.Location = new System.Drawing.Point(106, 105);
            this.txtWriteData.Name = "txtWriteData";
            this.txtWriteData.Size = new System.Drawing.Size(177, 25);
            this.txtWriteData.TabIndex = 6;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(302, 34);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 25);
            this.txtCount.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(105, 34);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 25);
            this.txtAddress.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "读取数据：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "写入数据：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "块数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "块地址：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.rtbMultiple);
            this.groupBox4.Controls.Add(this.rtbSingle);
            this.groupBox4.Location = new System.Drawing.Point(12, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(445, 60);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "寻卡模式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "寻卡模式：";
            // 
            // rtbMultiple
            // 
            this.rtbMultiple.AutoSize = true;
            this.rtbMultiple.Location = new System.Drawing.Point(288, 25);
            this.rtbMultiple.Name = "rtbMultiple";
            this.rtbMultiple.Size = new System.Drawing.Size(88, 19);
            this.rtbMultiple.TabIndex = 5;
            this.rtbMultiple.TabStop = true;
            this.rtbMultiple.Text = "寻找多卡";
            this.rtbMultiple.UseVisualStyleBackColor = true;
            // 
            // rtbSingle
            // 
            this.rtbSingle.AutoSize = true;
            this.rtbSingle.Location = new System.Drawing.Point(118, 26);
            this.rtbSingle.Name = "rtbSingle";
            this.rtbSingle.Size = new System.Drawing.Size(88, 19);
            this.rtbSingle.TabIndex = 4;
            this.rtbSingle.TabStop = true;
            this.rtbSingle.Text = "寻找单卡";
            this.rtbSingle.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnReaderTag);
            this.groupBox5.Controls.Add(this.cmbStopIndex);
            this.groupBox5.Controls.Add(this.cmbStartIndex);
            this.groupBox5.Controls.Add(this.btnSetAntenna);
            this.groupBox5.Controls.Add(this.rtbReceiveData);
            this.groupBox5.Controls.Add(this.chkChangeAndRead);
            this.groupBox5.Controls.Add(this.rbtnAntenna6);
            this.groupBox5.Controls.Add(this.rbtnAntenna7);
            this.groupBox5.Controls.Add(this.rbtnAntenna2);
            this.groupBox5.Controls.Add(this.rbtnAntenna3);
            this.groupBox5.Controls.Add(this.rbtnAntenna4);
            this.groupBox5.Controls.Add(this.rbtnAntenna8);
            this.groupBox5.Controls.Add(this.rbtnAntenna5);
            this.groupBox5.Controls.Add(this.rbtnAntenna1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(475, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(658, 589);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "多路复用";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "终止序号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "起始序号";
            // 
            // btnReaderTag
            // 
            this.btnReaderTag.Location = new System.Drawing.Point(502, 149);
            this.btnReaderTag.Name = "btnReaderTag";
            this.btnReaderTag.Size = new System.Drawing.Size(88, 43);
            this.btnReaderTag.TabIndex = 13;
            this.btnReaderTag.Text = "循环读卡";
            this.btnReaderTag.UseVisualStyleBackColor = true;
            this.btnReaderTag.Click += new System.EventHandler(this.btnReaderTag_Click);
            // 
            // cmbStopIndex
            // 
            this.cmbStopIndex.FormattingEnabled = true;
            this.cmbStopIndex.Location = new System.Drawing.Point(353, 160);
            this.cmbStopIndex.Name = "cmbStopIndex";
            this.cmbStopIndex.Size = new System.Drawing.Size(121, 23);
            this.cmbStopIndex.TabIndex = 12;
            // 
            // cmbStartIndex
            // 
            this.cmbStartIndex.FormattingEnabled = true;
            this.cmbStartIndex.Location = new System.Drawing.Point(107, 161);
            this.cmbStartIndex.Name = "cmbStartIndex";
            this.cmbStartIndex.Size = new System.Drawing.Size(121, 23);
            this.cmbStartIndex.TabIndex = 11;
            // 
            // btnSetAntenna
            // 
            this.btnSetAntenna.Location = new System.Drawing.Point(502, 100);
            this.btnSetAntenna.Name = "btnSetAntenna";
            this.btnSetAntenna.Size = new System.Drawing.Size(88, 43);
            this.btnSetAntenna.TabIndex = 10;
            this.btnSetAntenna.Text = "切换天线";
            this.btnSetAntenna.UseVisualStyleBackColor = true;
            this.btnSetAntenna.Click += new System.EventHandler(this.btnSetAntenna_Click);
            // 
            // rtbReceiveData
            // 
            this.rtbReceiveData.Location = new System.Drawing.Point(7, 197);
            this.rtbReceiveData.Name = "rtbReceiveData";
            this.rtbReceiveData.Size = new System.Drawing.Size(645, 372);
            this.rtbReceiveData.TabIndex = 9;
            this.rtbReceiveData.Text = "";
            // 
            // chkChangeAndRead
            // 
            this.chkChangeAndRead.AutoSize = true;
            this.chkChangeAndRead.Location = new System.Drawing.Point(55, 110);
            this.chkChangeAndRead.Name = "chkChangeAndRead";
            this.chkChangeAndRead.Size = new System.Drawing.Size(134, 19);
            this.chkChangeAndRead.TabIndex = 8;
            this.chkChangeAndRead.Text = "切换天线并读卡";
            this.chkChangeAndRead.UseVisualStyleBackColor = true;
            // 
            // rbtnAntenna6
            // 
            this.rbtnAntenna6.AutoSize = true;
            this.rbtnAntenna6.Location = new System.Drawing.Point(204, 65);
            this.rbtnAntenna6.Name = "rbtnAntenna6";
            this.rbtnAntenna6.Size = new System.Drawing.Size(88, 19);
            this.rbtnAntenna6.TabIndex = 7;
            this.rbtnAntenna6.TabStop = true;
            this.rbtnAntenna6.Text = "六号天线";
            this.rbtnAntenna6.UseVisualStyleBackColor = true;
            // 
            // rbtnAntenna7
            // 
            this.rbtnAntenna7.AutoSize = true;
            this.rbtnAntenna7.Location = new System.Drawing.Point(353, 65);
            this.rbtnAntenna7.Name = "rbtnAntenna7";
            this.rbtnAntenna7.Size = new System.Drawing.Size(88, 19);
            this.rbtnAntenna7.TabIndex = 6;
            this.rbtnAntenna7.TabStop = true;
            this.rbtnAntenna7.Text = "七号天线";
            this.rbtnAntenna7.UseVisualStyleBackColor = true;
            // 
            // rbtnAntenna2
            // 
            this.rbtnAntenna2.AutoSize = true;
            this.rbtnAntenna2.Location = new System.Drawing.Point(204, 31);
            this.rbtnAntenna2.Name = "rbtnAntenna2";
            this.rbtnAntenna2.Size = new System.Drawing.Size(88, 19);
            this.rbtnAntenna2.TabIndex = 5;
            this.rbtnAntenna2.TabStop = true;
            this.rbtnAntenna2.Text = "二号天线";
            this.rbtnAntenna2.UseVisualStyleBackColor = true;
            // 
            // rbtnAntenna3
            // 
            this.rbtnAntenna3.AutoSize = true;
            this.rbtnAntenna3.Location = new System.Drawing.Point(353, 31);
            this.rbtnAntenna3.Name = "rbtnAntenna3";
            this.rbtnAntenna3.Size = new System.Drawing.Size(88, 19);
            this.rbtnAntenna3.TabIndex = 4;
            this.rbtnAntenna3.TabStop = true;
            this.rbtnAntenna3.Text = "三号天线";
            this.rbtnAntenna3.UseVisualStyleBackColor = true;
            // 
            // rbtnAntenna4
            // 
            this.rbtnAntenna4.AutoSize = true;
            this.rbtnAntenna4.Location = new System.Drawing.Point(502, 31);
            this.rbtnAntenna4.Name = "rbtnAntenna4";
            this.rbtnAntenna4.Size = new System.Drawing.Size(88, 19);
            this.rbtnAntenna4.TabIndex = 3;
            this.rbtnAntenna4.TabStop = true;
            this.rbtnAntenna4.Text = "四号天线";
            this.rbtnAntenna4.UseVisualStyleBackColor = true;
            // 
            // rbtnAntenna8
            // 
            this.rbtnAntenna8.AutoSize = true;
            this.rbtnAntenna8.Location = new System.Drawing.Point(502, 65);
            this.rbtnAntenna8.Name = "rbtnAntenna8";
            this.rbtnAntenna8.Size = new System.Drawing.Size(88, 19);
            this.rbtnAntenna8.TabIndex = 2;
            this.rbtnAntenna8.TabStop = true;
            this.rbtnAntenna8.Text = "八号天线";
            this.rbtnAntenna8.UseVisualStyleBackColor = true;
            // 
            // rbtnAntenna5
            // 
            this.rbtnAntenna5.AutoSize = true;
            this.rbtnAntenna5.Location = new System.Drawing.Point(55, 65);
            this.rbtnAntenna5.Name = "rbtnAntenna5";
            this.rbtnAntenna5.Size = new System.Drawing.Size(88, 19);
            this.rbtnAntenna5.TabIndex = 1;
            this.rbtnAntenna5.TabStop = true;
            this.rbtnAntenna5.Text = "五号天线";
            this.rbtnAntenna5.UseVisualStyleBackColor = true;
            // 
            // rbtnAntenna1
            // 
            this.rbtnAntenna1.AutoSize = true;
            this.rbtnAntenna1.Location = new System.Drawing.Point(55, 31);
            this.rbtnAntenna1.Name = "rbtnAntenna1";
            this.rbtnAntenna1.Size = new System.Drawing.Size(88, 19);
            this.rbtnAntenna1.TabIndex = 0;
            this.rbtnAntenna1.TabStop = true;
            this.rbtnAntenna1.Text = "一号天线";
            this.rbtnAntenna1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 589);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "15693Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectTag;
        private System.Windows.Forms.TextBox txtTagNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtFsk;
        private System.Windows.Forms.RadioButton rbtnPsk;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.TextBox txtReadData;
        private System.Windows.Forms.TextBox txtWriteData;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rtbMultiple;
        private System.Windows.Forms.RadioButton rtbSingle;
        private System.Windows.Forms.RichTextBox rtbReceiveData;
        private System.Windows.Forms.CheckBox chkChangeAndRead;
        private System.Windows.Forms.RadioButton rbtnAntenna6;
        private System.Windows.Forms.RadioButton rbtnAntenna7;
        private System.Windows.Forms.RadioButton rbtnAntenna2;
        private System.Windows.Forms.RadioButton rbtnAntenna3;
        private System.Windows.Forms.RadioButton rbtnAntenna4;
        private System.Windows.Forms.RadioButton rbtnAntenna8;
        private System.Windows.Forms.RadioButton rbtnAntenna5;
        private System.Windows.Forms.RadioButton rbtnAntenna1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReaderTag;
        private System.Windows.Forms.ComboBox cmbStopIndex;
        private System.Windows.Forms.ComboBox cmbStartIndex;
        private System.Windows.Forms.Button btnSetAntenna;
    }
}

