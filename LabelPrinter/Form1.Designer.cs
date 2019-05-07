namespace LabelPrinter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Print = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_printername = new System.Windows.Forms.TextBox();
            this.txt_picpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browser = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(14, 317);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(113, 27);
            this.btn_Print.TabIndex = 7;
            this.btn_Print.Text = "打印";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "预览";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.BackColor = System.Drawing.Color.White;
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl1.Location = new System.Drawing.Point(0, 0);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(449, 214);
            this.printPreviewControl1.TabIndex = 11;
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(26, 378);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(306, 153);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.printPreviewControl1);
            this.panel1.Location = new System.Drawing.Point(13, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 216);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "打印机";
            // 
            // txt_printername
            // 
            this.txt_printername.Location = new System.Drawing.Point(88, 12);
            this.txt_printername.Name = "txt_printername";
            this.txt_printername.Size = new System.Drawing.Size(337, 21);
            this.txt_printername.TabIndex = 19;
            this.txt_printername.Text = "Gprinter GP-3120TU";
            // 
            // txt_picpath
            // 
            this.txt_picpath.Location = new System.Drawing.Point(88, 39);
            this.txt_picpath.Name = "txt_picpath";
            this.txt_picpath.Size = new System.Drawing.Size(337, 21);
            this.txt_picpath.TabIndex = 21;
            this.txt_picpath.Text = "test.jpg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "图片";
            // 
            // btn_browser
            // 
            this.btn_browser.Location = new System.Drawing.Point(431, 39);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(31, 21);
            this.btn_browser.TabIndex = 22;
            this.btn_browser.Text = "...";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btn_browser_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(133, 319);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(59, 23);
            this.btn_preview.TabIndex = 23;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Visible = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(384, 317);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(60, 23);
            this.btn_set.TabIndex = 29;
            this.btn_set.Text = "设置";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click_1);
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(325, 319);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(42, 21);
            this.txt_height.TabIndex = 28;
            this.txt_height.Text = "150";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "高";
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(254, 319);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(42, 21);
            this.txt_width.TabIndex = 26;
            this.txt_width.Text = "300";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "宽";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 353);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_browser);
            this.Controls.Add(this.txt_picpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_printername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Print);
            this.Name = "Form1";
            this.Text = "标签打印 V0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_printername;
        private System.Windows.Forms.TextBox txt_picpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label label5;
    }
}

