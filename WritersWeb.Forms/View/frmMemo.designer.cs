namespace WritersWeb.View
{
    partial class frmMemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new DevComponents.DotNetBar.PanelEx();
            this.lblSearch = new DevComponents.DotNetBar.LabelX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAddMemo = new DevComponents.DotNetBar.ButtonX();
            this.tableLeads = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLeads)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlMain.Controls.Add(this.lblSearch);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.btnAddMemo);
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
            this.pnlMain.TabIndex = 12;
            // 
            // lblSearch
            // 
            // 
            // 
            // 
            this.lblSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearch.Location = new System.Drawing.Point(16, 35);
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
            this.txtSearch.Location = new System.Drawing.Point(106, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(186, 31);
            this.txtSearch.TabIndex = 111;
            // 
            // btnAddMemo
            // 
            this.btnAddMemo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddMemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMemo.AutoExpandOnClick = true;
            this.btnAddMemo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddMemo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMemo.BackgroundImage")));
            this.btnAddMemo.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnAddMemo.FadeEffect = false;
            this.btnAddMemo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMemo.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnAddMemo.Location = new System.Drawing.Point(837, 26);
            this.btnAddMemo.Name = "btnAddMemo";
            this.btnAddMemo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.btnAddMemo.Size = new System.Drawing.Size(171, 39);
            this.btnAddMemo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddMemo.SubItemsExpandWidth = 15;
            this.btnAddMemo.SymbolColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddMemo.SymbolSize = 12F;
            this.btnAddMemo.TabIndex = 0;
            this.btnAddMemo.TabStop = false;
            this.btnAddMemo.Text = "ADD MEMO";
            this.btnAddMemo.TextColor = System.Drawing.Color.White;
            this.btnAddMemo.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableLeads
            // 
            this.tableLeads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLeads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLeads.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableLeads.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.tableLeads.Location = new System.Drawing.Point(14, 89);
            this.tableLeads.Name = "tableLeads";
            this.tableLeads.Size = new System.Drawing.Size(994, 464);
            this.tableLeads.TabIndex = 25;
            // 
            // frmMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 565);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMemo";
            this.Text = "frmMemo";
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.PanelEx pnlMain;
        private DevComponents.DotNetBar.LabelX lblSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.ButtonX btnAddMemo;
        private DevComponents.DotNetBar.Controls.DataGridViewX tableLeads;
    }
}