using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RDPCOMAPILib;

namespace ArmShareX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartConnection();
            HostPanelBottom.Visible = false;
            axRDPViewer1.Visible = true;
        }
        int Mx;
        int My;
        int Sw;
        int Sh;

        bool mov;

        bool menuHide = false;
        bool fullScreen = false;
        int counterGenerator = 0;
        int counterDisconnector = 0;
        int counterViewerDisconnetor = 0;
        int counterViewerConnector = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        RDPSession x = new RDPSession();

        private void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;//???
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }

        private void StartConnection()
        {
            x.OnAttendeeConnected += Incoming;
            x.Open();
        }

        private void LeftMenuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void HideLeftMenuButton_Click(object sender, EventArgs e)
        {
            if(menuHide == false)
            {
                LeftMenuPanel.Visible = false;
                menuHide = true;
            }
            else
            {
                LeftMenuPanel.Visible = true;
                menuHide = false;
            }
           

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This App Was Created By Armen Nagapetian in Year 2020");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullScreen_Click(object sender, EventArgs e)
        {
            if (fullScreen == false)
            {

                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                this.fullScreen = true;
            }
          
        }

        private void MenuButtonHost_Click(object sender, EventArgs e)
        {
            StartConnection();
            ViewerPanelBottom.Visible = false; 
            axRDPViewer1.Visible = false;
            HostPanelBottom.Visible = true;
        }

        private void HostTabEnterStartConnection()
        {
            RDPSession x = new RDPSession();
            x.OnAttendeeConnected += Incoming;
            x.Open();
        }

        private void MenuButtonViewer_Click(object sender, EventArgs e)
        {
            HostPanelBottom.Visible = false;
            axRDPViewer1.Visible = true;
            ViewerPanelBottom.Visible = true;

        }

        private void ViewerConnectButton_Click(object sender, EventArgs e)
        {
            if (ViewerTextBox1.Text == "")
            {
                MessageBox.Show("You need to add Code in the TextField");
            }
            else if (counterViewerConnector > 0)
            {
                MessageBox.Show("You Have Already been Connected");
            }
            else if(counterViewerConnector <= 0)
            {
                counterViewerConnector++;
                string Invitation = ViewerTextBox1.Text;
                axRDPViewer1.Connect(Invitation, "User1", "");
            }
        }

        private void ViewerDisconnectButton_Click(object sender, EventArgs e)
        {
            if(counterViewerDisconnetor > 0)
            {
                MessageBox.Show("You have already Disconnected ");
            }
            else
            {
                counterViewerDisconnetor++;
                axRDPViewer1.Disconnect();
            }
            
        }

        private void ViewerPasteButton_Click(object sender, EventArgs e)
        {
           ViewerTextBox1.Text = Clipboard.GetText();
        }

        private void HostButton1_Click(object sender, EventArgs e)
        {
            if(counterGenerator > 0)
            {
                MessageBox.Show("You have already Generated Code, Please use the Code from Text Field or Restart The app and try again");
            }
            else
            {
                counterGenerator++;

                IRDPSRAPIInvitation Invitation = x.Invitations.CreateInvitation("Trial", "MyGroup", "", 10);
                HostTextBox1.Text = Invitation.ConnectionString;
            }
           

            if (HostTextBox1.Text != "")
            {
                Clipboard.SetText(HostTextBox1.Text);
                HostLable2.Text = "True";
            }

        }

        private void HostButton2_Click(object sender, EventArgs e)
        {
            if(counterDisconnector > 0)
            {
                MessageBox.Show("You have already Disconnected The Connection, Please Restart And Try Again");
            }
            else
            {
                counterDisconnector++;
                x.Close();
                x = null;
            }
           
        }

        void SizerMouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        void SizerMouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        void SizerMouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }




    }



}
