namespace WritersWeb.View
{
    partial class frmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblSearch = new DevComponents.DotNetBar.LabelX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPurchase = new DevComponents.DotNetBar.ButtonX();
            this.tableLeads = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlMain.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLeads)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlMain.Controls.Add(this.panelEx1);
            this.pnlMain.Controls.Add(this.lblSearch);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.btnPurchase);
            this.pnlMain.Controls.Add(this.tableLeads);
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
            this.pnlMain.TabIndex = 8;
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx1.Location = new System.Drawing.Point(14, 12);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelEx1.Size = new System.Drawing.Size(994, 43);
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.SystemColors.ButtonFace;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderWidth = 5;
            this.panelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx1.Style.ForeColor.Color = System.Drawing.Color.DimGray;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.Style.MarginLeft = 10;
            this.panelEx1.TabIndex = 113;
            this.panelEx1.Text = "RECENT SALES";
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
            // lblSearch
            // 
            // 
            // 
            // 
            this.lblSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearch.Location = new System.Drawing.Point(16, 111);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 29);
            this.lblSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblSearch.TabIndex = 112;
            this.lblSearch.Text = "SEARCH";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(106, 109);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(186, 31);
            this.txtSearch.TabIndex = 111;
            // 
            // btnPurchase
            // 
            this.btnPurchase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurchase.AutoExpandOnClick = true;
            this.btnPurchase.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPurchase.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnPurchase.FadeEffect = false;
            this.btnPurchase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnPurchase.Location = new System.Drawing.Point(793, 102);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.btnPurchase.Size = new System.Drawing.Size(215, 39);
            this.btnPurchase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPurchase.SubItemsExpandWidth = 15;
            this.btnPurchase.SymbolColor = System.Drawing.Color.WhiteSmoke;
            this.btnPurchase.SymbolSize = 12F;
            this.btnPurchase.TabIndex = 0;
            this.btnPurchase.TabStop = false;
            this.btnPurchase.Text = "PURCHASE SERVICE";
            this.btnPurchase.TextColor = System.Drawing.Color.White;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // tableLeads
            // 
            this.tableLeads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLeads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLeads.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableLeads.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.tableLeads.Location = new System.Drawing.Point(14, 161);
            this.tableLeads.Name = "tableLeads";
            this.tableLeads.Size = new System.Drawing.Size(994, 392);
            this.tableLeads.TabIndex = 25;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 565);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmSales";
            this.Text = "frmSales";
            this.pnlMain.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.PanelEx pnlMain;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.ButtonX btnPurchase;
        private DevComponents.DotNetBar.Controls.DataGridViewX tableLeads;
    }
}