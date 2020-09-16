namespace ArmShareX
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftMenuPanel = new System.Windows.Forms.Panel();
            this.MenuButtonHost = new System.Windows.Forms.Button();
            this.MenuButtonViewer = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.NavigationtopPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FullScreen = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.HideLeftMenuButton = new System.Windows.Forms.Button();
            this.HostPanelBottom = new System.Windows.Forms.Panel();
            this.HostLable1 = new System.Windows.Forms.Label();
            this.HostButton2 = new System.Windows.Forms.Button();
            this.HostLable2 = new System.Windows.Forms.Label();
            this.HostButton1 = new System.Windows.Forms.Button();
            this.HostTextBox1 = new System.Windows.Forms.TextBox();
            this.ViewerPanelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewerPasteButton = new System.Windows.Forms.Button();
            this.ViewerTextBox1 = new System.Windows.Forms.TextBox();
            this.ViewerDisconnectButton = new System.Windows.Forms.Button();
            this.ViewerConnectButton = new System.Windows.Forms.Button();
            this.axRDPViewer1 = new AxRDPCOMAPILib.AxRDPViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeftMenuPanel.SuspendLayout();
            this.NavigationtopPanel.SuspendLayout();
            this.HostPanelBottom.SuspendLayout();
            this.ViewerPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftMenuPanel
            // 
            this.LeftMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftMenuPanel.Controls.Add(this.MenuButtonHost);
            this.LeftMenuPanel.Controls.Add(this.MenuButtonViewer);
            this.LeftMenuPanel.Controls.Add(this.LogoPanel);
            this.LeftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMenuPanel.Name = "LeftMenuPanel";
            this.LeftMenuPanel.Size = new System.Drawing.Size(151, 497);
            this.LeftMenuPanel.TabIndex = 0;
            this.LeftMenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftMenuPanel_MouseMove);
            // 
            // MenuButtonHost
            // 
            this.MenuButtonHost.FlatAppearance.BorderSize = 0;
            this.MenuButtonHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButtonHost.ForeColor = System.Drawing.Color.White;
            this.MenuButtonHost.Image = global::ArmShareX.Properties.Resources.projector2;
            this.MenuButtonHost.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuButtonHost.Location = new System.Drawing.Point(3, 163);
            this.MenuButtonHost.Name = "MenuButtonHost";
            this.MenuButtonHost.Size = new System.Drawing.Size(145, 64);
            this.MenuButtonHost.TabIndex = 2;
            this.MenuButtonHost.Text = "Host";
            this.MenuButtonHost.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuButtonHost.UseVisualStyleBackColor = true;
            this.MenuButtonHost.Click += new System.EventHandler(this.MenuButtonHost_Click);
            // 
            // MenuButtonViewer
            // 
            this.MenuButtonViewer.FlatAppearance.BorderSize = 0;
            this.MenuButtonViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButtonViewer.ForeColor = System.Drawing.Color.White;
            this.MenuButtonViewer.Image = global::ArmShareX.Properties.Resources._32x32;
            this.MenuButtonViewer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuButtonViewer.Location = new System.Drawing.Point(3, 93);
            this.MenuButtonViewer.Name = "MenuButtonViewer";
            this.MenuButtonViewer.Size = new System.Drawing.Size(145, 64);
            this.MenuButtonViewer.TabIndex = 1;
            this.MenuButtonViewer.Text = "Viewer";
            this.MenuButtonViewer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuButtonViewer.UseVisualStyleBackColor = true;
            this.MenuButtonViewer.Click += new System.EventHandler(this.MenuButtonViewer_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Olive;
            this.LogoPanel.BackgroundImage = global::ArmShareX.Properties.Resources.newlogo;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(151, 87);
            this.LogoPanel.TabIndex = 0;
            this.LogoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftMenuPanel_MouseMove);
            // 
            // NavigationtopPanel
            // 
            this.NavigationtopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavigationtopPanel.Controls.Add(this.panel2);
            this.NavigationtopPanel.Controls.Add(this.ExitButton);
            this.NavigationtopPanel.Controls.Add(this.FullScreen);
            this.NavigationtopPanel.Controls.Add(this.AboutButton);
            this.NavigationtopPanel.Controls.Add(this.HideLeftMenuButton);
            this.NavigationtopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationtopPanel.Location = new System.Drawing.Point(151, 0);
            this.NavigationtopPanel.Name = "NavigationtopPanel";
            this.NavigationtopPanel.Size = new System.Drawing.Size(818, 46);
            this.NavigationtopPanel.TabIndex = 1;
            this.NavigationtopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftMenuPanel_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(528, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(120, 45);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FullScreen
            // 
            this.FullScreen.FlatAppearance.BorderSize = 0;
            this.FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreen.ForeColor = System.Drawing.Color.White;
            this.FullScreen.Location = new System.Drawing.Point(276, 0);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(120, 45);
            this.FullScreen.TabIndex = 3;
            this.FullScreen.Text = "Full Screen";
            this.FullScreen.UseVisualStyleBackColor = true;
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(402, -1);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(120, 45);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HideLeftMenuButton
            // 
            this.HideLeftMenuButton.FlatAppearance.BorderSize = 0;
            this.HideLeftMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideLeftMenuButton.ForeColor = System.Drawing.Color.White;
            this.HideLeftMenuButton.Location = new System.Drawing.Point(150, 0);
            this.HideLeftMenuButton.Name = "HideLeftMenuButton";
            this.HideLeftMenuButton.Size = new System.Drawing.Size(120, 45);
            this.HideLeftMenuButton.TabIndex = 0;
            this.HideLeftMenuButton.Text = "Hide Menu";
            this.HideLeftMenuButton.UseVisualStyleBackColor = true;
            this.HideLeftMenuButton.Click += new System.EventHandler(this.HideLeftMenuButton_Click);
            // 
            // HostPanelBottom
            // 
            this.HostPanelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HostPanelBottom.Controls.Add(this.HostLable1);
            this.HostPanelBottom.Controls.Add(this.HostButton2);
            this.HostPanelBottom.Controls.Add(this.HostLable2);
            this.HostPanelBottom.Controls.Add(this.HostButton1);
            this.HostPanelBottom.Controls.Add(this.HostTextBox1);
            this.HostPanelBottom.Location = new System.Drawing.Point(358, 334);
            this.HostPanelBottom.Name = "HostPanelBottom";
            this.HostPanelBottom.Size = new System.Drawing.Size(288, 117);
            this.HostPanelBottom.TabIndex = 0;
            // 
            // HostLable1
            // 
            this.HostLable1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HostLable1.AutoSize = true;
            this.HostLable1.Location = new System.Drawing.Point(17, 13);
            this.HostLable1.Name = "HostLable1";
            this.HostLable1.Size = new System.Drawing.Size(145, 20);
            this.HostLable1.TabIndex = 6;
            this.HostLable1.Text = "ClipBoard Status :";
            // 
            // HostButton2
            // 
            this.HostButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HostButton2.FlatAppearance.BorderSize = 0;
            this.HostButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HostButton2.ForeColor = System.Drawing.Color.White;
            this.HostButton2.Location = new System.Drawing.Point(151, 79);
            this.HostButton2.Name = "HostButton2";
            this.HostButton2.Size = new System.Drawing.Size(120, 29);
            this.HostButton2.TabIndex = 6;
            this.HostButton2.Text = "Disconnect";
            this.HostButton2.UseVisualStyleBackColor = true;
            this.HostButton2.Click += new System.EventHandler(this.HostButton2_Click);
            // 
            // HostLable2
            // 
            this.HostLable2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HostLable2.AutoSize = true;
            this.HostLable2.Location = new System.Drawing.Point(164, 13);
            this.HostLable2.Name = "HostLable2";
            this.HostLable2.Size = new System.Drawing.Size(49, 20);
            this.HostLable2.TabIndex = 6;
            this.HostLable2.Text = "False";
            // 
            // HostButton1
            // 
            this.HostButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HostButton1.FlatAppearance.BorderSize = 0;
            this.HostButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HostButton1.ForeColor = System.Drawing.Color.White;
            this.HostButton1.Location = new System.Drawing.Point(14, 79);
            this.HostButton1.Name = "HostButton1";
            this.HostButton1.Size = new System.Drawing.Size(134, 29);
            this.HostButton1.TabIndex = 6;
            this.HostButton1.Text = "Generate";
            this.HostButton1.UseVisualStyleBackColor = true;
            this.HostButton1.Click += new System.EventHandler(this.HostButton1_Click);
            // 
            // HostTextBox1
            // 
            this.HostTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HostTextBox1.Location = new System.Drawing.Point(14, 36);
            this.HostTextBox1.Name = "HostTextBox1";
            this.HostTextBox1.Size = new System.Drawing.Size(257, 27);
            this.HostTextBox1.TabIndex = 6;
            // 
            // ViewerPanelBottom
            // 
            this.ViewerPanelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewerPanelBottom.Controls.Add(this.label1);
            this.ViewerPanelBottom.Controls.Add(this.ViewerPasteButton);
            this.ViewerPanelBottom.Controls.Add(this.ViewerTextBox1);
            this.ViewerPanelBottom.Controls.Add(this.ViewerDisconnectButton);
            this.ViewerPanelBottom.Controls.Add(this.ViewerConnectButton);
            this.ViewerPanelBottom.Location = new System.Drawing.Point(0, 335);
            this.ViewerPanelBottom.Name = "ViewerPanelBottom";
            this.ViewerPanelBottom.Size = new System.Drawing.Size(355, 116);
            this.ViewerPanelBottom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ClipBoard Paste";
            // 
            // ViewerPasteButton
            // 
            this.ViewerPasteButton.FlatAppearance.BorderSize = 0;
            this.ViewerPasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewerPasteButton.ForeColor = System.Drawing.Color.White;
            this.ViewerPasteButton.Location = new System.Drawing.Point(259, 35);
            this.ViewerPasteButton.Name = "ViewerPasteButton";
            this.ViewerPasteButton.Size = new System.Drawing.Size(93, 27);
            this.ViewerPasteButton.TabIndex = 3;
            this.ViewerPasteButton.Text = "Paste";
            this.ViewerPasteButton.UseVisualStyleBackColor = true;
            this.ViewerPasteButton.Click += new System.EventHandler(this.ViewerPasteButton_Click);
            // 
            // ViewerTextBox1
            // 
            this.ViewerTextBox1.Location = new System.Drawing.Point(56, 35);
            this.ViewerTextBox1.Name = "ViewerTextBox1";
            this.ViewerTextBox1.Size = new System.Drawing.Size(197, 27);
            this.ViewerTextBox1.TabIndex = 3;
            // 
            // ViewerDisconnectButton
            // 
            this.ViewerDisconnectButton.FlatAppearance.BorderSize = 0;
            this.ViewerDisconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewerDisconnectButton.ForeColor = System.Drawing.Color.White;
            this.ViewerDisconnectButton.Location = new System.Drawing.Point(154, 66);
            this.ViewerDisconnectButton.Name = "ViewerDisconnectButton";
            this.ViewerDisconnectButton.Size = new System.Drawing.Size(99, 38);
            this.ViewerDisconnectButton.TabIndex = 3;
            this.ViewerDisconnectButton.Text = "Disconnect";
            this.ViewerDisconnectButton.UseVisualStyleBackColor = true;
            this.ViewerDisconnectButton.Click += new System.EventHandler(this.ViewerDisconnectButton_Click);
            // 
            // ViewerConnectButton
            // 
            this.ViewerConnectButton.FlatAppearance.BorderSize = 0;
            this.ViewerConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewerConnectButton.ForeColor = System.Drawing.Color.White;
            this.ViewerConnectButton.Location = new System.Drawing.Point(56, 66);
            this.ViewerConnectButton.Name = "ViewerConnectButton";
            this.ViewerConnectButton.Size = new System.Drawing.Size(99, 38);
            this.ViewerConnectButton.TabIndex = 3;
            this.ViewerConnectButton.Text = "Connect";
            this.ViewerConnectButton.UseVisualStyleBackColor = true;
            this.ViewerConnectButton.Click += new System.EventHandler(this.ViewerConnectButton_Click);
            // 
            // axRDPViewer1
            // 
            this.axRDPViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axRDPViewer1.Enabled = true;
            this.axRDPViewer1.Location = new System.Drawing.Point(0, 0);
            this.axRDPViewer1.Name = "axRDPViewer1";
            this.axRDPViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRDPViewer1.OcxState")));
            this.axRDPViewer1.Size = new System.Drawing.Size(818, 451);
            this.axRDPViewer1.TabIndex = 1;
            this.axRDPViewer1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ViewerPanelBottom);
            this.panel1.Controls.Add(this.HostPanelBottom);
            this.panel1.Controls.Add(this.axRDPViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(151, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 451);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(798, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 19);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(969, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavigationtopPanel);
            this.Controls.Add(this.LeftMenuPanel);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "ArmShareX";
            this.LeftMenuPanel.ResumeLayout(false);
            this.NavigationtopPanel.ResumeLayout(false);
            this.HostPanelBottom.ResumeLayout(false);
            this.HostPanelBottom.PerformLayout();
            this.ViewerPanelBottom.ResumeLayout(false);
            this.ViewerPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftMenuPanel;
        private System.Windows.Forms.Button MenuButtonViewer;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel NavigationtopPanel;
        private System.Windows.Forms.Button MenuButtonHost;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button FullScreen;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button HideLeftMenuButton;
        private System.Windows.Forms.Panel ViewerPanelBottom;
        private System.Windows.Forms.Button ViewerPasteButton;
        private System.Windows.Forms.TextBox ViewerTextBox1;
        private System.Windows.Forms.Button ViewerDisconnectButton;
        private System.Windows.Forms.Button ViewerConnectButton;
        private AxRDPCOMAPILib.AxRDPViewer axRDPViewer1;
        private System.Windows.Forms.Label HostLable2;
        private System.Windows.Forms.Label HostLable1;
        private System.Windows.Forms.Button HostButton2;
        private System.Windows.Forms.Button HostButton1;
        private System.Windows.Forms.TextBox HostTextBox1;
        private System.Windows.Forms.Panel HostPanelBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

