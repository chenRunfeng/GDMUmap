namespace mapdemo2
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarker = new System.Windows.Forms.Button();
            this.btnDistance = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.comEnd = new System.Windows.Forms.ComboBox();
            this.comStart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDreset = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.labDistance = new System.Windows.Forms.Label();
            this.txtDend = new System.Windows.Forms.TextBox();
            this.labDend = new System.Windows.Forms.Label();
            this.txtDstart = new System.Windows.Forms.TextBox();
            this.labDsart = new System.Windows.Forms.Label();
            this.btnDsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMarker);
            this.panel1.Controls.Add(this.btnDistance);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 508);
            this.panel1.TabIndex = 0;
            // 
            // btnMarker
            // 
            this.btnMarker.Location = new System.Drawing.Point(29, 353);
            this.btnMarker.Name = "btnMarker";
            this.btnMarker.Size = new System.Drawing.Size(148, 23);
            this.btnMarker.TabIndex = 2;
            this.btnMarker.Text = "标注";
            this.btnMarker.UseVisualStyleBackColor = true;
            this.btnMarker.Click += new System.EventHandler(this.btnMarker_Click);
            // 
            // btnDistance
            // 
            this.btnDistance.Location = new System.Drawing.Point(29, 409);
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(148, 23);
            this.btnDistance.TabIndex = 3;
            this.btnDistance.Text = "测距";
            this.btnDistance.UseVisualStyleBackColor = true;
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 164);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(195, 155);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNavigate);
            this.tabPage1.Controls.Add(this.comEnd);
            this.tabPage1.Controls.Add(this.comStart);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(187, 129);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "路线查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNavigate
            // 
            this.btnNavigate.Location = new System.Drawing.Point(52, 102);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(67, 21);
            this.btnNavigate.TabIndex = 4;
            this.btnNavigate.Text = "导航";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // comEnd
            // 
            this.comEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comEnd.FormattingEnabled = true;
            this.comEnd.Items.AddRange(new object[] {
            "门诊部",
            "广医后门"});
            this.comEnd.Location = new System.Drawing.Point(75, 76);
            this.comEnd.Name = "comEnd";
            this.comEnd.Size = new System.Drawing.Size(102, 20);
            this.comEnd.TabIndex = 3;
            // 
            // comStart
            // 
            this.comStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comStart.FormattingEnabled = true;
            this.comStart.Items.AddRange(new object[] {
            "门诊部",
            "广医后门"});
            this.comStart.Location = new System.Drawing.Point(76, 40);
            this.comStart.Name = "comStart";
            this.comStart.Size = new System.Drawing.Size(101, 20);
            this.comStart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "终止点：";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始点：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(187, 129);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "地点查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(6, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 21);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(65, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDreset);
            this.tabPage3.Controls.Add(this.txtDistance);
            this.tabPage3.Controls.Add(this.labDistance);
            this.tabPage3.Controls.Add(this.txtDend);
            this.tabPage3.Controls.Add(this.labDend);
            this.tabPage3.Controls.Add(this.txtDstart);
            this.tabPage3.Controls.Add(this.labDsart);
            this.tabPage3.Controls.Add(this.btnDsave);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(187, 129);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "距离编辑";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDreset
            // 
            this.btnDreset.Location = new System.Drawing.Point(107, 103);
            this.btnDreset.Name = "btnDreset";
            this.btnDreset.Size = new System.Drawing.Size(56, 23);
            this.btnDreset.TabIndex = 7;
            this.btnDreset.Text = "重置";
            this.btnDreset.UseVisualStyleBackColor = true;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(59, 76);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 21);
            this.txtDistance.TabIndex = 6;
            // 
            // labDistance
            // 
            this.labDistance.AutoSize = true;
            this.labDistance.Location = new System.Drawing.Point(14, 85);
            this.labDistance.Name = "labDistance";
            this.labDistance.Size = new System.Drawing.Size(41, 12);
            this.labDistance.TabIndex = 5;
            this.labDistance.Text = "距离：";
            // 
            // txtDend
            // 
            this.txtDend.Location = new System.Drawing.Point(59, 41);
            this.txtDend.Name = "txtDend";
            this.txtDend.Size = new System.Drawing.Size(100, 21);
            this.txtDend.TabIndex = 4;
            // 
            // labDend
            // 
            this.labDend.AutoSize = true;
            this.labDend.Location = new System.Drawing.Point(13, 50);
            this.labDend.Name = "labDend";
            this.labDend.Size = new System.Drawing.Size(41, 12);
            this.labDend.TabIndex = 3;
            this.labDend.Text = "终点：";
            // 
            // txtDstart
            // 
            this.txtDstart.Location = new System.Drawing.Point(59, 9);
            this.txtDstart.Name = "txtDstart";
            this.txtDstart.Size = new System.Drawing.Size(100, 21);
            this.txtDstart.TabIndex = 2;
            // 
            // labDsart
            // 
            this.labDsart.AutoSize = true;
            this.labDsart.Location = new System.Drawing.Point(13, 18);
            this.labDsart.Name = "labDsart";
            this.labDsart.Size = new System.Drawing.Size(41, 12);
            this.labDsart.TabIndex = 1;
            this.labDsart.Text = "起点：";
            // 
            // btnDsave
            // 
            this.btnDsave.Location = new System.Drawing.Point(25, 103);
            this.btnDsave.Name = "btnDsave";
            this.btnDsave.Size = new System.Drawing.Size(56, 23);
            this.btnDsave.TabIndex = 0;
            this.btnDsave.Text = "保存";
            this.btnDsave.UseVisualStyleBackColor = true;
            this.btnDsave.Click += new System.EventHandler(this.btnDsave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路线概览";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 105);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "广医后门——门诊部——置禾超市       距离：600米";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(213, 1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(715, 528);
            this.webBrowser1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 509);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "广医地图";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDistance;
        private System.Windows.Forms.Button btnMarker;
        private System.Windows.Forms.ComboBox comEnd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDreset;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label labDistance;
        private System.Windows.Forms.TextBox txtDend;
        private System.Windows.Forms.Label labDend;
        private System.Windows.Forms.TextBox txtDstart;
        private System.Windows.Forms.Label labDsart;
        private System.Windows.Forms.Button btnDsave;
    }
}

