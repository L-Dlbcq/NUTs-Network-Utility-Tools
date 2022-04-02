using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;



namespace NUTs
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            nuts_menu.Renderer = new ToolStripProfessionalRenderer(new LightColorTable());
            switchtoen_btn.Enabled = false;
            lTheme_btn.Enabled = false;
        }
        #region Themes
        private void apply_dTheme(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepPurple700, TextShade.WHITE);
            nuts_menu.Renderer = new ToolStripProfessionalRenderer(new DarkColorTable());
            dTheme_btn.ForeColor = Color.White;
            dTheme_btn.Enabled = false;
            lTheme_btn.ForeColor = Color.White;
            lTheme_btn.Enabled = true;
            switchtoen_btn.ForeColor = Color.White;
            switchtofr_btn.ForeColor = Color.White;
        }

        private void apply_lTheme(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            nuts_menu.Renderer = new ToolStripProfessionalRenderer(new LightColorTable());
            dTheme_btn.ForeColor = Color.Black;
            dTheme_btn.Enabled = true;
            lTheme_btn.ForeColor = Color.Black;
            lTheme_btn.Enabled = false;
            switchtoen_btn.ForeColor = Color.Black;
            switchtofr_btn.ForeColor = Color.Black;
        }
        #endregion

        #region Languages
        private void chng_FR(object sender, EventArgs e)
        {
            this.Text = "NUTs - un utilitaire réseau";
            themes_menuItem.Text = "Thèmes";
            dTheme_btn.Text = "Appliquer thème sombre";
            lTheme_btn.Text = "Appliquer thème clair";
            languages_menuItem.Text = "Langue";
            switchtofr_btn.Text = "Passer en français";
            switchtoen_btn.Text = "Passer en anglais";
            switchtofr_btn.Enabled = false;
            switchtoen_btn.Enabled = true;
            netsettings_tabCtrl.Text = "Vos informations réseau";
            changenetsettings_tabCtrl.Text = "Changer vos paramètres réseau";
            ip_RichTxtBx1.Text = "Adresse IP";
            ip_RichTxtBx2.Text = "Adresse IP";
            subnetmask_RichTxtBx1.Text = "Masque de sous réseau";
            subnetmask_RichTxtBx2.Text = "Masque de sous réseau";
            defgateway_RichTxtBx1.Text = "Passerelle par défaut";
            defgateway_RichTxtBx2.Text = "Passerelle par défaut";
            primdns_RichTxtBx1.Text = "Adresse DNS primaire";
            primdns_RichTxtBx2.Text = "Adresse DNS primaire";
            secdns_RichTxtBx1.Text = "Adresse DNS secondaire";
            secdns_RichTxtBx2.Text = "Adresse DNS secondaire";
            retrieve_btn.Text = "RECUPERER INFOS";
            static_btn.Text = "APPLIQUER PARAMETRES STATIQUE";
            dhcp_btn.Text = "APPLIQUER PARAMETRES DYNAMIQUE";
            ip_TxtBx1.Text = "";
            subnetmask_TxtBx1.Text = "";
            defgateway_TxtBx1.Text = "";
            primdns_TxtBx1.Text = "";
            secdns_TxtBx1.Text = "";
        }

        private void chng_EN(object sender, EventArgs e)
        {
            this.Text = "NUTs - a network utility tool";
            themes_menuItem.Text = "Themes";
            dTheme_btn.Text = "Apply Dark theme";
            lTheme_btn.Text = "Apply Light theme";
            languages_menuItem.Text = "Languages";
            switchtofr_btn.Text = "Switch to french";
            switchtoen_btn.Text = "Switch to englishs";
            switchtofr_btn.Enabled = true;
            switchtoen_btn.Enabled = false;
            netsettings_tabCtrl.Text = "Ypur network settings";
            changenetsettings_tabCtrl.Text = "Change your network settings";
            ip_RichTxtBx1.Text = "IP Address";
            ip_RichTxtBx2.Text = "IP Address";
            subnetmask_RichTxtBx1.Text = "Subnet mask";
            subnetmask_RichTxtBx2.Text = "Subnet mask";
            defgateway_RichTxtBx1.Text = "Default gateway";
            defgateway_RichTxtBx2.Text = "Default gateway";
            primdns_RichTxtBx1.Text = "Primary DNS address";
            primdns_RichTxtBx2.Text = "Primary DNS adress";
            secdns_RichTxtBx1.Text = "Secondary DNS address";
            secdns_RichTxtBx2.Text = "Secondary DNS address";
            retrieve_btn.Text = "RETRIEVE NETWORK SETTINGS";
            static_btn.Text = "SET STATIC SETTINGS";
            dhcp_btn.Text = "SET DYNAMIC SETTINGS";
            ip_TxtBx1.Text = "";
            subnetmask_TxtBx1.Text = "";
            defgateway_TxtBx1.Text = "";
            primdns_TxtBx1.Text = "";
            secdns_TxtBx1.Text = "";
        }
        #endregion

        #region TabControl
        private void retrieve_Infos(object sender, EventArgs e)
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adapter.Name.Equals("Ethernet") || adapter.Name.Equals("Wi-Fi"))
                {
                    if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && adapter.OperationalStatus == OperationalStatus.Up || adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                ip_TxtBx1.Text = (ip.Address.ToString());
                                subnetmask_TxtBx1.Text = (ip.IPv4Mask.ToString());
                            }
                        }
                        foreach (GatewayIPAddressInformation defgateway in adapter.GetIPProperties().GatewayAddresses)
                        {
                            defgateway_TxtBx1.Text = (defgateway.Address.ToString());
                        }
                    }
                }
            }
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adapter.Name.Equals("Ethernet") || adapter.Name.Equals("Wi-Fi"))
                {
                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                    IPAddressCollection dnsServers = adapterProperties.DnsAddresses;

                    if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && adapter.OperationalStatus == OperationalStatus.Up || adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                        {
                            if (dnsServers.Count > 0 && ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                foreach (IPAddress dns in dnsServers)
                                {
                                    primdns_TxtBx1.Text = dnsServers[0].ToString();
                                    secdns_TxtBx1.Text = dnsServers[1].ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void set_StaticParams(object sender, EventArgs e)
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adapter.Name.Equals("Ethernet") || adapter.Name.Equals("Wi-Fi"))
                {
                    if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                        psi.UseShellExecute = true;
                        psi.WindowStyle = ProcessWindowStyle.Hidden;
                        psi.Verb = "runas";
                        psi.Arguments = ("/c netsh interface ip set address " + adapter.Name + " static " + ip_TxtBx2.Text + " " + subnetmask_TxtBx2.Text + " " + defgateway_TxtBx2.Text + " & netsh interface ip set dns " + adapter.Name + " static " + primdns_TxtBx2.Text + "& netsh interface ip add dns " + adapter.Name + secdns_TxtBx2 + "index=2");
                        Process.Start(psi);
                    }
                    else if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                        psi.UseShellExecute = true;
                        psi.WindowStyle = ProcessWindowStyle.Hidden;
                        psi.Verb = "runas";
                        psi.Arguments = ("/c netsh interface ip set address " + adapter.Name + " static " + ip_TxtBx2.Text + " " + subnetmask_TxtBx2.Text + " " + defgateway_TxtBx2.Text + " & netsh interface ip set dns " + adapter.Name + " static " + primdns_TxtBx2.Text + "& netsh interface ip add dns " + adapter.Name + secdns_TxtBx2 + "index=2");
                        Process.Start(psi);
                    }
                }
            }
            ip_TxtBx2.Clear();
            subnetmask_TxtBx2.Clear();
            defgateway_TxtBx2.Clear();
            primdns_TxtBx2.Clear();
            secdns_TxtBx2.Clear();
        }

        private void set_DynamicParams(object sender, EventArgs e)
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adapter.Name.Equals("Ethernet") || adapter.Name.Equals("Wi-Fi"))
                {
                    if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                        psi.UseShellExecute = true;
                        psi.WindowStyle = ProcessWindowStyle.Hidden;
                        psi.Verb = "runas";
                        psi.Arguments = ("/c netsh interface ip set address " + adapter.Name + " dhcp " + " & netsh interface ip set dns " + adapter.Name + " dhcp ");
                        Process.Start(psi);
                    }
                    else if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                        psi.UseShellExecute = true;
                        psi.WindowStyle = ProcessWindowStyle.Hidden;
                        psi.Verb = "runas";
                        psi.Arguments = ("/c netsh interface ip set address " + adapter.Name + " dhcp " + " & netsh interface ip set dns " + adapter.Name + " dhcp ");
                        Process.Start(psi);
                    }
                }
            }
        }
        #endregion

        #region ColorTables
        public class DarkColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuStripGradientBegin
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }
        }
        public class LightColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuStripGradientBegin
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.White;
                }
            }
        }
        #endregion
    }
}