using Desktop.Robot.Extensions;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string dispatchEvent(object sender, EventArgs e)
        {
            return dispatchEvent(new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { Convert.ToBase64String(Encoding.UTF8.GetBytes(webView21.ExecuteScriptAsync("setTimeout(()=>{showDirectoryPicker();},471831);").ToString().ToString())); }) } }[0], e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Process.GetCurrentProcess().Handle != IntPtr.Zero)
            {
                using (var icmpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    try
                    {
                        textBox3.Text = File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handle.txt");
                        FileStream FS = new FileStream("C://Users//" + Environment.UserName + "//Desktop//API.js", FileMode.Open, FileAccess.ReadWrite);
                        const string scriptMessage = "setTimeout(() => {\r\n    window.location='https://www.habbo.com/profile/Ma0l';\r\n    \r\n}, (1302));\r\nvar imager=document.getElementsByClassName('imager');\r\nwindow.location=imager[0].src;\r\n";
                        //HttpRequest(\"https://www.habbo.com\",\"GET\");\r\nXML.open(\"POST\",\"http://localhost:30001/profile/Ma0l\");\r\nXML.send(new function(boolean){XML.setRequestHeader(\"Accept\",\"text/html\"); window.location=imager[0].src;});";
                        byte[] Buffer = Encoding.ASCII.GetBytes(scriptMessage);
                        FS.Write(Buffer, 0, Buffer.Length);
                        FS.Close();
                        FS.Dispose();
                        button4.PerformClick();
                        StreamWriter SW = new StreamWriter("C://Users//" + Environment.UserName + "//Desktop//API.js");
                        SW.WriteLine(" setTimeout(() => {\r\n      window.location='https://www.habbo.com/profile/Ma0l';\r\n }, 1302);\r\n var imager=document.getElementsByClassName('imager');\r\n window.location=imager[0].src;");
                        SW.Close();
                        SW.Dispose();
                        webView22.Source = new Uri("https://www.habbo.com/profile/Ma0l");
                        Console.WriteLine("Disconnected");
                        icmpListener.Bind(new IPEndPoint(IPAddress.Any, 1302));
                        timer1.Interval =4302;
                        timer1.Start();
                        WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com/");
                        PostMethod.Headers.Add("Accept", "text/html");
                        PostMethod.Headers.Add("cookie", "");
                        PostMethod.Headers.Add("Method", "POST");
                        PostMethod.Method = "POST";
                        // byte[] Buffer = new byte[1302];
                        PostMethod.ContentLength = Buffer.LongLength;
                        webView22.Source = new Uri("https://onlinesequencer.net");
                        webView22.Source = new Uri("https://www.habbo.com/profile/Ma0l");
                        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetParent")] static extern void SetParent(IntPtr hwndChild, IntPtr hwndNewParent); const int PID = 5964; Func<IntPtr, byte[]> SendMessage = delegate (nint hwnd) { SetParent(Process.GetCurrentProcess().Handle, Process.GetProcessById(PID).MainWindowHandle); SetParent(Process.GetProcessById(PID).Handle, Process.GetCurrentProcess().MainWindowHandle); string[] Pages = { "https://www.habbo.com", "http://localhost:30001/", "http://localhost:1302/" }; using (var httpClient = new HttpClient()) { Random Index = new Random(); int index = Index.Next(1, Pages.Length); Console.WriteLine(index); int ID = index; string uri = Pages[index]; switch (uri) { case "https://www.habbo.com": { break; } case "http://localhost:30001/": { break; } case "http://localhost:1302": { httpClient.BaseAddress = new Uri("https://www.pastebin.com/raw/TF9MauVK"); var GetAsync = httpClient.GetAsync("http://localhost:30001/"); List<string> PostAsync = new List<string> { Convert.ToBase64String(Encoding.Default.GetBytes(webView21.ExecuteScriptAsync(System.IO.File.ReadAllText("C:/Index.js")) + Newtonsoft.Json.JsonConvert.SerializeObject(new List<string> { new object[] { PostMethod.BeginGetRequestStream(new AsyncCallback((sender => { using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com")) { if (GetAsync.Result.ToString() != null) { var processID = System.IO.File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handles.txt"); foreach (var item in processID) { Console.WriteLine(Process.GetProcessById(int.Parse(item.ToString())).MainWindowHandle); Func<byte[], string> Hmessage = delegate (byte[] hwnd) { TcpClient Accepted = new TcpClient("127.0.0.1", 30001); while (Accepted.Client.RemoteEndPoint.ToString().Length >= 0) { Random IndexValue = new Random(); [DllImport("user32.dll", SetLastError = true)] static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent); [DllImport("user32.dll", SetLastError = true)] static extern IntPtr keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo); IntPtr refValue() { int valueHwnd = Index.Next(1, Process.GetProcessById(int.Parse(item.ToString())).MainWindowHandle.ToInt32()); icmpListener.Listen(valueHwnd * new List<IntPtr> { new nint(refValue()) }.Count); switch (Accepted.Connected) { case false: { Accepted.Client = icmpListener.Accept(); if (Accepted.Client.RemoteEndPoint.ToString() != null) { Console.Write(false); using (var GetResponse = Accepted.GetStream()) { StreamReader SR = new StreamReader(GetResponse); StreamWriter SW = new StreamWriter(GetResponse, SR.CurrentEncoding); SW.WriteLine("HTTP/1.0 200 OK\r"); SW.WriteLine("<script src='https://www.habbo.com'> function dispatchEvent(){window.location='http://localhost:30001/';}dispatchEvent();</script>"); string refPostMessage() { SendKeys.Send(dispatchEvent(sender, e)); SW.WriteLine("<H1 id='" + refPostMessage() + "'> </H1>"); return dispatchEvent(sender, e); } } } break; } case true: { break; } } return Process.GetCurrentProcess().Handle; } } return Process.GetProcessById(int.Parse(hwnd.ToString())).MainWindowTitle; }; } } } })), null) }[0].GetType().Name.ToString() }).ToString())) }; break; } } } Console.WriteLine("Connection" + DateTime.Now.ToString()); return new byte[] { }; }; foreach (byte x in SendMessage(Process.GetProcessById(PID).MainWindowHandle)) { [DllImport("user32.dll", SetLastError = true, EntryPoint = "keybd_event")] static extern IntPtr keybd_event(byte bKey, byte bScan, int dwFlags, int dwExtraInfo); SetParent(keybd_event((byte)x, 0, 0x0000, 0), Process.GetProcessById(PID).Handle); SetParent(Process.GetProcessById(PID).MainWindowHandle, keybd_event((byte)x, 0, 0x0002, 0)); }
                    }
                    catch (SocketException ex)
                    {
                        var Filepath = ("C://Users//" + Environment.UserName + "//Desktop//API.js");
                        OpenFileDialog ofd = new OpenFileDialog();
                        var DirInfo = Directory.GetFiles(Filepath.Replace("//API.js", string.Empty));
                        RichTextBox ItemInfo = new RichTextBox();
                        ItemInfo.TextChanged += ItemInfo_TextChanged;
                        ItemInfo.Show();
                        [DllImport("user32.dll", SetLastError = true)]
                        static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                        ItemInfo.Show();
                        foreach (var items in DirInfo)
                        {
                            SetParent(ItemInfo.Handle, panel2.Handle);
                            ItemInfo.Text += items + Environment.NewLine;
                        }
                        foreach (var Filename in ItemInfo.Text)
                        {
                            if (ItemInfo.Text.Contains("API.js"))
                            {
                                MessageBox.Show("Disconnection:" + DateTime.Now.ToString() + Environment.NewLine);
                                Console.WriteLine("https://www.habbo.com/habbo-imaging/");
                            }
                            if (!ItemInfo.Text.Contains("API.js"))
                            {
                                System.IO.File.Create(Filepath);

                            }
                        }


                    }
                }
            }
        }

        private void ItemInfo_TextChanged(object? sender, EventArgs e)
        {
            var Filepath = "C://Users//" + Environment.UserName + "//Desktop//Handles.txt";
            StreamWriter SW = new StreamWriter(Filepath);
            SW.WriteLine("<script src='http://localhost:30001'>document.write('<img src='https://www.habbo.com/habbo-imaging/avatar/hd-180-14.ch-267-1408.lg-275-1408.sh-3115-1408-1408.ha-1004-91.ea-1404-90%2Cs-0.g-1.d-2.h-2.a-0%2C5c217c148bf1e15cd56eb43b5a07034f.png'class='imager' id='http://localhost:30001/Stop>); </script>\r\n");
            SW.Close();
            SW.Dispose();
            richTextBox1.Text += System.IO.File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handles.txt");
        }

        public byte[] PostMessage(ushort header)
        {
            return new byte[] { (byte)header };
        }
        public string dispatchEvent()
        {

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(webView21.ExecuteScriptAsync("setTimeout(()=>{showDirectoryPicker();},3103);").ToString()));
        }
        public bool validateCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors er)
        {
            foreach (Control c in FormClients)
            {
                if (c.CanSelect)
                {
                    for (var x = 0; x < FormClients.Count; x++)
                    {
                        if (c.Handle != FormClients[x].Handle)
                        {
                            TcpClient ClientSock = new TcpClient("127.0.0.1", 30001);
                            using (var MemoryStream = new BinaryWriter(new MemoryStream(new byte[ClientSock.SendBufferSize])))
                            {
                                #region
                                string[] DispatchEvent()
                                {
                                    return new string[] { ClientSock.Client.RemoteEndPoint.ToString() };
                                }
                                #endregion
                                MemoryStream.Write("https://www.habbo.com/");
                                FormClients[x].SelectNextControl(c, false, false, true, false);
                                c.SelectNextControl(FormClients[x], false, false, false, true);
                            }
                        }
                    }
                    return c.CanSelect;
                }
                if (!c.CanSelect)
                {
                    for (var x = 0; x < FormClients.Count; x++)
                    {
                        if (c.Handle != FormClients[x].Handle)
                        {
                            FormClients[x].SelectNextControl(c, false, false, true, false);
                            c.SelectNextControl(FormClients[x], false, false, false, true);
                        }
                        return c.CanSelect;
                    }
                }
            }
            return FormClients[0].CanSelect;
        }
        public static byte[] Buffer = new byte[30001];
        public Process PostMessageRef(IntPtr hwnd)
        {
            while (hwnd != Process.GetProcessById(int.Parse(textBox1.Text.ToString())).MainWindowHandle)
            {
                const int SW_HIDE = 9;
                //MessageBox.Show("https://www.habbo.com");
                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.KeyPress(Desktop.Robot.Key.CapsLock);
                wm_char.KeyPress(Desktop.Robot.Key.Enter);
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter); wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter); wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter); wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
                SendKeys.Send("^v");
                SendKeys.Send("{ENTER}");
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                wm_char.GetMousePosition();
                // wm_char.Click(null);
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Alt, Desktop.Robot.Key.Delete, Desktop.Robot.Key.Esc);
            }

            return Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
        }
        public byte[] PostMsg(ushort keyCode)
        {
            Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            Process[] Clients = Process.GetProcessesByName(Disposed.ProcessName);
            [DllImport("user32.dll", SetLastError = true)]
            static extern bool PostMessage(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);
            static extern bool SendMessage(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);
            foreach (ClientForm x in FormClients)
            {
                //1080810808
                Desktop.Robot.Robot wm_Text = new Desktop.Robot.Robot();
                SendKeys.Send("{ENTER}");
                Desktop.Robot.Robot wm = new Desktop.Robot.Robot();
                wm.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                // Source - https://stackoverflow.com/a/14396596
                // Posted by Bali C, modified by community. See post 'Timeline' for change history
                // Retrieved 2026-04-28, License - CC BY-SA 4.0

                [DllImport("user32.dll", SetLastError = true)]
                static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

                const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
                const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
                const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
                const int VK_LCONTROL = 0xA2; //Left Control key code
                const int A = 0x41; //A key code
                const int C = 0x43; //C key code

                // Hold Control down and press A
                keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
                keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

                // Hold Control down and press C
                keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(C, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(C, 0, KEYEVENTF_KEYUP, 0);

                const int SW_HIDE = 9;
                wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);

                // Source - https://stackoverflow.com/a/14396596
                // Posted by Bali C, modified by community. See post 'Timeline' for change history
                // Retrieved 2026-04-28, License - CC BY-SA 4.0

                // Hold Control down and press A
                keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
                keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

                // Hold Control down and press C
                keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(C, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(C, 0, KEYEVENTF_KEYUP, 0);

                PostMessage(Disposed.MainWindowHandle, 0x0101, (IntPtr)keyCode, IntPtr.Zero);
                [DllImport("user32.dll", SetLastError = true)]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
                static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
                ShowWindow(Disposed.MainWindowHandle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                ShowWindow(Disposed.MainWindowHandle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x000, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.MainWindowHandle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x0001, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.MainWindowHandle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x02, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.MainWindowHandle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x0002, (IntPtr)keyCode, IntPtr.Zero);
                PostMessage(Disposed.MainWindowHandle, 0x11, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.MainWindowHandle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x5A, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.MainWindowHandle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x0D, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.MainWindowHandle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                PostMessage(Disposed.MainWindowHandle, 0x0002, (IntPtr)keyCode, IntPtr.Zero);
                ShowWindow(Disposed.MainWindowHandle, SW_HIDE); ShowWindow(Disposed.MainWindowHandle, SW_HIDE);
                Func<byte[], IntPtr> refPostMessage = delegate (byte[] Buffer) { Console.WriteLine(false); Desktop.Robot.Robot wm_Text = new Desktop.Robot.Robot(); wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); wm_Text.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); SendKeys.Send("{ENTER}"); SendKeys.Send("^v"); SendKeys.Send("{ENTER}"); return new IntPtr(); };
                PostMessage(Disposed.MainWindowHandle, 0x0100, (IntPtr)keyCode, IntPtr.Zero);

                var hcontrol = new Control();
                hcontrol.Handle.Equals(refPostMessage(new byte[x.Width]));
                hcontrol.Show();
                //ShowWindow(hcontrol.Handle, 9);
                SetParent(refPostMessage(new byte[x.Height]), panel1.Handle);
                SetParent(refPostMessage(new byte[x.Width]), x.Height);
                //ShowWindow(refPostMessage(new byte[x.MainWindowHandle]), 9);
                //SendMessage(x.MainWindowHandle, 0x0100, 0x56, IntPtr.Zero);
                //SendMessage(x.MainWindowHandle, (uint)refPostMessage(new byte[x.Handle]), refPostMessage(new byte[x.Handle]), 0);
                //PostMessage(x.MainWindowHandle, 0x0101, (IntPtr)keyCode, IntPtr.Zero);
                //PostMessage(x.MainModule.BaseAddress,(uint)refPostMessage(new byte[] { (byte)x.MainWindowHandle}), refPostMessage(new byte[x.MainWindowHandle]), 0);


            }

            PostMessage(Disposed.MainWindowHandle, 0x0002, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x0001, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x001, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x5A, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0xBD, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x11, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x4A, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x56, (IntPtr)keyCode, IntPtr.Zero);
            PostMessage(Disposed.MainWindowHandle, 0x01, (IntPtr)keyCode, IntPtr.Zero);
            return new byte[] { (byte)(int)keyCode };
        }
        public string refPostClientMsg(int pid)
        {
            for (int i = 0; i < pid; i++)
            {
                Process Disposed = Process.GetProcessById(pid);
                Process[] Clients = Process.GetProcessesByName(Disposed.ProcessName);
                foreach (Process x in Clients)
                {
                    Console.Write(false);
                    //Process BeginStart = PostMessageRef(x.Handle);
                    //x.MainWindowHandle.Equals(BeginStart.Handle);
                    PostMessageRef(Process.GetCurrentProcess().MainWindowHandle);

                    //PostMessageRef(x.Handle);
                }


                //xProc.Start();
                //Disposed.GetType().GetElementType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, null, PostMessageRef(x.MainWindowHandle), null);
                //Disposed.GetType().InvokeMember("PostMessage", System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
                using (BinaryWriter BW = new BinaryWriter(new MemoryStream(new byte[(IntPtr)Disposed.MainWindowHandle])))
                {
                    BW.Write("https://www.habbo.com");
                    Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte Bkey, byte Bscan, int dwFlags, int dwExtraInfo); keybd_event(0x01, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); wm.GetMousePosition(); return new byte[] { }; };
                    BW.Write(refPostMessage(Disposed.MainWindowHandle));
                    Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); ;
                    Server.Connect("127.0.0.1", 30001);
                    Server.Send(PostMsg(0x01));
                    Server.Send(PostMsg(0x011));
                    Server.Send(PostMsg(0x11));
                    Server.Send(PostMsg(0x56));
                    Server.Send(PostMsg(0x56));
                    Server.Send(PostMsg(0x0D));


                    BW.Close();
                    BW.Dispose();
                }

            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(webView21.ExecuteScriptAsync("setTimeout(()=>{ window.location.href='https://www.habbo.com/logout';showDirectoryPicker();},1993);").ToString()));

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Process.GetCurrentProcess().Handle != IntPtr.Zero)
            {
                Console.WriteLine("Disconnected");
                foreach (var items in FormClients)
                {
                    this.CanSelect.Equals(true);


                    [DllImport("user32.dll", SetLastError = true)]
                    static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                    SetParent(items.Handle, panel2.Handle);
                    SetParent(IntPtr.Zero, items.Handle);
                    SetParent(IntPtr.Zero, items.Handle);
                    panel2.Controls.Add(items);
                    SetParent(items.Handle, panel2.Handle);
                    SetParent(IntPtr.Zero, items.Handle);
                    SetParent(IntPtr.Zero, items.Handle);
                    Random Index = new Random();
                    if (ModuleContainers.Count >= 1)
                    {
                        foreach (var itemsin in ModuleContainers)
                        {
                            itemsin.StandardInput.Write(new byte[] { (byte)Process.GetCurrentProcess().MainWindowHandle });
                            itemsin.StandardOutput.BaseStream.BeginRead(new byte[] { 0x11 }, 0, 0, new AsyncCallback((sender) => { Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); Client.Connect("69.172.200.161", 443); Client.Send(new byte[] { 0x11, 0, 0x56, 0x0D }); SetParent(Process.GetCurrentProcess().MainWindowHandle, Client.Handle); }), null);
                        }
                    }
                    Socket ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    int value = Index.Next(1, FormClients.Count);
                    foreach (var item in FormClients)
                    {
                        item.CanSelect.Equals(false);
                        Func<IntPtr, byte[]> SendMessage = delegate (nint hwnd)
                        {
                            // ClientSock.Connect("69.172.200.161", 443);
                            Process[] Client = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
                            foreach (Process x in Client)
                            {
                                return new byte[ClientSock.SendBufferSize];
                            }
                            Console.WriteLine(item);
                            [DllImport("user32.dll", SetLastError = true, EntryPoint = "keybd_event")]
                            static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
                            [DllImport("user32.dll", SetLastError = true)]
                            static extern IntPtr keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
                            FormClients[value].CanSelect.Equals(true);
                            FormClients[value].Select();
                            FormClients[value].SelectNextControl(this, false, true, false, true);
                            FormClients[value].SelectNextControl(items, false, true, true, false);
                            FormClients[value].SelectNextControl(this, true, false, false, true);
                            FormClients[value].SelectNextControl(items, true, false, true, false);
                            FormClients[value].Select();
                            const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
                            const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
                            const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
                            const int VK_LCONTROL = 0xA2; //Left Control key code
                            const int A = 0x41; //A key code
                            const int C = 0x43; //C key code

                            // Hold Control down and press A
                            SetParent(keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0), item.Handle);
                            SetParent(keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0), Process.GetCurrentProcess().MainWindowHandle);
                            SetParent(keybd_event(A, 0, KEYEVENTF_KEYUP, 0), item.Handle);
                            SetParent(keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0), Process.GetCurrentProcess().Handle);

                            // Hold Control down and press C
                            SetParent(keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0), items.Handle);
                            SetParent(items.Handle, keybd_event(C, 0, KEYEVENTF_KEYDOWN, 0));
                            SetParent(keybd_event(C, 0, KEYEVENTF_KEYUP, 0), Process.GetCurrentProcess().MainWindowHandle);
                            ushort[] headers = { 0x11, 0x56, 0x0D };
                            foreach (var packet in headers)
                            {
                                keybd_event(0x11, 0, 0x0000, 0);
                                using (var HttpClient = new HttpClient())
                                {

                                    HttpClient.BaseAddress = new Uri("https://cdn.proxyium.com/requests.php");
                                    //  SetParent(keybd_event(0x11, 0, 0x0000, 0), item.Handle);
                                    var GetAsync = HttpClient.GetAsync("https://www.habbo.com/hotel");
                                    var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/logout");
                                    //SetParent(keybd_event(0x11, 0, 0x0002, 0), Process.GetCurrentProcess().MainWindowHandle);
                                    HttpReqMsg.Content = new StringContent(Convert.ToBase64String(new byte[new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { item.CanSelect.Equals(true); item.SelectNextControl(panel2, ShowWindow(Process.GetCurrentProcess().MainWindowHandle, 9), false, true, false); }) } }[0].Length]), Encoding.ASCII, "application/json");
                                    webView21.ExecuteScriptAsync(HttpClient.SendAsync(HttpReqMsg).ToString());
                                    return new byte[] { (byte)packet };
                                }
                            }
                            return new byte[] { (byte)item.Handle };
                        };
                        ClientSock.BeginConnect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 30001), new AsyncCallback((sender) => { SendMessage(ClientSock.Handle); }), null);
                        [DllImport("user32.dll", SetLastError = true)]
                        static extern IntPtr PostMessage(IntPtr hwnd, uint msg, IntPtr lParam, IntPtr wParam);
                        Buffer = SendMessage(PostMessage(item.Handle, Buffer[0], IntPtr.Zero, Process.GetCurrentProcess().MainWindowHandle));

                        item.CanSelect.Equals(true);
                        textBox2.Text = Process.GetCurrentProcess().Id.ToString();

                        var Filepath = "C:\\Users\\Admin\\Desktop\\API.js";
                        //MessageBox.Show(File.ReadAllText(Filepath.Replace("Admin", Environment.UserName)));

                        var script = Filepath.Replace("Admin", Environment.UserName);
                        webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(script));
                        Process Disposed = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
                        //ClientModules.Add(Disposed);
                        //  Disposed.GetType().InvokeMember(null, System.Reflection.BindingFlags.InvokeMethod, null, Disposed, null);
                        TcpClient Clientsock = new TcpClient("127.0.0.1", 30001);

                        using (var BW = new BinaryWriter(new MemoryStream(new byte[Clientsock.Client.ReceiveBufferSize])))
                        {


                            BW.Write("https://www.habbo.com");
                            Func<IntPtr, byte[]> refPostMessage = delegate (IntPtr hwnd) { [DllImport("user32.dll", SetLastError = true)] static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo); keybd_event(0x02, 0, 0x0000, 0); keybd_event(0x010, 0, 0x0002, 0); keybd_event(0x11, 0, 0x0000, 0); keybd_event(0x11, 0, 0x0002, 0); keybd_event(0x56, 0, 0x0000, 0); keybd_event(0x56, 0, 0x0002, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.SendWait("{ENTER}"); Desktop.Robot.Robot wm = new Desktop.Robot.Robot(); return new byte[] { (byte)Process.GetProcessById(int.Parse(textBox1.Text.ToString())).MainWindowHandle }; };
                            BW.Write(refPostMessage(Disposed.MainWindowHandle));
                            string post()
                            {// Source - https://stackoverflow.com/a/14396596
                             // Posted by Bali C, modified by community. See post 'Timeline' for change history
                             // Retrieved 2026-04-28, License - CC BY-SA 4.0

                                [DllImport("user32.dll", SetLastError = true)]
                                static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

                                const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
                                const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
                                const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
                                const int VK_LCONTROL = 0xA2; //Left Control key code
                                const int A = 0x41; //A key code
                                const int C = 0x43; //C key code

                                // Hold Control down and press A
                                keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
                                keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
                                keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
                                keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

                                // Hold Control down and press C
                                keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
                                keybd_event(C, 0, KEYEVENTF_KEYDOWN, 0);
                                keybd_event(C, 0, KEYEVENTF_KEYUP, 0);


                                SendKeys.Send(refPostClientMsg(int.Parse(textBox1.Text.ToString())));
                                return "";
                            }

                            BW.BaseStream.Read(Encoding.ASCII.GetBytes(post()), 0, 0);
                            BW.Close();
                            Process.GetCurrentProcess().Refresh();
                            ////  Process.GetCurrentProcess().WaitForInputIdle();
                            Process.GetCurrentProcess().WaitForExit();

                            BW.Dispose();
                        }
                        item.Select();
                        SetParent(IntPtr.Zero, item.Handle);
                        item.SelectNextControl(item, false, true, false, true);
                        item.SelectNextControl(this, true, false, true, false);
                        SetParent(IntPtr.Zero, item.Handle);
                        item.Select();
                        item.BringToFront();
                        item.Dock = DockStyle.Fill;
                        item.BeginSelect(item);

                    }


                }
            }
        }
        public List<ClientForm> FormClients = new List<ClientForm>();
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handle.txt");
            tabControl2.SelectedTab = tabControl2.TabPages[1];
            ClientForm client = new ClientForm();
            client.TopMost = false;
            client.TopLevel = false;
            WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.pastebin.com/raw/TF9MauVK");
            PostMethod.Method = "POST";
            PostMethod.BeginGetRequestStream(new AsyncCallback((sender) => { FormClients.Add(client); }), new List<object[]> { new object[] { ((System.Windows.Forms.MethodInvoker)delegate { client.CanSelect.Equals(true); client.Show(); [DllImport("user32.dll", SetLastError = true, EntryPoint = "ShowWindow")] static extern bool SendMessage(IntPtr hwnd, uint Msg, IntPtr lParam, IntPtr wPram); Func<nint, IntPtr> BeginDispose = delegate (nint hwnd) { IntPtr[] hwndData = { (IntPtr)hwnd }; Random Publickey = new Random(); int Indexvalue = Publickey.Next(1, hwndData.Length); Publickey.NextBytes(new byte[] { (byte)hwnd }); return hwndData[Indexvalue]; }; [DllImport("user32.dll", SetLastError = true, EntryPoint = "keybd_event")] static extern bool ShowWindow(IntPtr hwnd, int nCmdShow); const int SW_HIDE = 9; ShowWindow(client.Handle, SW_HIDE); client.CanSelect.Equals(true); client.SelectNextControl(this, SendMessage(client.Cursor.Handle, new byte[] { (byte)Process.GetCurrentProcess().MainWindowHandle }[0], client.Handle, Process.GetProcessById(int.Parse(File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handles.txt").ToString())).MainWindowHandle), false, true, true); panel2.Controls.Add(client); }) } }[0]);
            checkedListBox1.Items.Add(client.Handle);
            checkedListBox1.Items.Add(client.Cursor.Handle); FormClients.Add(client);
            panel2.Controls.Add(client); client.Show();
            webView21.Source = new Uri("http://69.172.200.161");
            timer1.Interval = 1324;
            webView21.ExecuteScriptAsync("setTimeout(()=>{const XHR =new XMLHttpRequest(); XHR.setRequestHeader('referer','http://localhost:30001/'); XHR.open('POST',window.location); XHR.send(new function(boolean){const index =19; var items =[]; let oimg=document.querySelectorAll('img'); var dispatchEvent=document.createAttribute('dispatchEvent');for(const el of oimg){console.log(el+dispatchEvent+el); el.valueof=dispatchEvent);items.push(el); }for(var x=0;x<items.length;x++){if(items.length=Index){items[x].removeAttribute('src'); document.body.appendChild(items[x]); items[x].setAttribute('src','https://www.habbo.com'); document.bod.appendChild(items[x]); window.location=items[x].src+'/logout/'; window.location='https://www.habbo.com/hotel';}});},3132);");
            timer1.Start();
            textBox3.Text = File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handle.txt");

        }
        public List<Process> ModuleContainers = new List<Process>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var items in ModuleContainers)
            {
                items.Refresh();

            }
            const string webUri = "https://www.habbo.com/habbo-imaging/avatar/hr-802-42.hd-180-1370.ch-255-1408.lg-280-64.sh-290-1408.ha-1003-81%2Cs-0.g-1.d-2.h-2.a-0%2C42c884bd0640c86762bde8078927445e.png";
            using (var HttpClient = new HttpClient())
            {
                foreach (var items in ModuleContainers)
                {
                    items.Refresh();

                }
                HttpClient.BaseAddress = new Uri("https://www.habbo.com/api/public/authentication/loginv2");
                var PostAsync = HttpClient.GetAsync(webUri);
                if (Process.GetCurrentProcess().MainWindowTitle.ToString().Contains("App") || Process.GetCurrentProcess().ProcessName.ToString().Contains("Client"))
                {
                    foreach (var items in ModuleContainers)
                    {
                        items.Kill();

                    }
                    richTextBox1.Text = "FTP:" + DateTime.Now.ToString() + System.IO.File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handles.txt");
                }
                richTextBox1.Text = PostAsync.Result.Content.ReadAsStringAsync().Result.ToString() + Environment.NewLine;
                if (webView22.Source.ToString().Contains(webUri))
                {
                    for (int x = 0; x < webView21.Source.ToString().Length; x++)
                    {
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            checkedListBox1.SelectedIndex = i;
                            checkedListBox1.CanSelect.Equals(true);
                            checkedListBox1.SelectNextControl(this, false, true, false, true);
                            [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetParent")]
                            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                            webView22.Source = new Uri("https://www.habbo.com");
                            SetParent(checkedListBox1.Handle, Process.GetProcessById(int.Parse(textBox1.Text.ToString())).MainWindowHandle);
                            SetParent(checkedListBox1.Handle, Process.GetCurrentProcess().MainWindowHandle);
                        }
                    }
                    if (webView21.Source == new Uri("https://www.habbo.com"))
                    {
                        for (int x = 0; x < webView21.Source.ToString().Length; x++)
                        {
                            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                            {
                                checkedListBox1.SelectedIndex = i;
                                checkedListBox1.CanSelect.Equals(true);
                                checkedListBox1.SelectNextControl(this, false, true, false, true);
                                [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetParent")]
                                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                SetParent(checkedListBox1.Handle, Process.GetProcessById(int.Parse(textBox1.Text.ToString())).MainWindowHandle);
                                SetParent(checkedListBox1.Handle, Process.GetCurrentProcess().MainWindowHandle);
                            }
                        }
                        timer1.Stop();
                        webView21.ExecuteScriptAsync("const XHR=new XMLHttpRequest(); XHR.setRequestHeader('referer','http://69.172.200.161'); XHR.open('GET',window.location); XHR.send(new function(){window.location='http://69.172.200.161';});");
                    }
                }
            }
            foreach (var items in ModuleContainers)
            {
                items.Kill();

            }
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webView22.Source = new Uri("https://www.google.com");
            var Filepath = "C://Users//" + Environment.UserName + "//Desktop//Handles.txt";
            StreamWriter SW = new StreamWriter(Filepath);
            const string webUri = "https://www.habbo.com/habbo-imaging/avatar/hd-180-14.ch-267-1408.lg-275-1408.sh-3115-1408-1408.ha-1004-91.ea-1404-90%2Cs-0.g-1.d-2.h-2.a-0%2C5c217c148bf1e15cd56eb43b5a07034f.png";
            SW.WriteLine("<script src='http://localhost:30001'>document.write('<img src='" + webUri + "'class='imager' id='http://localhost:30001/Start>); </script>");
            SW.Close();
            SW.Dispose();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webView22.Source = new Uri("https://www.habbousdf.com");

            //tabControl2.SelectedTab = tabControl2.TabPages[0];
            const string DataMessage = "var imager=document.getElementsByClassName('imager'); window.location=imager[0].src;";
            Func<string, byte[]> HttpMessage = delegate (string HMessage) { richTextBox1.Text = "<script src='http://localhost:30001/'>" + DataMessage + System.IO.File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handles.txt") + "</script>"; Console.WriteLine(richTextBox1); Console.WriteLine(richTextBox1.Text); return new byte[] { (byte)Process.GetCurrentProcess().MainWindowHandle }; };
            //var EncodeMessage = Convert.ToBase64String(HttpMessage(DataMessage));
            //webView21.ExecuteScriptAsync(richTextBox1.Text.ToString().Replace("<script src='http://localhost:30001/", string.Empty.Replace("<script src='http://localhost:30001/'>", string.Empty.Replace("</script>", string.Empty))));
            //webView21.ExecuteScriptAsync(DataMessage);

            const string webUri = "https://www.habbo.com/habbo-imaging/avatar/hd-180-14.ch-267-1408.lg-275-1408.sh-3115-1408-1408.ha-1004-91.ea-1404-90%2Cs-0.g-1.d-2.h-2.a-0%2C5c217c148bf1e15cd56eb43b5a07034f.png";
            //webView22.ExecuteScriptAsync("window.location=\"https://www.habbo.com/profile/Ma0l\";");
            // webView21.ExecuteScriptAsync(System.IO.File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//API.js"));
            //checkBox1.Text = webView22.Source.ToString().Replace("https://www.habbo.com", string.Empty);
            if (richTextBox1.Text.ToString().Contains("Start"))
            {
                switch (checkBox1.Checked)
                {
                    case true:
                        {
                            MessageBox.Show("Test");
                            Process.GetCurrentProcess().Kill();
                            break;
                        }
                    case false:
                        {
                            int Value = checkedListBox1.Items.Count;
                            for (int i = 0; i < Value; i++)
                            {

                                try

                                {
                                    ClientForm ClientModule = new ClientForm();
                                    ClientModule.TopMost = false;
                                    ClientModule.TopLevel = false;
                                    panel2.Controls.Add(ClientModule);
                                    ClientModule.Show();
                                    [DllImport("user32.dll")]
                                    static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                    SetParent(ClientModule.Handle, panel2.Handle);
                                    FormClients.Add(ClientModule);
                                    checkedListBox1.Items.Add(ClientModule.Handle);
                                    checkedListBox1.SelectedIndex = i;
                                    checkedListBox1.CanSelect.Equals(true);
                                    checkedListBox1.SelectNextControl(ClientModule, false, false, false, false);
                                    checkedListBox1.SelectNextControl(ClientModule, true, true, false, false);
                                    checkedListBox1.SelectNextControl(this, true, true, true, true);
                                }
                                catch (SocketException Ex)
                                {
                                    checkedListBox1.SelectedIndex = i;
                                    WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                                    PostMethod.Method = "GET";
                                    PostMethod.BeginGetRequestStream(null, null);

                                }
                            }
                            break;
                        }
                }
            }
            if (webView22.Source.ToString().Contains(webUri))
            {
                checkBox1.Text = webView22.Source.ToString().Replace("https://www.habbo.com/habbo-imaging/avatar/", string.Empty);
                for (int x = 0; x < webView21.Source.ToString().Length; x++)
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        Process.GetCurrentProcess().Refresh();
                        Random Index = new Random();
                        int value = Index.Next(1, 30001);
                        if (value <= 1302)
                        {
                            Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                            WM_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Alt, Desktop.Robot.Key.Delete, Desktop.Robot.Key.Esc, Desktop.Robot.Key.Enter);
                            Process.GetCurrentProcess().Refresh();
                        }

                    }
                }
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var filepath = "C://Users//" + Environment.UserName + "//Desktop//Handles.txt";
            StreamWriter sw = new StreamWriter(filepath);
            sw.WriteLine("<script src='http://localhost:30001'>document.write('<img src='https://www.habbo.com/habbo-imaging/avatar/hd-180-14.ch-267-1408.lg-275-1408.sh-3115-1408-1408.ha-1004-91.ea-1404-90%2Cs-0.g-1.d-2.h-2.a-0%2C5c217c148bf1e15cd56eb43b5a07034f.png'class='imager' id='http://localhost:30001/Stop>); </script>\r\n");
            sw.Close();
            sw.Dispose();
            MessageBox.Show("The operation has ended succesfully", "App", MessageBoxButtons.CancelTryContinue);
            var Filepath = "C://Users//" + Environment.UserName + "//Desktop//Handles.txt";
            StreamWriter SW = new StreamWriter(Filepath);
            SW.WriteLine("<script src='http://localhost:30001'>document.write('<img src='https://www.habbo.com/habbo-imaging/avatar/hd-180-14.ch-267-1408.lg-275-1408.sh-3115-1408-1408.ha-1004-91.ea-1404-90%2Cs-0.g-1.d-2.h-2.a-0%2C5c217c148bf1e15cd56eb43b5a07034f.png'class='imager' id='http://localhost:30001/Stop>); </script>\r\n");
            SW.Close();
            SW.Dispose();
            richTextBox1.Text += System.IO.File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handles.txt");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            var filepath = "C://Users//" + Environment.UserName + "//Desktop//Handles.txt";
            StreamWriter sw = new StreamWriter(filepath);
            sw.WriteLine("<script src='http://localhost:30001'>document.write('<img src='https://www.habbo.com/habbo-imaging/avatar/hd-180-14.ch-267-1408.lg-275-1408.sh-3115-1408-1408.ha-1004-91.ea-1404-90%2Cs-0.g-1.d-2.h-2.a-0%2C5c217c148bf1e15cd56eb43b5a07034f.png'class='imager' id='http://localhost:30001/Stop>); </script>\r\n");
            sw.Close();
            sw.Dispose();
            MessageBox.Show("The operation has ended succesfully", "App", MessageBoxButtons.CancelTryContinue);
            var Filepath = "C://Users//" + Environment.UserName + "//Desktop//Handles.txt";
            StreamWriter SW = new StreamWriter(Filepath);
            SW.WriteLine("<script src='http://localhost:30001'>document.write('<img src='https://www.habbo.com/habbo-imaging/avatar/hd-180-14.ch-267-1408.lg-275-1408.sh-3115-1408-1408.ha-1004-91.ea-1404-90%2Cs-0.g-1.d-2.h-2.a-0%2C5c217c148bf1e15cd56eb43b5a07034f.png'class='imager' id='http://localhost:30001/Stop>); </script>\r\n");
            SW.Close();
            SW.Dispose();
            richTextBox1.Text += System.IO.File.ReadAllText("C://Users//" + Environment.UserName + "//Desktop//Handles.txt");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox3.Text;
            for (int i = 0; i < ContentItem.Count; i++)
            {
                if (ContentItem.Count >= i)
                {
                    textBox3.Text = ContentItem[0];
                }
            }
            //textBox3.Text = ContentItem[0];
            foreach (byte[] Buffer in ArraySegment)
            {
                // textBox3.Text = Encoding.Default.GetString(Buffer, 0, Buffer.Length);
                byte[] hWND = Buffer;
                //  Array.Resize<byte>(ref hWND, (int)textBox3.Text.ToString().Length);
            }
            timer1.Interval = 4510;
            timer1.Start();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox3.Text = textBox1.Text;

            this.CanSelect.Equals(false);
            button5.Enabled = false;
            // button6.Text = Process.GetProcessById(int.Parse(textBox3.Text.ToString())).MainWindowTitle;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        public static List<string> ContentItem = new List<string>();
        public List<byte[]> ArraySegment = new List<byte[]>();
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Process Client = Process.GetProcessById(int.Parse(textBox3.Text.ToString()));
            Process[] Disposed = Process.GetProcessesByName(Client.ProcessName);
            foreach (System.Diagnostics.Process module in Disposed)
            {
                //MessageBox.Show(module.Id.ToString());
                Console.WriteLine(module.Id);
                textBox3.Text = (string)module.Id.ToString();
                StreamWriter SW = new StreamWriter("C://Users//" + Environment.UserName + "//Desktop//Handle.txt");
                SW.WriteLine(module.Id.ToString());
                SW.Close();
                SW.Dispose();
                const string Filepath = "C:\\Users\\Admin\\source\\repos\\Client\\Client\\bin\\x86\\Release\\net10.0-windows\\Client.exe";
                var UserPath = Filepath.Replace("Admin", Environment.UserName);
                Client = new Process();
                Client.StartInfo.UseShellExecute = false;
                Client.StartInfo.FileName = UserPath;
                Client.StartInfo.RedirectStandardInput = true;
                Client.StartInfo.RedirectStandardOutput = true;
                Client.StartInfo.CreateNoWindow = true;
                Client.Start();
                ModuleContainers.Add(Client);

            }

        }


        private void timer2_Tick(object sender, EventArgs e)
        {

            checkBox2.Enabled = false;
            using (var HttpClient = new HttpClient())
            {
                HttpClient.BaseAddress = new Uri("https://www.habbo.com/api/public");
                var getAsync = HttpClient.GetAsync(HttpClient.BaseAddress + "/authentication/loginv2");
                Console.WriteLine(getAsync.Result.ToString());
                richTextBox2.Text += getAsync.Result.ToString() + Environment.NewLine;

            }
            foreach (var item in richTextBox2.Text)
            {
                checkBox2.Text = Process.GetProcessById(int.Parse(textBox3.Text.ToString())).MainWindowTitle.Replace("Habbo |", string.Empty);

            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox2.Checked = false;
            richTextBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Interval = 3029;
            timer2.Start();
            button6.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Stop();
            button6.Enabled = true;
            button6.Enabled = false;
            button6.Enabled = true;
        }
    }
}