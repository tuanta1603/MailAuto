using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using OpenQA.Selenium.Chrome;

namespace MailImport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] listFristName = null;
        string[] listLastName = null;
        string[] listUserAgent = null;
        string[] listSock = null;

        private string filePath = ""; // Khai báo biến filePath ở mức lớp để sử dụng trong toàn bộ class.

        private string[] ImportDataFromTxtFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName; // Gán đường dẫn vào biến filePath

                // Đọc nội dung tệp tin .txt
                string[] lines = File.ReadAllLines(filePath);

                return lines; // Trả về nội dung tệp tin là một mảng string
            }

            return null; // Trả về null nếu không chọn tệp hoặc có lỗi trong việc mở tệp.
        }

        private void btnFristName_Click(object sender, EventArgs e)
        {
            listFristName = ImportDataFromTxtFile();

            txtFristName.Text = filePath;
        }

        private void btnLastName_Click(object sender, EventArgs e)
        {
            listLastName = ImportDataFromTxtFile();

            txtLastName.Text = filePath;
        }

        private void btnUserAgentImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Đọc nội dung tệp tin .txt
                listUserAgent = File.ReadAllLines(filePath);

                // Hiển thị nội dung lên lstUserAgent
                lstUserAgent.Items.Clear(); // Xóa dữ liệu hiện có trong lstUserAgent
                lstUserAgent.Items.AddRange(listUserAgent); // Thêm nội dung từ tệp tin vào lstUserAgent
            }

        }

        private void lstUserAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSockImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Đọc nội dung tệp tin .txt
                listSock = File.ReadAllLines(filePath);

                // Hiển thị nội dung lên lstSock
                lstSock.Items.Clear(); // Xóa dữ liệu hiện có trong lstSock
                lstSock.Items.AddRange(listSock); // Thêm nội dung từ tệp tin vào lstSock
            }
        }

        private void lstSock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class DataEntry
        {
            public string Sock { get; set; }
            public string FristName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PassWord { get; set; }
            public string UserAgent { get; set; }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<DataEntry> dataEntries = new List<DataEntry>();

            List<int> arrayLengths = new List<int>
                {
                    listSock.Length,
                    listFristName.Length,
                    listLastName.Length,
                    listUserAgent.Length
                };

            int maxArrayLength = arrayLengths.Max(); // Tìm độ dài tối đa trong danh sách chiều dài mảng

            for (int i = 0; i < maxArrayLength; i++)
            {
                DataEntry entry = new DataEntry();
                if (i < listSock.Length)
                {
                    entry.Sock = listSock[i];
                }

                if (i < listFristName.Length)
                {
                    entry.FristName = listFristName[i];
                }

                if (i < listLastName.Length)
                {
                    entry.LastName = listLastName[i];
                }
                if(i < listFristName.Length && i < listLastName.Length)
                {
                    entry.Email = listFristName[i] + listLastName[i]+ GetCurrentTime();
                    entry.PassWord = GenerateRandomPassword(10);
                }    
                if (i < listUserAgent.Length)
                {
                    entry.UserAgent = listUserAgent[i];
                }

                dataEntries.Add(entry);
            }
            RegisterChromeAccounts(dataEntries);
            dgvData.DataSource = dataEntries;
        }

        static string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";

            using (var rng = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                var password = new StringBuilder(length);

                foreach (var byteValue in randomBytes)
                {
                    password.Append(validChars[byteValue % validChars.Length]);
                }

                return password.ToString();
            }
        }

        static string GetCurrentTime()
        {
            DateTime now = DateTime.Now;
            string time = now.ToString("HHmmssffff");
            return time;
        }

        public void RegisterChromeAccounts(List<DataEntry> dataEntries)
        {
            foreach (var entry in dataEntries)
            {
                if (!IsSocks5ProxyAlive(entry.Sock))
                {
                    ChromeOptions options = new ChromeOptions(); ;
                    options.AddArgument("--disable-blink-features=AutomationControlled");
                    options.AddArguments("--disable-blink-features=AutomationControlled");
                    options.AddArgument("--disable-blink-features");
                    options.AddArgument("--disable-automation");
                    // ... (các thiết lập khác)
                    // Set the user agent for this iteration
                    Random rnd = new Random();
                    int r = rnd.Next(listUserAgent.Length);
                    options.AddArgument($"--user-agent={listUserAgent[r]}");
                    //options.AddArgument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                    options.AddArguments("--incognito");
                    Proxy proxy = new Proxy();
                    proxy.Kind = ProxyKind.Manual;
                    proxy.IsAutoDetect = false;
                    proxy.HttpProxy =
                    proxy.SslProxy = entry.Sock;
                    //options.Proxy = proxy;
                    options.AddArgument("ignore-certificate-errors");
                    // Set SOCKS proxy
                    //options.AddArguments("--headless");
                    //options.AddArgument($"--proxy-server=socks5://{entry.Sock}");

                    //FirefoxProfile firefoxProfile = new FirefoxProfile();
                    //firefoxProfile.SetPreference("media.peerconnection.enabled", false);
                    //firefoxProfile.SetPreference("network.proxy.type", 1);
                    //// điền vào IP của proxy
                    //firefoxProfile.SetPreference("network.proxy.http", "43.152.112.135");
                    //// điền vào port
                    //firefoxProfile.SetPreference("network.proxy.http_port", 10777);
                    //firefoxProfile.SetPreference("network.proxy.ssl", "43.152.112.135");
                    //firefoxProfile.SetPreference("network.proxy.ssl_port", 10777);
                    // Add the argument to open Google directly
                    //options.AddArgument("https://www.google.com");

                    // Set the proxy options
                    //options.Proxy = proxy;

                    using (var driver = new ChromeDriver(options))
                    {
                        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                        jsExecutor.ExecuteScript($"window.location.href = 'https://www.google.com';");
                        // Điền thông tin tài khoản
                        System.Threading.Thread.Sleep(3000); // Wait for 3 seconds
                        driver.FindElement(By.XPath("//a[text()='Gmail']")).Click();
                        driver.FindElement(By.XPath("//span[@class='laptop-desktop-only']")).Click();
                        //driver.FindElement(By.XPath("//*[contains(@class, 'laptop-desktop-only')]")).Click();
                        System.Threading.Thread.Sleep(3000); // Wait for 3 seconds
                        driver.FindElement(By.XPath("//input[@id='firstName']")).SendKeys(entry.FristName);
                        driver.FindElement(By.XPath("//input[@id='lastName']")).SendKeys(entry.LastName);
                        driver.FindElement(By.XPath("//div[@id='collectNameNext']")).Click();
                        System.Threading.Thread.Sleep(3000); // Wait for 3 seconds
                        driver.FindElement(By.XPath("//input[@id='day']")).SendKeys("16");
                        driver.FindElement(By.XPath("//select[@id='month']")).SendKeys("Tháng 3");
                        driver.FindElement(By.XPath("//input[@id='year']")).SendKeys("1995");
                        driver.FindElement(By.XPath("//select[@id='gender']")).SendKeys("Nam");
                        driver.FindElement(By.XPath("//div[@id='birthdaygenderNext']")).Click();
                        System.Threading.Thread.Sleep(3000); // Wait for 3 seconds
                        driver.FindElement(By.XPath("//input[@name='Username']")).SendKeys(entry.Email);
                        System.Threading.Thread.Sleep(3000); // Wait for 3 seconds

                        driver.FindElement(By.XPath("//div[@id='next']")).Click();
                        System.Threading.Thread.Sleep(3000); // Wait for 3 seconds
                        driver.FindElement(By.XPath("//input[@name='Passwd']")).SendKeys(entry.PassWord);
                        driver.FindElement(By.XPath("//input[@name='PasswdAgain']")).SendKeys(entry.PassWord);
                        System.Threading.Thread.Sleep(3000); // Wait for 3 seconds

                        driver.FindElement(By.XPath("//div[@id='createpasswordNext']")).Click();
                        System.Threading.Thread.Sleep(3000); // Wait for 3 seconds
                        driver.FindElement(By.XPath("//div[@id='next']")).Click();


                        // Bấm nút Đăng ký
                        //driver.FindElement(By.Id("accountDetailsNext")).Click();

                        // Do thêm các bước cần thiết cho đăng ký tài khoản ở đây, chẳng hạn như xác minh số điện thoại, ...

                        // Sau khi hoàn thành đăng ký tài khoản, bạn có thể thực hiện các công việc khác, chẳng hạn như lưu thông tin tài khoản vào cơ sở dữ liệu.

                        // Đóng trình duyệt sau khi hoàn thành mỗi lần đăng ký
                        driver.Quit();
                    }
                
                }
            }
        }
        public static bool IsSocks5ProxyAlive(string sockProxy)
        {
            try
            {
                string[] parts = sockProxy.Split(':');
                string proxyHost = parts[0];
                int proxyPort = int.Parse(parts[1]);

                using (TcpClient tcpClient = new TcpClient())
                {
                    var cts = new CancellationTokenSource(TimeSpan.FromSeconds(20));

                    // Connect to the SOCKS5 proxy with timeout
                    tcpClient.ConnectAsync(proxyHost, proxyPort).Wait(cts.Token);

                    // Send a simple SOCKS5 authentication request
                    NetworkStream networkStream = tcpClient.GetStream();
                    byte[] request = { 0x05, 0x01, 0x00 };
                    networkStream.Write(request, 0, request.Length);

                    // Receive the response
                    byte[] response = new byte[2];
                    networkStream.Read(response, 0, response.Length);

                    // Check if the response indicates success
                    if (response[0] == 0x05 && response[1] == 0x00)
                    {
                        // SOCKS5 proxy is alive
                        return true;
                    }

                    // SOCKS5 proxy is not alive
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log it
                return false;
            }
        }

    }
}
