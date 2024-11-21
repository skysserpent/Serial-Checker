using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Input;

namespace SystemInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        private void form1_load(object sender, EventArgs e)
        {
            CheckSecureBoot();
            CheckWindowsVersion();
            string realTimeProtectionStatus = CheckRealTimeProtection();
            lblRealTimeProtection.Text = "Real-Time Protection: " + realTimeProtectionStatus;
            lblRealTimeProtection.ForeColor = (realTimeProtectionStatus == "Enabled") ? Color.FromArgb(255, 51, 51) : Color.FromArgb(51, 255, 160);             // Change label color based on status
            DisplayProcessorInformation();
            LoadSystemInfo();
            LoadBaseboardInfo();
            DiskDriveInfo();
            DisplayMacAddresses();
            DisplayMonitorInfo();
            CheckCustomOS();
        }

        private void btnRefreshInfo_Click(object sender, EventArgs e)
        {
            LoadSystemInfo();
        }

        private void LoadSystemInfo() // LoadSystemInfo(); will re-do this ex put this function in a button and it will re-check all of these as shown in RefreshInfo_Click
        {
            lblManufacturer.Text = $"Manufacturer: {GetWmiValue("Win32_ComputerSystem", "Manufacturer")}";
            lblProductName.Text = $"Product Name: {GetWmiValue("Win32_ComputerSystem", "Model")}";
            lblSystemSerial.Text = $"System Serial: {GetWmiValue("Win32_BIOS", "SerialNumber")}";

            lblBiosVendor.Text = $"Vendor: {GetWmiValue("Win32_BIOS", "Manufacturer")}";
            lblBiosVersion.Text = $"Version: {GetWmiValue("Win32_BIOS", "SMBIOSBIOSVersion")}";
            lblBiosReleaseDate.Text = $"Release Date: {FormatDate(GetWmiValue("Win32_BIOS", "ReleaseDate"))}";

            lblDiskModel.Text = $"Disk Model: {GetWmiValue("Win32_DiskDrive", "Model")}";
            lblDiskSerial.Text = $"Disk Serial: {GetWmiValue("Win32_PhysicalMedia", "SerialNumber")}";

            lblTpmStatus.Text = $"TPM Status: {CheckTpmStatus()}";
            bool isTpmEnabled = CheckTpmStatus() == "Enabled";
            lblTpmStatus.ForeColor = isTpmEnabled ? Color.FromArgb(51, 255, 160) : Color.FromArgb(255, 51, 51);
        }
        private void DisplayProcessorInformation()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    lblProcessorManufacturer.Text = "Manufacturer: " + obj["Manufacturer"]?.ToString() ?? "Unknown";
                    lblProcessorVersion.Text = "Version: " + obj["Name"]?.ToString() ?? "Unknown";
                    lblProcessorSerialNumber.Text = "Serial Number: " + obj["ProcessorId"]?.ToString() ?? "Unknown";
                    lblSocketProcessor.Text = "Socket: " + obj["SocketDesignation"]?.ToString() ?? "Unknown";
                    lblProcessorPartNumber.Text = "Part Number: " + (obj["PartNumber"]?.ToString() == "To Be Filled By O.E.M." ? "Unknown" : obj["PartNumber"]?.ToString());
                    bool isVirtualizationEnabled = IsVirtualizationEnabled();
                    lblProcessorVirtualization.Text = "Virtualization: " + (isVirtualizationEnabled ? "Enabled" : "Disabled");
                    lblProcessorVirtualization.ForeColor = isVirtualizationEnabled ? Color.FromArgb(51, 255, 160) : Color.FromArgb(255, 51, 51);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadBaseboardInfo()
        {
            // Retrieve baseboard (motherboard) information using WMI
            lblBaseboardManufacturer.Text = "Manufacturer: " + GetWmiValue("Win32_BaseBoard", "Manufacturer");
            lblBaseboardProductName.Text = "Product Name: " + GetWmiValue("Win32_BaseBoard", "Product");
            lblBaseboardVersion.Text = "Version: " + GetWmiValue("Win32_BaseBoard", "Version");
            lblBaseboardSerialNumber.Text = "Serial Number: " + GetWmiValue("Win32_BaseBoard", "SerialNumber");
            lblBaseboardLocation.Text = "Location: " + GetWmiValue("Win32_BaseBoard", "LocationInChassis");
        }
        private void DiskDriveInfo()
        {
            lblDiskStorageModel.Text = $"Disk Storage Model: {GetDiskStorageModel()}";
        }
        private void DisplayMacAddresses()
        {
            string macAddresses = GetMacAddresses();
            var macList = macAddresses.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            // Display them on the labels
            lblMacCache1.Text = macList.Length > 0 ? $"MAC [Cache 1]: {macList[0]}" : "MAC [Cache 1]: Not Available";
            lblMacCache2.Text = macList.Length > 1 ? $"MAC [Cache 2]: {macList[1]}" : "MAC [Cache 2]: Not Available";
            lblMacCache3.Text = macList.Length > 2 ? $"MAC [Cache 3]: {macList[2]}" : "MAC [Cache 3]: Not Available";
            lblMacCache4.Text = macList.Length > 3 ? $"MAC [Cache 4]: {macList[3]}" : "MAC [Cache 4]: Not Available";
            lblMacCache5.Text = macList.Length > 4 ? $"MAC [Cache 5]: {macList[4]}" : "MAC [Cache 5]: Not Available";
            lblMacCache6.Text = macList.Length > 5 ? $"MAC [Cache 6]: {macList[5]}" : "MAC [Cache 6]: Not Available";
        }
        private void DisplayMonitorInfo()
        {
            string resolution = GetMonitorResolution();
            lblMonitorActive.Text = $"Active Monitor: {GetActiveMonitor()}";
            lblMonitorResolution.Text = $"Resolution: {resolution}";

            if (resolution == "Less Than 1920x1080")
            {
                lblMonitorResolution.ForeColor = Color.Red;  // Red if the resolution is less than 1920x1080
            }
            else if (resolution == "1920 x 1080" || resolution == "1920 x 1200" || resolution == "2560 x 1440")
            {
                lblMonitorResolution.ForeColor = Color.Purple;  // Purple for specific resolutions
            }
            else if (resolution == "2560 x 1440")
            {
                lblMonitorResolution.ForeColor = Color.FromArgb(51, 255, 160);  // Green for 2560x1440
            }
            else
            {
                lblMonitorResolution.ForeColor = Color.Black;  // Default color if no match
            }
        }
        private string GetDiskStorageModel()
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher("SELECT Model FROM Win32_DiskDrive"))
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        return queryObj["Model"]?.ToString() ?? "Model Not Found";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }

            return "Model Not Found";
        }

        private string GetWmiValue(string wmiClass, string wmiProperty)
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher($"SELECT * FROM {wmiClass}"))
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        var propertyValue = queryObj[wmiProperty];
                        if (propertyValue != null)
                        {
                            return propertyValue.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }

            return "N/A";  
        }

        private string FormatDate(string rawDate)
        {
            if (string.IsNullOrEmpty(rawDate) || rawDate.Length < 8) return "N/A";
            var year = rawDate.Substring(0, 4);
            var month = rawDate.Substring(4, 2);
            var day = rawDate.Substring(6, 2);
            return $"{month}/{day}/{year}";
        }

        private string CheckTpmStatus()
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher("SELECT SpecVersion FROM Win32_Tpm"))
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        return "Enabled"; 
                    }
                }
            }
            catch
            {
                return "Disabled"; 
            }


            return "Disabled";
        }


        private bool IsVirtualizationEnabled()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["VirtualizationFirmwareEnabled"] != null && (bool)obj["VirtualizationFirmwareEnabled"];
                }
            }
            catch
            {
                // send a webhook send a message box ect
            }
            return false;
        }
        private void CheckSecureBoot()
        {
            bool isSecureBootEnabled = IsSecureBootEnabled(); 
            lblSecureBoot.Text = "Secure Boot: " + (isSecureBootEnabled ? "Enabled" : "Disabled");
            lblSecureBoot.ForeColor = isSecureBootEnabled ? Color.FromArgb(255, 51, 51) : Color.FromArgb(51, 255, 160);
        }
        private bool IsSecureBootEnabled()
        {
            try
            {
                using (var process = new Process())
                {
                    process.StartInfo.FileName = "powershell.exe";
                    process.StartInfo.Arguments = "-Command \"Confirm-SecureBootUEFI\"";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    return output.Contains("True");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking Secure Boot status: " + ex.Message);
                return false;
            }
        }
        private void lblSecureBoot_Click(object sender, EventArgs e)
        {

        }
        private void CheckWindowsVersion() 
        {
            string windowsName = "Unknown";
            string versionInfo = "Unknown";
            string build = "Unknown";

            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementBaseObject os in searcher.Get())
                {
                    build = os["BuildNumber"].ToString(); // Get the OS build number
                    string caption = os["Caption"].ToString(); // Get the OS name (Windows 10 or Windows 11)

                    // Determine Windows name and version
                    if (caption.Contains("Windows 10"))
                    {
                        windowsName = "Windows 10";
                        versionInfo = GetWindows10ReleaseId(build);
                    }
                    else if (caption.Contains("Windows 11"))
                    {
                        windowsName = "Windows 11";
                        versionInfo = GetWindows11ReleaseId(build);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving Windows version: " + ex.Message);
            }
            lblWindowsVersion.Text = $"{windowsName} Version {versionInfo} (OS Build {build})";
        }
        private string GetWindows10ReleaseId(string build)
        {

            switch (build)
            {
                case "19042":
                case "19043":
                case "19044":
                    return "20H2";
                case "19041":
                    return "20H1";
                case "18363":
                    return "1909";
                case "18362":
                    return "1903";
                case "17763":
                    return "1809";
                case "17134":
                    return "1803";
                case "16299":
                    return "1709";
                case "15063":
                    return "1703";
                default:
                    return "Unsupported Windows version";
            }
        }

        private string GetWindows11ReleaseId(string build)
        {
            switch (build)
            {
                case "22621":
                    return "22H2"; // 2022 Update
                case "22000":
                    return "21H2"; // Initial Release
                case "22631":
                    return "23H2"; // 2023 Update
                case "22661":
                    return "24H2"; // 2024 Update
                default:
                    return "Unsupported Windows Version";
                    // add more windows versions as they update
            }
        }

        private void lblWindowsVersion_Click(object sender, EventArgs e)
        {

        }

        private void CheckCustomOS()
        {
            bool isCustomOS = IsCustomOS(); 
            lblCustomOS.Text = "Custom OS: " + (isCustomOS ? "Yes" : "No");
            lblCustomOS.ForeColor = isCustomOS ? Color.FromArgb(255, 51, 51) : Color.FromArgb(51, 255, 160);
        }

        private bool IsCustomOS()
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        string osCaption = queryObj["Caption"]?.ToString() ?? "Unknown";
                        string osVersion = queryObj["Version"]?.ToString() ?? "Unknown";

                        // Add logic to identify a custom OS based on version, name, or other properties
                        if (osCaption.Contains("CustomOS") || osVersion.StartsWith("10.0.19045."))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error detecting custom OS: {ex.Message}");
            }

            return false; // Return false if no custom OS is detected
        }
        public string CheckRealTimeProtection() // then we go do this
        {
            var path = @"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection";
            var key = "DisableRealtimeMonitoring";

            using (var regkey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                if (regkey != null)
                {
                    using (var subkey = regkey.OpenSubKey(path))
                    {
                        if (subkey != null)
                        {
                            var val = subkey.GetValue(key);
                            if (val is int value)
                            {
                                if (value == 1)
                                {
                                    return "Disabled";
                                }
                                else
                                {
                                    return "Enabled";
                                }
                            }
                            else
                            {
                                return "Protection status is indeterminate (default state assumed to be on).";
                            }
                        }
                        else
                        {
                            return "Real-time Protection subkey not found.";
                        }
                    }
                }
                else
                {
                    return "Failed to open the registry base key.";
                }
            }
        }

        // method to get real time protection status based off microsoft homepage lmao

        private string GetMacAddresses()
        {
            try
            {
                List<string> macAddresses = new List<string>();
                using (var searcher = new ManagementObjectSearcher("SELECT MACAddress FROM Win32_NetworkAdapter WHERE MACAddress IS NOT NULL"))
                {
                    foreach (ManagementObject adapter in searcher.Get())
                    {
                        string mac = adapter["MACAddress"]?.ToString();
                        if (!string.IsNullOrEmpty(mac))
                        {
                            macAddresses.Add(mac);
                        }
                    }
                }
                return string.Join(", ", macAddresses);
            }
            catch
            {
                return "Unknown";
            }
        }







        private string GetMonitorResolution()
        {
            try
            {
                var screen = Screen.PrimaryScreen;
                int width = screen.Bounds.Width;
                int height = screen.Bounds.Height;

                // Check if the resolution is less than 1920x1080
                if (width < 1920 || height < 1080)
                {
                    return "Less Than 1920x1080";
                }

                return $"{width} x {height}";  // Return resolution in width x height format
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private string GetActiveMonitor()
        {
            try
            {
                // Placeholder logic: Assume primary monitor is active
                return Screen.PrimaryScreen.DeviceName;
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTpmStatus_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CheckSecureBoot();
            CheckWindowsVersion();
            lblRealTimeProtection.Text = "Real-Time Protection: " + CheckRealTimeProtection();
            DisplayProcessorInformation();
            LoadSystemInfo();
        }

        private void lblProcessorVirtualization_Click(object sender, EventArgs e)
        {

        }

        private void lblRequirements_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblManufacturer_Click(object sender, EventArgs e)
        {

        }

        private void lblBiosVendor_Click(object sender, EventArgs e)
        {

        }

        private void lblBiosVendor_Click_1(object sender, EventArgs e)
        {

        }
    }
}
