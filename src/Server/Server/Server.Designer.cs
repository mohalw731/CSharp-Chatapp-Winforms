namespace Server
{
    partial class Server
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.portLabel = new System.Windows.Forms.Label();
            this.localaddrLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.totalLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.addrTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.sendTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.usernameTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.keyTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.portTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.startButton = new Siticone.UI.WinForms.SiticoneButton();
            this.clearButton = new Siticone.UI.WinForms.SiticoneButton();
            this.disconnectButton = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.Color.Transparent;
            this.portLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.portLabel.ForeColor = System.Drawing.Color.White;
            this.portLabel.Location = new System.Drawing.Point(387, 66);
            this.portLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(32, 15);
            this.portLabel.TabIndex = 22;
            this.portLabel.Text = "Port:";
            // 
            // localaddrLabel
            // 
            this.localaddrLabel.AutoSize = true;
            this.localaddrLabel.BackColor = System.Drawing.Color.Transparent;
            this.localaddrLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.localaddrLabel.ForeColor = System.Drawing.Color.White;
            this.localaddrLabel.Location = new System.Drawing.Point(184, 67);
            this.localaddrLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.localaddrLabel.Name = "localaddrLabel";
            this.localaddrLabel.Size = new System.Drawing.Size(52, 15);
            this.localaddrLabel.TabIndex = 21;
            this.localaddrLabel.Text = "Address:";
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.ForeColor = System.Drawing.Color.White;
            this.logTextBox.Location = new System.Drawing.Point(7, 7);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(555, 348);
            this.logTextBox.TabIndex = 24;
            this.logTextBox.TabStop = false;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.Transparent;
            this.logLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.ForeColor = System.Drawing.Color.White;
            this.logLabel.Location = new System.Drawing.Point(17, 189);
            this.logLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(60, 15);
            this.logLabel.TabIndex = 29;
            this.logLabel.Text = "Chat Logs";
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.AllowUserToDeleteRows = false;
            this.clientsDataGridView.AllowUserToResizeColumns = false;
            this.clientsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.clientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.clientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.clientsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientsDataGridView.ColumnHeadersHeight = 24;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifier,
            this.name,
            this.dc});
            this.clientsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clientsDataGridView.EnableHeadersVisualStyles = false;
            this.clientsDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.clientsDataGridView.Location = new System.Drawing.Point(2, 2);
            this.clientsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.clientsDataGridView.MultiSelect = false;
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            this.clientsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.clientsDataGridView.RowHeadersVisible = false;
            this.clientsDataGridView.RowHeadersWidth = 40;
            this.clientsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.clientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.RowTemplate.ReadOnly = true;
            this.clientsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGridView.ShowCellErrors = false;
            this.clientsDataGridView.ShowCellToolTips = false;
            this.clientsDataGridView.ShowEditingIcon = false;
            this.clientsDataGridView.ShowRowErrors = false;
            this.clientsDataGridView.Size = new System.Drawing.Size(309, 484);
            this.clientsDataGridView.TabIndex = 30;
            this.clientsDataGridView.TabStop = false;
            this.clientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsDataGridView_CellClick);
            // 
            // identifier
            // 
            this.identifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.identifier.DefaultCellStyle = dataGridViewCellStyle3;
            this.identifier.HeaderText = "ID";
            this.identifier.MaxInputLength = 20;
            this.identifier.MinimumWidth = 20;
            this.identifier.Name = "identifier";
            this.identifier.ReadOnly = true;
            this.identifier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.identifier.Width = 70;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle4;
            this.name.HeaderText = "Name";
            this.name.MaxInputLength = 20;
            this.name.MinimumWidth = 20;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dc
            // 
            this.dc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dc.HeaderText = "Disconnect";
            this.dc.MinimumWidth = 20;
            this.dc.Name = "dc";
            this.dc.ReadOnly = true;
            this.dc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dc.Text = "Kick";
            this.dc.UseColumnTextForButtonValue = true;
            this.dc.Width = 80;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.Location = new System.Drawing.Point(-3, 494);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(90, 13);
            this.totalLabel.TabIndex = 31;
            this.totalLabel.Text = "Total clients: 0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(180, 104);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(56, 15);
            this.usernameLabel.TabIndex = 33;
            this.usernameLabel.Text = "Userame:";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.BackColor = System.Drawing.Color.Transparent;
            this.keyLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyLabel.ForeColor = System.Drawing.Color.White;
            this.keyLabel.Location = new System.Drawing.Point(390, 104);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(29, 15);
            this.keyLabel.TabIndex = 35;
            this.keyLabel.Text = "Key:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(279, 496);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 38;
            this.versionLabel.Text = "v1.5";
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox.ForeColor = System.Drawing.Color.White;
            this.checkBox.Location = new System.Drawing.Point(426, 136);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(72, 20);
            this.checkBox.TabIndex = 42;
            this.checkBox.Text = "Hide key";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.versionLabel);
            this.siticonePanel1.Controls.Add(this.clientsDataGridView);
            this.siticonePanel1.Controls.Add(this.totalLabel);
            this.siticonePanel1.Location = new System.Drawing.Point(612, 51);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(313, 521);
            this.siticonePanel1.TabIndex = 44;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticonePanel2.BorderRadius = 8;
            this.siticonePanel2.BorderThickness = 2;
            this.siticonePanel2.Controls.Add(this.logTextBox);
            this.siticonePanel2.Location = new System.Drawing.Point(20, 209);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(570, 363);
            this.siticonePanel2.TabIndex = 45;
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
            this.addrTextBox.Location = new System.Drawing.Point(243, 66);
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.PasswordChar = '\0';
            this.addrTextBox.PlaceholderText = "";
            this.addrTextBox.SelectedText = "";
            this.addrTextBox.ShadowDecoration.Parent = this.addrTextBox;
            this.addrTextBox.Size = new System.Drawing.Size(133, 25);
            this.addrTextBox.TabIndex = 46;
            // 
            // sendTextBox
            // 
            this.sendTextBox.BackColor = System.Drawing.Color.Transparent;
            this.sendTextBox.BorderColor = System.Drawing.Color.MediumPurple;
            this.sendTextBox.BorderRadius = 8;
            this.sendTextBox.BorderThickness = 0;
            this.sendTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sendTextBox.DefaultText = "";
            this.sendTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sendTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sendTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sendTextBox.DisabledState.Parent = this.sendTextBox;
            this.sendTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sendTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sendTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sendTextBox.FocusedState.Parent = this.sendTextBox;
            this.sendTextBox.ForeColor = System.Drawing.Color.White;
            this.sendTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sendTextBox.HoveredState.Parent = this.sendTextBox;
            this.sendTextBox.Location = new System.Drawing.Point(596, 38);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.PasswordChar = '\0';
            this.sendTextBox.PlaceholderText = "";
            this.sendTextBox.SelectedText = "";
            this.sendTextBox.ShadowDecoration.Parent = this.sendTextBox;
            this.sendTextBox.Size = new System.Drawing.Size(10, 36);
            this.sendTextBox.TabIndex = 43;
            this.sendTextBox.TextChanged += new System.EventHandler(this.sendTextBox_TextChanged);
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
            this.usernameTextBox.Location = new System.Drawing.Point(243, 104);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(133, 25);
            this.usernameTextBox.TabIndex = 47;
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
            this.keyTextBox.Location = new System.Drawing.Point(426, 104);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.PasswordChar = '\0';
            this.keyTextBox.PlaceholderText = "";
            this.keyTextBox.SelectedText = "";
            this.keyTextBox.ShadowDecoration.Parent = this.keyTextBox;
            this.keyTextBox.Size = new System.Drawing.Size(133, 25);
            this.keyTextBox.TabIndex = 48;
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
            this.portTextBox.Location = new System.Drawing.Point(426, 67);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.PasswordChar = '\0';
            this.portTextBox.PlaceholderText = "";
            this.portTextBox.SelectedText = "";
            this.portTextBox.ShadowDecoration.Parent = this.portTextBox;
            this.portTextBox.Size = new System.Drawing.Size(133, 25);
            this.portTextBox.TabIndex = 49;
            // 
            // startButton
            // 
            this.startButton.BorderRadius = 8;
            this.startButton.CheckedState.Parent = this.startButton;
            this.startButton.CustomImages.Parent = this.startButton;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.HoveredState.Parent = this.startButton;
            this.startButton.Location = new System.Drawing.Point(12, 51);
            this.startButton.Name = "startButton";
            this.startButton.ShadowDecoration.Parent = this.startButton;
            this.startButton.Size = new System.Drawing.Size(136, 31);
            this.startButton.TabIndex = 50;
            this.startButton.Text = "Start Server";
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.BorderRadius = 8;
            this.clearButton.CheckedState.Parent = this.clearButton;
            this.clearButton.CustomImages.Parent = this.clearButton;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.HoveredState.Parent = this.clearButton;
            this.clearButton.Location = new System.Drawing.Point(12, 99);
            this.clearButton.Name = "clearButton";
            this.clearButton.ShadowDecoration.Parent = this.clearButton;
            this.clearButton.Size = new System.Drawing.Size(136, 31);
            this.clearButton.TabIndex = 51;
            this.clearButton.Text = "Clear Logs";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.BorderRadius = 8;
            this.disconnectButton.CheckedState.Parent = this.disconnectButton;
            this.disconnectButton.CustomImages.Parent = this.disconnectButton;
            this.disconnectButton.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.disconnectButton.ForeColor = System.Drawing.Color.White;
            this.disconnectButton.HoveredState.Parent = this.disconnectButton;
            this.disconnectButton.Location = new System.Drawing.Point(12, 145);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.ShadowDecoration.Parent = this.disconnectButton;
            this.disconnectButton.Size = new System.Drawing.Size(136, 31);
            this.disconnectButton.TabIndex = 52;
            this.disconnectButton.Text = "Disconnect all ";
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.siticoneControlBox2);
            this.panel1.Controls.Add(this.siticoneControlBox1);
            this.panel1.Location = new System.Drawing.Point(-9, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 39);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Void Chat Control panel";
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(850, 11);
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
            this.siticoneControlBox1.Location = new System.Drawing.Point(893, 11);
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
            // Server
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(940, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.addrTextBox);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.localaddrLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Void Chat Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label localaddrLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn dc;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.CheckBox checkBox;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneTextBox addrTextBox;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticoneTextBox sendTextBox;
        private Siticone.UI.WinForms.SiticoneTextBox portTextBox;
        private Siticone.UI.WinForms.SiticoneTextBox keyTextBox;
        private Siticone.UI.WinForms.SiticoneTextBox usernameTextBox;
        private Siticone.UI.WinForms.SiticoneButton startButton;
        private Siticone.UI.WinForms.SiticoneButton clearButton;
        private Siticone.UI.WinForms.SiticoneButton disconnectButton;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private System.Windows.Forms.Label label1;
    }
}

