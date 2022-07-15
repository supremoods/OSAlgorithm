
namespace OSAlgorithms
{
    partial class lruAlgo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lruAlgo));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.no_Of_frames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getRefString = new Guna.UI2.WinForms.Guna2TextBox();
            this.getStringSize = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReferenceString = new System.Windows.Forms.Label();
            this.frameValidation = new System.Windows.Forms.Label();
            this.submit_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.data_tbl = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.setFaultRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.setHitRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.setFaults = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.setHit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Transition2 = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.getStringSize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tbl)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(143, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frame";
            // 
            // no_Of_frames
            // 
            this.no_Of_frames.AutoRoundedCorners = true;
            this.no_Of_frames.BackColor = System.Drawing.Color.Transparent;
            this.no_Of_frames.BorderColor = System.Drawing.Color.Transparent;
            this.no_Of_frames.BorderRadius = 12;
            this.guna2Transition2.SetDecoration(this.no_Of_frames, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.no_Of_frames, Guna.UI2.AnimatorNS.DecorationType.None);
            this.no_Of_frames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.no_Of_frames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.no_Of_frames.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.no_Of_frames.FocusedColor = System.Drawing.Color.Transparent;
            this.no_Of_frames.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.no_Of_frames.FocusedState.Parent = this.no_Of_frames;
            this.no_Of_frames.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.no_Of_frames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.no_Of_frames.HoverState.Parent = this.no_Of_frames;
            this.no_Of_frames.ItemHeight = 20;
            this.no_Of_frames.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.no_Of_frames.ItemsAppearance.Parent = this.no_Of_frames;
            this.no_Of_frames.Location = new System.Drawing.Point(225, 49);
            this.no_Of_frames.Name = "no_Of_frames";
            this.no_Of_frames.ShadowDecoration.Parent = this.no_Of_frames;
            this.no_Of_frames.Size = new System.Drawing.Size(140, 26);
            this.no_Of_frames.TabIndex = 10;
            this.no_Of_frames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.no_Of_frames_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(409, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size of String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number Reference String";
            // 
            // getRefString
            // 
            this.getRefString.AutoRoundedCorners = true;
            this.getRefString.BackColor = System.Drawing.Color.Transparent;
            this.getRefString.BorderRadius = 17;
            this.getRefString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.getRefString, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.getRefString, Guna.UI2.AnimatorNS.DecorationType.None);
            this.getRefString.DefaultText = "";
            this.getRefString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.getRefString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.getRefString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.getRefString.DisabledState.Parent = this.getRefString;
            this.getRefString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.getRefString.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.getRefString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.getRefString.FocusedState.Parent = this.getRefString;
            this.getRefString.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.getRefString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.getRefString.HoverState.Parent = this.getRefString;
            this.getRefString.Location = new System.Drawing.Point(311, 98);
            this.getRefString.Name = "getRefString";
            this.getRefString.PasswordChar = '\0';
            this.getRefString.PlaceholderText = "";
            this.getRefString.SelectedText = "";
            this.getRefString.ShadowDecoration.Parent = this.getRefString;
            this.getRefString.Size = new System.Drawing.Size(510, 36);
            this.getRefString.TabIndex = 8;
            this.getRefString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getRefString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getRefString_KeyPress);
            // 
            // getStringSize
            // 
            this.getStringSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getStringSize.AutoRoundedCorners = true;
            this.getStringSize.BackColor = System.Drawing.Color.Transparent;
            this.getStringSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.getStringSize.BorderRadius = 12;
            this.getStringSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.getStringSize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.getStringSize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.getStringSize.DisabledState.Parent = this.getStringSize;
            this.getStringSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.getStringSize.FocusedState.Parent = this.getStringSize;
            this.getStringSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.getStringSize.ForeColor = System.Drawing.Color.Black;
            this.getStringSize.Location = new System.Drawing.Point(547, 49);
            this.getStringSize.Name = "getStringSize";
            this.getStringSize.ShadowDecoration.Parent = this.getStringSize;
            this.getStringSize.Size = new System.Drawing.Size(162, 26);
            this.getStringSize.TabIndex = 7;
            this.getStringSize.UpDownButtonFillColor = System.Drawing.Color.DarkSlateBlue;
            this.getStringSize.UpDownButtonForeColor = System.Drawing.Color.White;
            this.getStringSize.UseTransparentBackground = true;
            this.getStringSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReferenceString);
            this.panel1.Controls.Add(this.frameValidation);
            this.panel1.Controls.Add(this.submit_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.no_Of_frames);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.getRefString);
            this.panel1.Controls.Add(this.getStringSize);
            this.guna2Transition2.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(259, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 227);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // ReferenceString
            // 
            this.ReferenceString.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.ReferenceString, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.ReferenceString, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ReferenceString.ForeColor = System.Drawing.Color.Crimson;
            this.ReferenceString.Location = new System.Drawing.Point(308, 137);
            this.ReferenceString.Name = "ReferenceString";
            this.ReferenceString.Size = new System.Drawing.Size(35, 13);
            this.ReferenceString.TabIndex = 17;
            this.ReferenceString.Text = "label8";
            this.ReferenceString.Visible = false;
            // 
            // frameValidation
            // 
            this.frameValidation.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.frameValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.frameValidation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.frameValidation.ForeColor = System.Drawing.Color.Crimson;
            this.frameValidation.Location = new System.Drawing.Point(222, 78);
            this.frameValidation.Name = "frameValidation";
            this.frameValidation.Size = new System.Drawing.Size(35, 13);
            this.frameValidation.TabIndex = 17;
            this.frameValidation.Text = "label8";
            this.frameValidation.Visible = false;
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
            this.submit_btn.Location = new System.Drawing.Point(337, 153);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.ShadowDecoration.Parent = this.submit_btn;
            this.submit_btn.Size = new System.Drawing.Size(180, 45);
            this.submit_btn.TabIndex = 9;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseTransparentBackground = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // data_tbl
            // 
            this.data_tbl.AllowUserToOrderColumns = true;
            this.data_tbl.AllowUserToResizeColumns = false;
            this.data_tbl.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.data_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_tbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_tbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.data_tbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_tbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_tbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_tbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_tbl.ColumnHeadersHeight = 21;
            this.guna2Transition2.SetDecoration(this.data_tbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.data_tbl, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_tbl.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_tbl.EnableHeadersVisualStyles = false;
            this.data_tbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.data_tbl.Location = new System.Drawing.Point(64, 332);
            this.data_tbl.Name = "data_tbl";
            this.data_tbl.RowHeadersVisible = false;
            this.data_tbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_tbl.Size = new System.Drawing.Size(884, 225);
            this.data_tbl.TabIndex = 14;
            this.data_tbl.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.data_tbl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.data_tbl.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_tbl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_tbl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_tbl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_tbl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.data_tbl.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.data_tbl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.data_tbl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_tbl.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_tbl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_tbl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data_tbl.ThemeStyle.HeaderStyle.Height = 21;
            this.data_tbl.ThemeStyle.ReadOnly = false;
            this.data_tbl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.data_tbl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_tbl.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_tbl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.data_tbl.ThemeStyle.RowsStyle.Height = 22;
            this.data_tbl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.data_tbl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.data_tbl.Visible = false;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(660, 618);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = global::OSAlgorithms.Properties.Resources.back_48px;
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.TabIndex = 16;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.setFaultRate);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.setHitRate);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.setFaults);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.setHit);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Transition2.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(956, 266);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(341, 357);
            this.guna2Panel1.TabIndex = 18;
            this.guna2Panel1.Visible = false;
            // 
            // setFaultRate
            // 
            this.setFaultRate.AutoRoundedCorners = true;
            this.setFaultRate.BackColor = System.Drawing.Color.Transparent;
            this.setFaultRate.BorderRadius = 11;
            this.setFaultRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.setFaultRate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.setFaultRate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.setFaultRate.DefaultText = "";
            this.setFaultRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.setFaultRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.setFaultRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setFaultRate.DisabledState.Parent = this.setFaultRate;
            this.setFaultRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setFaultRate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.setFaultRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setFaultRate.FocusedState.Parent = this.setFaultRate;
            this.setFaultRate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.setFaultRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.setFaultRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setFaultRate.HoverState.Parent = this.setFaultRate;
            this.setFaultRate.Location = new System.Drawing.Point(206, 283);
            this.setFaultRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setFaultRate.Name = "setFaultRate";
            this.setFaultRate.PasswordChar = '\0';
            this.setFaultRate.PlaceholderText = "";
            this.setFaultRate.SelectedText = "";
            this.setFaultRate.ShadowDecoration.Parent = this.setFaultRate;
            this.setFaultRate.Size = new System.Drawing.Size(110, 24);
            this.setFaultRate.TabIndex = 22;
            this.setFaultRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label5.Location = new System.Drawing.Point(56, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fault Rate";
            // 
            // setHitRate
            // 
            this.setHitRate.AutoRoundedCorners = true;
            this.setHitRate.BackColor = System.Drawing.Color.Transparent;
            this.setHitRate.BorderRadius = 11;
            this.setHitRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.setHitRate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.setHitRate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.setHitRate.DefaultText = "";
            this.setHitRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.setHitRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.setHitRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setHitRate.DisabledState.Parent = this.setHitRate;
            this.setHitRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setHitRate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.setHitRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setHitRate.FocusedState.Parent = this.setHitRate;
            this.setHitRate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.setHitRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.setHitRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setHitRate.HoverState.Parent = this.setHitRate;
            this.setHitRate.Location = new System.Drawing.Point(206, 241);
            this.setHitRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setHitRate.Name = "setHitRate";
            this.setHitRate.PasswordChar = '\0';
            this.setHitRate.PlaceholderText = "";
            this.setHitRate.SelectedText = "";
            this.setHitRate.ShadowDecoration.Parent = this.setHitRate;
            this.setHitRate.Size = new System.Drawing.Size(110, 24);
            this.setHitRate.TabIndex = 20;
            this.setHitRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label8.Location = new System.Drawing.Point(56, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Hit Rate";
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
            this.label7.Text = "LRU ALGORITHM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setFaults
            // 
            this.setFaults.AutoRoundedCorners = true;
            this.setFaults.BackColor = System.Drawing.Color.Transparent;
            this.setFaults.BorderRadius = 11;
            this.setFaults.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.setFaults, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.setFaults, Guna.UI2.AnimatorNS.DecorationType.None);
            this.setFaults.DefaultText = "";
            this.setFaults.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.setFaults.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.setFaults.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setFaults.DisabledState.Parent = this.setFaults;
            this.setFaults.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setFaults.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.setFaults.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setFaults.FocusedState.Parent = this.setFaults;
            this.setFaults.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.setFaults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.setFaults.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setFaults.HoverState.Parent = this.setFaults;
            this.setFaults.Location = new System.Drawing.Point(206, 196);
            this.setFaults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setFaults.Name = "setFaults";
            this.setFaults.PasswordChar = '\0';
            this.setFaults.PlaceholderText = "";
            this.setFaults.SelectedText = "";
            this.setFaults.ShadowDecoration.Parent = this.setFaults;
            this.setFaults.Size = new System.Drawing.Size(110, 24);
            this.setFaults.TabIndex = 17;
            this.setFaults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label6.Location = new System.Drawing.Point(56, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Number of Faults";
            // 
            // setHit
            // 
            this.setHit.AutoRoundedCorners = true;
            this.setHit.BackColor = System.Drawing.Color.Transparent;
            this.setHit.BorderRadius = 11;
            this.setHit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.setHit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.setHit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.setHit.DefaultText = "";
            this.setHit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.setHit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.setHit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setHit.DisabledState.Parent = this.setHit;
            this.setHit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.setHit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.setHit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setHit.FocusedState.Parent = this.setHit;
            this.setHit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.setHit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.setHit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.setHit.HoverState.Parent = this.setHit;
            this.setHit.Location = new System.Drawing.Point(206, 154);
            this.setHit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setHit.Name = "setHit";
            this.setHit.PasswordChar = '\0';
            this.setHit.PlaceholderText = "";
            this.setHit.SelectedText = "";
            this.setHit.ShadowDecoration.Parent = this.setHit;
            this.setHit.Size = new System.Drawing.Size(110, 24);
            this.setHit.TabIndex = 16;
            this.setHit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.label4.Location = new System.Drawing.Point(56, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Number of Hits";
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
            // lruAlgo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1359, 699);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_tbl);
            this.Controls.Add(this.guna2ImageButton1);
            this.guna2Transition2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lruAlgo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lruAlgo";
            this.Load += new System.EventHandler(this.lruAlgo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getStringSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tbl)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton submit_btn;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox no_Of_frames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox getRefString;
        private Guna.UI2.WinForms.Guna2NumericUpDown getStringSize;
        private Guna.UI2.WinForms.Guna2DataGridView data_tbl;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label ReferenceString;
        private System.Windows.Forms.Label frameValidation;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox setFaultRate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox setHitRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox setFaults;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox setHit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition2;
    }
}