namespace CassidyBookStore.UserControls
{
    partial class UC_Storage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Storage));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.dtgvBooks = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAddNewBook = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnEdit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuImageButton();
            this.qLNSDataSet = new CassidyBookStore.QLNSDataSet();
            this.qLNSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new CassidyBookStore.QLNSDataSetTableAdapters.BOOKSTableAdapter();
            this.bOOKSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBooks
            // 
            this.dtgvBooks.AllowCustomTheming = true;
            this.dtgvBooks.AllowUserToAddRows = false;
            this.dtgvBooks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dtgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvBooks.ColumnHeadersHeight = 40;
            this.dtgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BookTitle,
            this.Author,
            this.Stock,
            this.Cost,
            this.Price});
            this.dtgvBooks.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgvBooks.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvBooks.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvBooks.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvBooks.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvBooks.CurrentTheme.BackColor = System.Drawing.Color.Purple;
            this.dtgvBooks.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvBooks.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.dtgvBooks.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvBooks.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBooks.CurrentTheme.Name = null;
            this.dtgvBooks.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBooks.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvBooks.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvBooks.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvBooks.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBooks.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvBooks.EnableHeadersVisualStyles = false;
            this.dtgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvBooks.HeaderBackColor = System.Drawing.Color.DarkViolet;
            this.dtgvBooks.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvBooks.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvBooks.Location = new System.Drawing.Point(51, 149);
            this.dtgvBooks.Name = "dtgvBooks";
            this.dtgvBooks.ReadOnly = true;
            this.dtgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvBooks.RowHeadersVisible = false;
            this.dtgvBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvBooks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBooks.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvBooks.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvBooks.RowTemplate.Height = 40;
            this.dtgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBooks.ShowCellErrors = false;
            this.dtgvBooks.Size = new System.Drawing.Size(916, 543);
            this.dtgvBooks.TabIndex = 5;
            this.dtgvBooks.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBooks_CellClick);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuTextBox1.BorderRadius = 35;
            this.bunifuTextBox1.BorderThickness = 0;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 5;
            this.bunifuTextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.IconRight")));
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(51, 88);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Black;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties8;
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Search...";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(297, 35);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 2;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 10;
            this.bunifuTextBox1.TextMarginTop = 0;
            this.bunifuTextBox1.TextPlaceholder = "Search...";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "STORAGE";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.dtgvBooks;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.ActiveImage = null;
            this.btnAddNewBook.AllowAnimations = true;
            this.btnAddNewBook.AllowBuffering = true;
            this.btnAddNewBook.AllowZooming = true;
            this.btnAddNewBook.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewBook.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewBook.ErrorImage")));
            this.btnAddNewBook.FadeWhenInactive = false;
            this.btnAddNewBook.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAddNewBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewBook.Image")));
            this.btnAddNewBook.ImageActive = null;
            this.btnAddNewBook.ImageLocation = null;
            this.btnAddNewBook.ImageMargin = 0;
            this.btnAddNewBook.ImageSize = new System.Drawing.Size(37, 35);
            this.btnAddNewBook.ImageZoomSize = new System.Drawing.Size(37, 35);
            this.btnAddNewBook.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewBook.InitialImage")));
            this.btnAddNewBook.Location = new System.Drawing.Point(372, 88);
            this.btnAddNewBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Rotation = 0;
            this.btnAddNewBook.ShowActiveImage = true;
            this.btnAddNewBook.ShowCursorChanges = true;
            this.btnAddNewBook.ShowImageBorders = false;
            this.btnAddNewBook.ShowSizeMarkers = false;
            this.btnAddNewBook.Size = new System.Drawing.Size(37, 35);
            this.btnAddNewBook.TabIndex = 7;
            this.btnAddNewBook.ToolTipText = "Add New Book";
            this.btnAddNewBook.WaitOnLoad = false;
            this.btnAddNewBook.Zoom = 0;
            this.btnAddNewBook.ZoomSpeed = 10;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveImage = null;
            this.btnEdit.AllowAnimations = true;
            this.btnEdit.AllowBuffering = true;
            this.btnEdit.AllowZooming = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ErrorImage")));
            this.btnEdit.FadeWhenInactive = false;
            this.btnEdit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.ImageLocation = null;
            this.btnEdit.ImageMargin = 0;
            this.btnEdit.ImageSize = new System.Drawing.Size(37, 35);
            this.btnEdit.ImageZoomSize = new System.Drawing.Size(37, 35);
            this.btnEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.InitialImage")));
            this.btnEdit.Location = new System.Drawing.Point(415, 88);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Rotation = 0;
            this.btnEdit.ShowActiveImage = true;
            this.btnEdit.ShowCursorChanges = true;
            this.btnEdit.ShowImageBorders = true;
            this.btnEdit.ShowSizeMarkers = false;
            this.btnEdit.Size = new System.Drawing.Size(37, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.ToolTipText = "Edit";
            this.btnEdit.WaitOnLoad = false;
            this.btnEdit.Zoom = 0;
            this.btnEdit.ZoomSpeed = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveImage = null;
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowBuffering = true;
            this.btnDelete.AllowZooming = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ErrorImage")));
            this.btnDelete.FadeWhenInactive = false;
            this.btnDelete.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.ImageLocation = null;
            this.btnDelete.ImageMargin = 0;
            this.btnDelete.ImageSize = new System.Drawing.Size(37, 35);
            this.btnDelete.ImageZoomSize = new System.Drawing.Size(37, 35);
            this.btnDelete.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.InitialImage")));
            this.btnDelete.Location = new System.Drawing.Point(458, 88);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0;
            this.btnDelete.ShowActiveImage = true;
            this.btnDelete.ShowCursorChanges = true;
            this.btnDelete.ShowImageBorders = true;
            this.btnDelete.ShowSizeMarkers = false;
            this.btnDelete.Size = new System.Drawing.Size(37, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.WaitOnLoad = false;
            this.btnDelete.Zoom = 0;
            this.btnDelete.ZoomSpeed = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNSDataSetBindingSource
            // 
            this.qLNSDataSetBindingSource.DataSource = this.qLNSDataSet;
            this.qLNSDataSetBindingSource.Position = 0;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKSBindingSource2
            // 
            this.bOOKSBindingSource2.DataMember = "BOOKS";
            this.bOOKSBindingSource2.DataSource = this.qLNSDataSetBindingSource;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // BookTitle
            // 
            this.BookTitle.DataPropertyName = "BOOKTITLE";
            this.BookTitle.HeaderText = "Book Title";
            this.BookTitle.MinimumWidth = 6;
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "AUTHOR";
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "STOCK";
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "COST";
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PRICE";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // UC_Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.dtgvBooks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Storage";
            this.Size = new System.Drawing.Size(1019, 675);
            this.Load += new System.EventHandler(this.UC_Storage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddNewBook;
        private Bunifu.UI.WinForms.BunifuImageButton btnEdit;
        private Bunifu.UI.WinForms.BunifuImageButton btnDelete;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource qLNSDataSetBindingSource;
        private QLNSDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.BindingSource bOOKSBindingSource2;
        public Bunifu.UI.WinForms.BunifuDataGridView dtgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
