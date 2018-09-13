namespace WritersWeb.View
{
    partial class frmLead
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridLead = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnAddLead = new DevComponents.DotNetBar.ButtonX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSearch = new DevComponents.DotNetBar.LabelX();
            this.pnlCondition = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlMain = new DevComponents.DotNetBar.PanelEx();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.gridLead)).BeginInit();
            this.pnlCondition.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLead
            // 
            this.gridLead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridLead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLead.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridLead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLead.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridLead.Location = new System.Drawing.Point(1, 1);
            this.gridLead.Name = "gridLead";
            this.gridLead.Size = new System.Drawing.Size(982, 344);
            this.gridLead.TabIndex = 25;
            // 
            // btnAddLead
            // 
            this.btnAddLead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddLead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLead.AutoExpandOnClick = true;
            this.btnAddLead.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddLead.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnAddLead.FadeEffect = false;
            this.btnAddLead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLead.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnAddLead.Location = new System.Drawing.Point(863, 118);
            this.btnAddLead.Name = "btnAddLead";
            this.btnAddLead.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.btnAddLead.Size = new System.Drawing.Size(140, 39);
            this.btnAddLead.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddLead.SubItemsExpandWidth = 15;
            this.btnAddLead.SymbolColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddLead.SymbolSize = 12F;
            this.btnAddLead.TabIndex = 0;
            this.btnAddLead.TabStop = false;
            this.btnAddLead.Text = "ADD LEAD";
            this.btnAddLead.TextColor = System.Drawing.Color.White;
            this.btnAddLead.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(107, 126);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(212, 31);
            this.txtSearch.TabIndex = 111;
            // 
            // lblSearch
            // 
            // 
            // 
            // 
            this.lblSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearch.Location = new System.Drawing.Point(17, 128);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 29);
            this.lblSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblSearch.TabIndex = 112;
            this.lblSearch.Text = "SEARCH";
            // 
            // pnlCondition
            // 
            this.pnlCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCondition.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlCondition.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlCondition.Controls.Add(this.labelX1);
            this.pnlCondition.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlCondition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCondition.Location = new System.Drawing.Point(14, 12);
            this.pnlCondition.Name = "pnlCondition";
            this.pnlCondition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlCondition.Size = new System.Drawing.Size(994, 43);
            this.pnlCondition.Style.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.pnlCondition.Style.BackColor2.Color = System.Drawing.SystemColors.ButtonFace;
            this.pnlCondition.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlCondition.Style.BorderWidth = 5;
            this.pnlCondition.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlCondition.Style.ForeColor.Color = System.Drawing.Color.DimGray;
            this.pnlCondition.Style.GradientAngle = 90;
            this.pnlCondition.Style.MarginLeft = 10;
            this.pnlCondition.TabIndex = 113;
            this.pnlCondition.Text = "RECENT LEADS";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelX1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelX1.Location = new System.Drawing.Point(955, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(39, 43);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.Symbol = "58131";
            this.labelX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX1.SymbolSize = 25F;
            this.labelX1.TabIndex = 117;
            // 
            // pnlMain
            // 
            this.pnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlMain.Controls.Add(this.buttonX2);
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Controls.Add(this.buttonX1);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.lblSearch);
            this.pnlMain.Controls.Add(this.btnAddLead);
            this.pnlMain.Controls.Add(this.pnlCondition);
            this.pnlMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1020, 565);
            this.pnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlMain.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlMain.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlMain.Style.GradientAngle = 90;
            this.pnlMain.TabIndex = 4;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.AutoExpandOnClick = true;
            this.buttonX2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX2.FadeEffect = false;
            this.buttonX2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.buttonX2.Location = new System.Drawing.Point(694, 119);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.buttonX2.Size = new System.Drawing.Size(153, 38);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.SubItemsExpandWidth = 15;
            this.buttonX2.SymbolColor = System.Drawing.Color.WhiteSmoke;
            this.buttonX2.SymbolSize = 12F;
            this.buttonX2.TabIndex = 118;
            this.buttonX2.TabStop = false;
            this.buttonX2.Text = "UPLOAD EXCEL";
            this.buttonX2.TextColor = System.Drawing.Color.White;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.AutoExpandOnClick = true;
            this.buttonX1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX1.FadeEffect = false;
            this.buttonX1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.buttonX1.Location = new System.Drawing.Point(501, 118);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.buttonX1.Size = new System.Drawing.Size(175, 38);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.SubItemsExpandWidth = 15;
            this.buttonX1.SymbolColor = System.Drawing.Color.WhiteSmoke;
            this.buttonX1.SymbolSize = 12F;
            this.buttonX1.TabIndex = 117;
            this.buttonX1.TabStop = false;
            this.buttonX1.Text = "DOWNLOAD EXCEL";
            this.buttonX1.TextColor = System.Drawing.Color.White;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.BackColor = System.Drawing.Color.Transparent;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.ColorScheme.TabBackground = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabBackground2 = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabBorder = System.Drawing.Color.Transparent;
            this.tabControl1.ColorScheme.TabItemBackground = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabItemBackground2 = System.Drawing.Color.Gray;
            this.tabControl1.ColorScheme.TabItemBackgroundColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(249))))), 0F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(208)))), ((int)(((byte)(245))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(229)))), ((int)(((byte)(247))))), 1F)});
            this.tabControl1.ColorScheme.TabItemBorder = System.Drawing.Color.Honeydew;
            this.tabControl1.ColorScheme.TabItemHotBackground2 = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(235))))), 0F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(168))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(89))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(141))))), 1F)});
            this.tabControl1.ColorScheme.TabItemHotBorder = System.Drawing.Color.Transparent;
            this.tabControl1.ColorScheme.TabItemHotText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabControl1.ColorScheme.TabItemSelectedBackground = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabItemSelectedBackground2 = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabItemSelectedBorder = System.Drawing.Color.Transparent;
            this.tabControl1.ColorScheme.TabItemSelectedBorderDark = System.Drawing.Color.Transparent;
            this.tabControl1.ColorScheme.TabItemSelectedBorderLight = System.Drawing.Color.Silver;
            this.tabControl1.ColorScheme.TabItemSelectedText = System.Drawing.Color.DimGray;
            this.tabControl1.ColorScheme.TabItemText = System.Drawing.Color.DimGray;
            this.tabControl1.ColorScheme.TabPanelBackground2 = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabPanelBorder = System.Drawing.Color.Transparent;
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl1.Location = new System.Drawing.Point(19, 174);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.SelectedTabIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(984, 375);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl1.TabIndex = 129;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = " NEW LEADS";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.gridLead);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(984, 346);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = " SUMITTED LEADS";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.dataGridViewX1);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(984, 346);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.White;
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 5;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(982, 342);
            this.dataGridViewX1.TabIndex = 26;
            // 
            // frmLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 565);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmLead";
            this.Text = "frmLead";
            ((System.ComponentModel.ISupportInitialize)(this.gridLead)).EndInit();
            this.pnlCondition.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnAddLead;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.LabelX lblSearch;
        private DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.PanelEx pnlMain;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        public DevComponents.DotNetBar.Controls.DataGridViewX gridLead;
        public DevComponents.DotNetBar.PanelEx pnlCondition;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
    }
}