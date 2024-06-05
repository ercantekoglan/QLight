using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("Ux64_dllc.dll")]
        public static extern void Usb_Qu_Open();
        [DllImport("Ux64_dllc.dll")]
        public static extern void Usb_Qu_Close();
        [DllImport("Ux64_dllc.dll")]
        public static unsafe extern  bool Usb_Qu_write(byte Q_index, byte Q_type, byte* pQ_data);
        [DllImport("Ux64_dllc.dll")]
        public static extern int Usb_Qu_Getstate();

        const byte C_lampOff = 0;
        const byte C_lampOn = 1;
        const byte C_lampBlink = 2;
        const byte C_D_not = 100;  // Don't care

        public Form1()
        {
            InitializeComponent();
        }

        private unsafe void SetLampState(byte[] states, byte sound)
        {
            bool bchk;
            byte[] bbb = new byte[6];

            for (int i = 0; i < 5; i++)
            {
                bbb[i] = states[i];
            }
            bbb[5] = sound;

            fixed (byte* pbbb = bbb)
            {
                bchk = Usb_Qu_write(0, 0, pbbb);
            }

            if (bchk) text1.Text = "Success write";
            else text1.Text = "Write error";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetLampState(new byte[] { C_lampOn, C_lampBlink, C_D_not, C_lampOn, C_lampBlink }, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String pass = "PASS";
            String fail = "FAIL";
            String processing = "PROCESSING";
            String done = "DONE";

            if (processing.Equals("PROCESSING"))
            {
                SetLampState(new byte[] { C_lampOff, C_lampOn, C_lampOff, C_lampOff, C_lampOff }, 0);

            }
            else if (pass.Equals("PASS"))
            {
                SetLampState(new byte[] { C_lampOn, C_lampOff, C_lampOff, C_lampOff, C_lampOff }, 0);


            }
            else if (fail.Equals("FAIL"))
            {
                SetLampState(new byte[] { C_lampOff, C_lampOff, C_lampOn, C_lampOff, C_lampOff }, 0);

            }
            else if (done.Equals("DONE"))

                SetLampState(new byte[] { C_lampOff, C_lampOff, C_lampOff, C_lampOff, C_lampOff }, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int state = Usb_Qu_Getstate();
            string status = " Read Connect Usb  -->  ";

            status += (state & 0x01) == 1 ? "Index0(0), " : "Index0(X), ";
            status += (state & 0x02) == 2 ? "Index1(O), " : "Index1(X), ";
            status += (state & 0x04) == 4 ? "Index2(O), " : "Index2(X), ";
            status += (state & 0x08) == 8 ? "Index3(O), " : "Index3(X), ";

            text1.Text = status;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetLampState(new byte[] { C_lampOff, C_lampOff, C_lampOn, C_lampOff, C_lampOff }, 0);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetLampState(new byte[] { C_lampOff, C_lampOn, C_lampOff, C_lampOff, C_lampOff }, 0);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            SetLampState(new byte[] { C_lampOn, C_lampOff, C_lampOff, C_lampOff, C_lampOff }, 0);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetLampState(new byte[] { C_lampOff, C_lampOff, C_lampOff, C_lampOff, C_lampOff }, 0);

        }
    }
}