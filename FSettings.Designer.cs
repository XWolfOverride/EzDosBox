namespace EzDosBox
{
    partial class FSettings
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
            this.lbRoot = new System.Windows.Forms.Label();
            this.tbRoot = new System.Windows.Forms.TextBox();
            this.btRootChoose = new System.Windows.Forms.Button();
            this.btDosBoxChoose = new System.Windows.Forms.Button();
            this.tbDosBox = new System.Windows.Forms.TextBox();
            this.lbDosBox = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbRoot
            // 
            this.lbRoot.AutoSize = true;
            this.lbRoot.Location = new System.Drawing.Point(12, 9);
            this.lbRoot.Name = "lbRoot";
            this.lbRoot.Size = new System.Drawing.Size(38, 15);
            this.lbRoot.TabIndex = 0;
            this.lbRoot.Text = "label1";
            // 
            // tbRoot
            // 
            this.tbRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRoot.Location = new System.Drawing.Point(12, 27);
            this.tbRoot.Name = "tbRoot";
            this.tbRoot.Size = new System.Drawing.Size(207, 23);
            this.tbRoot.TabIndex = 1;
            // 
            // btRootChoose
            // 
            this.btRootChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRootChoose.Location = new System.Drawing.Point(225, 27);
            this.btRootChoose.Name = "btRootChoose";
            this.btRootChoose.Size = new System.Drawing.Size(26, 23);
            this.btRootChoose.TabIndex = 2;
            this.btRootChoose.Text = "...";
            this.btRootChoose.UseVisualStyleBackColor = true;
            this.btRootChoose.Click += new System.EventHandler(this.btRootChoose_Click);
            // 
            // btDosBoxChoose
            // 
            this.btDosBoxChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDosBoxChoose.Location = new System.Drawing.Point(225, 74);
            this.btDosBoxChoose.Name = "btDosBoxChoose";
            this.btDosBoxChoose.Size = new System.Drawing.Size(26, 23);
            this.btDosBoxChoose.TabIndex = 5;
            this.btDosBoxChoose.Text = "...";
            this.btDosBoxChoose.UseVisualStyleBackColor = true;
            this.btDosBoxChoose.Click += new System.EventHandler(this.btDosBoxChoose_Click);
            // 
            // tbDosBox
            // 
            this.tbDosBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDosBox.Location = new System.Drawing.Point(12, 74);
            this.tbDosBox.Name = "tbDosBox";
            this.tbDosBox.Size = new System.Drawing.Size(207, 23);
            this.tbDosBox.TabIndex = 4;
            // 
            // lbDosBox
            // 
            this.lbDosBox.AutoSize = true;
            this.lbDosBox.Location = new System.Drawing.Point(12, 56);
            this.lbDosBox.Name = "lbDosBox";
            this.lbDosBox.Size = new System.Drawing.Size(38, 15);
            this.lbDosBox.TabIndex = 3;
            this.lbDosBox.Text = "label1";
            // 
            // FSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 113);
            this.Controls.Add(this.btDosBoxChoose);
            this.Controls.Add(this.tbDosBox);
            this.Controls.Add(this.lbDosBox);
            this.Controls.Add(this.btRootChoose);
            this.Controls.Add(this.tbRoot);
            this.Controls.Add(this.lbRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbRoot;
        private TextBox tbRoot;
        private Button btRootChoose;
        private Button btDosBoxChoose;
        private TextBox tbDosBox;
        private Label lbDosBox;
        private ToolTip toolTip;
    }
}