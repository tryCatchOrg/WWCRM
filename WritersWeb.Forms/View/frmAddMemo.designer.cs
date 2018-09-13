namespace WritersWeb.View
{
    partial class frmAddMemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMemo));
            this.lblClose = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblfilterDate = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.pnlMain = new DevComponents.DotNetBar.PanelEx();
            this.richTextBoxEx1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblClose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.DimGray;
            this.lblClose.Location = new System.Drawing.Point(664, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.PaddingBottom = 3;
            this.lblClose.Size = new System.Drawing.Size(23, 21);
            this.lblClose.SymbolColor = System.Drawing.Color.Gray;
            this.lblClose.SymbolSize = 12F;
            this.lblClose.TabIndex = 160;
            this.lblClose.Text = "X";
            this.lblClose.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelX1.Location = new System.Drawing.Point(76, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(274, 32);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 118;
            this.labelX1.Text = "MEMO INFORMATION";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(251, 98);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(354, 31);
            this.textBoxX1.TabIndex = 117;
            // 
            // lblfilterDate
            // 
            // 
            // 
            // 
            this.lblfilterDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblfilterDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilterDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblfilterDate.Location = new System.Drawing.Point(76, 100);
            this.lblfilterDate.Name = "lblfilterDate";
            this.lblfilterDate.Size = new System.Drawing.Size(113, 32);
            this.lblfilterDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblfilterDate.TabIndex = 109;
            this.lblfilterDate.Text = "NAME";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.AutoExpandOnClick = true;
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnAdd.FadeEffect = false;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnAdd.Location = new System.Drawing.Point(465, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.btnAdd.Size = new System.Drawing.Size(140, 39);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.SubItemsExpandWidth = 15;
            this.btnAdd.SymbolColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.SymbolSize = 12F;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            // 
            // pnlMain
            // 
            this.pnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlMain.Controls.Add(this.labelX2);
            this.pnlMain.Controls.Add(this.richTextBoxEx1);
            this.pnlMain.Controls.Add(this.lblClose);
            this.pnlMain.Controls.Add(this.labelX1);
            this.pnlMain.Controls.Add(this.textBoxX1);
            this.pnlMain.Controls.Add(this.lblfilterDate);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(692, 403);
            this.pnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlMain.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlMain.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlMain.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlMain.Style.CornerDiameter = 0;
            this.pnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlMain.Style.GradientAngle = 90;
            this.pnlMain.TabIndex = 16;
            // 
            // richTextBoxEx1
            // 
            // 
            // 
            // 
            this.richTextBoxEx1.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx1.Location = new System.Drawing.Point(251, 154);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx1.Size = new System.Drawing.Size(354, 119);
            this.richTextBoxEx1.TabIndex = 161;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelX2.Location = new System.Drawing.Point(76, 154);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(153, 32);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX2.TabIndex = 162;
            this.labelX2.Text = "DESCRIPTION";
            // 
            // frmAddMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 403);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddMemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddMemo";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX lblClose;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX lblfilterDate;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        public DevComponents.DotNetBar.PanelEx pnlMain;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx1;
    }
}