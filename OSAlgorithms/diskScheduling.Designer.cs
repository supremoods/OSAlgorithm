
namespace OSAlgorithms
{
    partial class diskScheduling
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diskScheduling));
            this.sstfbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cScanbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.diskExitbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cScan_line = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.sstf_line = new Guna.UI2.WinForms.Guna2Separator();
            this.cScan_txt = new System.Windows.Forms.Label();
            this.sstf_txt = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sstfbtn
            // 
            this.sstfbtn.BackColor = System.Drawing.Color.Transparent;
            this.sstfbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.sstfbtn.CheckedState.Parent = this.sstfbtn;
            this.guna2Transition1.SetDecoration(this.sstfbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sstfbtn.HoverState.Image = global::OSAlgorithms.Properties.Resources.sstf;
            this.sstfbtn.HoverState.ImageSize = new System.Drawing.Size(460, 460);
            this.sstfbtn.HoverState.Parent = this.sstfbtn;
            this.sstfbtn.Image = global::OSAlgorithms.Properties.Resources.sstf;
            this.sstfbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.sstfbtn.ImageRotate = 0F;
            this.sstfbtn.ImageSize = new System.Drawing.Size(450, 450);
            this.sstfbtn.Location = new System.Drawing.Point(491, 244);
            this.sstfbtn.Name = "sstfbtn";
            this.sstfbtn.PressedState.Image = global::OSAlgorithms.Properties.Resources.sstf;
            this.sstfbtn.PressedState.ImageSize = new System.Drawing.Size(460, 460);
            this.sstfbtn.PressedState.Parent = this.sstfbtn;
            this.sstfbtn.ShadowDecoration.Parent = this.sstfbtn;
            this.sstfbtn.Size = new System.Drawing.Size(391, 385);
            this.sstfbtn.TabIndex = 1;
            this.sstfbtn.UseTransparentBackground = true;
            this.sstfbtn.Click += new System.EventHandler(this.sstfbtn_Click);
            this.sstfbtn.MouseHover += new System.EventHandler(this.hoverSSTF);
            // 
            // cScanbtn
            // 
            this.cScanbtn.BackColor = System.Drawing.Color.Transparent;
            this.cScanbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.cScanbtn.CheckedState.Parent = this.cScanbtn;
            this.guna2Transition1.SetDecoration(this.cScanbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cScanbtn.HoverState.Image = global::OSAlgorithms.Properties.Resources.csscan;
            this.cScanbtn.HoverState.ImageSize = new System.Drawing.Size(460, 460);
            this.cScanbtn.HoverState.Parent = this.cScanbtn;
            this.cScanbtn.Image = global::OSAlgorithms.Properties.Resources.csscan;
            this.cScanbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cScanbtn.ImageRotate = 0F;
            this.cScanbtn.ImageSize = new System.Drawing.Size(450, 450);
            this.cScanbtn.Location = new System.Drawing.Point(670, 244);
            this.cScanbtn.Name = "cScanbtn";
            this.cScanbtn.PressedState.Image = global::OSAlgorithms.Properties.Resources.csscan;
            this.cScanbtn.PressedState.ImageSize = new System.Drawing.Size(460, 460);
            this.cScanbtn.PressedState.Parent = this.cScanbtn;
            this.cScanbtn.ShadowDecoration.Parent = this.cScanbtn;
            this.cScanbtn.Size = new System.Drawing.Size(391, 385);
            this.cScanbtn.TabIndex = 2;
            this.cScanbtn.UseTransparentBackground = true;
            this.cScanbtn.Click += new System.EventHandler(this.cScanbtn_Click);
            this.cScanbtn.MouseHover += new System.EventHandler(this.hoverCscan);
            // 
            // diskExitbtn
            // 
            this.diskExitbtn.BackColor = System.Drawing.Color.Transparent;
            this.diskExitbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.diskExitbtn.CheckedState.Parent = this.diskExitbtn;
            this.guna2Transition1.SetDecoration(this.diskExitbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.diskExitbtn.HoverState.Image = global::OSAlgorithms.Properties.Resources.diskExit;
            this.diskExitbtn.HoverState.ImageSize = new System.Drawing.Size(460, 460);
            this.diskExitbtn.HoverState.Parent = this.diskExitbtn;
            this.diskExitbtn.Image = global::OSAlgorithms.Properties.Resources.diskExit;
            this.diskExitbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.diskExitbtn.ImageRotate = 0F;
            this.diskExitbtn.ImageSize = new System.Drawing.Size(450, 450);
            this.diskExitbtn.IndicateFocus = true;
            this.diskExitbtn.Location = new System.Drawing.Point(588, 95);
            this.diskExitbtn.Name = "diskExitbtn";
            this.diskExitbtn.PressedState.Image = global::OSAlgorithms.Properties.Resources.diskExit;
            this.diskExitbtn.PressedState.ImageSize = new System.Drawing.Size(460, 460);
            this.diskExitbtn.PressedState.Parent = this.diskExitbtn;
            this.diskExitbtn.ShadowDecoration.Parent = this.diskExitbtn;
            this.diskExitbtn.Size = new System.Drawing.Size(391, 385);
            this.diskExitbtn.TabIndex = 3;
            this.diskExitbtn.UseTransparentBackground = true;
            this.diskExitbtn.Click += new System.EventHandler(this.diskExitbtn_Click);
            // 
            // cScan_line
            // 
            this.cScan_line.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.cScan_line, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cScan_line.FillColor = System.Drawing.Color.White;
            this.cScan_line.FillThickness = 4;
            this.cScan_line.Location = new System.Drawing.Point(985, 553);
            this.cScan_line.Name = "cScan_line";
            this.cScan_line.Size = new System.Drawing.Size(150, 11);
            this.cScan_line.TabIndex = 4;
            this.cScan_line.UseTransparentBackground = true;
            this.cScan_line.Visible = false;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // sstf_line
            // 
            this.sstf_line.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.sstf_line, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sstf_line.FillColor = System.Drawing.Color.White;
            this.sstf_line.FillThickness = 4;
            this.sstf_line.Location = new System.Drawing.Point(287, 463);
            this.sstf_line.Name = "sstf_line";
            this.sstf_line.Size = new System.Drawing.Size(200, 11);
            this.sstf_line.TabIndex = 5;
            this.sstf_line.UseTransparentBackground = true;
            this.sstf_line.Visible = false;
            // 
            // cScan_txt
            // 
            this.cScan_txt.AutoSize = true;
            this.cScan_txt.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.cScan_txt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cScan_txt.Font = new System.Drawing.Font("Azonix", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cScan_txt.ForeColor = System.Drawing.Color.White;
            this.cScan_txt.Location = new System.Drawing.Point(977, 529);
            this.cScan_txt.Name = "cScan_txt";
            this.cScan_txt.Size = new System.Drawing.Size(207, 21);
            this.cScan_txt.TabIndex = 15;
            this.cScan_txt.Text = "Circular scan";
            this.cScan_txt.Visible = false;
            // 
            // sstf_txt
            // 
            this.sstf_txt.AutoSize = true;
            this.sstf_txt.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.sstf_txt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sstf_txt.Font = new System.Drawing.Font("Azonix", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sstf_txt.ForeColor = System.Drawing.Color.White;
            this.sstf_txt.Location = new System.Drawing.Point(119, 439);
            this.sstf_txt.Name = "sstf_txt";
            this.sstf_txt.Size = new System.Drawing.Size(370, 21);
            this.sstf_txt.TabIndex = 16;
            this.sstf_txt.Text = "Shortest Seek Time First";
            this.sstf_txt.Visible = false;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.guna2Separator3.FillThickness = 10;
            this.guna2Separator3.Location = new System.Drawing.Point(48, 97);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(423, 67);
            this.guna2Separator3.TabIndex = 18;
            this.guna2Separator3.UseTransparentBackground = true;
            this.guna2Separator3.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Azonix", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 79);
            this.label3.TabIndex = 17;
            this.label3.Text = "disk scheduling algorithms";
            this.label3.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::OSAlgorithms.Properties.Resources.wallpaperflare_com_wallpaper;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1359, 699);
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click_1);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2Transition1.SetDecoration(this.guna2ImageButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ImageButton3.HoverState.Image = global::OSAlgorithms.Properties.Resources.exit_60px;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = global::OSAlgorithms.Properties.Resources.exit_60px;
            this.guna2ImageButton3.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(58, 58);
            this.guna2ImageButton3.Location = new System.Drawing.Point(754, 175);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.Image = global::OSAlgorithms.Properties.Resources.exit_60px;
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.ShadowDecoration.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton3.TabIndex = 20;
            this.guna2ImageButton3.UseTransparentBackground = true;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
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
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(107, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 100);
            this.panel1.TabIndex = 21;
            // 
            // diskScheduling
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OSAlgorithms.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(1359, 699);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.cScan_txt);
            this.Controls.Add(this.cScan_line);
            this.Controls.Add(this.sstf_line);
            this.Controls.Add(this.sstf_txt);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cScanbtn);
            this.Controls.Add(this.sstfbtn);
            this.Controls.Add(this.diskExitbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diskScheduling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "diskScheduling";
            this.Load += new System.EventHandler(this.diskScheduling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton sstfbtn;
        private Guna.UI2.WinForms.Guna2ImageButton cScanbtn;
        private Guna.UI2.WinForms.Guna2ImageButton diskExitbtn;
        private Guna.UI2.WinForms.Guna2Separator cScan_line;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label cScan_txt;
        private Guna.UI2.WinForms.Guna2Separator sstf_line;
        private System.Windows.Forms.Label sstf_txt;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Panel panel1;
    }
}