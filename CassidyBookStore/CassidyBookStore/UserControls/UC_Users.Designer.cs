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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Users));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvUsers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(38, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "USERS";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // dtgvUsers
            // 
            this.dtgvUsers.AllowCustomTheming = true;
            this.dtgvUsers.AllowUserToAddRows = false;
            this.dtgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvUsers.ColumnHeadersHeight = 40;
            this.dtgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Phone,
            this.Email});
            this.dtgvUsers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgvUsers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvUsers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvUsers.CurrentTheme.BackColor = System.Drawing.Color.Purple;
            this.dtgvUsers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvUsers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Indigo;
            this.dtgvUsers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvUsers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvUsers.CurrentTheme.Name = null;
            this.dtgvUsers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvUsers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvUsers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvUsers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvUsers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvUsers.EnableHeadersVisualStyles = false;
            this.dtgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvUsers.HeaderBackColor = System.Drawing.Color.Indigo;
            this.dtgvUsers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvUsers.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvUsers.Location = new System.Drawing.Point(24, 78);
            this.dtgvUsers.MultiSelect = false;
            this.dtgvUsers.Name = "dtgvUsers";
            this.dtgvUsers.ReadOnly = true;
            this.dtgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvUsers.RowHeadersVisible = false;
            this.dtgvUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvUsers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvUsers.RowTemplate.Height = 40;
            this.dtgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUsers.ShowCellErrors = false;
            this.dtgvUsers.Size = new System.Drawing.Size(954, 630);
            this.dtgvUsers.TabIndex = 6;
            this.dtgvUsers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuToolTip1.SetToolTip(this.dtgvUsers, "");
            this.bunifuToolTip1.SetToolTipIcon(this.dtgvUsers, null);
            this.bunifuToolTip1.SetToolTipTitle(this.dtgvUsers, "");
            this.dtgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsers_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FIRSTNAME";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LASTNAME";
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "PHONE";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "EMAIL";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.AcceptsReturn = false;
            this.txtSearchBox.AcceptsTab = false;
            this.txtSearchBox.AnimationSpeed = 200;
            this.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchBox.BackgroundImage")));
            this.txtSearchBox.BorderColorActive = System.Drawing.Color.Indigo;
            this.txtSearchBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearchBox.BorderColorHover = System.Drawing.Color.DarkOrchid;
            this.txtSearchBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearchBox.BorderRadius = 35;
            this.txtSearchBox.BorderThickness = 0;
            this.txtSearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.FillColor = System.Drawing.Color.White;
            this.txtSearchBox.HideSelection = true;
            this.txtSearchBox.IconLeft = null;
            this.txtSearchBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.IconPadding = 5;
            this.txtSearchBox.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearchBox.IconRight")));
            this.txtSearchBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.Lines = new string[0];
            this.txtSearchBox.Location = new System.Drawing.Point(642, 23);
            this.txtSearchBox.MaxLength = 32767;
            this.txtSearchBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSearchBox.Modified = false;
            this.txtSearchBox.Multiline = false;
            this.txtSearchBox.Name = "txtSearchBox";
            stateProperties1.BorderColor = System.Drawing.Color.Indigo;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearchBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.DarkOrchid;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchBox.OnIdleState = stateProperties4;
            this.txtSearchBox.PasswordChar = '\0';
            this.txtSearchBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearchBox.PlaceholderText = "Search...";
            this.txtSearchBox.ReadOnly = false;
            this.txtSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.SelectionLength = 0;
            this.txtSearchBox.SelectionStart = 0;
            this.txtSearchBox.ShortcutsEnabled = true;
            this.txtSearchBox.Size = new System.Drawing.Size(336, 36);
            this.txtSearchBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearchBox.TabIndex = 16;
            this.txtSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchBox.TextMarginBottom = 0;
            this.txtSearchBox.TextMarginLeft = 10;
            this.txtSearchBox.TextMarginTop = 0;
            this.txtSearchBox.TextPlaceholder = "Search...";
            this.bunifuToolTip1.SetToolTip(this.txtSearchBox, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtSearchBox, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtSearchBox, "");
            this.txtSearchBox.UseSystemPasswordChar = false;
            this.txtSearchBox.WordWrap = true;
            this.txtSearchBox.TextChange += new System.EventHandler(this.txtSearchBox_TextChanged);
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageActive")));
            this.btnDelete.Location = new System.Drawing.Point(328, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDelete.TabIndex = 19;
            this.btnDelete.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnDelete, "Delete User");
            this.bunifuToolTip1.SetToolTipIcon(this.btnDelete, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnDelete, "");
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageActive")));
            this.btnEdit.Location = new System.Drawing.Point(255, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnEdit.TabIndex = 18;
            this.btnEdit.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnEdit, "Edit User");
            this.bunifuToolTip1.SetToolTipIcon(this.btnEdit, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnEdit, "");
            this.btnEdit.Zoom = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageActive")));
            this.btnAdd.Location = new System.Drawing.Point(184, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAdd.TabIndex = 17;
            this.btnAdd.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnAdd, "Add New User");
            this.bunifuToolTip1.SetToolTipIcon(this.btnAdd, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnAdd, "");
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.dtgvUsers);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(1019, 675);
            this.bunifuToolTip1.SetToolTip(this, "");
            this.bunifuToolTip1.SetToolTipIcon(this, null);
            this.bunifuToolTip1.SetToolTipTitle(this, "");
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        public Bunifu.UI.WinForms.BunifuDataGridView dtgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearchBox;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}
