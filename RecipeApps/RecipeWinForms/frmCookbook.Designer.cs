namespace RecipeWinForms
{
    partial class frmCookbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCookbook));
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            tblMain = new TableLayoutPanel();
            lblCookbookName = new Label();
            lblWebUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            txtCookbookName = new TextBox();
            lstWebUserName = new ComboBox();
            tblPrice = new TableLayoutPanel();
            lblCaptionDateCreated = new Label();
            txtCookbookPrice = new TextBox();
            lblDateCookbookCreated = new Label();
            cbActive = new CheckBox();
            tblRecipe = new TableLayoutPanel();
            btnRecipeSave = new Button();
            gData = new DataGridView();
            tsMain.SuspendLayout();
            tblMain.SuspendLayout();
            tblPrice.SuspendLayout();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(838, 35);
            tsMain.TabIndex = 0;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(61, 32);
            btnSave.Text = "Save";
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
            btnDelete.Text = "Delete";
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblMain.Controls.Add(lblCookbookName, 0, 0);
            tblMain.Controls.Add(lblWebUser, 0, 1);
            tblMain.Controls.Add(lblPrice, 0, 2);
            tblMain.Controls.Add(lblActive, 0, 3);
            tblMain.Controls.Add(txtCookbookName, 1, 0);
            tblMain.Controls.Add(lstWebUserName, 1, 1);
            tblMain.Controls.Add(tblPrice, 1, 2);
            tblMain.Controls.Add(cbActive, 1, 3);
            tblMain.Controls.Add(tblRecipe, 0, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 35);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.13607931F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.13607931F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2332792F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.13607931F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 66.35848F));
            tblMain.Size = new Size(838, 664);
            tblMain.TabIndex = 1;
            // 
            // lblCookbookName
            // 
            lblCookbookName.AutoSize = true;
            lblCookbookName.Dock = DockStyle.Left;
            lblCookbookName.Location = new Point(3, 0);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(160, 47);
            lblCookbookName.TabIndex = 0;
            lblCookbookName.Text = "Cookbook Name";
            lblCookbookName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWebUser
            // 
            lblWebUser.AutoSize = true;
            lblWebUser.Dock = DockStyle.Left;
            lblWebUser.Location = new Point(3, 47);
            lblWebUser.Name = "lblWebUser";
            lblWebUser.Size = new Size(58, 47);
            lblWebUser.TabIndex = 1;
            lblWebUser.Text = "User";
            lblWebUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Left;
            lblPrice.Location = new Point(3, 94);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 81);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Dock = DockStyle.Left;
            lblActive.Location = new Point(3, 175);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(71, 47);
            lblActive.TabIndex = 3;
            lblActive.Text = "Active";
            lblActive.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCookbookName
            // 
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(254, 3);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(581, 35);
            txtCookbookName.TabIndex = 4;
            // 
            // lstWebUserName
            // 
            lstWebUserName.Dock = DockStyle.Fill;
            lstWebUserName.DropDownStyle = ComboBoxStyle.DropDownList;
            lstWebUserName.FormattingEnabled = true;
            lstWebUserName.Location = new Point(254, 50);
            lstWebUserName.Name = "lstWebUserName";
            lstWebUserName.Size = new Size(581, 36);
            lstWebUserName.TabIndex = 5;
            // 
            // tblPrice
            // 
            tblPrice.ColumnCount = 2;
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPrice.Controls.Add(lblCaptionDateCreated, 1, 0);
            tblPrice.Controls.Add(txtCookbookPrice, 0, 1);
            tblPrice.Controls.Add(lblDateCookbookCreated, 1, 1);
            tblPrice.Dock = DockStyle.Fill;
            tblPrice.Location = new Point(254, 97);
            tblPrice.Name = "tblPrice";
            tblPrice.RowCount = 2;
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblPrice.Size = new Size(581, 75);
            tblPrice.TabIndex = 6;
            // 
            // lblCaptionDateCreated
            // 
            lblCaptionDateCreated.AutoSize = true;
            lblCaptionDateCreated.Dock = DockStyle.Fill;
            lblCaptionDateCreated.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaptionDateCreated.Location = new Point(293, 0);
            lblCaptionDateCreated.Name = "lblCaptionDateCreated";
            lblCaptionDateCreated.Size = new Size(285, 30);
            lblCaptionDateCreated.TabIndex = 0;
            lblCaptionDateCreated.Text = "Date Created:";
            lblCaptionDateCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCookbookPrice
            // 
            txtCookbookPrice.Dock = DockStyle.Left;
            txtCookbookPrice.Location = new Point(3, 33);
            txtCookbookPrice.Name = "txtCookbookPrice";
            txtCookbookPrice.Size = new Size(138, 35);
            txtCookbookPrice.TabIndex = 1;
            // 
            // lblDateCookbookCreated
            // 
            lblDateCookbookCreated.AutoSize = true;
            lblDateCookbookCreated.BackColor = SystemColors.ActiveBorder;
            lblDateCookbookCreated.Dock = DockStyle.Fill;
            lblDateCookbookCreated.Location = new Point(293, 30);
            lblDateCookbookCreated.Name = "lblDateCookbookCreated";
            lblDateCookbookCreated.Size = new Size(285, 45);
            lblDateCookbookCreated.TabIndex = 2;
            lblDateCookbookCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Dock = DockStyle.Left;
            cbActive.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbActive.Location = new Point(254, 178);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(18, 41);
            cbActive.TabIndex = 7;
            cbActive.UseVisualStyleBackColor = true;
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 1;
            tblMain.SetColumnSpan(tblRecipe, 2);
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipe.Controls.Add(btnRecipeSave, 0, 0);
            tblRecipe.Controls.Add(gData, 0, 1);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(3, 225);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tblRecipe.Size = new Size(832, 436);
            tblRecipe.TabIndex = 8;
            // 
            // btnRecipeSave
            // 
            btnRecipeSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRecipeSave.AutoSize = true;
            btnRecipeSave.Location = new Point(3, 16);
            btnRecipeSave.Name = "btnRecipeSave";
            btnRecipeSave.Size = new Size(94, 46);
            btnRecipeSave.TabIndex = 0;
            btnRecipeSave.Text = "Save";
            btnRecipeSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(3, 68);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.Size = new Size(826, 365);
            gData.TabIndex = 1;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 699);
            Controls.Add(tblMain);
            Controls.Add(tsMain);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "frmCookbook";
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblPrice.ResumeLayout(false);
            tblPrice.PerformLayout();
            tblRecipe.ResumeLayout(false);
            tblRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private TableLayoutPanel tblMain;
        private Label lblCookbookName;
        private Label lblWebUser;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtCookbookName;
        private ComboBox lstWebUserName;
        private TableLayoutPanel tblPrice;
        private Label lblCaptionDateCreated;
        private TextBox txtCookbookPrice;
        private Label lblDateCookbookCreated;
        private CheckBox cbActive;
        private TableLayoutPanel tblRecipe;
        private Button btnRecipeSave;
        private DataGridView gData;
    }
}