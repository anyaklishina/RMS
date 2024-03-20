namespace RM.View
{
    partial class frmPOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTabel = new System.Windows.Forms.Label();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TileButton4 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton7 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton6 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton3 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton5 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.pnActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стол";
            // 
            // lblTabel
            // 
            this.lblTabel.AutoSize = true;
            this.lblTabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTabel.Location = new System.Drawing.Point(125, 9);
            this.lblTabel.Name = "lblTabel";
            this.lblTabel.Size = new System.Drawing.Size(55, 28);
            this.lblTabel.TabIndex = 0;
            this.lblTabel.Text = "Стол";
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWaiter.Location = new System.Drawing.Point(12, 9);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(107, 28);
            this.lblWaiter.TabIndex = 0;
            this.lblWaiter.Text = "Официант";
            // 
            // ProductPanel
            // 
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProductPanel.Location = new System.Drawing.Point(916, 0);
            this.ProductPanel.MaximumSize = new System.Drawing.Size(351, 1024);
            this.ProductPanel.MinimumSize = new System.Drawing.Size(351, 1024);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(351, 1024);
            this.ProductPanel.TabIndex = 1;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle33;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(51, 77);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 35;
            this.guna2DataGridView1.Size = new System.Drawing.Size(756, 641);
            this.guna2DataGridView1.TabIndex = 6;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.FillWeight = 30F;
            this.dgvName.HeaderText = "Название";
            this.dgvName.MinimumWidth = 30;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 70F;
            this.dgvQty.HeaderText = "Кол-во";
            this.dgvQty.MinimumWidth = 70;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 70;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 70F;
            this.dgvPrice.HeaderText = "Цена";
            this.dgvPrice.MinimumWidth = 70;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 70;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.HeaderText = "Стоимость";
            this.dgvAmount.MinimumWidth = 100;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 125;
            // 
            // pnActions
            // 
            this.pnActions.Controls.Add(this.btnExit);
            this.pnActions.Controls.Add(this.guna2TileButton4);
            this.pnActions.Controls.Add(this.guna2TileButton7);
            this.pnActions.Controls.Add(this.guna2TileButton6);
            this.pnActions.Controls.Add(this.guna2TileButton3);
            this.pnActions.Controls.Add(this.guna2TileButton5);
            this.pnActions.Controls.Add(this.guna2TileButton2);
            this.pnActions.Controls.Add(this.guna2TileButton1);
            this.pnActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnActions.FillColor = System.Drawing.Color.Teal;
            this.pnActions.Location = new System.Drawing.Point(0, 724);
            this.pnActions.Name = "pnActions";
            this.pnActions.Size = new System.Drawing.Size(916, 300);
            this.pnActions.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::RM.Properties.Resources.Vector;
            this.btnExit.ImageRotate = 0F;
            this.btnExit.Location = new System.Drawing.Point(750, 178);
            this.btnExit.MaximumSize = new System.Drawing.Size(90, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 90);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2TileButton4
            // 
            this.guna2TileButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton4.BorderRadius = 10;
            this.guna2TileButton4.BorderThickness = 4;
            this.guna2TileButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton4.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton4.CheckedState.Image = global::RM.Properties.Resources.chef__1_1;
            this.guna2TileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton4.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton4.Image = global::RM.Properties.Resources.chef1;
            this.guna2TileButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2TileButton4.Location = new System.Drawing.Point(690, 39);
            this.guna2TileButton4.MaximumSize = new System.Drawing.Size(210, 100);
            this.guna2TileButton4.Name = "guna2TileButton4";
            this.guna2TileButton4.Size = new System.Drawing.Size(210, 100);
            this.guna2TileButton4.TabIndex = 0;
            this.guna2TileButton4.Text = "Отправить на кухню";
            // 
            // guna2TileButton7
            // 
            this.guna2TileButton7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton7.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton7.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton7.BorderRadius = 10;
            this.guna2TileButton7.BorderThickness = 4;
            this.guna2TileButton7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton7.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton7.CheckedState.Image = global::RM.Properties.Resources.dinner_table__1_;
            this.guna2TileButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton7.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton7.Image = global::RM.Properties.Resources.dinner_table;
            this.guna2TileButton7.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2TileButton7.Location = new System.Drawing.Point(465, 168);
            this.guna2TileButton7.MaximumSize = new System.Drawing.Size(210, 100);
            this.guna2TileButton7.Name = "guna2TileButton7";
            this.guna2TileButton7.Size = new System.Drawing.Size(210, 100);
            this.guna2TileButton7.TabIndex = 0;
            this.guna2TileButton7.Text = "В заведении";
            // 
            // guna2TileButton6
            // 
            this.guna2TileButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton6.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton6.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton6.BorderRadius = 10;
            this.guna2TileButton6.BorderThickness = 4;
            this.guna2TileButton6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton6.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton6.CheckedState.Image = global::RM.Properties.Resources.take_away__1_;
            this.guna2TileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton6.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton6.Image = global::RM.Properties.Resources.take_away;
            this.guna2TileButton6.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2TileButton6.Location = new System.Drawing.Point(240, 168);
            this.guna2TileButton6.MaximumSize = new System.Drawing.Size(210, 100);
            this.guna2TileButton6.Name = "guna2TileButton6";
            this.guna2TileButton6.Size = new System.Drawing.Size(210, 100);
            this.guna2TileButton6.TabIndex = 0;
            this.guna2TileButton6.Text = "Самовывоз";
            // 
            // guna2TileButton3
            // 
            this.guna2TileButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton3.BorderRadius = 10;
            this.guna2TileButton3.BorderThickness = 4;
            this.guna2TileButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton3.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton3.CheckedState.Image = global::RM.Properties.Resources.transaction_history__1_;
            this.guna2TileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton3.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton3.Image = global::RM.Properties.Resources.transaction_history;
            this.guna2TileButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2TileButton3.Location = new System.Drawing.Point(465, 39);
            this.guna2TileButton3.MaximumSize = new System.Drawing.Size(210, 100);
            this.guna2TileButton3.Name = "guna2TileButton3";
            this.guna2TileButton3.Size = new System.Drawing.Size(210, 100);
            this.guna2TileButton3.TabIndex = 0;
            this.guna2TileButton3.Text = "Чек-лист";
            // 
            // guna2TileButton5
            // 
            this.guna2TileButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton5.BorderRadius = 10;
            this.guna2TileButton5.BorderThickness = 4;
            this.guna2TileButton5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton5.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton5.CheckedState.Image = global::RM.Properties.Resources.fast_delivery__1_;
            this.guna2TileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton5.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton5.Image = global::RM.Properties.Resources.fast_delivery;
            this.guna2TileButton5.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2TileButton5.Location = new System.Drawing.Point(15, 168);
            this.guna2TileButton5.MaximumSize = new System.Drawing.Size(210, 100);
            this.guna2TileButton5.Name = "guna2TileButton5";
            this.guna2TileButton5.Size = new System.Drawing.Size(210, 100);
            this.guna2TileButton5.TabIndex = 0;
            this.guna2TileButton5.Text = "Доставка";
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.BorderRadius = 10;
            this.guna2TileButton2.BorderThickness = 4;
            this.guna2TileButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton2.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton2.CheckedState.Image = global::RM.Properties.Resources.time_left__1_;
            this.guna2TileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.Image = global::RM.Properties.Resources.time_left;
            this.guna2TileButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2TileButton2.Location = new System.Drawing.Point(240, 39);
            this.guna2TileButton2.MaximumSize = new System.Drawing.Size(210, 100);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.Size = new System.Drawing.Size(210, 100);
            this.guna2TileButton2.TabIndex = 0;
            this.guna2TileButton2.Text = "Отложить";
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.BorderRadius = 10;
            this.guna2TileButton1.BorderThickness = 4;
            this.guna2TileButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton1.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton1.CheckedState.Image = global::RM.Properties.Resources.add__1_;
            this.guna2TileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.Image = global::RM.Properties.Resources.add;
            this.guna2TileButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2TileButton1.Location = new System.Drawing.Point(15, 39);
            this.guna2TileButton1.MaximumSize = new System.Drawing.Size(210, 100);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(210, 100);
            this.guna2TileButton1.TabIndex = 0;
            this.guna2TileButton1.Text = "Новый заказ";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::RM.Properties.Resources.search;
            this.txtSearch.Location = new System.Drawing.Point(590, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Что найти для вас?";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(320, 48);
            this.txtSearch.TabIndex = 8;
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1267, 1024);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnActions);
            this.Controls.Add(this.lblWaiter);
            this.Controls.Add(this.lblTabel);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.pnActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTabel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private Guna.UI2.WinForms.Guna2Panel pnActions;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton4;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton7;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton6;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton3;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton5;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}