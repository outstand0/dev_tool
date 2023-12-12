namespace DeviceTool_cc550bt
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbDeviceName = new System.Windows.Forms.Label();
            this.lbBdAddress = new System.Windows.Forms.Label();
            this.lbXtalFtrim = new System.Windows.Forms.Label();
            this.lbXtalLoadcap = new System.Windows.Forms.Label();
            this.lbIg1505FwVersion = new System.Windows.Forms.Label();
            this.lbBtFwVersion = new System.Windows.Forms.Label();
            this.lbModeReadWrite = new System.Windows.Forms.Label();
            this.lbLicenseKey = new System.Windows.Forms.Label();
            this.lbPdlReset = new System.Windows.Forms.Label();
            this.tbDeviceName = new System.Windows.Forms.RichTextBox();
            this.tbBdAddress = new System.Windows.Forms.RichTextBox();
            this.tbXtalFtrim = new System.Windows.Forms.RichTextBox();
            this.tbXtalLoadcap = new System.Windows.Forms.RichTextBox();
            this.tbIg1505FwVersion = new System.Windows.Forms.RichTextBox();
            this.tbBtFwVersion = new System.Windows.Forms.RichTextBox();
            this.tbModeReadWrite = new System.Windows.Forms.RichTextBox();
            this.tbLicenseKey = new System.Windows.Forms.RichTextBox();
            this.tbNrOnOff = new System.Windows.Forms.RichTextBox();
            this.lbNrOnOff = new System.Windows.Forms.Label();
            this.btnDeviceNameRead = new System.Windows.Forms.Button();
            this.btnDeviceNameWrite = new System.Windows.Forms.Button();
            this.btnBdAddressWrite = new System.Windows.Forms.Button();
            this.btnBdAddressRead = new System.Windows.Forms.Button();
            this.btnXtalFtrimWrite = new System.Windows.Forms.Button();
            this.btnXtalFtrimRead = new System.Windows.Forms.Button();
            this.btnXtalLoadcapWrite = new System.Windows.Forms.Button();
            this.btnXtalLoadcapRead = new System.Windows.Forms.Button();
            this.btnBtFwVersionWrite = new System.Windows.Forms.Button();
            this.btnBtFwVersionRead = new System.Windows.Forms.Button();
            this.btnNrOnOffWrite = new System.Windows.Forms.Button();
            this.btnNrOnOffRead = new System.Windows.Forms.Button();
            this.btmModeReadWriteWrite = new System.Windows.Forms.Button();
            this.btnModeReadWriteRead = new System.Windows.Forms.Button();
            this.btnLicenseKeyWrite = new System.Windows.Forms.Button();
            this.btnLicenseKeyRead = new System.Windows.Forms.Button();
            this.btnIg1505FwVersionWrite = new System.Windows.Forms.Button();
            this.btnIg1505FwVersionRead = new System.Windows.Forms.Button();
            this.cbComport = new System.Windows.Forms.ComboBox();
            this.tbReceiveTest = new System.Windows.Forms.RichTextBox();
            this.btnTestSend = new System.Windows.Forms.Button();
            this.tbSendTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConnect.Location = new System.Drawing.Point(10, 38);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(160, 50);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDisconnect.Location = new System.Drawing.Point(176, 38);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(160, 50);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(342, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 50);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbDeviceName
            // 
            this.lbDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDeviceName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDeviceName.Location = new System.Drawing.Point(11, 93);
            this.lbDeviceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDeviceName.Name = "lbDeviceName";
            this.lbDeviceName.Size = new System.Drawing.Size(160, 40);
            this.lbDeviceName.TabIndex = 3;
            this.lbDeviceName.Text = "DEVICE NAME";
            this.lbDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBdAddress
            // 
            this.lbBdAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBdAddress.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBdAddress.Location = new System.Drawing.Point(11, 142);
            this.lbBdAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBdAddress.Name = "lbBdAddress";
            this.lbBdAddress.Size = new System.Drawing.Size(160, 40);
            this.lbBdAddress.TabIndex = 4;
            this.lbBdAddress.Text = "BD ADDRESS";
            this.lbBdAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbXtalFtrim
            // 
            this.lbXtalFtrim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbXtalFtrim.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbXtalFtrim.Location = new System.Drawing.Point(11, 240);
            this.lbXtalFtrim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXtalFtrim.Name = "lbXtalFtrim";
            this.lbXtalFtrim.Size = new System.Drawing.Size(160, 40);
            this.lbXtalFtrim.TabIndex = 6;
            this.lbXtalFtrim.Text = "XTAL FTRIM";
            this.lbXtalFtrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbXtalLoadcap
            // 
            this.lbXtalLoadcap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbXtalLoadcap.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbXtalLoadcap.Location = new System.Drawing.Point(11, 191);
            this.lbXtalLoadcap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXtalLoadcap.Name = "lbXtalLoadcap";
            this.lbXtalLoadcap.Size = new System.Drawing.Size(160, 40);
            this.lbXtalLoadcap.TabIndex = 5;
            this.lbXtalLoadcap.Text = "XTAL LOADCAP";
            this.lbXtalLoadcap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIg1505FwVersion
            // 
            this.lbIg1505FwVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIg1505FwVersion.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbIg1505FwVersion.Location = new System.Drawing.Point(12, 487);
            this.lbIg1505FwVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIg1505FwVersion.Name = "lbIg1505FwVersion";
            this.lbIg1505FwVersion.Size = new System.Drawing.Size(160, 40);
            this.lbIg1505FwVersion.TabIndex = 10;
            this.lbIg1505FwVersion.Text = "IG1505 FW VERSION";
            this.lbIg1505FwVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBtFwVersion
            // 
            this.lbBtFwVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBtFwVersion.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBtFwVersion.Location = new System.Drawing.Point(12, 438);
            this.lbBtFwVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBtFwVersion.Name = "lbBtFwVersion";
            this.lbBtFwVersion.Size = new System.Drawing.Size(160, 40);
            this.lbBtFwVersion.TabIndex = 9;
            this.lbBtFwVersion.Text = "BT FW VERSION";
            this.lbBtFwVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbModeReadWrite
            // 
            this.lbModeReadWrite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbModeReadWrite.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModeReadWrite.Location = new System.Drawing.Point(12, 338);
            this.lbModeReadWrite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbModeReadWrite.Name = "lbModeReadWrite";
            this.lbModeReadWrite.Size = new System.Drawing.Size(160, 40);
            this.lbModeReadWrite.TabIndex = 8;
            this.lbModeReadWrite.Text = "MODE R/W";
            this.lbModeReadWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLicenseKey
            // 
            this.lbLicenseKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLicenseKey.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLicenseKey.Location = new System.Drawing.Point(12, 289);
            this.lbLicenseKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLicenseKey.Name = "lbLicenseKey";
            this.lbLicenseKey.Size = new System.Drawing.Size(160, 40);
            this.lbLicenseKey.TabIndex = 7;
            this.lbLicenseKey.Text = "LICENSE KEY";
            this.lbLicenseKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPdlReset
            // 
            this.lbPdlReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPdlReset.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPdlReset.Location = new System.Drawing.Point(12, 537);
            this.lbPdlReset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPdlReset.Name = "lbPdlReset";
            this.lbPdlReset.Size = new System.Drawing.Size(160, 40);
            this.lbPdlReset.TabIndex = 11;
            this.lbPdlReset.Text = "PDL RESET";
            this.lbPdlReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDeviceName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDeviceName.Location = new System.Drawing.Point(178, 93);
            this.tbDeviceName.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(250, 40);
            this.tbDeviceName.TabIndex = 12;
            this.tbDeviceName.Text = "";
            // 
            // tbBdAddress
            // 
            this.tbBdAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBdAddress.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbBdAddress.Location = new System.Drawing.Point(178, 142);
            this.tbBdAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbBdAddress.Name = "tbBdAddress";
            this.tbBdAddress.Size = new System.Drawing.Size(250, 40);
            this.tbBdAddress.TabIndex = 13;
            this.tbBdAddress.Text = "";
            // 
            // tbXtalFtrim
            // 
            this.tbXtalFtrim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbXtalFtrim.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbXtalFtrim.Location = new System.Drawing.Point(178, 240);
            this.tbXtalFtrim.Margin = new System.Windows.Forms.Padding(2);
            this.tbXtalFtrim.Name = "tbXtalFtrim";
            this.tbXtalFtrim.Size = new System.Drawing.Size(250, 40);
            this.tbXtalFtrim.TabIndex = 15;
            this.tbXtalFtrim.Text = "";
            // 
            // tbXtalLoadcap
            // 
            this.tbXtalLoadcap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbXtalLoadcap.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbXtalLoadcap.Location = new System.Drawing.Point(178, 191);
            this.tbXtalLoadcap.Margin = new System.Windows.Forms.Padding(2);
            this.tbXtalLoadcap.Name = "tbXtalLoadcap";
            this.tbXtalLoadcap.Size = new System.Drawing.Size(250, 40);
            this.tbXtalLoadcap.TabIndex = 14;
            this.tbXtalLoadcap.Text = "";
            // 
            // tbIg1505FwVersion
            // 
            this.tbIg1505FwVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIg1505FwVersion.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbIg1505FwVersion.Location = new System.Drawing.Point(178, 487);
            this.tbIg1505FwVersion.Margin = new System.Windows.Forms.Padding(2);
            this.tbIg1505FwVersion.Name = "tbIg1505FwVersion";
            this.tbIg1505FwVersion.Size = new System.Drawing.Size(250, 40);
            this.tbIg1505FwVersion.TabIndex = 19;
            this.tbIg1505FwVersion.Text = "";
            // 
            // tbBtFwVersion
            // 
            this.tbBtFwVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBtFwVersion.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbBtFwVersion.Location = new System.Drawing.Point(178, 438);
            this.tbBtFwVersion.Margin = new System.Windows.Forms.Padding(2);
            this.tbBtFwVersion.Name = "tbBtFwVersion";
            this.tbBtFwVersion.Size = new System.Drawing.Size(250, 40);
            this.tbBtFwVersion.TabIndex = 18;
            this.tbBtFwVersion.Text = "";
            // 
            // tbModeReadWrite
            // 
            this.tbModeReadWrite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbModeReadWrite.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbModeReadWrite.Location = new System.Drawing.Point(178, 338);
            this.tbModeReadWrite.Margin = new System.Windows.Forms.Padding(2);
            this.tbModeReadWrite.Name = "tbModeReadWrite";
            this.tbModeReadWrite.Size = new System.Drawing.Size(250, 40);
            this.tbModeReadWrite.TabIndex = 17;
            this.tbModeReadWrite.Text = "";
            // 
            // tbLicenseKey
            // 
            this.tbLicenseKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLicenseKey.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbLicenseKey.Location = new System.Drawing.Point(178, 289);
            this.tbLicenseKey.Margin = new System.Windows.Forms.Padding(2);
            this.tbLicenseKey.Name = "tbLicenseKey";
            this.tbLicenseKey.Size = new System.Drawing.Size(250, 40);
            this.tbLicenseKey.TabIndex = 16;
            this.tbLicenseKey.Text = "";
            // 
            // tbNrOnOff
            // 
            this.tbNrOnOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNrOnOff.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbNrOnOff.Location = new System.Drawing.Point(178, 388);
            this.tbNrOnOff.Margin = new System.Windows.Forms.Padding(2);
            this.tbNrOnOff.Name = "tbNrOnOff";
            this.tbNrOnOff.Size = new System.Drawing.Size(250, 40);
            this.tbNrOnOff.TabIndex = 21;
            this.tbNrOnOff.Text = "";
            // 
            // lbNrOnOff
            // 
            this.lbNrOnOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNrOnOff.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNrOnOff.Location = new System.Drawing.Point(11, 387);
            this.lbNrOnOff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNrOnOff.Name = "lbNrOnOff";
            this.lbNrOnOff.Size = new System.Drawing.Size(160, 40);
            this.lbNrOnOff.TabIndex = 20;
            this.lbNrOnOff.Text = "NR ON/OFF";
            this.lbNrOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeviceNameRead
            // 
            this.btnDeviceNameRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeviceNameRead.Location = new System.Drawing.Point(433, 93);
            this.btnDeviceNameRead.Name = "btnDeviceNameRead";
            this.btnDeviceNameRead.Size = new System.Drawing.Size(60, 40);
            this.btnDeviceNameRead.TabIndex = 22;
            this.btnDeviceNameRead.Text = "READ";
            this.btnDeviceNameRead.UseVisualStyleBackColor = true;
            this.btnDeviceNameRead.Click += new System.EventHandler(this.btnDeviceNameRead_Click);
            // 
            // btnDeviceNameWrite
            // 
            this.btnDeviceNameWrite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeviceNameWrite.Location = new System.Drawing.Point(499, 93);
            this.btnDeviceNameWrite.Name = "btnDeviceNameWrite";
            this.btnDeviceNameWrite.Size = new System.Drawing.Size(60, 40);
            this.btnDeviceNameWrite.TabIndex = 23;
            this.btnDeviceNameWrite.Text = "WRITE";
            this.btnDeviceNameWrite.UseVisualStyleBackColor = true;
            this.btnDeviceNameWrite.Click += new System.EventHandler(this.btnDeviceNameWrite_Click);
            // 
            // btnBdAddressWrite
            // 
            this.btnBdAddressWrite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBdAddressWrite.Location = new System.Drawing.Point(499, 142);
            this.btnBdAddressWrite.Name = "btnBdAddressWrite";
            this.btnBdAddressWrite.Size = new System.Drawing.Size(60, 40);
            this.btnBdAddressWrite.TabIndex = 25;
            this.btnBdAddressWrite.Text = "WRITE";
            this.btnBdAddressWrite.UseVisualStyleBackColor = true;
            // 
            // btnBdAddressRead
            // 
            this.btnBdAddressRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBdAddressRead.Location = new System.Drawing.Point(433, 142);
            this.btnBdAddressRead.Name = "btnBdAddressRead";
            this.btnBdAddressRead.Size = new System.Drawing.Size(60, 40);
            this.btnBdAddressRead.TabIndex = 24;
            this.btnBdAddressRead.Text = "READ";
            this.btnBdAddressRead.UseVisualStyleBackColor = true;
            // 
            // btnXtalFtrimWrite
            // 
            this.btnXtalFtrimWrite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnXtalFtrimWrite.Location = new System.Drawing.Point(499, 240);
            this.btnXtalFtrimWrite.Name = "btnXtalFtrimWrite";
            this.btnXtalFtrimWrite.Size = new System.Drawing.Size(60, 40);
            this.btnXtalFtrimWrite.TabIndex = 29;
            this.btnXtalFtrimWrite.Text = "WRITE";
            this.btnXtalFtrimWrite.UseVisualStyleBackColor = true;
            // 
            // btnXtalFtrimRead
            // 
            this.btnXtalFtrimRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnXtalFtrimRead.Location = new System.Drawing.Point(433, 240);
            this.btnXtalFtrimRead.Name = "btnXtalFtrimRead";
            this.btnXtalFtrimRead.Size = new System.Drawing.Size(60, 40);
            this.btnXtalFtrimRead.TabIndex = 28;
            this.btnXtalFtrimRead.Text = "READ";
            this.btnXtalFtrimRead.UseVisualStyleBackColor = true;
            // 
            // btnXtalLoadcapWrite
            // 
            this.btnXtalLoadcapWrite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnXtalLoadcapWrite.Location = new System.Drawing.Point(499, 191);
            this.btnXtalLoadcapWrite.Name = "btnXtalLoadcapWrite";
            this.btnXtalLoadcapWrite.Size = new System.Drawing.Size(60, 40);
            this.btnXtalLoadcapWrite.TabIndex = 27;
            this.btnXtalLoadcapWrite.Text = "WRITE";
            this.btnXtalLoadcapWrite.UseVisualStyleBackColor = true;
            // 
            // btnXtalLoadcapRead
            // 
            this.btnXtalLoadcapRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnXtalLoadcapRead.Location = new System.Drawing.Point(433, 191);
            this.btnXtalLoadcapRead.Name = "btnXtalLoadcapRead";
            this.btnXtalLoadcapRead.Size = new System.Drawing.Size(60, 40);
            this.btnXtalLoadcapRead.TabIndex = 26;
            this.btnXtalLoadcapRead.Text = "READ";
            this.btnXtalLoadcapRead.UseVisualStyleBackColor = true;
            // 
            // btnBtFwVersionWrite
            // 
            this.btnBtFwVersionWrite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBtFwVersionWrite.Location = new System.Drawing.Point(499, 436);
            this.btnBtFwVersionWrite.Name = "btnBtFwVersionWrite";
            this.btnBtFwVersionWrite.Size = new System.Drawing.Size(60, 40);
            this.btnBtFwVersionWrite.TabIndex = 37;
            this.btnBtFwVersionWrite.Text = "WRITE";
            this.btnBtFwVersionWrite.UseVisualStyleBackColor = true;
            this.btnBtFwVersionWrite.Click += new System.EventHandler(this.btnBtFwVersionWrite_Click);
            // 
            // btnBtFwVersionRead
            // 
            this.btnBtFwVersionRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBtFwVersionRead.Location = new System.Drawing.Point(433, 436);
            this.btnBtFwVersionRead.Name = "btnBtFwVersionRead";
            this.btnBtFwVersionRead.Size = new System.Drawing.Size(60, 40);
            this.btnBtFwVersionRead.TabIndex = 36;
            this.btnBtFwVersionRead.Text = "READ";
            this.btnBtFwVersionRead.UseVisualStyleBackColor = true;
            this.btnBtFwVersionRead.Click += new System.EventHandler(this.btnBtFwVersionRead_Click);
            // 
            // btnNrOnOffWrite
            // 
            this.btnNrOnOffWrite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNrOnOffWrite.Location = new System.Drawing.Point(499, 387);
            this.btnNrOnOffWrite.Name = "btnNrOnOffWrite";
            this.btnNrOnOffWrite.Size = new System.Drawing.Size(60, 40);
            this.btnNrOnOffWrite.TabIndex = 35;
            this.btnNrOnOffWrite.Text = "WRITE";
            this.btnNrOnOffWrite.UseVisualStyleBackColor = true;
            this.btnNrOnOffWrite.Click += new System.EventHandler(this.btnNrOnOffWrite_Click);
            // 
            // btnNrOnOffRead
            // 
            this.btnNrOnOffRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNrOnOffRead.Location = new System.Drawing.Point(433, 387);
            this.btnNrOnOffRead.Name = "btnNrOnOffRead";
            this.btnNrOnOffRead.Size = new System.Drawing.Size(60, 40);
            this.btnNrOnOffRead.TabIndex = 34;
            this.btnNrOnOffRead.Text = "READ";
            this.btnNrOnOffRead.UseVisualStyleBackColor = true;
            this.btnNrOnOffRead.Click += new System.EventHandler(this.btnNrOnOffRead_Click);
            // 
            // btmModeReadWriteWrite
            // 
            this.btmModeReadWriteWrite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btmModeReadWriteWrite.Location = new System.Drawing.Point(499, 337);
            this.btmModeReadWriteWrite.Name = "btmModeReadWriteWrite";
            this.btmModeReadWriteWrite.Size = new System.Drawing.Size(60, 40);
            this.btmModeReadWriteWrite.TabIndex = 33;
            this.btmModeReadWriteWrite.Text = "WRITE";
            this.btmModeReadWriteWrite.UseVisualStyleBackColor = true;
            this.btmModeReadWriteWrite.Click += new System.EventHandler(this.btmModeReadWriteWrite_Click);
            // 
            // btnModeReadWriteRead
            // 
            this.btnModeReadWriteRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModeReadWriteRead.Location = new System.Drawing.Point(433, 337);
            this.btnModeReadWriteRead.Name = "btnModeReadWriteRead";
            this.btnModeReadWriteRead.Size = new System.Drawing.Size(60, 40);
            this.btnModeReadWriteRead.TabIndex = 32;
            this.btnModeReadWriteRead.Text = "READ";
            this.btnModeReadWriteRead.UseVisualStyleBackColor = true;
            this.btnModeReadWriteRead.Click += new System.EventHandler(this.btnModeReadWriteRead_Click);
            // 
            // btnLicenseKeyWrite
            // 
            this.btnLicenseKeyWrite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLicenseKeyWrite.Location = new System.Drawing.Point(499, 289);
            this.btnLicenseKeyWrite.Name = "btnLicenseKeyWrite";
            this.btnLicenseKeyWrite.Size = new System.Drawing.Size(60, 40);
            this.btnLicenseKeyWrite.TabIndex = 31;
            this.btnLicenseKeyWrite.Text = "WRITE";
            this.btnLicenseKeyWrite.UseVisualStyleBackColor = true;
            // 
            // btnLicenseKeyRead
            // 
            this.btnLicenseKeyRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLicenseKeyRead.Location = new System.Drawing.Point(433, 289);
            this.btnLicenseKeyRead.Name = "btnLicenseKeyRead";
            this.btnLicenseKeyRead.Size = new System.Drawing.Size(60, 40);
            this.btnLicenseKeyRead.TabIndex = 30;
            this.btnLicenseKeyRead.Text = "READ";
            this.btnLicenseKeyRead.UseVisualStyleBackColor = true;
            // 
            // btnIg1505FwVersionWrite
            // 
            this.btnIg1505FwVersionWrite.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnIg1505FwVersionWrite.Location = new System.Drawing.Point(499, 486);
            this.btnIg1505FwVersionWrite.Name = "btnIg1505FwVersionWrite";
            this.btnIg1505FwVersionWrite.Size = new System.Drawing.Size(60, 40);
            this.btnIg1505FwVersionWrite.TabIndex = 39;
            this.btnIg1505FwVersionWrite.Text = "WRITE";
            this.btnIg1505FwVersionWrite.UseVisualStyleBackColor = true;
            this.btnIg1505FwVersionWrite.Click += new System.EventHandler(this.btnIg1505FwVersionWrite_Click);
            // 
            // btnIg1505FwVersionRead
            // 
            this.btnIg1505FwVersionRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnIg1505FwVersionRead.Location = new System.Drawing.Point(433, 486);
            this.btnIg1505FwVersionRead.Name = "btnIg1505FwVersionRead";
            this.btnIg1505FwVersionRead.Size = new System.Drawing.Size(60, 40);
            this.btnIg1505FwVersionRead.TabIndex = 38;
            this.btnIg1505FwVersionRead.Text = "READ";
            this.btnIg1505FwVersionRead.UseVisualStyleBackColor = true;
            this.btnIg1505FwVersionRead.Click += new System.EventHandler(this.btnIg1505FwVersionRead_Click);
            // 
            // cbComport
            // 
            this.cbComport.FormattingEnabled = true;
            this.cbComport.Location = new System.Drawing.Point(11, 12);
            this.cbComport.Name = "cbComport";
            this.cbComport.Size = new System.Drawing.Size(80, 20);
            this.cbComport.TabIndex = 40;
            // 
            // tbReceiveTest
            // 
            this.tbReceiveTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReceiveTest.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbReceiveTest.Location = new System.Drawing.Point(564, 143);
            this.tbReceiveTest.Margin = new System.Windows.Forms.Padding(2);
            this.tbReceiveTest.Name = "tbReceiveTest";
            this.tbReceiveTest.Size = new System.Drawing.Size(201, 236);
            this.tbReceiveTest.TabIndex = 41;
            this.tbReceiveTest.Text = "";
            // 
            // btnTestSend
            // 
            this.btnTestSend.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTestSend.Location = new System.Drawing.Point(564, 45);
            this.btnTestSend.Name = "btnTestSend";
            this.btnTestSend.Size = new System.Drawing.Size(60, 40);
            this.btnTestSend.TabIndex = 42;
            this.btnTestSend.Text = "SEND";
            this.btnTestSend.UseVisualStyleBackColor = true;
            this.btnTestSend.Click += new System.EventHandler(this.btnTestSend_Click);
            // 
            // tbSendTest
            // 
            this.tbSendTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSendTest.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSendTest.Location = new System.Drawing.Point(564, 93);
            this.tbSendTest.Margin = new System.Windows.Forms.Padding(2);
            this.tbSendTest.Name = "tbSendTest";
            this.tbSendTest.Size = new System.Drawing.Size(201, 38);
            this.tbSendTest.TabIndex = 43;
            this.tbSendTest.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 595);
            this.Controls.Add(this.tbSendTest);
            this.Controls.Add(this.btnTestSend);
            this.Controls.Add(this.tbReceiveTest);
            this.Controls.Add(this.cbComport);
            this.Controls.Add(this.btnIg1505FwVersionWrite);
            this.Controls.Add(this.btnIg1505FwVersionRead);
            this.Controls.Add(this.btnBtFwVersionWrite);
            this.Controls.Add(this.btnBtFwVersionRead);
            this.Controls.Add(this.btnNrOnOffWrite);
            this.Controls.Add(this.btnNrOnOffRead);
            this.Controls.Add(this.btmModeReadWriteWrite);
            this.Controls.Add(this.btnModeReadWriteRead);
            this.Controls.Add(this.btnLicenseKeyWrite);
            this.Controls.Add(this.btnLicenseKeyRead);
            this.Controls.Add(this.btnXtalFtrimWrite);
            this.Controls.Add(this.btnXtalFtrimRead);
            this.Controls.Add(this.btnXtalLoadcapWrite);
            this.Controls.Add(this.btnXtalLoadcapRead);
            this.Controls.Add(this.btnBdAddressWrite);
            this.Controls.Add(this.btnBdAddressRead);
            this.Controls.Add(this.btnDeviceNameWrite);
            this.Controls.Add(this.btnDeviceNameRead);
            this.Controls.Add(this.tbNrOnOff);
            this.Controls.Add(this.lbNrOnOff);
            this.Controls.Add(this.tbIg1505FwVersion);
            this.Controls.Add(this.tbBtFwVersion);
            this.Controls.Add(this.tbModeReadWrite);
            this.Controls.Add(this.tbLicenseKey);
            this.Controls.Add(this.tbXtalFtrim);
            this.Controls.Add(this.tbXtalLoadcap);
            this.Controls.Add(this.tbBdAddress);
            this.Controls.Add(this.tbDeviceName);
            this.Controls.Add(this.lbPdlReset);
            this.Controls.Add(this.lbIg1505FwVersion);
            this.Controls.Add(this.lbBtFwVersion);
            this.Controls.Add(this.lbModeReadWrite);
            this.Controls.Add(this.lbLicenseKey);
            this.Controls.Add(this.lbXtalFtrim);
            this.Controls.Add(this.lbXtalLoadcap);
            this.Controls.Add(this.lbBdAddress);
            this.Controls.Add(this.lbDeviceName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "ATH-CC550BT Device Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.Label lbBdAddress;
        private System.Windows.Forms.Label lbXtalFtrim;
        private System.Windows.Forms.Label lbXtalLoadcap;
        private System.Windows.Forms.Label lbIg1505FwVersion;
        private System.Windows.Forms.Label lbBtFwVersion;
        private System.Windows.Forms.Label lbModeReadWrite;
        private System.Windows.Forms.Label lbLicenseKey;
        private System.Windows.Forms.Label lbPdlReset;
        private System.Windows.Forms.RichTextBox tbDeviceName;
        private System.Windows.Forms.RichTextBox tbBdAddress;
        private System.Windows.Forms.RichTextBox tbXtalFtrim;
        private System.Windows.Forms.RichTextBox tbXtalLoadcap;
        private System.Windows.Forms.RichTextBox tbIg1505FwVersion;
        private System.Windows.Forms.RichTextBox tbBtFwVersion;
        private System.Windows.Forms.RichTextBox tbModeReadWrite;
        private System.Windows.Forms.RichTextBox tbLicenseKey;
        private System.Windows.Forms.RichTextBox tbNrOnOff;
        private System.Windows.Forms.Label lbNrOnOff;
        private System.Windows.Forms.Button btnDeviceNameRead;
        private System.Windows.Forms.Button btnDeviceNameWrite;
        private System.Windows.Forms.Button btnBdAddressWrite;
        private System.Windows.Forms.Button btnBdAddressRead;
        private System.Windows.Forms.Button btnXtalFtrimWrite;
        private System.Windows.Forms.Button btnXtalFtrimRead;
        private System.Windows.Forms.Button btnXtalLoadcapWrite;
        private System.Windows.Forms.Button btnXtalLoadcapRead;
        private System.Windows.Forms.Button btnBtFwVersionWrite;
        private System.Windows.Forms.Button btnBtFwVersionRead;
        private System.Windows.Forms.Button btnNrOnOffWrite;
        private System.Windows.Forms.Button btnNrOnOffRead;
        private System.Windows.Forms.Button btmModeReadWriteWrite;
        private System.Windows.Forms.Button btnModeReadWriteRead;
        private System.Windows.Forms.Button btnLicenseKeyWrite;
        private System.Windows.Forms.Button btnLicenseKeyRead;
        private System.Windows.Forms.Button btnIg1505FwVersionWrite;
        private System.Windows.Forms.Button btnIg1505FwVersionRead;
        private System.Windows.Forms.ComboBox cbComport;
        private System.Windows.Forms.RichTextBox tbReceiveTest;
        private System.Windows.Forms.Button btnTestSend;
        private System.Windows.Forms.RichTextBox tbSendTest;
    }
}

