using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using ZXing.QrCode;
using ZXing;
using ZXing.Common;

namespace LabelPrinter
{
    public partial class Form1 : Form
    {
        PrintDocument pd = new PrintDocument();
        public Form1(string[] paras)
        {
            InitializeComponent();
            pd.PrintPage += new PrintPageEventHandler(printDocument_PrintA4Page);

            //寻找名称中包含关键字的打印机
            foreach (String fPrinterName in PrinterSettings.InstalledPrinters)
            {
                if (fPrinterName.Contains(txt_printername.Text))
                {
                    //打印机名称 
                    //pd.DefaultPageSettings.Landscape = true;  //设置横向打印，不设置默认是纵向的
                    pd.DefaultPageSettings.PrinterSettings.PrinterName = fPrinterName;       
                }
            }
                                                                                    
            pd.PrintController = new System.Drawing.Printing.StandardPrintController();

            //executeapp <picpath><printer keyword><printWidth><printHeight>
            if (paras.Length>0)
            {
                if (paras.Length >= 1) txt_picpath.Text = paras[0];
                if (paras.Length >= 2) txt_printername.Text = paras[1];
                if (paras.Length >= 4) { txt_width.Text = paras[2]; txt_height.Text = paras[3];};
                btn_set_Click_1(null, null);
                btn_preview_Click(null, null);
                btn_Print_Click(null, null);
                Application.DoEvents();
                Console.WriteLine("OK");
                Environment.Exit(0);
                
            }


        }
        private void printDocument_PrintA4Page(object sender, PrintPageEventArgs e)
        {
                e.Graphics.DrawImage(pic1.Image, new System.Drawing.Point(0, 0));

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_preview_Click(sender, e);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            pd.Print();
        }



        private void btn_browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "图片文件|*.bmp;*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_picpath.Text= ofd.FileName.ToString();
                btn_preview_Click(sender, e);
            }


        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            pic1.Image = ZoomPicture(Image.FromFile(txt_picpath.Text),pic1.Width,pic1.Height);
            //将写好的格式给打印预览控件以便预览
            printPreviewControl1.Document = pd;
        }
        // 按比例缩放图片
        public Image ZoomPicture(Image SourceImage, int TargetWidth, int TargetHeight)
        {
            int IntWidth; //新的图片宽
            int IntHeight; //新的图片高
            try
            {
                System.Drawing.Imaging.ImageFormat format = SourceImage.RawFormat;
                System.Drawing.Bitmap SaveImage = new System.Drawing.Bitmap(TargetWidth, TargetHeight);
                Graphics g = Graphics.FromImage(SaveImage);
                g.Clear(Color.White);
                g.DrawImage(SourceImage,0,0,TargetWidth,TargetHeight);
                SourceImage.Dispose();

                return SaveImage;
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        public class LocalPrinter
        {
            private static PrintDocument fPrintDocument = new PrintDocument();
            /// <summary> 
            /// 获取本机默认打印机名称 
            /// </summary> 
            public static String DefaultPrinter
            {
                get { return fPrintDocument.PrinterSettings.PrinterName; }
            }
            /// <summary> 
            /// 获取本机的打印机列表。列表中的第一项就是默认打印机。 
            /// </summary> 
            public static List<String> GetLocalPrinters()
            {
                List<String> fPrinters = new List<string>();
                fPrinters.Add(DefaultPrinter); // 默认打印机始终出现在列表的第一项 
                foreach (String fPrinterName in PrinterSettings.InstalledPrinters)
                {
                    if (!fPrinters.Contains(fPrinterName))
                        fPrinters.Add(fPrinterName);
                }
                return fPrinters;
            }
        }

        private void btn_set_Click_1(object sender, EventArgs e)
        {
            try
            {
                pic1.Width = Convert.ToInt32(txt_width.Text);
                pic1.Height = Convert.ToInt32(txt_height.Text);
            }
            catch { }
        }
    }
}
