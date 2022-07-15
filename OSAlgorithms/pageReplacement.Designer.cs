
namespace OSAlgorithms
{
    partial class pageReplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageReplacement));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lru = new Guna.UI2.WinForms.Guna2ImageButton();
            this.exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.optimal = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lruCircle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lruLine = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.optimalCircle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.optimal_line = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lruCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimalCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lru
            // 
            this.lru.BackColor = System.Drawing.Color.Transparent;
            this.lru.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.lru.CheckedState.Parent = this.lru;
            this.guna2Transition1.SetDecoration(this.lru, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lru.HoverState.Image = global::OSAlgorithms.Properties.Resources.OPlru;
            this.lru.HoverState.ImageSize = new System.Drawing.Size(420, 420);
            this.lru.HoverState.Parent = this.lru;
            this.lru.Image = global::OSAlgorithms.Properties.Resources.OPlru;
            this.lru.ImageOffset = new System.Drawing.Point(0, 0);
            this.lru.ImageRotate = 0F;
            this.lru.ImageSize = new System.Drawing.Size(400, 400);
            this.lru.Location = new System.Drawing.Point(376, 93);
            this.lru.Name = "lru";
            this.lru.PressedState.Image = global::OSAlgorithms.Properties.Resources.OPlru;
            this.lru.PressedState.ImageSize = new System.Drawing.Size(410, 410);
            this.lru.PressedState.Parent = this.lru;
            this.lru.ShadowDecoration.Parent = this.lru;
            this.lru.Size = new System.Drawing.Size(346, 398);
            this.lru.TabIndex = 1;
            this.lru.UseTransparentBackground = true;
            this.lru.Click += new System.EventHandler(this.lru_Click);
            this.lru.MouseEnter += new System.EventHandler(this.lruHover);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exit.CheckedState.Parent = this.exit;
            this.guna2Transition1.SetDecoration(this.exit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.exit.HoverState.Image = global::OSAlgorithms.Properties.Resources.OPexit1;
            this.exit.HoverState.ImageSize = new System.Drawing.Size(400, 400);
            this.exit.HoverState.Parent = this.exit;
            this.exit.Image = global::OSAlgorithms.Properties.Resources.OPexit;
            this.exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.exit.ImageRotate = 0F;
            this.exit.ImageSize = new System.Drawing.Size(400, 400);
            this.exit.Location = new System.Drawing.Point(300, 248);
            this.exit.Name = "exit";
            this.exit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exit.PressedState.Parent = this.exit;
            this.exit.ShadowDecoration.Parent = this.exit;
            this.exit.Size = new System.Drawing.Size(346, 398);
            this.exit.TabIndex = 2;
            this.exit.UseTransparentBackground = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            // optimal
            // 
            this.optimal.BackColor = System.Drawing.Color.Transparent;
            this.optimal.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.optimal.CheckedState.Parent = this.optimal;
            this.guna2Transition1.SetDecoration(this.optimal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.optimal.HoverState.Image = global::OSAlgorithms.Properties.Resources.OPoptimal;
            this.optimal.HoverState.ImageSize = new System.Drawing.Size(420, 420);
            this.optimal.HoverState.Parent = this.optimal;
            this.optimal.Image = global::OSAlgorithms.Properties.Resources.OPoptimal;
            this.optimal.ImageOffset = new System.Drawing.Point(0, 0);
            this.optimal.ImageRotate = 0F;
            this.optimal.ImageSize = new System.Drawing.Size(400, 400);
            this.optimal.Location = new System.Drawing.Point(214, 93);
            this.optimal.Name = "optimal";
            this.optimal.PressedState.Image = global::OSAlgorithms.Properties.Resources.OPoptimal;
            this.optimal.PressedState.ImageSize = new System.Drawing.Size(410, 410);
            this.optimal.PressedState.Parent = this.optimal;
            this.optimal.ShadowDecoration.Parent = this.optimal;
            this.optimal.Size = new System.Drawing.Size(346, 398);
            this.optimal.TabIndex = 4;
            this.optimal.UseTransparentBackground = true;
            this.optimal.Click += new System.EventHandler(this.optimal_Click);
            this.optimal.MouseEnter += new System.EventHandler(this.optimalHover);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Azonix", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(770, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "Page Replacement Algorithms";
            this.label1.Visible = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.guna2Separator1.FillThickness = 10;
            this.guna2Separator1.Location = new System.Drawing.Point(777, 130);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(423, 67);
            this.guna2Separator1.TabIndex = 6;
            this.guna2Separator1.UseTransparentBackground = true;
            this.guna2Separator1.Visible = false;
            // 
            // lruCircle
            // 
            this.lruCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lruCircle.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lruCircle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lruCircle.FillColor = System.Drawing.Color.Transparent;
            this.lruCircle.Image = global::OSAlgorithms.Properties.Resources.circle_128px;
            this.lruCircle.ImageRotate = 0F;
            this.lruCircle.Location = new System.Drawing.Point(824, 248);
            this.lruCircle.Name = "lruCircle";
            this.lruCircle.ShadowDecoration.Parent = this.lruCircle;
            this.lruCircle.Size = new System.Drawing.Size(27, 26);
            this.lruCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lruCircle.TabIndex = 9;
            this.lruCircle.TabStop = false;
            this.lruCircle.UseTransparentBackground = true;
            this.lruCircle.Visible = false;
            // 
            // lruLine
            // 
            this.lruLine.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lruLine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lruLine.FillColor = System.Drawing.Color.White;
            this.lruLine.FillThickness = 5;
            this.lruLine.Location = new System.Drawing.Point(724, 228);
            this.lruLine.Name = "lruLine";
            this.lruLine.Size = new System.Drawing.Size(101, 67);
            this.lruLine.TabIndex = 10;
            this.lruLine.UseTransparentBackground = true;
            this.lruLine.Visible = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::OSAlgorithms.Properties.Resources.exit_60px;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(437, 478);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(85, 71);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 11;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::OSAlgorithms.Properties.Resources.wallpaperflare_com_wallpaper;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1359, 699);
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Azonix", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(857, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Least recently used";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Azonix", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "optimal";
            this.label3.Visible = false;
            // 
            // optimalCircle
            // 
            this.optimalCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optimalCircle.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.optimalCircle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.optimalCircle.FillColor = System.Drawing.Color.Transparent;
            this.optimalCircle.Image = global::OSAlgorithms.Properties.Resources.circle_128px;
            this.optimalCircle.ImageRotate = 0F;
            this.optimalCircle.Location = new System.Drawing.Point(169, 150);
            this.optimalCircle.Name = "optimalCircle";
            this.optimalCircle.ShadowDecoration.Parent = this.optimalCircle;
            this.optimalCircle.Size = new System.Drawing.Size(27, 26);
            this.optimalCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.optimalCircle.TabIndex = 14;
            this.optimalCircle.TabStop = false;
            this.optimalCircle.UseTransparentBackground = true;
            this.optimalCircle.Visible = false;
            // 
            // optimal_line
            // 
            this.optimal_line.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.optimal_line, Guna.UI2.AnimatorNS.DecorationType.None);
            this.optimal_line.FillColor = System.Drawing.Color.White;
            this.optimal_line.FillThickness = 5;
            this.optimal_line.Location = new System.Drawing.Point(196, 156);
            this.optimal_line.Name = "optimal_line";
            this.optimal_line.Size = new System.Drawing.Size(69, 15);
            this.optimal_line.TabIndex = 15;
            this.optimal_line.UseTransparentBackground = true;
            this.optimal_line.Visible = false;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // pageReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OSAlgorithms.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(1359, 699);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.optimalCircle);
            this.Controls.Add(this.optimal_line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.lruCircle);
            this.Controls.Add(this.lruLine);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optimal);
            this.Controls.Add(this.lru);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pageReplacement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pageReplacement";
            this.Load += new System.EventHandler(this.pageReplacement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lruCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimalCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton exit;
        private Guna.UI2.WinForms.Guna2ImageButton lru;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2ImageButton optimal;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox lruCircle;
        public Guna.UI2.WinForms.Guna2Separator lruLine;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox optimalCircle;
        public Guna.UI2.WinForms.Guna2Separator optimal_line;
    }
}