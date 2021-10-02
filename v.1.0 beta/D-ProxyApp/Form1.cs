using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_ProxyApp
{
    public partial class MainFrm : Form
    {
        public string countre = "";
        RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

        public MainFrm()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
            notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);

        }
        private void setBestBtn_Click(object sender, EventArgs e)
        {
            bool rd;

            rd = setProxy(countre);
            if (rd)
            {
                setBestBtn.BackColor = Color.PaleGreen;
                setBestBtn.Text = "Подключено. Нажмите чтобы переподключится";
            }
            else
            {
                setBestBtn.BackColor = Color.Tomato;
                setBestBtn.Text = "НЕ Подключено! Попробуйте убрать/изменить код страны и нажмите чтобы переподключится";
            }

        }

        private bool setProxy(string country = "")
        {
            string q = API.Connect("http://proxyscan.io/api/proxy", "format=txt&uptime=100&ping=20&type=socks4,socks5&country=" + country);
            if (q == "")
            {
                q = "" + API.Connect("http://proxyscan.io/api/proxy", "format=txt&uptime=50&ping=200&type=socks4,socks5&country=" + country);
            }
            if (q == "")
            {
                q = "" + API.Connect("http://proxyscan.io/api/proxy", "format=txt&uptime=100&ping=100&type=socks4,socks5&country=" + country);
            }
            if (q == "")
            {
                q = "" + API.Connect("http://proxyscan.io/api/proxy", "format=txt&type=socks4,socks5&country=" + country);
            }
            if (q != "")
            {
        
                registry.SetValue("ProxyEnable", 1);
                registry.SetValue("ProxyServer", $"socks={q}");
                Thread thread = new Thread(new ThreadStart(Check));
                thread.Start();
                return true;
            }
            else
            {
        
                registry.SetValue("ProxyEnable", 0);
                registry.SetValue("ProxyServer", "");
                return false;
            }
        }

        private void setMyProxy()
        {
    
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", proxy.Text);
        }

        private void Check()
        {
            while (true)
            {
                try
                {
                    API.Connect("https://icanhazip.com/");
                    API.Connect("http://icanhazip.com/");
                }
                catch
                {
                    setProxy(countre);
                    break;
                }
                Thread.Sleep(1000);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
    
            registry.SetValue("ProxyEnable", 0);
            setBestBtn.BackColor = Color.Transparent;
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
    
            registry.SetValue("ProxyEnable", 0);
            setBestBtn.Text = "Лучший выбор (Автоматическая проверка и замена прокси)";
            Size = new Size(277, 360);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label2.Text = "   ";
            Size = new Size(277, 360);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            button1.Visible = false;
            proxy.Visible = false;
            label2.Text = "Страна(Из двух букв например \n ru / kz / us. \nТак же можно через запятую\n(без пробелов), \nНапример: ru, kz, us)";
            Size = new Size(277, 470);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        private void trayBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            ShowInTaskbar = true;
            Visible = true;
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "Введите прокси: ";
            button1.Visible = true;
            proxy.Visible = true;
            Size = new Size(277, 446);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "   ";
            button1.Visible = false;
            proxy.Visible = false;
            Size = new Size(277, 360);
            setMyProxy();
            setBestBtn.BackColor = Color.LightSteelBlue;
            setBestBtn.Text = "Подключено к вашему прокси\n\n(Нажмите чтобы подключиться к автообновляемому прокси.)";
        }

        internal void textBox1_TextChanged(object sender, EventArgs e)
        {
            countre = textBox1.Text.ToString();
        }

        private void SetExBtn_Click(object sender, EventArgs e)
        {
            Size = new Size(390, 360);
        }

        private void exEdt_Leave(object sender, EventArgs e)
        {
            registry.SetValue("ProxyOverride", $"*.proxyscan.io;{exEdt.Text}");
            Size = new Size(277, 360);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "http://github.com/DIMNISSV";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
