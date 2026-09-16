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
            txtAmountCalories = new TextBox();
            lblCaptionRecipe = new Label();
            txtRecipeName = new TextBox();
            lblCaptionUser = new Label();
            lblCaptionCuisine = new Label();
            lstWebUserName = new ComboBox();
            lstCuisineName = new ComboBox();
            lblCaptionNumCalories = new Label();
            lblCaptionCurrentStatus = new Label();
            lblRecipeStatus = new Label();
            lblCaptionStatusDates = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            tblStatusTexts = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            tblChildRecords = new TabControl();
            tabPage1 = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnIngredientsSave = new Button();
            gIngredients = new DataGridView();
            tabPage2 = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnStepsSave = new Button();
            gSteps = new DataGridView();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnChangeStatus = new ToolStripButton();
            tblMain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tblStatusTexts.SuspendLayout();
            tblChildRecords.SuspendLayout();
            tabPage1.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tabPage2.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.30303F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.69697F));
            tblMain.Controls.Add(txtAmountCalories, 1, 4);
            tblMain.Controls.Add(lblCaptionRecipe, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lblCaptionUser, 0, 2);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 3);
            tblMain.Controls.Add(lstWebUserName, 1, 2);
            tblMain.Controls.Add(lstCuisineName, 1, 3);
            tblMain.Controls.Add(lblCaptionNumCalories, 0, 4);
            tblMain.Controls.Add(lblCaptionCurrentStatus, 0, 5);
            tblMain.Controls.Add(lblRecipeStatus, 1, 5);
            tblMain.Controls.Add(lblCaptionStatusDates, 0, 7);
            tblMain.Controls.Add(tblStatusDates, 1, 7);
            tblMain.Controls.Add(tblStatusTexts, 1, 6);
            tblMain.Controls.Add(tblChildRecords, 0, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 3, 4, 3);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            tblMain.Size = new Size(935, 717);
            tblMain.TabIndex = 0;
            // 
            // txtAmountCalories
            // 
            txtAmountCalories.BorderStyle = BorderStyle.None;
            txtAmountCalories.Dock = DockStyle.Fill;
            txtAmountCalories.Location = new Point(287, 158);
            txtAmountCalories.Margin = new Padding(4, 3, 4, 3);
            txtAmountCalories.Multiline = true;
            txtAmountCalories.Name = "txtAmountCalories";
            txtAmountCalories.Size = new Size(644, 34);
            txtAmountCalories.TabIndex = 7;
            // 
            // lblCaptionRecipe
            // 
            lblCaptionRecipe.Anchor = AnchorStyles.Left;
            lblCaptionRecipe.AutoSize = true;
            lblCaptionRecipe.Location = new Point(4, 41);
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
            txtRecipeName.Location = new Point(286, 38);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(646, 34);
            txtRecipeName.TabIndex = 1;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.Anchor = AnchorStyles.Left;
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Location = new Point(3, 81);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(58, 28);
            lblCaptionUser.TabIndex = 2;
            lblCaptionUser.Text = "User";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Location = new Point(3, 121);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(77, 28);
            lblCaptionCuisine.TabIndex = 4;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // lstWebUserName
            // 
            lstWebUserName.Dock = DockStyle.Fill;
            lstWebUserName.DropDownStyle = ComboBoxStyle.DropDownList;
            lstWebUserName.FormattingEnabled = true;
            lstWebUserName.Location = new Point(286, 78);
            lstWebUserName.Name = "lstWebUserName";
            lstWebUserName.Size = new Size(646, 36);
            lstWebUserName.TabIndex = 3;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.DropDownStyle = ComboBoxStyle.DropDownList;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(286, 118);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(646, 36);
            lstCuisineName.TabIndex = 5;
            // 
            // lblCaptionNumCalories
            // 
            lblCaptionNumCalories.Anchor = AnchorStyles.Left;
            lblCaptionNumCalories.AutoSize = true;
            lblCaptionNumCalories.Location = new Point(3, 161);
            lblCaptionNumCalories.Name = "lblCaptionNumCalories";
            lblCaptionNumCalories.Size = new Size(134, 28);
            lblCaptionNumCalories.TabIndex = 6;
            lblCaptionNumCalories.Text = "Num Calories";
            // 
            // lblCaptionCurrentStatus
            // 
            lblCaptionCurrentStatus.Anchor = AnchorStyles.Left;
            lblCaptionCurrentStatus.AutoSize = true;
            lblCaptionCurrentStatus.Location = new Point(3, 201);
            lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            lblCaptionCurrentStatus.Size = new Size(149, 28);
            lblCaptionCurrentStatus.TabIndex = 1;
            lblCaptionCurrentStatus.Text = "Current Status";
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = SystemColors.ControlDark;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Enabled = false;
            lblRecipeStatus.Location = new Point(286, 195);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(646, 40);
            lblRecipeStatus.TabIndex = 4;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionStatusDates
            // 
            lblCaptionStatusDates.Anchor = AnchorStyles.Left;
            lblCaptionStatusDates.AutoSize = true;
            lblCaptionStatusDates.Location = new Point(3, 281);
            lblCaptionStatusDates.Name = "lblCaptionStatusDates";
            lblCaptionStatusDates.Size = new Size(131, 28);
            lblCaptionStatusDates.TabIndex = 24;
            lblCaptionStatusDates.Text = "Status Dates";
            // 
            // tblStatusDates
            // 
            tblStatusDates.AutoSize = true;
            tblStatusDates.ColumnCount = 3;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Controls.Add(lblDateDrafted, 0, 0);
            tblStatusDates.Controls.Add(lblDatePublished, 1, 0);
            tblStatusDates.Controls.Add(lblDateArchived, 2, 0);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(286, 278);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 1;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblStatusDates.Size = new Size(646, 34);
            tblStatusDates.TabIndex = 25;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = SystemColors.ControlDark;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Enabled = false;
            lblDateDrafted.Location = new Point(3, 0);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(209, 34);
            lblDateDrafted.TabIndex = 0;
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = SystemColors.ControlDark;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(218, 0);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(209, 34);
            lblDatePublished.TabIndex = 1;
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = SystemColors.ControlDark;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(433, 0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(210, 34);
            lblDateArchived.TabIndex = 2;
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusTexts
            // 
            tblStatusTexts.AutoSize = true;
            tblStatusTexts.ColumnCount = 3;
            tblStatusTexts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatusTexts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusTexts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusTexts.Controls.Add(lblDrafted, 0, 0);
            tblStatusTexts.Controls.Add(lblPublished, 1, 0);
            tblStatusTexts.Controls.Add(lblArchived, 2, 0);
            tblStatusTexts.Dock = DockStyle.Fill;
            tblStatusTexts.Location = new Point(286, 238);
            tblStatusTexts.Name = "tblStatusTexts";
            tblStatusTexts.RowCount = 1;
            tblStatusTexts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusTexts.Size = new Size(646, 34);
            tblStatusTexts.TabIndex = 26;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Font = new Font("Comic Sans MS", 11F);
            lblDrafted.Location = new Point(3, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(209, 34);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Font = new Font("Comic Sans MS", 11F);
            lblPublished.Location = new Point(218, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(209, 34);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Font = new Font("Comic Sans MS", 11F);
            lblArchived.Location = new Point(433, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(210, 34);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblChildRecords
            // 
            tblMain.SetColumnSpan(tblChildRecords, 2);
            tblChildRecords.Controls.Add(tabPage1);
            tblChildRecords.Controls.Add(tabPage2);
            tblChildRecords.Dock = DockStyle.Fill;
            tblChildRecords.Location = new Point(3, 318);
            tblChildRecords.Name = "tblChildRecords";
            tblChildRecords.SelectedIndex = 0;
            tblChildRecords.Size = new Size(929, 396);
            tblChildRecords.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblIngredients);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(921, 355);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingredients";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblIngredients.Controls.Add(btnIngredientsSave, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tblIngredients.Size = new Size(915, 349);
            tblIngredients.TabIndex = 0;
            // 
            // btnIngredientsSave
            // 
            btnIngredientsSave.Dock = DockStyle.Left;
            btnIngredientsSave.Location = new Point(3, 3);
            btnIngredientsSave.Name = "btnIngredientsSave";
            btnIngredientsSave.Size = new Size(94, 46);
            btnIngredientsSave.TabIndex = 1;
            btnIngredientsSave.Text = "S&ave";
            btnIngredientsSave.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 55);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.Size = new Size(909, 291);
            gIngredients.TabIndex = 10;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tblSteps);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(921, 363);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Steps";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblSteps.Controls.Add(btnStepsSave, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tblSteps.Size = new Size(915, 357);
            tblSteps.TabIndex = 0;
            // 
            // btnStepsSave
            // 
            btnStepsSave.Dock = DockStyle.Left;
            btnStepsSave.Location = new Point(3, 3);
            btnStepsSave.Name = "btnStepsSave";
            btnStepsSave.Size = new Size(94, 47);
            btnStepsSave.TabIndex = 0;
            btnStepsSave.Text = "S&ave";
            btnStepsSave.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 56);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.Size = new Size(909, 298);
            gSteps.TabIndex = 1;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Comic Sans MS", 12F);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2, btnChangeStatus });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(935, 35);
            tsMain.TabIndex = 8;
            tsMain.TabStop = true;
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
            // btnChangeStatus
            // 
            btnChangeStatus.Alignment = ToolStripItemAlignment.Right;
            btnChangeStatus.BackColor = Color.White;
            btnChangeStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnChangeStatus.ImageTransparentColor = Color.Magenta;
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(148, 32);
            btnChangeStatus.Text = "&Change Status";
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 717);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmRecipe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tblStatusTexts.ResumeLayout(false);
            tblStatusTexts.PerformLayout();
            tblChildRecords.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tabPage2.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipe;
        private TextBox txtRecipeName;
        private Label lblCaptionUser;
        private Label lblCaptionCuisine;
        private ComboBox lstWebUserName;
        private ComboBox lstCuisineName;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnChangeStatus;
        private TextBox txtAmountCalories;
        private Label lblCaptionNumCalories;
        private Label lblCaptionCurrentStatus;
        private Label lblRecipeStatus;
        private Label lblCaptionStatusDates;
        private TableLayoutPanel tblStatusDates;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TableLayoutPanel tblStatusTexts;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TabControl tblChildRecords;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tblIngredients;
        private Button btnIngredientsSave;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnStepsSave;
        private DataGridView gSteps;
    }
}