
namespace OSAlgorithms
{
    partial class cscanAlgo
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cscanAlgo));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackValidation = new System.Windows.Forms.Label();
            this.directionValidation = new System.Windows.Forms.Label();
            this.headValidation = new System.Windows.Forms.Label();
            this.diskSizeValidation = new System.Windows.Forms.Label();
            this.getDiskSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.getflag = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gethead = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submit_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getTrackNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.getSizeTrackNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bunifuDataViz1 = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.setSequence = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.setTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Transition2 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getSizeTrackNumber)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackValidation);
            this.panel1.Controls.Add(this.directionValidation);
            this.panel1.Controls.Add(this.headValidation);
            this.panel1.Controls.Add(this.diskSizeValidation);
            this.panel1.Controls.Add(this.getDiskSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.getflag);
            this.panel1.Controls.Add(this.gethead);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.submit_btn);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.getTrackNumber);
            this.panel1.Controls.Add(this.getSizeTrackNumber);
            this.guna2Transition2.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(39, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 227);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // trackValidation
            // 
            this.trackValidation.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.trackValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.trackValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trackValidation.ForeColor = System.Drawing.Color.Crimson;
            this.trackValidation.Location = new System.Drawing.Point(342, 126);
            this.trackValidation.Name = "trackValidation";
            this.trackValidation.Size = new System.Drawing.Size(35, 13);
            this.trackValidation.TabIndex = 17;
            this.trackValidation.Text = "label8";
            this.trackValidation.Visible = false;
            // 
            // directionValidation
            // 
            this.directionValidation.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.directionValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.directionValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.directionValidation.ForeColor = System.Drawing.Color.Crimson;
            this.directionValidation.Location = new System.Drawing.Point(949, 126);
            this.directionValidation.Name = "directionValidation";
            this.directionValidation.Size = new System.Drawing.Size(35, 13);
            this.directionValidation.TabIndex = 17;
            this.directionValidation.Text = "label8";
            this.directionValidation.Visible = false;
            // 
            // headValidation
            // 
            this.headValidation.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.headValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.headValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.headValidation.ForeColor = System.Drawing.Color.Crimson;
            this.headValidation.Location = new System.Drawing.Point(1058, 63);
            this.headValidation.Name = "headValidation";
            this.headValidation.Size = new System.Drawing.Size(35, 13);
            this.headValidation.TabIndex = 17;
            this.headValidation.Text = "label8";
            this.headValidation.Visible = false;
            // 
            // diskSizeValidation
            // 
            this.diskSizeValidation.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.diskSizeValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.diskSizeValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.diskSizeValidation.ForeColor = System.Drawing.Color.Crimson;
            this.diskSizeValidation.Location = new System.Drawing.Point(215, 63);
            this.diskSizeValidation.Name = "diskSizeValidation";
            this.diskSizeValidation.Size = new System.Drawing.Size(35, 13);
            this.diskSizeValidation.TabIndex = 16;
            this.diskSizeValidation.Text = "label8";
            this.diskSizeValidation.Visible = false;
            // 
            // getDiskSize
            // 
            this.getDiskSize.AutoRoundedCorners = true;
            this.getDiskSize.BackColor = System.Drawing.Color.Transparent;
            this.getDiskSize.BorderRadius = 12;
            this.getDiskSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.getDiskSize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.getDiskSize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.getDiskSize.DefaultText = "";
            this.getDiskSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.getDiskSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.getDiskSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.getDiskSize.DisabledState.Parent = this.getDiskSize;
            this.getDiskSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.getDiskSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.getDiskSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.getDiskSize.FocusedState.Parent = this.getDiskSize;
            this.getDiskSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.getDiskSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.getDiskSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.getDiskSize.HoverState.Parent = this.getDiskSize;
            this.getDiskSize.Location = new System.Drawing.Point(218, 34);
            this.getDiskSize.Name = "getDiskSize";
            this.getDiskSize.PasswordChar = '\0';
            this.getDiskSize.PlaceholderText = "";
            this.getDiskSize.SelectedText = "";
            this.getDiskSize.ShadowDecoration.Parent = this.getDiskSize;
            this.getDiskSize.Size = new System.Drawing.Size(96, 26);
            this.getDiskSize.TabIndex = 15;
            this.getDiskSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getDiskSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getDiskSize_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label5.Location = new System.Drawing.Point(844, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Direction";
            // 
            // getflag
            // 
            this.getflag.AutoRoundedCorners = true;
            this.getflag.BackColor = System.Drawing.Color.Transparent;
            this.getflag.BorderColor = System.Drawing.Color.Transparent;
            this.getflag.BorderRadius = 12;
            this.guna2Transition2.SetDecoration(this.getflag, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.getflag, Guna.UI2.AnimatorNS.DecorationType.None);
            this.getflag.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.getflag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getflag.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.getflag.FocusedColor = System.Drawing.Color.Transparent;
            this.getflag.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.getflag.FocusedState.Parent = this.getflag;
            this.getflag.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.getflag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.getflag.HoverState.Parent = this.getflag;
            this.getflag.ItemHeight = 20;
            this.getflag.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.getflag.ItemsAppearance.Parent = this.getflag;
            this.getflag.Location = new System.Drawing.Point(952, 97);
            this.getflag.Name = "getflag";
            this.getflag.ShadowDecoration.Parent = this.getflag;
            this.getflag.Size = new System.Drawing.Size(162, 26);
            this.getflag.TabIndex = 14;
            // 
            // gethead
            // 
            this.gethead.AutoRoundedCorners = true;
            this.gethead.BackColor = System.Drawing.Color.Transparent;
            this.gethead.BorderRadius = 12;
            this.gethead.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.gethead, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.gethead, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gethead.DefaultText = "";
            this.gethead.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gethead.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gethead.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gethead.DisabledState.Parent = this.gethead;
            this.gethead.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gethead.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.gethead.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gethead.FocusedState.Parent = this.gethead;
            this.gethead.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gethead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.gethead.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gethead.HoverState.Parent = this.gethead;
            this.gethead.Location = new System.Drawing.Point(1061, 34);
            this.gethead.Name = "gethead";
            this.gethead.PasswordChar = '\0';
            this.gethead.PlaceholderText = "";
            this.gethead.SelectedText = "";
            this.gethead.ShadowDecoration.Parent = this.gethead;
            this.gethead.Size = new System.Drawing.Size(75, 26);
            this.gethead.TabIndex = 12;
            this.gethead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gethead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gethead_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label4.Location = new System.Drawing.Point(928, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Initial Head";
            // 
            // submit_btn
            // 
            this.submit_btn.AutoRoundedCorners = true;
            this.submit_btn.BackColor = System.Drawing.Color.Transparent;
            this.submit_btn.BorderRadius = 21;
            this.submit_btn.CheckedState.Parent = this.submit_btn;
            this.submit_btn.CustomImages.Parent = this.submit_btn;
            this.guna2Transition2.SetDecoration(this.submit_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.submit_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.submit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submit_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submit_btn.DisabledState.Parent = this.submit_btn;
            this.submit_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.submit_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.submit_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.submit_btn.ForeColor = System.Drawing.Color.White;
            this.submit_btn.HoverState.Parent = this.submit_btn;
            this.submit_btn.Image = global::OSAlgorithms.Properties.Resources._1;
            this.submit_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.submit_btn.Location = new System.Drawing.Point(551, 157);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.ShadowDecoration.Parent = this.submit_btn;
            this.submit_btn.Size = new System.Drawing.Size(180, 45);
            this.submit_btn.TabIndex = 9;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseTransparentBackground = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label.Location = new System.Drawing.Point(105, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 25);
            this.label.TabIndex = 2;
            this.label.Text = "Disk Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(432, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size of Track Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label3.Location = new System.Drawing.Point(158, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Track Number";
            // 
            // getTrackNumber
            // 
            this.getTrackNumber.AutoRoundedCorners = true;
            this.getTrackNumber.BackColor = System.Drawing.Color.Transparent;
            this.getTrackNumber.BorderRadius = 12;
            this.getTrackNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.getTrackNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.getTrackNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.getTrackNumber.DefaultText = "";
            this.getTrackNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.getTrackNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.getTrackNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.getTrackNumber.DisabledState.Parent = this.getTrackNumber;
            this.getTrackNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.getTrackNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.getTrackNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.getTrackNumber.FocusedState.Parent = this.getTrackNumber;
            this.getTrackNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.getTrackNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.getTrackNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.getTrackNumber.HoverState.Parent = this.getTrackNumber;
            this.getTrackNumber.Location = new System.Drawing.Point(345, 97);
            this.getTrackNumber.Name = "getTrackNumber";
            this.getTrackNumber.PasswordChar = '\0';
            this.getTrackNumber.PlaceholderText = "";
            this.getTrackNumber.SelectedText = "";
            this.getTrackNumber.ShadowDecoration.Parent = this.getTrackNumber;
            this.getTrackNumber.Size = new System.Drawing.Size(431, 26);
            this.getTrackNumber.TabIndex = 8;
            this.getTrackNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getTrackNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getTrackNumber_KeyPress);
            // 
            // getSizeTrackNumber
            // 
            this.getSizeTrackNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getSizeTrackNumber.AutoRoundedCorners = true;
            this.getSizeTrackNumber.BackColor = System.Drawing.Color.Transparent;
            this.getSizeTrackNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.getSizeTrackNumber.BorderRadius = 12;
            this.getSizeTrackNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.getSizeTrackNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.getSizeTrackNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.getSizeTrackNumber.DisabledState.Parent = this.getSizeTrackNumber;
            this.getSizeTrackNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.getSizeTrackNumber.FocusedState.Parent = this.getSizeTrackNumber;
            this.getSizeTrackNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.getSizeTrackNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.getSizeTrackNumber.Location = new System.Drawing.Point(673, 34);
            this.getSizeTrackNumber.Name = "getSizeTrackNumber";
            this.getSizeTrackNumber.ShadowDecoration.Parent = this.getSizeTrackNumber;
            this.getSizeTrackNumber.Size = new System.Drawing.Size(163, 26);
            this.getSizeTrackNumber.TabIndex = 7;
            this.getSizeTrackNumber.UpDownButtonFillColor = System.Drawing.Color.DarkSlateBlue;
            this.getSizeTrackNumber.UpDownButtonForeColor = System.Drawing.Color.White;
            this.getSizeTrackNumber.UseTransparentBackground = true;
            this.getSizeTrackNumber.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2Transition2.SetDecoration(this.guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ImageButton1.HoverState.Image = global::OSAlgorithms.Properties.Resources.back_48px;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::OSAlgorithms.Properties.Resources.back_48px;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(659, 638);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = global::OSAlgorithms.Properties.Resources.back_48px;
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.TabIndex = 14;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // bunifuDataViz1
            // 
            this.bunifuDataViz1.animationEnabled = true;
            this.bunifuDataViz1.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz1.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.AxisYFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisYGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition2.SetDecoration(this.bunifuDataViz1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.bunifuDataViz1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bunifuDataViz1.Location = new System.Drawing.Point(14, 13);
            this.bunifuDataViz1.Name = "bunifuDataViz1";
            this.bunifuDataViz1.Size = new System.Drawing.Size(839, 357);
            this.bunifuDataViz1.TabIndex = 15;
            this.bunifuDataViz1.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme2;
            this.bunifuDataViz1.Title = "";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.setSequence);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.setTotal);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Transition2.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(950, 256);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(360, 357);
            this.guna2Panel1.TabIndex = 16;
            this.guna2Panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label7.Location = new System.Drawing.Point(62, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 47);
            this.label7.TabIndex = 19;
            this.label7.Text = "C-SCAN DISK SCHEDULING ALGORITHM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setSequence
            // 
            this.setSequence.AutoRoundedCorners = true;
            this.setSequence.BackColor = System.Drawing.Color.Transparent;
            this.setSequence.BorderRadius = 11;
            this.setSequence.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.setSequence, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.setSequence, Guna.UI2.AnimatorNS.DecorationType.None);
            this.setSequence.DefaultText = "";
            this.setSequence.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.setSequence.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.setSequence.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setSequence.DisabledState.Parent = this.setSequence;
            this.setSequence.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setSequence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.setSequence.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setSequence.FocusedState.Parent = this.setSequence;
            this.setSequence.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.setSequence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.setSequence.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setSequence.HoverState.Parent = this.setSequence;
            this.setSequence.Location = new System.Drawing.Point(28, 264);
            this.setSequence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setSequence.Name = "setSequence";
            this.setSequence.PasswordChar = '\0';
            this.setSequence.PlaceholderText = "";
            this.setSequence.SelectedText = "";
            this.setSequence.ShadowDecoration.Parent = this.setSequence;
            this.setSequence.Size = new System.Drawing.Size(309, 24);
            this.setSequence.TabIndex = 17;
            this.setSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label6.Location = new System.Drawing.Point(25, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Seek Sequence";
            // 
            // setTotal
            // 
            this.setTotal.AutoRoundedCorners = true;
            this.setTotal.BackColor = System.Drawing.Color.Transparent;
            this.setTotal.BorderRadius = 11;
            this.setTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.setTotal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.setTotal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.setTotal.DefaultText = "";
            this.setTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.setTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.setTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setTotal.DisabledState.Parent = this.setTotal;
            this.setTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.setTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setTotal.FocusedState.Parent = this.setTotal;
            this.setTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.setTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.setTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setTotal.HoverState.Parent = this.setTotal;
            this.setTotal.Location = new System.Drawing.Point(175, 155);
            this.setTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setTotal.Name = "setTotal";
            this.setTotal.PasswordChar = '\0';
            this.setTotal.PlaceholderText = "";
            this.setTotal.SelectedText = "";
            this.setTotal.ShadowDecoration.Parent = this.setTotal;
            this.setTotal.Size = new System.Drawing.Size(110, 24);
            this.setTotal.TabIndex = 16;
            this.setTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(80, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Seek";
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.bunifuDataViz1);
            this.guna2Transition2.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Location = new System.Drawing.Point(54, 256);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(867, 381);
            this.guna2Panel2.TabIndex = 17;
            this.guna2Panel2.Visible = false;
            // 
            // guna2Transition2
            // 
            this.guna2Transition2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition2.DefaultAnimation = animation1;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // cscanAlgo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1359, 699);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.panel1);
            this.guna2Transition2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cscanAlgo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cscanAlgo";
            this.Load += new System.EventHandler(this.cscanAlgo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getSizeTrackNumber)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton submit_btn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox getTrackNumber;
        private Guna.UI2.WinForms.Guna2NumericUpDown getSizeTrackNumber;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox getflag;
        private Guna.UI2.WinForms.Guna2TextBox gethead;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox getDiskSize;
        private Bunifu.DataViz.WinForms.BunifuDataViz bunifuDataViz1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox setSequence;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox setTotal;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label trackValidation;
        private System.Windows.Forms.Label directionValidation;
        private System.Windows.Forms.Label headValidation;
        private System.Windows.Forms.Label diskSizeValidation;
    }
}