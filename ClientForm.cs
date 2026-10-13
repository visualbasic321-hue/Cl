using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        public UIntPtr BeginSelect(Control item)
        {
            this.CanSelect.Equals(true);
            this.SelectNextControl(this, false, false, true, false);
            this.SelectNextControl(this, true, false, false, true);
            this.Select();
            switch (this.CanSelect)
            {
                case false:
                    {
                        // this.SetTopLevel(this.CanSelect);
                        this.TopMost.Equals(false);
                        this.TopLevel.Equals(false);
                        this.Select();
                        this.SelectNextControl(item, false, true, false, false);
                        if (item.Handle != this.Handle)
                        {
                            this.Select();
                        }

                        break;
                    }

                case true:
                    {
                        //this.SetTopLevel(this.CanSelect);
                        this.TopMost = true;
                        this.TopLevel.Equals(false);
                        this.Select();
                        this.SelectNextControl(item, false, true, false, false);
                        if (item.Handle == this.Handle)
                        {
                            this.Select();
                        }
                        break;
                    }
            }

            return UIntPtr.Parse(item.Handle.ToString());
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            WebRequest PostMethod = (HttpWebRequest)WebRequest.CreateHttp("https://www.habbo.es/api/public/authentication/captcha");
            PostMethod.Method = "GET";
            webView22.Source = new Uri(PostMethod.RequestUri.ToString());
            string[] Images = { "C:\\Users\\" + Environment.UserName + "\\source\\repos\\Client\\Client\\Images\\Image01.png", "C:\\Users\\" + Environment.UserName + "\\source\\repos\\Client\\Client\\Images\\Image02.jpg", "C:\\Users\\" + Environment.UserName + "\\source\\repos\\Client\\Client\\Images\\Image03.jpg", "C:\\Users\\" + Environment.UserName + "\\source\\repos\\Client\\Client\\Images\\Image04.jpg", "C:\\Users\\" + Environment.UserName + "\\source\\repos\\Client\\Client\\Images\\Image05.jpg", "C:\\Users\\" + Environment.UserName + "\\source\\repos\\Client\\Client\\Images\\Image05.png", "C:\\Users\\" + Environment.UserName + "\\source\\repos\\Client\\Client\\Images\\Image06.png", "C:\\Users\\" + Environment.UserName + "\\source\\repos\\Client\\Client\\Images\\Image07.jpg", "C:\\Users\\" + Environment.UserName + "\\source\\repos\\Client\\Client\\Images\\Image08.jpg" };
            PostMethod.Headers.Add("cookie", "OptanonConsent=isGpcEnabled=0&datestamp=Thu+Apr+23+2026+14%3A02%3A48+GMT-0500+(Central+Daylight+Time)&version=202409.1.0&browserGpcFlag=0&isIABGlobal=false&hosts=&consentId=ea71597a-160f-4d47-a3b2-42c4efd55037&interactionCount=1&isAnonUser=1&landingPath=NotLandingPage&groups=C0002%3A0%2CC0004%3A0%2CC0001%3A1%2CC0003%3A0&intType=2; browser_token=s%3A2KxeI90g6irboFTr52qx84Db2ysAxBi3UcNbI_kK_Ck.JUZUre%2FkjyRz0MExZcMiLjpeQveGigALVhi42nmB3lQ; OptanonAlertBoxClosed=2026-04-23T19:02:48.586Z; session.id=s%3AzgNj0wCNOUlhwnYAZ22HFrRVDuTdldicngo1emGWYVQ.SITzHMED%2FeVIgvcYhB4RTbfx%2F%2BeZo9nboE5GqbwMIK4");
            PostMethod.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:149.0) Gecko/20100101 Firefox/149.0");
            PostMethod.Headers.Add("Accept", "application/json, text/plain, */*");
            PostMethod.Headers.Add("x-habbo-fingerprint", "0f14eccf02931a14adf3dd78315da8fc");
            PostMethod.Headers.Add("Referer", "https://cdn.proxyium.com/requests.php");
            int GetResp = PostMethod.GetResponse().GetResponseStream().ReadByte().ToString().Length;
            Func<WebRequest, byte[]> GetResponse = delegate (WebRequest WebRequestMethod) { var Hclient = new HttpClient(); Hclient.BaseAddress = new Uri("https://images.habbo.com/habbo-web/america/es/assets/images/sprite@2x.f98bb62b.png"); Hclient.GetAsync("https://www.habbo.com"); var Resp = Hclient.GetAsync("https://images.habbo.com/habbo-web/america/es/assets/images/sprite@2x.f98bb62b.png"); using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, WebRequestMethod.RequestUri)) { Random PublicKey = new Random(); int Index = PublicKey.Next(1, Images.Length); ushort[] Message = { 0x11, 0, 0x0000, 0, 0x11, 0, 0x0002, 0, 0x56, 0, 0x0000, 0, 0x56, 0, 0x0002, 0 }; foreach (ushort header in Message) { Console.Write(false); this.CanSelect.Equals(true); List<IntPtr> refHandles = new List<nint>(); var Hwnd = File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handles.txt"); foreach (var item in Hwnd) { [DllImport("user32.dll")] static extern bool PostMessage(IntPtr hwnd, uint Msg, int Lparam, int wPram); static extern bool SendMessage(IntPtr hwnd, uint Msg, int LpARAM, int wParam); this.CanSelect.Equals(false); this.CanSelect.Equals(true); panel1.BackgroundImage = Image.FromFile(Images[Index]); this.SelectNextControl(panel1, PostMessage(nint.Parse(item.ToString()), new byte[] { (byte)Process.GetCurrentProcess().Handle }[0], 0, 0), false, false, true); return new byte[] { (byte)(IntPtr)nint.Parse(Hwnd.ToString()) }; } Console.Write(true); } } return new byte[GetResp]; };
            IList<ArraySegment<byte>> Buffers = new List<ArraySegment<byte>>();
            byte[] Buffer = File.ReadAllBytes("C://Users//" + Environment.UserName + "Desktop//Index.js"); foreach (byte b in GetResponse(PostMethod)) { webView21.ExecuteScriptAsync("<script src='http://localhost:1302'> function GetClientProfile(){const XHR=new XMLHttpRequest(); XHR.open('GET','https://www.habbo.com'); XHR.send(new function(boolean){console.log(window.location.href" + new StringBuilder((string)new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { byte[] Buffer = Encoding.Default.GetBytes(Convert.ToBase64String(Encoding.ASCII.GetBytes(webView22.ExecuteScriptAsync(File.ReadAllText("C://Index.js")).ToString()))); }) } }[0].ToString().Length.ToString() + ";});}GetClientProfile();</script>")); webView22.ExecuteScriptAsync(System.IO.File.ReadAllText("C:\\HomeRoom.js")); webView22.ExecuteScriptAsync("C:\\Index.js"); Buffer = new byte[] { b }; Array.Resize<byte>(ref Buffer, (int)(int)(int)(int)(int)(int)(int)GetResp); }
           
        }









        private void timer1_Tick(object sender, EventArgs e)
        {
            BeginSelect(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            var Proc = Process.GetProcessById(int.Parse(toolStripTextBox1.Text.ToString()));
            SetParent(Proc.MainWindowHandle, panel1.Handle);

        }
    }
}
