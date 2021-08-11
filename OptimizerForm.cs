using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsOptimizer
{
    public partial class OptimizerForm : System.Windows.Forms.Form
    {
        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        private readonly WebClient webClient = new WebClient();
        public OptimizerForm()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        // For Extracting Files..
        private static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                w.Write(r.ReadBytes((int)s.Length));
            }
        }
        // For Extracting Files..

        // PowerShell
        private void Debloat()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\WindowsDebloater.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\" -Sysprep -Debloat -Privacy",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void DarkMode()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Dark_Mode.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void LightMode()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Light_Mode.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Uninstall_OneDrive_()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Uninstall_OneDrive.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Unpin_Start_Menu_Tiles()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Unpin_Start_Menu_Tiles.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Disable_Background_Apps()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Disable_Background_Apps.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Enable_Background_Apps()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Enable_Background_Apps.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Disable_Cortana_()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Disable_Cortana.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Enable_Cortana_()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Enable_Cortana.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Reduced_FX()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Visual_FX.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void ProtectPrivacy()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Protect_Privacy.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void EdgePDFEnable()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\EnableEdgePDF.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void EdgePDFDisable()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\DisableEdgePDF.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void NETInstall()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\NETInstall.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void WinUpdateOnlySecurity()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\WinDefenderSecUpdates.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void WinUpdateDefaults()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\WinUpdateDefault.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Auto_Hide_TaskBar()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Auto_Hide_Taskbar.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Disable_Auto_Hide_TaskBar()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Disable_Auto_Hide_Taskbar.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Fullscreen_Taskbar()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Fullscreen_TaskBar.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void Disable_Fullscreen_Taskbar()
        {
            string sPath = Path.GetTempPath(); //getting temp's path
            string path = @"\Gorkido_Stuff\Debloat_Stuff\Disable_Fullscreen_TaskBar.ps1";
            string ps1File = sPath + path;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }
        // PowerShell

        private void Debloat_Windows_MouseDown(object sender, MouseEventArgs e)
        {
            DragLabel.Focus();
            Debloat();
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                string sPath = Path.GetTempPath(); //getting temp's path
                string dir2 = @"\Gorkido_Stuff\Debloat_Stuff";
                File.Delete(sPath + @"\Gorkido_Stuff\Debloat.zip");// Deleting Debloat.zip.
                Directory.Delete(sPath + dir2, true);// Deleting %temp%\Gorkido_Stuff\Debloat_Stuff
                Thread.Sleep(1000);
                Application.Exit();// Exit from the application.
            }
        }

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Black;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Black;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Gray;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Red;
        }

        private void Main_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            DragLabel.Focus();
        }

        private void DragLabeluseless_MouseDown(object sender, MouseEventArgs e)
        {
            DragLabel.Focus();
        }

        private void OptimizerForm_Load(object sender, EventArgs e)
        {
            Application_Installation_Panel.Hide();
            Others_Menu.Hide();
        }

        private void OptimizerFormXD_Shown(object sender, EventArgs e)
        {
            Main_Panel.Focus();
            string dir = @"\Gorkido_Stuff";
            string sPath = Path.GetTempPath(); //getting temp's path
            string dir2 = @"\Gorkido_Stuff\Debloat_Stuff";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir2); //if \Gorkido_Stuff doesn't exist it'll create the folder
            }
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Stuff doesn't exist it'll create the folder
            }
            Extract("WindowsOptimizer", sPath + dir, "Resources", "Debloat.zip"); // Extracting "Debloat.zip" (Extracting the zip itself.)
            Thread.Sleep(1000);
            string zipPath = @"\Gorkido_Stuff\Debloat.zip";
            string extractPath = @"\Gorkido_Stuff\Debloat_Stuff\";
            Directory.Delete(sPath + dir2, true);
            Thread.Sleep(1500);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir2); //if \\Gorkido_Stuff\Debloat_Stuff doesn't exist it'll create the folder
            }
            Thread.Sleep(500);
            System.IO.Compression.ZipFile.ExtractToDirectory(sPath + zipPath, sPath + extractPath);
        }

        private void Dark_Mode_MouseDown(object sender, MouseEventArgs e)
        {
            DarkMode();
        }

        private void Light_Mode_MouseDown(object sender, MouseEventArgs e)
        {
            LightMode();
        }

        private void Uninstall_OneDrive_MouseDown(object sender, MouseEventArgs e)
        {
            Uninstall_OneDrive_();
        }

        private void Unpin_Start_Menu_Tile_MouseDown(object sender, MouseEventArgs e)
        {
            Unpin_Start_Menu_Tiles();
        }

        private void Disable_Back_Apps_MouseDown(object sender, MouseEventArgs e)
        {
            Disable_Background_Apps();
        }

        private void Enable_Back_Apps_MouseDown(object sender, MouseEventArgs e)
        {
            Enable_Background_Apps();
        }

        private void Disable_Cortana_MouseDown(object sender, MouseEventArgs e)
        {
            Disable_Cortana_();
        }

        private void Enable_Cortana_MouseDown(object sender, MouseEventArgs e)
        {
            Enable_Cortana_();
        }

        private void Reduced_Visual_MouseDown(object sender, MouseEventArgs e)
        {
            Reduced_FX();
        }

        private void Privacy_Protection_MouseDown(object sender, MouseEventArgs e)
        {
            ProtectPrivacy();
        }

        private void Enable_Edge_PDF_MouseDown(object sender, MouseEventArgs e)
        {
            EdgePDFEnable();
        }

        private void Disable_Edge_PDF_MouseDown(object sender, MouseEventArgs e)
        {
            EdgePDFDisable();
        }

        private void Install_NET_MouseDown(object sender, MouseEventArgs e)
        {
            NETInstall();
        }

        private void WinDefenderSecUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            WinUpdateOnlySecurity();
        }

        private void WinDefaultUpdates_MouseDown(object sender, MouseEventArgs e)
        {
            WinUpdateDefaults();
        }

        private void Other_MouseDown(object sender, MouseEventArgs e)
        {
            Others_Menu.Show();
            //
            Main_Panel.Hide();
        }

        private void Others_Text_MouseDown(object sender, MouseEventArgs e)
        {
            Others_Menu.Hide();
            //
            Main_Panel.Show();

        }

        private void Others_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            DragLabel.Focus();
        }

        private void AutoTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            Auto_Hide_TaskBar();
        }

        private void DisAutoHideTaskbar_MouseDown(object sender, MouseEventArgs e)
        {
            Disable_Auto_Hide_TaskBar();
        }

        private void FullScreenTaskbar_MouseDown(object sender, MouseEventArgs e)
        {
            Fullscreen_Taskbar();
        }

        private void DisableFullScreenTaskbar_MouseDown(object sender, MouseEventArgs e)
        {
            Disable_Fullscreen_Taskbar();
        }

        private void Brave_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://laptop-updates.brave.com/latest/winx64", (sPath + dir + @"\BraveBrowserSetup.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Brave Browser?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\BraveBrowserSetup.exe"));// If user clicks "yes" then it will open "BraveBrowserSetup.exe".
            }
        }

        private void Libre_Office_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://www.libreoffice.org/donate/dl/win-x86_64/7.1.5/en-US/LibreOffice_7.1.5_Win_x64.msi", (sPath + dir + @"\LibreOffice_7.1.5_Win_x64.msi"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Libre Office?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\LibreOffice_7.1.5_Win_x64.msi"));// If user clicks "yes" then it will open "LibreOffice_7.1.5_Win_x64.msi".
            }
        }

        private void AdobeReader_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://admdownload.adobe.com/bin/live/readerdc_en_xa_crd_install.exe", (sPath + dir + @"\readerdc_en_xa_crd_install.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Adobe Reader?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\readerdc_en_xa_crd_install.exe"));// If user clicks "yes" then it will open "readerdc_en_xa_crd_install.exe".
            }
        }

        private void ImageGlass_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://github-releases.githubusercontent.com/7377936/81429300-b72c-11eb-9a43-524447a7477d?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAIWNJYAX4CSVEH53A%2F20210808%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20210808T111648Z&X-Amz-Expires=300&X-Amz-Signature=39bcf68dfe84fc80f4a5821ea17f1065821f0d99755b1078a4b3e948f25b874f&X-Amz-SignedHeaders=host&actor_id=0&key_id=0&repo_id=7377936&response-content-disposition=attachment%3B%20filename%3DImageGlass_8.2.6.6_x64.msi&response-content-type=application%2Foctet-stream", (sPath + dir + @"\ImageGlass_8.2.6.6_x64.msi"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Image Glass?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\ImageGlass_8.2.6.6_x64.msi"));// If user clicks "yes" then it will open "ImageGlass_8.2.6.6_x64.msi".
            }
        }

        private void Firefox_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://download.mozilla.org/?product=firefox-stub&os=win&lang=en-US", (sPath + dir + @"\Firefox Installer.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Firefox Browser?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\Firefox Installer.exe"));// If user clicks "yes" then it will open "Firefox Installer.exe".
            }
        }

        private void VLC_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://mirrors.netix.net/vlc/vlc/3.0.16/win64/vlc-3.0.16-win64.exe", (sPath + dir + @"\vlc-3.0.16-win64.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install VLC?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\vlc-3.0.16-win64.exe"));// If user clicks "yes" then it will open "vlc-3.0.16-win64.exe".
            }
        }

        private void Zip_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://www.7-zip.org/a/7z1900-x64.exe", (sPath + dir + @"\7z1900-x64.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install 7-Zip?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\7z1900-x64.exe"));// If user clicks "yes" then it will open "7z1900-x64.exe".
            }
        }

        private void VsCodium_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://github.com/VSCodium/vscodium/releases/download/1.59.0/VSCodiumSetup-x64-1.59.0.exe", (sPath + dir + @"\VSCodiumSetup-x64-1.59.0.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install VsCodium?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\VSCodiumSetup-x64-1.59.0.exe"));// If user clicks "yes" then it will open "VSCodiumSetup-x64-1.59.0.exe".
            }
        }

        private void Powertoys_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://github.com/microsoft/PowerToys/releases/download/v0.43.0/PowerToysSetup-0.43.0-x64.exe", (sPath + dir + @"\PowerToysSetup-0.43.0-x64.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Powertoys?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\PowerToysSetup-0.43.0-x64.exe"));// If user clicks "yes" then it will open "PowerToysSetup-0.43.0-x64.exe".
            }
        }

        private void Gimp_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://download.gimp.org/mirror/pub/gimp/v2.10/windows/gimp-2.10.24-setup-3.exe", (sPath + dir + @"\gimp-2.10.24-setup-3.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Gimp?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\gimp-2.10.24-setup-3.exe"));// If user clicks "yes" then it will open "gimp-2.10.24-setup-3.exe".
            }
        }

        private void EverythingSearch_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://www.voidtools.com/Everything-1.4.1.1009.x64-Setup.exe", (sPath + dir + @"\Everything-1.4.1.1009.x64-Setup.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Everything Search?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\Everything-1.4.1.1009.x64-Setup.exe"));// If user clicks "yes" then it will open "Everything-1.4.1.1009.x64-Setup.exe".
            }
        }

        private void FileZilla_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://download.filezilla-project.org/client/FileZilla_3.55.0_win64_sponsored-setup.exe", (sPath + dir + @"\FileZilla_3.55.0_win64_sponsored-setup.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install FileZilla?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\FileZilla_3.55.0_win64_sponsored-setup.exe"));// If user clicks "yes" then it will open "FileZilla_3.55.0_win64_sponsored-setup.exe".
            }
        }

        private void qBitTorrent_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://www.fosshub.com/qBittorrent.html?dwl=qbittorrent_4.3.7_x64_setup.exe", (sPath + dir + @"\qbittorrent_4.3.7_x64_setup.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install qBitTorrent?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\qbittorrent_4.3.7_x64_setup.exe"));// If user clicks "yes" then it will open "qbittorrent_4.3.7_x64_setup.exe".
            }
        }

        private void Flameshot_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://github.com/flameshot-org/flameshot/releases/download/v0.10.1/Flameshot-0.10.1-win64.msi", (sPath + dir + @"\Flameshot-0.10.1-win64.msi"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Brave Browser?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\Flameshot-0.10.1-win64.msi"));// If user clicks "yes" then it will open "Flameshot-0.10.1-win64.msi".
            }
        }

        private void AutoHotkey_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://www.autohotkey.com/download/ahk-install.exe", (sPath + dir + @"\AutoHotkey_1.1.33.09_setup.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Auto Hotkey?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\AutoHotkey_1.1.33.09_setup.exe"));// If user clicks "yes" then it will open "AutoHotkey_1.1.33.09_setup.exe".
            }
        }

        private void Notepad_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
            }
            webClient.DownloadFile("https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.1.2/npp.8.1.2.Installer.x64.exe", (sPath + dir + @"\npp.8.1.2.Installer.x64.exe"));
            Thread.Sleep(1000);
            if (MessageBox.Show("Do you want to install Notepad++?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\npp.8.1.2.Installer.x64.exe")); // If user clicks "yes" then it will open "npp.8.1.2.Installer.x64.exe".
            }
        }

        private void Application_Installer_MouseDown(object sender, MouseEventArgs e)
        {
            Main_Panel.Hide();
            //
            Application_Installation_Panel.Show();
        }

        private void AppBack_MouseDown(object sender, MouseEventArgs e)
        {
            Main_Panel.Show();
            //
            Application_Installation_Panel.Hide();
        }

        // Draggable Form

        private void DragLabel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DragLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void DragLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void BelowBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void BelowBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void BelowBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // Draggable Form //

        private void Downlaods_Folder_MouseDown(object sender, MouseEventArgs e)
        {
            string dir = @"\Gorkido_Stuff\Gorkido_Downlaods";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downlaods doesn't exist it'll create the folder
            }
            Thread.Sleep(500);
            Process.Start(sPath + dir);
        }
    }
}
