namespace RecipeWinForms
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            tblMain = new TableLayoutPanel();
            lblCaptionRecipe = new Label();
            txtRecipeName = new TextBox();
            lblCaptionAmountCalories = new Label();
            lblCaptionRecipeStatus = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionUser = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionCuisine = new Label();
            dtpDateDrafted = new DateTimePicker();
            txtAmountCalories = new TextBox();
            lblRecipeStatus = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lstWebUserName = new ComboBox();
            lstCuisineName = new ComboBox();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73F));
            tblMain.Controls.Add(lblCaptionRecipe, 0, 0);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lblCaptionAmountCalories, 0, 7);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 6);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 5);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 4);
            tblMain.Controls.Add(lblCaptionUser, 0, 1);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 3);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 2);
            tblMain.Controls.Add(dtpDateDrafted, 1, 3);
            tblMain.Controls.Add(txtAmountCalories, 1, 7);
            tblMain.Controls.Add(lblRecipeStatus, 1, 6);
            tblMain.Controls.Add(lblDatePublished, 1, 4);
            tblMain.Controls.Add(lblDateArchived, 1, 5);
            tblMain.Controls.Add(lstWebUserName, 1, 1);
            tblMain.Controls.Add(lstCuisineName, 1, 2);
            tblMain.Location = new Point(0, 39);
            tblMain.Margin = new Padding(4, 3, 4, 3);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937592F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937525F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937525F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937525F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937525F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937525F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5187416F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.51874F));
            tblMain.Size = new Size(645, 304);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipe
            // 
            lblCaptionRecipe.Anchor = AnchorStyles.Left;
            lblCaptionRecipe.AutoSize = true;
            lblCaptionRecipe.Location = new Point(4, 4);
            lblCaptionRecipe.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipe.Name = "lblCaptionRecipe";
            lblCaptionRecipe.Size = new Size(132, 28);
            lblCaptionRecipe.TabIndex = 0;
            lblCaptionRecipe.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.BorderStyle = BorderStyle.None;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(177, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(465, 31);
            txtRecipeName.TabIndex = 1;
            // 
            // lblCaptionAmountCalories
            // 
            lblCaptionAmountCalories.Anchor = AnchorStyles.Left;
            lblCaptionAmountCalories.AutoSize = true;
            lblCaptionAmountCalories.Location = new Point(4, 268);
            lblCaptionAmountCalories.Margin = new Padding(4, 0, 4, 0);
            lblCaptionAmountCalories.Name = "lblCaptionAmountCalories";
            lblCaptionAmountCalories.Size = new Size(161, 28);
            lblCaptionAmountCalories.TabIndex = 5;
            lblCaptionAmountCalories.Text = "Amount Calories";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(4, 227);
            lblCaptionRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(140, 28);
            lblCaptionRecipeStatus.TabIndex = 4;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Location = new Point(4, 189);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(146, 28);
            lblCaptionDateArchived.TabIndex = 3;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Location = new Point(4, 152);
            lblCaptionDatePublished.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(149, 28);
            lblCaptionDatePublished.TabIndex = 2;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.Anchor = AnchorStyles.Left;
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Location = new Point(3, 41);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(58, 28);
            lblCaptionUser.TabIndex = 17;
            lblCaptionUser.Text = "User";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(4, 115);
            lblCaptionDateDrafted.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(136, 28);
            lblCaptionDateDrafted.TabIndex = 1;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Location = new Point(3, 78);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(77, 28);
            lblCaptionCuisine.TabIndex = 18;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // dtpDateDrafted
            // 
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
            dtpDateDrafted.Location = new Point(177, 114);
            dtpDateDrafted.Name = "dtpDateDrafted";
            dtpDateDrafted.Size = new Size(180, 35);
            dtpDateDrafted.TabIndex = 4;
            // 
            // txtAmountCalories
            // 
            txtAmountCalories.BorderStyle = BorderStyle.None;
            txtAmountCalories.Dock = DockStyle.Fill;
            txtAmountCalories.Location = new Point(178, 263);
            txtAmountCalories.Margin = new Padding(4, 3, 4, 3);
            txtAmountCalories.Multiline = true;
            txtAmountCalories.Name = "txtAmountCalories";
            txtAmountCalories.Size = new Size(463, 38);
            txtAmountCalories.TabIndex = 8;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(177, 222);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(465, 38);
            lblRecipeStatus.TabIndex = 7;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(177, 148);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(465, 37);
            lblDatePublished.TabIndex = 5;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(177, 185);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(465, 37);
            lblDateArchived.TabIndex = 6;
            // 
            // lstWebUserName
            // 
            lstWebUserName.Dock = DockStyle.Fill;
            lstWebUserName.FormattingEnabled = true;
            lstWebUserName.Location = new Point(177, 40);
            lstWebUserName.Name = "lstWebUserName";
            lstWebUserName.Size = new Size(465, 36);
            lstWebUserName.TabIndex = 2;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(177, 77);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(465, 36);
            lstCuisineName.TabIndex = 3;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Comic Sans MS", 12F);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(646, 35);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
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
            btnDelete.BackColor = Color.White;
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 32);
            btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 380);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipe;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private Label lblCaptionAmountCalories;
        private TextBox txtAmountCalories;
        private TextBox txtRecipeName;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblRecipeStatus;
        private DateTimePicker dtpDateDrafted;
        private Label lblCaptionUser;
        private Label lblCaptionCuisine;
        private ComboBox lstWebUserName;
        private ComboBox lstCuisineName;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
    }
}