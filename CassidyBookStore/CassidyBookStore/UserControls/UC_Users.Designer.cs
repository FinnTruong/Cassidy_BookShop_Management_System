namespace CassidyBookStore.UserControls
{
    partial class UC_Users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Users));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Location = new System.Drawing.Point(17, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 439);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Purple;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(730, 439);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.BorderRadius = 0;
            this.btn_Add.ButtonText = "   Add";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Add.Iconimage")));
            this.btn_Add.Iconimage_right = null;
            this.btn_Add.Iconimage_right_Selected = null;
            this.btn_Add.Iconimage_Selected = null;
            this.btn_Add.IconMarginLeft = 0;
            this.btn_Add.IconMarginRight = 0;
            this.btn_Add.IconRightVisible = true;
            this.btn_Add.IconRightZoom = 0D;
            this.btn_Add.IconVisible = true;
            this.btn_Add.IconZoom = 70D;
            this.btn_Add.IsTab = false;
            this.btn_Add.Location = new System.Drawing.Point(17, 15);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_Add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Add.selected = false;
            this.btn_Add.Size = new System.Drawing.Size(174, 52);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "   Add";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Textcolor = System.Drawing.Color.White;
            this.btn_Add.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Activecolor = System.Drawing.Color.DarkOrchid;
            this.btn_Edit.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Edit.BorderRadius = 0;
            this.btn_Edit.ButtonText = "   Edit ";
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Edit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Edit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Iconimage")));
            this.btn_Edit.Iconimage_right = null;
            this.btn_Edit.Iconimage_right_Selected = null;
            this.btn_Edit.Iconimage_Selected = null;
            this.btn_Edit.IconMarginLeft = 0;
            this.btn_Edit.IconMarginRight = 0;
            this.btn_Edit.IconRightVisible = true;
            this.btn_Edit.IconRightZoom = 0D;
            this.btn_Edit.IconVisible = true;
            this.btn_Edit.IconZoom = 70D;
            this.btn_Edit.IsTab = false;
            this.btn_Edit.Location = new System.Drawing.Point(187, 15);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Normalcolor = System.Drawing.Color.DarkOrchid;
            this.btn_Edit.OnHovercolor = System.Drawing.Color.DarkOrchid;
            this.btn_Edit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Edit.selected = false;
            this.btn_Edit.Size = new System.Drawing.Size(174, 52);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "   Edit ";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Textcolor = System.Drawing.Color.White;
            this.btn_Edit.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Delete
            // 
            this.btn_Delete.Activecolor = System.Drawing.Color.MediumOrchid;
            this.btn_Delete.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.BorderRadius = 0;
            this.btn_Delete.ButtonText = "   Delete";
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Iconimage")));
            this.btn_Delete.Iconimage_right = null;
            this.btn_Delete.Iconimage_right_Selected = null;
            this.btn_Delete.Iconimage_Selected = null;
            this.btn_Delete.IconMarginLeft = 0;
            this.btn_Delete.IconMarginRight = 0;
            this.btn_Delete.IconRightVisible = true;
            this.btn_Delete.IconRightZoom = 0D;
            this.btn_Delete.IconVisible = true;
            this.btn_Delete.IconZoom = 70D;
            this.btn_Delete.IsTab = false;
            this.btn_Delete.Location = new System.Drawing.Point(358, 15);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Normalcolor = System.Drawing.Color.MediumOrchid;
            this.btn_Delete.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.btn_Delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Delete.selected = false;
            this.btn_Delete.Size = new System.Drawing.Size(174, 52);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "   Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Textcolor = System.Drawing.Color.White;
            this.btn_Delete.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this.btn_Add;
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(764, 548);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Add;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Edit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
