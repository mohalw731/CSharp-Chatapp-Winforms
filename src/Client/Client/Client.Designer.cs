namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.logLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.sendTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.portTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.keyTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.usernameTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.addrTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.localaddrLabel = new System.Windows.Forms.Label();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.connectButton = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticonePanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(284, 135);
            this.logLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(25, 13);
            this.logLabel.TabIndex = 31;
            this.logLabel.Text = "Log";
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.ForeColor = System.Drawing.Color.White;
            this.logTextBox.Location = new System.Drawing.Point(14, 11);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(819, 376);
            this.logTextBox.TabIndex = 30;
            this.logTextBox.TabStop = false;
            // 
            // sendTextBox
            // 
            this.sendTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.sendTextBox.BorderRadius = 10;
            this.sendTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sendTextBox.DefaultText = "";
            this.sendTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sendTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sendTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sendTextBox.DisabledState.Parent = this.sendTextBox;
            this.sendTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sendTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sendTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sendTextBox.FocusedState.Parent = this.sendTextBox;
            this.sendTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sendTextBox.HoveredState.Parent = this.sendTextBox;
            this.sendTextBox.Location = new System.Drawing.Point(17, 533);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.PasswordChar = '\0';
            this.sendTextBox.PlaceholderText = "Send message in Void Chat";
            this.sendTextBox.SelectedText = "";
            this.sendTextBox.ShadowDecoration.Parent = this.sendTextBox;
            this.sendTextBox.Size = new System.Drawing.Size(707, 39);
            this.sendTextBox.TabIndex = 49;
            // 
            // clearButton
            // 
            this.clearButton.Animated = true;
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BorderColor = System.Drawing.Color.DarkRed;
            this.clearButton.BorderRadius = 7;
            this.clearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageSize = new System.Drawing.Size(19, 19);
            this.clearButton.Location = new System.Drawing.Point(823, 533);
            this.clearButton.Name = "clearButton";
            this.clearButton.PressedColor = System.Drawing.Color.White;
            this.clearButton.Size = new System.Drawing.Size(43, 39);
            this.clearButton.TabIndex = 64;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticonePanel2.BorderRadius = 8;
            this.siticonePanel2.BorderThickness = 2;
            this.siticonePanel2.Controls.Add(this.logTextBox);
            this.siticonePanel2.Location = new System.Drawing.Point(17, 124);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(849, 403);
            this.siticonePanel2.TabIndex = 65;
            // 
            // portTextBox
            // 
            this.portTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.portTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.portTextBox.DefaultText = "9000";
            this.portTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.portTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.portTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.portTextBox.DisabledState.Parent = this.portTextBox;
            this.portTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.portTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.portTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.portTextBox.FocusedState.Parent = this.portTextBox;
            this.portTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.portTextBox.HoveredState.Parent = this.portTextBox;
            this.portTextBox.Location = new System.Drawing.Point(255, 49);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.PasswordChar = '\0';
            this.portTextBox.PlaceholderText = "";
            this.portTextBox.SelectedText = "";
            this.portTextBox.ShadowDecoration.Parent = this.portTextBox;
            this.portTextBox.Size = new System.Drawing.Size(133, 25);
            this.portTextBox.TabIndex = 73;
            // 
            // keyTextBox
            // 
            this.keyTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.keyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyTextBox.DefaultText = "";
            this.keyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyTextBox.DisabledState.Parent = this.keyTextBox;
            this.keyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.keyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keyTextBox.FocusedState.Parent = this.keyTextBox;
            this.keyTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keyTextBox.HoveredState.Parent = this.keyTextBox;
            this.keyTextBox.Location = new System.Drawing.Point(255, 86);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.PasswordChar = '\0';
            this.keyTextBox.PlaceholderText = "";
            this.keyTextBox.SelectedText = "";
            this.keyTextBox.ShadowDecoration.Parent = this.keyTextBox;
            this.keyTextBox.Size = new System.Drawing.Size(133, 25);
            this.keyTextBox.TabIndex = 72;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "Sever";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.Parent = this.usernameTextBox;
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.FocusedState.Parent = this.usernameTextBox;
            this.usernameTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.HoveredState.Parent = this.usernameTextBox;
            this.usernameTextBox.Location = new System.Drawing.Point(72, 86);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(133, 25);
            this.usernameTextBox.TabIndex = 71;
            // 
            // addrTextBox
            // 
            this.addrTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.addrTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addrTextBox.DefaultText = "127.0.0.1";
            this.addrTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addrTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addrTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addrTextBox.DisabledState.Parent = this.addrTextBox;
            this.addrTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addrTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.addrTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addrTextBox.FocusedState.Parent = this.addrTextBox;
            this.addrTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addrTextBox.HoveredState.Parent = this.addrTextBox;
            this.addrTextBox.Location = new System.Drawing.Point(72, 48);
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.PasswordChar = '\0';
            this.addrTextBox.PlaceholderText = "";
            this.addrTextBox.SelectedText = "";
            this.addrTextBox.ShadowDecoration.Parent = this.addrTextBox;
            this.addrTextBox.Size = new System.Drawing.Size(133, 25);
            this.addrTextBox.TabIndex = 70;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.BackColor = System.Drawing.Color.Transparent;
            this.keyLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyLabel.ForeColor = System.Drawing.Color.White;
            this.keyLabel.Location = new System.Drawing.Point(219, 86);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(29, 15);
            this.keyLabel.TabIndex = 69;
            this.keyLabel.Text = "Key:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(9, 86);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(56, 15);
            this.usernameLabel.TabIndex = 68;
            this.usernameLabel.Text = "Userame:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.Color.Transparent;
            this.portLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.portLabel.ForeColor = System.Drawing.Color.White;
            this.portLabel.Location = new System.Drawing.Point(216, 48);
            this.portLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(32, 15);
            this.portLabel.TabIndex = 67;
            this.portLabel.Text = "Port:";
            // 
            // localaddrLabel
            // 
            this.localaddrLabel.AutoSize = true;
            this.localaddrLabel.BackColor = System.Drawing.Color.Transparent;
            this.localaddrLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.localaddrLabel.ForeColor = System.Drawing.Color.White;
            this.localaddrLabel.Location = new System.Drawing.Point(13, 49);
            this.localaddrLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.localaddrLabel.Name = "localaddrLabel";
            this.localaddrLabel.Size = new System.Drawing.Size(52, 15);
            this.localaddrLabel.TabIndex = 66;
            this.localaddrLabel.Text = "Address:";
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this;
            // 
            // connectButton
            // 
            this.connectButton.BorderRadius = 8;
            this.connectButton.CheckedState.Parent = this.connectButton;
            this.connectButton.CustomImages.Parent = this.connectButton;
            this.connectButton.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.HoveredState.Parent = this.connectButton;
            this.connectButton.Location = new System.Drawing.Point(730, 42);
            this.connectButton.Name = "connectButton";
            this.connectButton.ShadowDecoration.Parent = this.connectButton;
            this.connectButton.Size = new System.Drawing.Size(136, 31);
            this.connectButton.TabIndex = 74;
            this.connectButton.Text = "Connect ";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click_1);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 8;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(730, 79);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(136, 31);
            this.siticoneButton1.TabIndex = 75;
            this.siticoneButton1.Text = "Control Panel";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.siticoneControlBox2);
            this.panel1.Controls.Add(this.siticoneControlBox1);
            this.panel1.Location = new System.Drawing.Point(-21, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 39);
            this.panel1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Void Chat ";
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(801, 11);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(54, 25);
            this.siticoneControlBox2.TabIndex = 55;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(844, 11);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(54, 25);
            this.siticoneControlBox1.TabIndex = 54;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.panel1;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticoneButton2.BorderRadius = 8;
            this.siticoneButton2.BorderThickness = 1;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(730, 533);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(87, 39);
            this.siticoneButton2.TabIndex = 77;
            this.siticoneButton2.Text = "Send";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // Client
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(878, 591);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.addrTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.localaddrLabel);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.logLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Client";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private Siticone.UI.WinForms.SiticoneTextBox sendTextBox;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.UI.WinForms.SiticoneTextBox portTextBox;
        private Siticone.UI.WinForms.SiticoneTextBox keyTextBox;
        private Siticone.UI.WinForms.SiticoneTextBox usernameTextBox;
        private Siticone.UI.WinForms.SiticoneTextBox addrTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label localaddrLabel;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneButton connectButton;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
    }
}

