namespace Todoist.QuickCapture
{
    partial class FormQuickCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuickCapture));
            this.tbTask = new System.Windows.Forms.TextBox();
            this.lbTask = new System.Windows.Forms.Label();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.lbProject = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.lbPriority = new System.Windows.Forms.Label();
            this.cbLabel = new System.Windows.Forms.CheckedListBox();
            this.lbLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.pnlError = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDue = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTask
            // 
            this.tbTask.Location = new System.Drawing.Point(12, 65);
            this.tbTask.Multiline = true;
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(297, 68);
            this.tbTask.TabIndex = 0;
            // 
            // lbTask
            // 
            this.lbTask.AutoSize = true;
            this.lbTask.Location = new System.Drawing.Point(12, 45);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(33, 17);
            this.lbTask.TabIndex = 1;
            this.lbTask.Text = "&Task";
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(12, 224);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(195, 25);
            this.cbProject.TabIndex = 2;
            // 
            // lbProject
            // 
            this.lbProject.AutoSize = true;
            this.lbProject.Location = new System.Drawing.Point(12, 204);
            this.lbProject.Name = "lbProject";
            this.lbProject.Size = new System.Drawing.Size(48, 17);
            this.lbProject.TabIndex = 1;
            this.lbProject.Text = "&Project";
            // 
            // cbPriority
            // 
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(213, 224);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(96, 25);
            this.cbPriority.TabIndex = 3;
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Location = new System.Drawing.Point(213, 204);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(49, 17);
            this.lbPriority.TabIndex = 1;
            this.lbPriority.Text = "P&riority";
            // 
            // cbLabel
            // 
            this.cbLabel.CheckOnClick = true;
            this.cbLabel.FormattingEnabled = true;
            this.cbLabel.Location = new System.Drawing.Point(315, 65);
            this.cbLabel.Name = "cbLabel";
            this.cbLabel.Size = new System.Drawing.Size(197, 184);
            this.cbLabel.TabIndex = 4;
            this.cbLabel.ThreeDCheckBoxes = true;
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Location = new System.Drawing.Point(315, 45);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(45, 17);
            this.lbLabel.TabIndex = 1;
            this.lbLabel.Text = "&Labels";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDate,
            this.lbMessage});
            this.statusStrip.Location = new System.Drawing.Point(0, 262);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(524, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lbDate
            // 
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 17);
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbMessage.ForeColor = System.Drawing.Color.Blue;
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbCancel,
            this.tsbSettings,
            this.tsbHelp,
            this.tsbExit});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(524, 39);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "toolStrip1";
            this.tsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMain_ItemClicked);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(90, 36);
            this.tsbSave.Tag = "1";
            this.tsbSave.Text = "&Save (F2)";
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(107, 36);
            this.tsbCancel.Tag = "2";
            this.tsbCancel.Text = "Cancel (Esc)";
            // 
            // tsbSettings
            // 
            this.tsbSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsbSettings.Image")));
            this.tsbSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(85, 36);
            this.tsbSettings.Tag = "3";
            this.tsbSettings.Text = "Se&ttings";
            // 
            // tsbHelp
            // 
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(76, 36);
            this.tsbHelp.Tag = "4";
            this.tsbHelp.Text = "&About";
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(62, 36);
            this.tsbExit.Tag = "5";
            this.tsbExit.Text = "E&xit";
            // 
            // pnlError
            // 
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Location = new System.Drawing.Point(53, 94);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(119, 69);
            this.pnlError.TabIndex = 7;
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(119, 69);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "label1";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Due";
            // 
            // tbDue
            // 
            this.tbDue.Location = new System.Drawing.Point(13, 157);
            this.tbDue.Name = "tbDue";
            this.tbDue.Size = new System.Drawing.Size(296, 25);
            this.tbDue.TabIndex = 1;
            // 
            // FormQuickCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(524, 284);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.tbDue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.cbLabel);
            this.Controls.Add(this.lbPriority);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.lbProject);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.tbTask);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormQuickCapture";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuickCapture_FormClosing);
            this.Load += new System.EventHandler(this.FormQuickCapture_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormQuickCapture_KeyDown);
            this.Resize += new System.EventHandler(this.FormQuickCapture_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.pnlError.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDue;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label lbProject;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.CheckedListBox cbLabel;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbDate;
        private System.Windows.Forms.ToolStripStatusLabel lbMessage;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbSettings;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
    }
}

