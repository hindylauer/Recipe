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
            txtUser = new TextBox();
            txtCuisine = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Left;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
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
            tblMain.Controls.Add(txtUser, 1, 1);
            tblMain.Controls.Add(txtCuisine, 1, 2);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 3, 4, 3);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937563F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937534F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937534F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937534F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937534F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4937534F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5187426F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5187426F));
            tblMain.Size = new Size(648, 307);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipe
            // 
            lblCaptionRecipe.Anchor = AnchorStyles.Left;
            lblCaptionRecipe.AutoSize = true;
            lblCaptionRecipe.Location = new Point(4, 5);
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
            txtRecipeName.Location = new Point(327, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(318, 32);
            txtRecipeName.TabIndex = 12;
            // 
            // lblCaptionAmountCalories
            // 
            lblCaptionAmountCalories.Anchor = AnchorStyles.Left;
            lblCaptionAmountCalories.AutoSize = true;
            lblCaptionAmountCalories.Location = new Point(4, 272);
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
            lblCaptionRecipeStatus.Location = new Point(4, 233);
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
            lblCaptionDateArchived.Location = new Point(4, 195);
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
            lblCaptionDatePublished.Location = new Point(4, 157);
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
            lblCaptionUser.Location = new Point(3, 43);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(58, 28);
            lblCaptionUser.TabIndex = 17;
            lblCaptionUser.Text = "User";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(4, 119);
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
            lblCaptionCuisine.Location = new Point(3, 81);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(77, 28);
            lblCaptionCuisine.TabIndex = 18;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // dtpDateDrafted
            // 
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
            dtpDateDrafted.Location = new Point(327, 117);
            dtpDateDrafted.Name = "dtpDateDrafted";
            dtpDateDrafted.Size = new Size(159, 35);
            dtpDateDrafted.TabIndex = 16;
            // 
            // txtAmountCalories
            // 
            txtAmountCalories.BorderStyle = BorderStyle.None;
            txtAmountCalories.Location = new Point(328, 269);
            txtAmountCalories.Margin = new Padding(4, 3, 4, 3);
            txtAmountCalories.Multiline = true;
            txtAmountCalories.Name = "txtAmountCalories";
            txtAmountCalories.Size = new Size(316, 32);
            txtAmountCalories.TabIndex = 11;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(327, 228);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(318, 38);
            lblRecipeStatus.TabIndex = 15;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Location = new Point(327, 152);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(318, 38);
            lblDatePublished.TabIndex = 13;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(327, 190);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(318, 38);
            lblDateArchived.TabIndex = 14;
            // 
            // txtUser
            // 
            txtUser.Dock = DockStyle.Fill;
            txtUser.Location = new Point(327, 41);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(318, 35);
            txtUser.TabIndex = 19;
            // 
            // txtCuisine
            // 
            txtCuisine.Dock = DockStyle.Fill;
            txtCuisine.Location = new Point(327, 79);
            txtCuisine.Name = "txtCuisine";
            txtCuisine.Size = new Size(318, 35);
            txtCuisine.TabIndex = 20;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 307);
            Controls.Add(tblMain);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
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
        private TextBox txtUser;
        private TextBox txtCuisine;
    }
}