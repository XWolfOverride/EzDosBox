namespace EzDosBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbItems = new System.Windows.Forms.ListBox();
            this.pToolbar = new System.Windows.Forms.Panel();
            this.btConfig = new System.Windows.Forms.Button();
            this.ilTbIcons = new System.Windows.Forms.ImageList(this.components);
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pinfo = new System.Windows.Forms.Panel();
            this.btOpenDir = new System.Windows.Forms.Button();
            this.pToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbItems
            // 
            this.lbItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.IntegralHeight = false;
            this.lbItems.ItemHeight = 35;
            this.lbItems.Location = new System.Drawing.Point(12, 12);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(218, 399);
            this.lbItems.TabIndex = 0;
            this.lbItems.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbItems_DrawItem);
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            this.lbItems.DoubleClick += new System.EventHandler(this.lbItems_DoubleClick);
            // 
            // pToolbar
            // 
            this.pToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pToolbar.Controls.Add(this.btOpenDir);
            this.pToolbar.Controls.Add(this.btConfig);
            this.pToolbar.Controls.Add(this.btRemove);
            this.pToolbar.Controls.Add(this.btAdd);
            this.pToolbar.Location = new System.Drawing.Point(12, 417);
            this.pToolbar.Name = "pToolbar";
            this.pToolbar.Size = new System.Drawing.Size(218, 32);
            this.pToolbar.TabIndex = 1;
            // 
            // btConfig
            // 
            this.btConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConfig.ImageIndex = 2;
            this.btConfig.ImageList = this.ilTbIcons;
            this.btConfig.Location = new System.Drawing.Point(186, 0);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(32, 32);
            this.btConfig.TabIndex = 2;
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // ilTbIcons
            // 
            this.ilTbIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth4Bit;
            this.ilTbIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTbIcons.ImageStream")));
            this.ilTbIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTbIcons.Images.SetKeyName(0, "tbPlus.ico");
            this.ilTbIcons.Images.SetKeyName(1, "tbRemove.ico");
            this.ilTbIcons.Images.SetKeyName(2, "tbSettings.ico");
            // 
            // btRemove
            // 
            this.btRemove.ImageIndex = 1;
            this.btRemove.ImageList = this.ilTbIcons;
            this.btRemove.Location = new System.Drawing.Point(38, 0);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(32, 32);
            this.btRemove.TabIndex = 1;
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.ImageIndex = 0;
            this.btAdd.ImageList = this.ilTbIcons;
            this.btAdd.Location = new System.Drawing.Point(0, 0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(32, 32);
            this.btAdd.TabIndex = 0;
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.ErrorImage = global::EzDosBox.Properties.Resources.imgError;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(327, 82);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // pinfo
            // 
            this.pinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pinfo.AutoScroll = true;
            this.pinfo.Controls.Add(this.pbImage);
            this.pinfo.Location = new System.Drawing.Point(236, 12);
            this.pinfo.Name = "pinfo";
            this.pinfo.Size = new System.Drawing.Size(356, 437);
            this.pinfo.TabIndex = 3;
            // 
            // btOpenDir
            // 
            this.btOpenDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenDir.ImageIndex = 2;
            this.btOpenDir.ImageList = this.ilTbIcons;
            this.btOpenDir.Location = new System.Drawing.Point(148, 0);
            this.btOpenDir.Name = "btOpenDir";
            this.btOpenDir.Size = new System.Drawing.Size(32, 32);
            this.btOpenDir.TabIndex = 3;
            this.btOpenDir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.pinfo);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.pToolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ez-DosBox";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pinfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbItems;
        private Panel pToolbar;
        private Button btConfig;
        private Button btRemove;
        private Button btAdd;
        private ImageList ilTbIcons;
        private ToolTip toolTip;
        private PictureBox pbImage;
        private Panel pinfo;
        private Button btOpenDir;
    }
}