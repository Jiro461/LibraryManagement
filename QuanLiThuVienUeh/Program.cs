using QuanLiThuVienUeh.admin;
using QuanLiThuVienUeh.login;
using QuanLiThuVienUeh.nguoidung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVienUeh
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_NguoiDung(1201021233));
        }
    }
}
