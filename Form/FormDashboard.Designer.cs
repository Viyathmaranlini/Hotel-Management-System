
namespace hotel_management
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancellation = new System.Windows.Forms.Button();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hotelDataSet1 = new hotel_management.HotelDataSet();
            this.userControlCancellation1 = new hotel_management.User_Control.UserControlCancellation();
            this.userControlAboutus1 = new hotel_management.User_Control.UserControlAboutus();
            this.userControlRoom1 = new hotel_management.User_Control.UserControlRoom();
            this.userControlClient1 = new hotel_management.User_Control.UserControlClient();
            this.userControlSetting3 = new hotel_management.User_Control.UserControlSetting();
            this.userControlSetting1 = new hotel_management.User_Control.UserControlSetting();
            this.userControlSetting2 = new hotel_management.User_Control.UserControlSetting();
            this.userControlDashbord1 = new hotel_management.User_Control.UserControlDashbord();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(71)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.buttonCancellation);
            this.panel1.Controls.Add(this.buttonAboutUs);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.buttonSetting);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonCancellation
            // 
            this.buttonCancellation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancellation.FlatAppearance.BorderSize = 0;
            this.buttonCancellation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancellation.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancellation.ForeColor = System.Drawing.Color.White;
            this.buttonCancellation.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancellation.Image")));
            this.buttonCancellation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancellation.Location = new System.Drawing.Point(20, 424);
            this.buttonCancellation.Name = "buttonCancellation";
            this.buttonCancellation.Size = new System.Drawing.Size(276, 54);
            this.buttonCancellation.TabIndex = 8;
            this.buttonCancellation.Text = "          Cancellation";
            this.buttonCancellation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancellation.UseVisualStyleBackColor = true;
            this.buttonCancellation.Click += new System.EventHandler(this.buttonCancellation_Click);
            // 
            // buttonAboutUs
            // 
            this.buttonAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAboutUs.FlatAppearance.BorderSize = 0;
            this.buttonAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutUs.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAboutUs.ForeColor = System.Drawing.Color.White;
            this.buttonAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("buttonAboutUs.Image")));
            this.buttonAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutUs.Location = new System.Drawing.Point(20, 604);
            this.buttonAboutUs.Name = "buttonAboutUs";
            this.buttonAboutUs.Size = new System.Drawing.Size(276, 54);
            this.buttonAboutUs.TabIndex = 7;
            this.buttonAboutUs.Text = "          About us \n";
            this.buttonAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAboutUs.UseVisualStyleBackColor = true;
            this.buttonAboutUs.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(20, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "         Customer feed back\n";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 245);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(14, 53);
            this.panelSlide.TabIndex = 0;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(305, 244);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1058, 422);
            this.panel6.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSetting.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetting.Image")));
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(20, 484);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(276, 54);
            this.buttonSetting.TabIndex = 5;
            this.buttonSetting.Text = "          Setting";
            this.buttonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom.ForeColor = System.Drawing.Color.White;
            this.buttonRoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoom.Image")));
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(20, 364);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(285, 54);
            this.buttonRoom.TabIndex = 3;
            this.buttonRoom.Text = "          Room";
            this.buttonRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Image = ((System.Drawing.Image)(resources.GetObject("buttonClient.Image")));
            this.buttonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.Location = new System.Drawing.Point(20, 304);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(285, 54);
            this.buttonClient.TabIndex = 2;
            this.buttonClient.Text = "          Client";
            this.buttonClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(20, 244);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(285, 54);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "          Dashboard";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(71)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 239);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "HOTEL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUXURY GRAND";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hotel_management.Properties.Resources.house_chimney;
            this.pictureBox2.Location = new System.Drawing.Point(95, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(71)))), ((int)(((byte)(56)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.labelUsername);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelDateTime);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(305, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 239);
            this.panel3.TabIndex = 0;
            this.panel3.UseWaitCursor = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(144, 148);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(25, 28);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "?";
            this.labelUsername.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome:";
            this.label3.UseWaitCursor = true;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDateTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.White;
            this.labelDateTime.Location = new System.Drawing.Point(6, 72);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(21, 23);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "?";
            this.labelDateTime.UseWaitCursor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(71)))), ((int)(((byte)(56)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.linkLabelLogOut);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1061, 56);
            this.panel4.TabIndex = 0;
            this.panel4.UseWaitCursor = true;
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.linkLabelLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.linkLabelLogOut.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.linkLabelLogOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.linkLabelLogOut.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.linkLabelLogOut.Location = new System.Drawing.Point(964, 22);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(71, 19);
            this.linkLabelLogOut.TabIndex = 0;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "Log Out";
            this.linkLabelLogOut.UseWaitCursor = true;
            this.linkLabelLogOut.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(902, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userControlCancellation1
            // 
            this.userControlCancellation1.BackColor = System.Drawing.Color.White;
            this.userControlCancellation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCancellation1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlCancellation1.Location = new System.Drawing.Point(305, 239);
            this.userControlCancellation1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlCancellation1.Name = "userControlCancellation1";
            this.userControlCancellation1.Size = new System.Drawing.Size(1061, 481);
            this.userControlCancellation1.TabIndex = 0;
            this.userControlCancellation1.Visible = false;
            // 
            // userControlAboutus1
            // 
            this.userControlAboutus1.BackColor = System.Drawing.Color.White;
            this.userControlAboutus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAboutus1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAboutus1.Location = new System.Drawing.Point(305, 239);
            this.userControlAboutus1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAboutus1.Name = "userControlAboutus1";
            this.userControlAboutus1.Size = new System.Drawing.Size(1061, 481);
            this.userControlAboutus1.TabIndex = 0;
            this.userControlAboutus1.Visible = false;
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.BackColor = System.Drawing.Color.White;
            this.userControlRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRoom1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlRoom1.Location = new System.Drawing.Point(305, 239);
            this.userControlRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1061, 481);
            this.userControlRoom1.TabIndex = 0;
            this.userControlRoom1.Visible = false;
            // 
            // userControlClient1
            // 
            this.userControlClient1.BackColor = System.Drawing.Color.White;
            this.userControlClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClient1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlClient1.Location = new System.Drawing.Point(305, 239);
            this.userControlClient1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1061, 481);
            this.userControlClient1.TabIndex = 0;
            this.userControlClient1.Visible = false;
            // 
            // userControlSetting3
            // 
            this.userControlSetting3.BackColor = System.Drawing.Color.White;
            this.userControlSetting3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSetting3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlSetting3.Location = new System.Drawing.Point(305, 239);
            this.userControlSetting3.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetting3.Name = "userControlSetting3";
            this.userControlSetting3.Size = new System.Drawing.Size(1061, 481);
            this.userControlSetting3.TabIndex = 1;
            this.userControlSetting3.Visible = false;
            // 
            // userControlSetting1
            // 
            this.userControlSetting1.BackColor = System.Drawing.Color.White;
            this.userControlSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSetting1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlSetting1.Location = new System.Drawing.Point(305, 239);
            this.userControlSetting1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetting1.Name = "userControlSetting1";
            this.userControlSetting1.Size = new System.Drawing.Size(1061, 481);
            this.userControlSetting1.TabIndex = 1;
            this.userControlSetting1.Visible = false;
            // 
            // userControlSetting2
            // 
            this.userControlSetting2.BackColor = System.Drawing.Color.White;
            this.userControlSetting2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlSetting2.Location = new System.Drawing.Point(305, 244);
            this.userControlSetting2.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetting2.Name = "userControlSetting2";
            this.userControlSetting2.Size = new System.Drawing.Size(1102, 462);
            this.userControlSetting2.TabIndex = 1;
            this.userControlSetting2.Load += new System.EventHandler(this.userControlSetting2_Load);
            // 
            // userControlDashbord1
            // 
            this.userControlDashbord1.BackColor = System.Drawing.Color.White;
            this.userControlDashbord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashbord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDashbord1.Location = new System.Drawing.Point(305, 239);
            this.userControlDashbord1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlDashbord1.Name = "userControlDashbord1";
            this.userControlDashbord1.Size = new System.Drawing.Size(1061, 481);
            this.userControlDashbord1.TabIndex = 0;
            this.userControlDashbord1.Visible = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.userControlDashbord1);
            this.Controls.Add(this.userControlCancellation1);
            this.Controls.Add(this.userControlAboutus1);
            this.Controls.Add(this.userControlRoom1);
            this.Controls.Add(this.userControlClient1);
            this.Controls.Add(this.userControlSetting3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabelLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private HotelDataSet hotelDataSet1;
        private User_Control.UserControlSetting userControlSetting1;
        private User_Control.UserControlSetting userControlSetting2;
        private User_Control.UserControlSetting userControlSetting3;
        private User_Control.UserControlClient userControlClient1;
        private User_Control.UserControlRoom userControlRoom1;
        private System.Windows.Forms.Button buttonAboutUs;
        private System.Windows.Forms.Button button1;
        private User_Control.UserControlAboutus userControlAboutus1;
        private User_Control.UserControlCancellation userControlCancellation1;
        private System.Windows.Forms.Button buttonCancellation;
        private User_Control.UserControlDashbord userControlDashbord1;
    }
}