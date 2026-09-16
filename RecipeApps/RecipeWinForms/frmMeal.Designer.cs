namespace RecipeWinForms
{
    partial class frmMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeal));
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            tblMain = new TableLayoutPanel();
            lblMealName = new Label();
            lblWebUser = new Label();
            lblDateMealCreated = new Label();
            txtMealName = new TextBox();
            lstWebUserName = new ComboBox();
            dtpDateMealCreated = new DateTimePicker();
            tblActive = new TableLayoutPanel();
            optActive = new RadioButton();
            optInactive = new RadioButton();
            tsMain.SuspendLayout();
            tblMain.SuspendLayout();
            tblActive.SuspendLayout();
            SuspendLayout();
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(686, 35);
            tsMain.TabIndex = 8;
            tsMain.TabStop = true;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(61, 32);
            btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 32);
            btnDelete.Text = "&Delete";
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblMain.Controls.Add(lblMealName, 0, 0);
            tblMain.Controls.Add(lblWebUser, 0, 1);
            tblMain.Controls.Add(lblDateMealCreated, 0, 2);
            tblMain.Controls.Add(txtMealName, 1, 0);
            tblMain.Controls.Add(lstWebUserName, 1, 1);
            tblMain.Controls.Add(dtpDateMealCreated, 1, 2);
            tblMain.Controls.Add(tblActive, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 35);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(686, 392);
            tblMain.TabIndex = 1;
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.Dock = DockStyle.Left;
            lblMealName.Location = new Point(3, 0);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(114, 98);
            lblMealName.TabIndex = 0;
            lblMealName.Text = "Meal Name";
            // 
            // lblWebUser
            // 
            lblWebUser.AutoSize = true;
            lblWebUser.Dock = DockStyle.Left;
            lblWebUser.Location = new Point(3, 98);
            lblWebUser.Name = "lblWebUser";
            lblWebUser.Size = new Size(58, 98);
            lblWebUser.TabIndex = 2;
            lblWebUser.Text = "User";
            // 
            // lblDateMealCreated
            // 
            lblDateMealCreated.AutoSize = true;
            lblDateMealCreated.Dock = DockStyle.Left;
            lblDateMealCreated.Location = new Point(3, 196);
            lblDateMealCreated.Name = "lblDateMealCreated";
            lblDateMealCreated.Size = new Size(135, 98);
            lblDateMealCreated.TabIndex = 5;
            lblDateMealCreated.Text = "Date Created";
            // 
            // txtMealName
            // 
            txtMealName.Dock = DockStyle.Fill;
            txtMealName.Location = new Point(277, 3);
            txtMealName.Name = "txtMealName";
            txtMealName.Size = new Size(406, 35);
            txtMealName.TabIndex = 1;
            // 
            // lstWebUserName
            // 
            lstWebUserName.Dock = DockStyle.Fill;
            lstWebUserName.DropDownStyle = ComboBoxStyle.DropDownList;
            lstWebUserName.FormattingEnabled = true;
            lstWebUserName.Location = new Point(277, 101);
            lstWebUserName.Name = "lstWebUserName";
            lstWebUserName.Size = new Size(406, 36);
            lstWebUserName.TabIndex = 4;
            // 
            // dtpDateMealCreated
            // 
            dtpDateMealCreated.Dock = DockStyle.Fill;
            dtpDateMealCreated.Location = new Point(277, 199);
            dtpDateMealCreated.Name = "dtpDateMealCreated";
            dtpDateMealCreated.Size = new Size(406, 35);
            dtpDateMealCreated.TabIndex = 6;
            // 
            // tblActive
            // 
            tblActive.ColumnCount = 1;
            tblActive.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblActive.Controls.Add(optActive, 0, 0);
            tblActive.Controls.Add(optInactive, 0, 1);
            tblActive.Location = new Point(277, 297);
            tblActive.Name = "tblActive";
            tblActive.RowCount = 2;
            tblActive.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActive.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActive.Size = new Size(406, 92);
            tblActive.TabIndex = 7;
            // 
            // optActive
            // 
            optActive.AutoSize = true;
            optActive.Dock = DockStyle.Fill;
            optActive.Location = new Point(3, 3);
            optActive.Name = "optActive";
            optActive.Size = new Size(400, 40);
            optActive.TabIndex = 0;
            optActive.TabStop = true;
            optActive.Text = "Active";
            optActive.UseVisualStyleBackColor = true;
            // 
            // optInactive
            // 
            optInactive.AutoSize = true;
            optInactive.Dock = DockStyle.Fill;
            optInactive.Location = new Point(3, 49);
            optInactive.Name = "optInactive";
            optInactive.Size = new Size(400, 40);
            optInactive.TabIndex = 1;
            optInactive.TabStop = true;
            optInactive.Text = "Inactive";
            optInactive.UseVisualStyleBackColor = true;
            // 
            // frmMeal
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 427);
            Controls.Add(tblMain);
            Controls.Add(tsMain);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmMeal";
            Text = "Meal";
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblActive.ResumeLayout(false);
            tblActive.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private TableLayoutPanel tblMain;
        private Label lblMealName;
        private Label lblWebUser;
        private Label lblDateMealCreated;
        private TextBox txtMealName;
        private ComboBox lstWebUserName;
        private DateTimePicker dtpDateMealCreated;
        private TableLayoutPanel tblActive;
        private RadioButton optActive;
        private RadioButton optInactive;
    }
}