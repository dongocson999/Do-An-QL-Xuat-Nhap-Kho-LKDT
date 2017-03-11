using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLXuatNhapKhoLKDT
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm1 form = new XtraForm1();
            form.MdiParent = this;
            form.Show();
        }

       

        private void barButtonItem_MenuPupop_HeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu_HeThong.ShowPopup(new Point(500,300));
        }

        private void barButtonItem_MenuPupop_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem_MenuPupop_DanhMuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu_DanhMuc.ShowPopup(new Point(500,300));
        }

        private void barButtonItem_MenuPupop_NghiepVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu_NghiepVu.ShowPopup(new Point(500,300));
        }

        private void barButtonItem_MenuPopup_QuayLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu_NghiepVu.HidePopup();
        }

        private void barButtonItem109_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_MenuPupop_BaoHanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu_BaoHanh.ShowPopup(new Point(500,300));
        }

        private void barButtonItem_MenuPupop_BaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu_BaoCao.ShowPopup(new Point(500,300));
        }

        private void barButtonItem_MenuPupop_CongCu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu_CongCu.ShowPopup(new Point(500, 300));
        }
    }
}
