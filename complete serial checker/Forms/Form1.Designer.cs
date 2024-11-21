namespace SystemInfoApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSecureBoot = new System.Windows.Forms.Label();
            this.lblWindowsVersion = new System.Windows.Forms.Label();
            this.lblRealTimeProtection = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.lblTpmStatus = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblProcessorManufacturer = new System.Windows.Forms.Label();
            this.lblProcessorVersion = new System.Windows.Forms.Label();
            this.lblProcessorSerialNumber = new System.Windows.Forms.Label();
            this.lblSocketProcessor = new System.Windows.Forms.Label();
            this.lblProcessorVirtualization = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProcessorInformation = new System.Windows.Forms.Label();
            this.lblProcessorPartNumber = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblSystemSerial = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBiosReleaseDate = new System.Windows.Forms.Label();
            this.lblBiosVendor = new System.Windows.Forms.Label();
            this.lblBiosVersion = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDiskInformation = new System.Windows.Forms.Label();
            this.lblDiskModel = new System.Windows.Forms.Label();
            this.lblDiskSerial = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCustomOS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBaseboardLocation = new System.Windows.Forms.Label();
            this.lblBaseboardManufacturer = new System.Windows.Forms.Label();
            this.lblBaseboardSerialNumber = new System.Windows.Forms.Label();
            this.lblBaseboardProductName = new System.Windows.Forms.Label();
            this.lblBaseboardVersion = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiskStorageModel = new System.Windows.Forms.Label();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMacCache5 = new System.Windows.Forms.Label();
            this.lblMacCache6 = new System.Windows.Forms.Label();
            this.lblMacCache1 = new System.Windows.Forms.Label();
            this.lblMacCache4 = new System.Windows.Forms.Label();
            this.lblMacCache2 = new System.Windows.Forms.Label();
            this.lblMacCache3 = new System.Windows.Forms.Label();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMonitorActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMonitorResolution = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSecureBoot
            // 
            this.lblSecureBoot.AutoSize = true;
            this.lblSecureBoot.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecureBoot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSecureBoot.Location = new System.Drawing.Point(12, 65);
            this.lblSecureBoot.Name = "lblSecureBoot";
            this.lblSecureBoot.Size = new System.Drawing.Size(112, 16);
            this.lblSecureBoot.TabIndex = 5;
            this.lblSecureBoot.Text = "Secure Boot: ";
            this.lblSecureBoot.Click += new System.EventHandler(this.lblSecureBoot_Click);
            // 
            // lblWindowsVersion
            // 
            this.lblWindowsVersion.AutoSize = true;
            this.lblWindowsVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowsVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWindowsVersion.Location = new System.Drawing.Point(12, 99);
            this.lblWindowsVersion.Name = "lblWindowsVersion";
            this.lblWindowsVersion.Size = new System.Drawing.Size(146, 16);
            this.lblWindowsVersion.TabIndex = 8;
            this.lblWindowsVersion.Text = "Windows Version: ";
            this.lblWindowsVersion.Click += new System.EventHandler(this.lblWindowsVersion_Click);
            // 
            // lblRealTimeProtection
            // 
            this.lblRealTimeProtection.AutoSize = true;
            this.lblRealTimeProtection.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealTimeProtection.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRealTimeProtection.Location = new System.Drawing.Point(12, 41);
            this.lblRealTimeProtection.Name = "lblRealTimeProtection";
            this.lblRealTimeProtection.Size = new System.Drawing.Size(178, 16);
            this.lblRealTimeProtection.TabIndex = 9;
            this.lblRealTimeProtection.Text = "Real-Time Protection: ";
            this.lblRealTimeProtection.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.lblRequirements);
            this.guna2Panel1.Controls.Add(this.lblTpmStatus);
            this.guna2Panel1.Controls.Add(this.lblRealTimeProtection);
            this.guna2Panel1.Controls.Add(this.lblSecureBoot);
            this.guna2Panel1.Location = new System.Drawing.Point(20, 263);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(411, 121);
            this.guna2Panel1.TabIndex = 10;
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.lblRequirements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.lblRequirements.Location = new System.Drawing.Point(150, 20);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(107, 21);
            this.lblRequirements.TabIndex = 0;
            this.lblRequirements.Text = "Requirements";
            this.lblRequirements.Click += new System.EventHandler(this.lblRequirements_Click);
            // 
            // lblTpmStatus
            // 
            this.lblTpmStatus.AutoSize = true;
            this.lblTpmStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpmStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTpmStatus.Location = new System.Drawing.Point(12, 89);
            this.lblTpmStatus.Name = "lblTpmStatus";
            this.lblTpmStatus.Size = new System.Drawing.Size(107, 16);
            this.lblTpmStatus.TabIndex = 12;
            this.lblTpmStatus.Text = "TPM Status: ";
            this.lblTpmStatus.Click += new System.EventHandler(this.lblTpmStatus_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 0.65D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Transparent;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderColor = System.Drawing.SystemColors.Control;
            this.guna2ControlBox1.BorderRadius = 6;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(848, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(10, 10);
            this.guna2ControlBox1.TabIndex = 11;
            // 
            // lblProcessorManufacturer
            // 
            this.lblProcessorManufacturer.AutoSize = true;
            this.lblProcessorManufacturer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessorManufacturer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProcessorManufacturer.Location = new System.Drawing.Point(12, 36);
            this.lblProcessorManufacturer.Name = "lblProcessorManufacturer";
            this.lblProcessorManufacturer.Size = new System.Drawing.Size(120, 16);
            this.lblProcessorManufacturer.TabIndex = 17;
            this.lblProcessorManufacturer.Text = "Manufacturer: ";
            // 
            // lblProcessorVersion
            // 
            this.lblProcessorVersion.AutoSize = true;
            this.lblProcessorVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessorVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProcessorVersion.Location = new System.Drawing.Point(12, 52);
            this.lblProcessorVersion.Name = "lblProcessorVersion";
            this.lblProcessorVersion.Size = new System.Drawing.Size(75, 16);
            this.lblProcessorVersion.TabIndex = 18;
            this.lblProcessorVersion.Text = "Version: ";
            // 
            // lblProcessorSerialNumber
            // 
            this.lblProcessorSerialNumber.AutoSize = true;
            this.lblProcessorSerialNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessorSerialNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProcessorSerialNumber.Location = new System.Drawing.Point(12, 68);
            this.lblProcessorSerialNumber.Name = "lblProcessorSerialNumber";
            this.lblProcessorSerialNumber.Size = new System.Drawing.Size(123, 16);
            this.lblProcessorSerialNumber.TabIndex = 19;
            this.lblProcessorSerialNumber.Text = "Serial Number: ";
            // 
            // lblSocketProcessor
            // 
            this.lblSocketProcessor.AutoSize = true;
            this.lblSocketProcessor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocketProcessor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSocketProcessor.Location = new System.Drawing.Point(12, 84);
            this.lblSocketProcessor.Name = "lblSocketProcessor";
            this.lblSocketProcessor.Size = new System.Drawing.Size(72, 16);
            this.lblSocketProcessor.TabIndex = 20;
            this.lblSocketProcessor.Text = "Socket: ";
            // 
            // lblProcessorVirtualization
            // 
            this.lblProcessorVirtualization.AutoSize = true;
            this.lblProcessorVirtualization.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessorVirtualization.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProcessorVirtualization.Location = new System.Drawing.Point(12, 116);
            this.lblProcessorVirtualization.Name = "lblProcessorVirtualization";
            this.lblProcessorVirtualization.Size = new System.Drawing.Size(175, 16);
            this.lblProcessorVirtualization.TabIndex = 21;
            this.lblProcessorVirtualization.Text = "Virtualization Status: ";
            this.lblProcessorVirtualization.Click += new System.EventHandler(this.lblProcessorVirtualization_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.lblProcessorInformation);
            this.guna2Panel2.Controls.Add(this.lblProcessorPartNumber);
            this.guna2Panel2.Controls.Add(this.lblProcessorVirtualization);
            this.guna2Panel2.Controls.Add(this.lblProcessorManufacturer);
            this.guna2Panel2.Controls.Add(this.lblSocketProcessor);
            this.guna2Panel2.Controls.Add(this.lblProcessorVersion);
            this.guna2Panel2.Controls.Add(this.lblProcessorSerialNumber);
            this.guna2Panel2.Location = new System.Drawing.Point(437, 478);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(411, 155);
            this.guna2Panel2.TabIndex = 13;
            // 
            // lblProcessorInformation
            // 
            this.lblProcessorInformation.AutoSize = true;
            this.lblProcessorInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.lblProcessorInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.lblProcessorInformation.Location = new System.Drawing.Point(125, 17);
            this.lblProcessorInformation.Name = "lblProcessorInformation";
            this.lblProcessorInformation.Size = new System.Drawing.Size(164, 21);
            this.lblProcessorInformation.TabIndex = 13;
            this.lblProcessorInformation.Text = "Processor Information";
            // 
            // lblProcessorPartNumber
            // 
            this.lblProcessorPartNumber.AutoSize = true;
            this.lblProcessorPartNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessorPartNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProcessorPartNumber.Location = new System.Drawing.Point(12, 100);
            this.lblProcessorPartNumber.Name = "lblProcessorPartNumber";
            this.lblProcessorPartNumber.Size = new System.Drawing.Size(100, 16);
            this.lblProcessorPartNumber.TabIndex = 22;
            this.lblProcessorPartNumber.Text = "PartNumber:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(20, 578);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(411, 55);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Refresh Info";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblSystemSerial
            // 
            this.lblSystemSerial.AutoSize = true;
            this.lblSystemSerial.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemSerial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSystemSerial.Location = new System.Drawing.Point(12, 83);
            this.lblSystemSerial.Name = "lblSystemSerial";
            this.lblSystemSerial.Size = new System.Drawing.Size(123, 16);
            this.lblSystemSerial.TabIndex = 14;
            this.lblSystemSerial.Text = "System Serial: ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductName.Location = new System.Drawing.Point(12, 67);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(124, 16);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Product Name: ";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblManufacturer.Location = new System.Drawing.Point(12, 51);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(120, 16);
            this.lblManufacturer.TabIndex = 13;
            this.lblManufacturer.Text = "Manufacturer: ";
            this.lblManufacturer.Click += new System.EventHandler(this.lblManufacturer_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel3.BorderRadius = 8;
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.lblBiosReleaseDate);
            this.guna2Panel3.Controls.Add(this.lblBiosVendor);
            this.guna2Panel3.Controls.Add(this.lblBiosVersion);
            this.guna2Panel3.Location = new System.Drawing.Point(20, 136);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(411, 121);
            this.guna2Panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(166, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bios Info";
            // 
            // lblBiosReleaseDate
            // 
            this.lblBiosReleaseDate.AutoSize = true;
            this.lblBiosReleaseDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiosReleaseDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBiosReleaseDate.Location = new System.Drawing.Point(12, 89);
            this.lblBiosReleaseDate.Name = "lblBiosReleaseDate";
            this.lblBiosReleaseDate.Size = new System.Drawing.Size(118, 16);
            this.lblBiosReleaseDate.TabIndex = 12;
            this.lblBiosReleaseDate.Text = "Release Date: ";
            // 
            // lblBiosVendor
            // 
            this.lblBiosVendor.AutoSize = true;
            this.lblBiosVendor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiosVendor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBiosVendor.Location = new System.Drawing.Point(12, 41);
            this.lblBiosVendor.Name = "lblBiosVendor";
            this.lblBiosVendor.Size = new System.Drawing.Size(66, 16);
            this.lblBiosVendor.TabIndex = 9;
            this.lblBiosVendor.Text = "Vendor:";
            this.lblBiosVendor.Click += new System.EventHandler(this.lblBiosVendor_Click_1);
            // 
            // lblBiosVersion
            // 
            this.lblBiosVersion.AutoSize = true;
            this.lblBiosVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiosVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBiosVersion.Location = new System.Drawing.Point(12, 65);
            this.lblBiosVersion.Name = "lblBiosVersion";
            this.lblBiosVersion.Size = new System.Drawing.Size(75, 16);
            this.lblBiosVersion.TabIndex = 5;
            this.lblBiosVersion.Text = "Version: ";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel4.BorderRadius = 8;
            this.guna2Panel4.BorderThickness = 3;
            this.guna2Panel4.Controls.Add(this.lblDiskInformation);
            this.guna2Panel4.Controls.Add(this.lblDiskModel);
            this.guna2Panel4.Controls.Add(this.lblDiskSerial);
            this.guna2Panel4.Location = new System.Drawing.Point(20, 32);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(411, 98);
            this.guna2Panel4.TabIndex = 14;
            // 
            // lblDiskInformation
            // 
            this.lblDiskInformation.AutoSize = true;
            this.lblDiskInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.lblDiskInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.lblDiskInformation.Location = new System.Drawing.Point(140, 20);
            this.lblDiskInformation.Name = "lblDiskInformation";
            this.lblDiskInformation.Size = new System.Drawing.Size(126, 21);
            this.lblDiskInformation.TabIndex = 0;
            this.lblDiskInformation.Text = "Disk Information";
            // 
            // lblDiskModel
            // 
            this.lblDiskModel.AutoSize = true;
            this.lblDiskModel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskModel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDiskModel.Location = new System.Drawing.Point(12, 43);
            this.lblDiskModel.Name = "lblDiskModel";
            this.lblDiskModel.Size = new System.Drawing.Size(99, 16);
            this.lblDiskModel.TabIndex = 9;
            this.lblDiskModel.Text = "Disk Model: ";
            // 
            // lblDiskSerial
            // 
            this.lblDiskSerial.AutoSize = true;
            this.lblDiskSerial.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskSerial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDiskSerial.Location = new System.Drawing.Point(12, 67);
            this.lblDiskSerial.Name = "lblDiskSerial";
            this.lblDiskSerial.Size = new System.Drawing.Size(98, 16);
            this.lblDiskSerial.TabIndex = 5;
            this.lblDiskSerial.Text = "Disk Serial: ";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.BorderThickness = 3;
            this.guna2Panel5.Controls.Add(this.lblCustomOS);
            this.guna2Panel5.Controls.Add(this.lblProductName);
            this.guna2Panel5.Controls.Add(this.label2);
            this.guna2Panel5.Controls.Add(this.lblSystemSerial);
            this.guna2Panel5.Controls.Add(this.lblManufacturer);
            this.guna2Panel5.Controls.Add(this.lblWindowsVersion);
            this.guna2Panel5.Location = new System.Drawing.Point(437, 329);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(411, 143);
            this.guna2Panel5.TabIndex = 14;
            // 
            // lblCustomOS
            // 
            this.lblCustomOS.AutoSize = true;
            this.lblCustomOS.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomOS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCustomOS.Location = new System.Drawing.Point(12, 115);
            this.lblCustomOS.Name = "lblCustomOS";
            this.lblCustomOS.Size = new System.Drawing.Size(96, 16);
            this.lblCustomOS.TabIndex = 16;
            this.lblCustomOS.Text = "Custom OS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(139, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "System Information";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel6.BorderRadius = 8;
            this.guna2Panel6.BorderThickness = 3;
            this.guna2Panel6.Controls.Add(this.label3);
            this.guna2Panel6.Controls.Add(this.lblBaseboardLocation);
            this.guna2Panel6.Controls.Add(this.lblBaseboardManufacturer);
            this.guna2Panel6.Controls.Add(this.lblBaseboardSerialNumber);
            this.guna2Panel6.Controls.Add(this.lblBaseboardProductName);
            this.guna2Panel6.Controls.Add(this.lblBaseboardVersion);
            this.guna2Panel6.Location = new System.Drawing.Point(437, 32);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(411, 130);
            this.guna2Panel6.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(125, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Baseboard Information";
            // 
            // lblBaseboardLocation
            // 
            this.lblBaseboardLocation.AutoSize = true;
            this.lblBaseboardLocation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseboardLocation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaseboardLocation.Location = new System.Drawing.Point(12, 100);
            this.lblBaseboardLocation.Name = "lblBaseboardLocation";
            this.lblBaseboardLocation.Size = new System.Drawing.Size(78, 16);
            this.lblBaseboardLocation.TabIndex = 22;
            this.lblBaseboardLocation.Text = "Location:";
            // 
            // lblBaseboardManufacturer
            // 
            this.lblBaseboardManufacturer.AutoSize = true;
            this.lblBaseboardManufacturer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseboardManufacturer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaseboardManufacturer.Location = new System.Drawing.Point(12, 36);
            this.lblBaseboardManufacturer.Name = "lblBaseboardManufacturer";
            this.lblBaseboardManufacturer.Size = new System.Drawing.Size(120, 16);
            this.lblBaseboardManufacturer.TabIndex = 17;
            this.lblBaseboardManufacturer.Text = "Manufacturer: ";
            // 
            // lblBaseboardSerialNumber
            // 
            this.lblBaseboardSerialNumber.AutoSize = true;
            this.lblBaseboardSerialNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseboardSerialNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaseboardSerialNumber.Location = new System.Drawing.Point(12, 84);
            this.lblBaseboardSerialNumber.Name = "lblBaseboardSerialNumber";
            this.lblBaseboardSerialNumber.Size = new System.Drawing.Size(117, 16);
            this.lblBaseboardSerialNumber.TabIndex = 20;
            this.lblBaseboardSerialNumber.Text = "SerialNumber: ";
            // 
            // lblBaseboardProductName
            // 
            this.lblBaseboardProductName.AutoSize = true;
            this.lblBaseboardProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseboardProductName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaseboardProductName.Location = new System.Drawing.Point(12, 52);
            this.lblBaseboardProductName.Name = "lblBaseboardProductName";
            this.lblBaseboardProductName.Size = new System.Drawing.Size(118, 16);
            this.lblBaseboardProductName.TabIndex = 18;
            this.lblBaseboardProductName.Text = "ProductName: ";
            // 
            // lblBaseboardVersion
            // 
            this.lblBaseboardVersion.AutoSize = true;
            this.lblBaseboardVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseboardVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaseboardVersion.Location = new System.Drawing.Point(12, 68);
            this.lblBaseboardVersion.Name = "lblBaseboardVersion";
            this.lblBaseboardVersion.Size = new System.Drawing.Size(75, 16);
            this.lblBaseboardVersion.TabIndex = 19;
            this.lblBaseboardVersion.Text = "Version: ";
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel7.BorderRadius = 8;
            this.guna2Panel7.BorderThickness = 3;
            this.guna2Panel7.Controls.Add(this.label4);
            this.guna2Panel7.Controls.Add(this.lblDiskStorageModel);
            this.guna2Panel7.Location = new System.Drawing.Point(20, 390);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(411, 72);
            this.guna2Panel7.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(125, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Disk Drive Information";
            // 
            // lblDiskStorageModel
            // 
            this.lblDiskStorageModel.AutoSize = true;
            this.lblDiskStorageModel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskStorageModel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDiskStorageModel.Location = new System.Drawing.Point(12, 43);
            this.lblDiskStorageModel.Name = "lblDiskStorageModel";
            this.lblDiskStorageModel.Size = new System.Drawing.Size(158, 16);
            this.lblDiskStorageModel.TabIndex = 17;
            this.lblDiskStorageModel.Text = "Disk Storage Model:";
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel8.BorderRadius = 8;
            this.guna2Panel8.BorderThickness = 3;
            this.guna2Panel8.Controls.Add(this.label5);
            this.guna2Panel8.Controls.Add(this.lblMacCache5);
            this.guna2Panel8.Controls.Add(this.lblMacCache6);
            this.guna2Panel8.Controls.Add(this.lblMacCache1);
            this.guna2Panel8.Controls.Add(this.lblMacCache4);
            this.guna2Panel8.Controls.Add(this.lblMacCache2);
            this.guna2Panel8.Controls.Add(this.lblMacCache3);
            this.guna2Panel8.Location = new System.Drawing.Point(437, 168);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(411, 155);
            this.guna2Panel8.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(125, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Network Information";
            // 
            // lblMacCache5
            // 
            this.lblMacCache5.AutoSize = true;
            this.lblMacCache5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacCache5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMacCache5.Location = new System.Drawing.Point(12, 100);
            this.lblMacCache5.Name = "lblMacCache5";
            this.lblMacCache5.Size = new System.Drawing.Size(112, 16);
            this.lblMacCache5.TabIndex = 22;
            this.lblMacCache5.Text = "MAC [Cache]:";
            // 
            // lblMacCache6
            // 
            this.lblMacCache6.AutoSize = true;
            this.lblMacCache6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacCache6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMacCache6.Location = new System.Drawing.Point(12, 116);
            this.lblMacCache6.Name = "lblMacCache6";
            this.lblMacCache6.Size = new System.Drawing.Size(112, 16);
            this.lblMacCache6.TabIndex = 21;
            this.lblMacCache6.Text = "MAC [Cache]:";
            // 
            // lblMacCache1
            // 
            this.lblMacCache1.AutoSize = true;
            this.lblMacCache1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacCache1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMacCache1.Location = new System.Drawing.Point(12, 36);
            this.lblMacCache1.Name = "lblMacCache1";
            this.lblMacCache1.Size = new System.Drawing.Size(112, 16);
            this.lblMacCache1.TabIndex = 17;
            this.lblMacCache1.Text = "MAC [Cache]:";
            // 
            // lblMacCache4
            // 
            this.lblMacCache4.AutoSize = true;
            this.lblMacCache4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacCache4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMacCache4.Location = new System.Drawing.Point(12, 84);
            this.lblMacCache4.Name = "lblMacCache4";
            this.lblMacCache4.Size = new System.Drawing.Size(112, 16);
            this.lblMacCache4.TabIndex = 20;
            this.lblMacCache4.Text = "MAC [Cache]:";
            // 
            // lblMacCache2
            // 
            this.lblMacCache2.AutoSize = true;
            this.lblMacCache2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacCache2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMacCache2.Location = new System.Drawing.Point(12, 52);
            this.lblMacCache2.Name = "lblMacCache2";
            this.lblMacCache2.Size = new System.Drawing.Size(112, 16);
            this.lblMacCache2.TabIndex = 18;
            this.lblMacCache2.Text = "MAC [Cache]:";
            // 
            // lblMacCache3
            // 
            this.lblMacCache3.AutoSize = true;
            this.lblMacCache3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacCache3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMacCache3.Location = new System.Drawing.Point(12, 68);
            this.lblMacCache3.Name = "lblMacCache3";
            this.lblMacCache3.Size = new System.Drawing.Size(112, 16);
            this.lblMacCache3.TabIndex = 19;
            this.lblMacCache3.Text = "MAC [Cache]:";
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel9.BorderRadius = 8;
            this.guna2Panel9.BorderThickness = 3;
            this.guna2Panel9.Controls.Add(this.lblMonitorActive);
            this.guna2Panel9.Controls.Add(this.label6);
            this.guna2Panel9.Controls.Add(this.lblMonitorResolution);
            this.guna2Panel9.Location = new System.Drawing.Point(20, 468);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(411, 99);
            this.guna2Panel9.TabIndex = 24;
            // 
            // lblMonitorActive
            // 
            this.lblMonitorActive.AutoSize = true;
            this.lblMonitorActive.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitorActive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMonitorActive.Location = new System.Drawing.Point(12, 51);
            this.lblMonitorActive.Name = "lblMonitorActive";
            this.lblMonitorActive.Size = new System.Drawing.Size(104, 16);
            this.lblMonitorActive.TabIndex = 23;
            this.lblMonitorActive.Text = "MainMonitor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(128, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monitor Information";
            // 
            // lblMonitorResolution
            // 
            this.lblMonitorResolution.AutoSize = true;
            this.lblMonitorResolution.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitorResolution.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMonitorResolution.Location = new System.Drawing.Point(12, 67);
            this.lblMonitorResolution.Name = "lblMonitorResolution";
            this.lblMonitorResolution.Size = new System.Drawing.Size(91, 16);
            this.lblMonitorResolution.TabIndex = 22;
            this.lblMonitorResolution.Text = "Resolution:";
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.Transparent;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(870, 675);
            this.Controls.Add(this.guna2Panel9);
            this.Controls.Add(this.guna2Panel8);
            this.Controls.Add(this.guna2Panel7);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(870, 675);
            this.MinimumSize = new System.Drawing.Size(870, 675);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "System Information";
            this.Load += new System.EventHandler(this.form1_load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblSecureBoot;
        private System.Windows.Forms.Label lblWindowsVersion;
        private System.Windows.Forms.Label lblRealTimeProtection;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label lblTpmStatus;
        private System.Windows.Forms.Label lblProcessorVirtualization;
        private System.Windows.Forms.Label lblSocketProcessor;
        private System.Windows.Forms.Label lblProcessorSerialNumber;
        private System.Windows.Forms.Label lblProcessorVersion;
        private System.Windows.Forms.Label lblProcessorManufacturer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lblProcessorPartNumber;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.Label lblProcessorInformation;
        private System.Windows.Forms.Label lblSystemSerial;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblManufacturer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBiosReleaseDate;
        private System.Windows.Forms.Label lblBiosVendor;
        private System.Windows.Forms.Label lblBiosVersion;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label lblDiskInformation;
        private System.Windows.Forms.Label lblDiskModel;
        private System.Windows.Forms.Label lblDiskSerial;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBaseboardLocation;
        private System.Windows.Forms.Label lblBaseboardManufacturer;
        private System.Windows.Forms.Label lblBaseboardSerialNumber;
        private System.Windows.Forms.Label lblBaseboardProductName;
        private System.Windows.Forms.Label lblBaseboardVersion;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDiskStorageModel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMacCache5;
        private System.Windows.Forms.Label lblMacCache6;
        private System.Windows.Forms.Label lblMacCache1;
        private System.Windows.Forms.Label lblMacCache4;
        private System.Windows.Forms.Label lblMacCache2;
        private System.Windows.Forms.Label lblMacCache3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private System.Windows.Forms.Label lblMonitorActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMonitorResolution;
        private System.Windows.Forms.Label lblCustomOS;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}
