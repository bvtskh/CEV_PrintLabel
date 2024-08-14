using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.IO.Ports;
using System.Management;


namespace PrintLabel
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            // Lấy tất cả các cổng COM hiện có trên máy tính
            string[] ports = SerialPort.GetPortNames();

            //// In ra danh sách các cổng COM
            //Console.WriteLine("Các cổng COM đang được kết nối:");
            //foreach (string port in ports)
            //{
            //    Console.WriteLine(port);
            //    GetDeviceInformation(port);
            //}

            //// Liệt kê tất cả các thiết bị USB
            //Console.WriteLine("\nCác thiết bị USB đang được kết nối:");
            //GetUSBDevices();

            // Liệt kê tất cả các thiết bị lưu trữ
            // Console.WriteLine("\nCác thiết bị lưu trữ đang được kết nối:");
            //GetDiskDevices();
            GetCameraDevices();
        }

        //static void GetDeviceInformation(string portName)
        //{
        //    string query = $"SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%({portName})%'";

        //    try
        //    {
        //        using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
        //        {
        //            foreach (ManagementObject obj in searcher.Get())
        //            {
        //                Console.WriteLine($"Tên thiết bị: {obj["Name"]}");
        //                Console.WriteLine($"Mô tả thiết bị: {obj["Description"]}");
        //                Console.WriteLine($"Nhà sản xuất: {obj["Manufacturer"]}");
        //                Console.WriteLine($"Địa chỉ cổng: {obj["DeviceID"]}");
        //                Console.WriteLine();
        //            }
        //        }
        //    }
        //    catch (ManagementException e)
        //    {
        //        Console.WriteLine($"Lỗi khi truy vấn WMI: {e.Message}");
        //    }
        //    catch (UnauthorizedAccessException e)
        //    {
        //        Console.WriteLine($"Không đủ quyền truy cập: {e.Message}");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Lỗi khác: {e.Message}");
        //    }
        //}

        //static void GetUSBDevices()
        //{
        //    string query = "SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%USB%'";

        //    try
        //    {
        //        using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
        //        {
        //            foreach (ManagementObject obj in searcher.Get())
        //            {
        //                Console.WriteLine($"Tên thiết bị: {obj["Name"]}");
        //                Console.WriteLine($"Mô tả thiết bị: {obj["Description"]}");
        //                Console.WriteLine($"Nhà sản xuất: {obj["Manufacturer"]}");
        //                Console.WriteLine($"ID thiết bị: {obj["DeviceID"]}");
        //                Console.WriteLine();
        //            }
        //        }
        //    }
        //    catch (ManagementException e)
        //    {
        //        Console.WriteLine($"Lỗi khi truy vấn WMI: {e.Message}");
        //    }
        //    catch (UnauthorizedAccessException e)
        //    {
        //        Console.WriteLine($"Không đủ quyền truy cập: {e.Message}");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Lỗi khác: {e.Message}");
        //    }
        //}

        static void GetDiskDevices()
        {
            string query = "SELECT * FROM Win32_Cameras";

            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        Console.WriteLine($"Tên thiết bị: {obj["Model"]}");
                        Console.WriteLine($"Mô tả thiết bị: {obj["Caption"]}");
                        Console.WriteLine($"Loại thiết bị: {obj["MediaType"]}");
                        Console.WriteLine($"Số serial: {obj["SerialNumber"]}");
                        Console.WriteLine($"Kích thước: {obj["Size"]}");
                        Console.WriteLine($"ID thiết bị: {obj["DeviceID"]}");
                        Console.WriteLine();
                    }
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine($"Lỗi khi truy vấn WMI: {e.Message}");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Không đủ quyền truy cập: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi khác: {e.Message}");
            }
        }
        static void GetCameraDevices()
        {
            string query = "SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%Camera%' OR Caption LIKE '%Video%'";

            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        Console.WriteLine($"Tên thiết bị: {obj["Name"]}");
                        Console.WriteLine($"Mô tả thiết bị: {obj["Description"]}");
                        Console.WriteLine($"Nhà sản xuất: {obj["Manufacturer"]}");
                        Console.WriteLine($"ID thiết bị: {obj["DeviceID"]}");
                        Console.WriteLine($"PN ID: {obj["PNPDeviceID"]}");
                        Console.WriteLine($"serial: {obj["SerialNumber"]}");
                        Console.WriteLine();
                    }
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine($"Lỗi khi truy vấn WMI: {e.Message}");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Không đủ quyền truy cập: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi khác: {e.Message}");
            }
        }
    }
}
//PCI\VEN_8086&DEV_A363&SUBSYS_83E1103C&REV_10\3&11583659&1&B3
