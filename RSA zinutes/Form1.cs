using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_zinutes
{
    public partial class Form1 : Form
    {

        private int port1 = 80;
        private int port2 = 81;

        private void ListenServer()
        {
            BigInteger[] keyPub = new BigInteger[2];
            string message = "", signature = "";
            Server.Start(port1, ref keyPub, ref message, ref signature);
            rTxtBoxMes.Invoke(new MethodInvoker(delegate ()
            {
                rTxtBoxMes.Text = message;
            }));
            rTxtBoxSig.Invoke(new MethodInvoker(delegate ()
            {
                rTxtBoxSig.Text = signature;
            }));
            lb2KeyPublic.Invoke(new MethodInvoker(delegate ()
            {
                lb2KeyPublic.Text = "ViesasRaktas = ( " + keyPub[0] + "; " + keyPub[1] + " )";
            }));
            ListenServer();
        }

        private void ListenClient()
        {
            BigInteger[] keyPub = new BigInteger[2];
            string message = "", signature = "";
            Server.Start(port2, ref keyPub, ref message, ref signature);
            rTxtBoxMesEnd.Invoke(new MethodInvoker(delegate ()
            {
                rTxtBoxMesEnd.Text = message;
            }));
            rTxtBoxSigSer.Invoke(new MethodInvoker(delegate ()
            {
                rTxtBoxSigSer.Text = signature;
            }));
            lb3KeyPublic.Invoke(new MethodInvoker(delegate ()
            {
                lb3KeyPublic.Text = "ViesasRaktas = ( " + keyPub[0] + "; " + keyPub[1] + " )";
            }));
            string[] signatureStringArray = signature.Split(' ');
            int length = signatureStringArray.Length;
            if (signatureStringArray[signatureStringArray.Length - 1] == "")
                length = signatureStringArray.Length - 1;
            int[] signatureIntArray = new int[length];
            for (int i = 0; i < signatureIntArray.Length; i++)
            {
                signatureIntArray[i] = int.Parse(signatureStringArray[i]);
            }
            int[] messageIntArray = RSACipher.Unsign(signatureIntArray, keyPub);
            string messageStr = "";
            foreach (var ch in messageIntArray)
            {
                messageStr += ch + " ";
            }
            rTxtBoxMesSer.Invoke(new MethodInvoker(delegate ()
            {
                rTxtBoxMesSer.Text = messageStr;
            }));
            lbSigCon.Invoke(new MethodInvoker(delegate ()
            {
                if (message == messageStr)
                    lbSigCon.Text = "Parasas patvirtintas";
                else
                    lbSigCon.Text = "Parasas nebuvo patvirtintas";
            }));
            ListenClient();
        }


        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void B1Pal_Click(object sender, EventArgs e)
        {
            B1Pal.Enabled = false;
            B2Pal.Enabled = false;
            B3Pal.Enabled = false;
            B1Pal.BackColor = Color.LightSteelBlue;
            panel1.Visible = true;
            var primaryNumbers = new string[] { "2", "3", "5", "7", "11", "13", "17", "19", "23", "29", "31", "37", "41", "43", "47", "53", "59", "61", "67", "71", "73", "79", "83", "89", "97", "101" };
            cBoxQ.Items.AddRange(primaryNumbers);
            cBoxP.Items.AddRange(primaryNumbers);
        }

        private void B2Pal_Click(object sender, EventArgs e)
        {
            B1Pal.Enabled = false;
            B2Pal.Enabled = false;
            B3Pal.Enabled = false;
            B2Pal.BackColor = Color.LightSteelBlue;
            panel2.Visible = true;
            Task.Run(() => this.ListenServer());
        }

        private void B3Pal_Click(object sender, EventArgs e)
        {
            B1Pal.Enabled = false;
            B2Pal.Enabled = false;
            B3Pal.Enabled = false;
            B3Pal.BackColor = Color.LightSteelBlue;
            panel3.Visible = true;
            Task.Run(() => this.ListenClient());
        }

        private void B1ASend_Click(object sender, EventArgs e)
        {
            int p, q;
            if (int.TryParse(cBoxP.Text, out p) && int.TryParse(cBoxQ.Text, out q))
            {
                string plainNumbers = "";
                string cipherNumbers = "";
                string text = rTxtBoxPText.Text;
                var encrypted = RSACipher.Sign(text, p, q);
                var plainBytes = Encoding.ASCII.GetBytes(text);
                char[] cipherText = new char[encrypted.Length];
                int[] encryptedNumbers = new int[encrypted.Length];
                for (int i = 0; i < encrypted.Length; i++)
                {
                    plainNumbers += int.Parse(plainBytes[i].ToString()) + " ";
                    cipherNumbers += encrypted[i] + " ";
                    cipherText[i] = (char)encrypted[i];
                    encryptedNumbers[i] = encrypted[i];
                }
                rTxtBoxCiphTxt.Text = "Zinutes skaitmenine reiksme:\n" + plainNumbers + "\n";
                rTxtBoxCiphTxt.AppendText("Paraso skaitmenine reiksme:\n" + cipherNumbers + "\n");
                BigInteger keyPri = RSACipher.GetPrivateKey();
                BigInteger[] keyPub = RSACipher.GetPublicKey();
                lb1KeyPublic.Text = "PrivatusRaktas = ( " + keyPri + " )";
                lbKeyPrivate.Text = "ViesasRaktas = ( " + keyPub[0] + "; " + keyPub[1] + " )";
                Client.Send(port1, keyPub, plainNumbers, cipherNumbers);
            }
        }

        private void B2ASend_Click(object sender, EventArgs e)
        {
            string str = lb2KeyPublic.Text;
            str = str.Replace("ViesasRaktas = ( ", "");
            str = str.Replace("; ", " ");
            str = str.Replace(" )", "");
            string[] strArray = str.Split(' ');
            BigInteger[] keyPub = new BigInteger[2];
            keyPub[0] = BigInteger.Parse(strArray[0]);
            keyPub[1] = BigInteger.Parse(strArray[1]);
            Client.Send(port2, keyPub, rTxtBoxMes.Text, rTxtBoxSig.Text);
        }
    }
}
