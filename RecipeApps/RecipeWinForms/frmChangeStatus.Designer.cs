namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            tblMain = new TableLayoutPanel();
            lblRecipeName = new Label();
            tblStatusTitles = new TableLayoutPanel();
            lblDraftedCaption = new Label();
            lblPublishedCaption = new Label();
            lblArchivedCaption = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            tblStatusButtons = new TableLayoutPanel();
            btnPublish = new Button();
            btnDraft = new Button();
            btnArchive = new Button();
            tblStatusText = new TableLayoutPanel();
            lblRecipeStatus = new Label();
            lblCurrentStatusTitle = new Label();
            tblMain.SuspendLayout();
            tblStatusTitles.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tblStatusButtons.SuspendLayout();
            tblStatusText.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(tblStatusTitles, 0, 2);
            tblMain.Controls.Add(tblStatusDates, 0, 3);
            tblMain.Controls.Add(tblStatusButtons, 0, 4);
            tblMain.Controls.Add(tblStatusText, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(5, 4, 5, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2429161F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.642252F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.201324F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4276762F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40.4858246F));
            tblMain.Size = new Size(697, 424);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblRecipeName.Location = new Point(5, 0);
            lblRecipeName.Margin = new Padding(5, 0, 5, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(687, 85);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusTitles
            // 
            tblStatusTitles.ColumnCount = 5;
            tblStatusTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusTitles.Controls.Add(lblDraftedCaption, 1, 0);
            tblStatusTitles.Controls.Add(lblPublishedCaption, 2, 0);
            tblStatusTitles.Controls.Add(lblArchivedCaption, 3, 0);
            tblStatusTitles.Dock = DockStyle.Fill;
            tblStatusTitles.Location = new Point(5, 155);
            tblStatusTitles.Margin = new Padding(5, 4, 5, 4);
            tblStatusTitles.Name = "tblStatusTitles";
            tblStatusTitles.RowCount = 1;
            tblStatusTitles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusTitles.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tblStatusTitles.Size = new Size(687, 31);
            tblStatusTitles.TabIndex = 2;
            // 
            // lblDraftedCaption
            // 
            lblDraftedCaption.AutoSize = true;
            lblDraftedCaption.Dock = DockStyle.Fill;
            lblDraftedCaption.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDraftedCaption.Location = new Point(142, 0);
            lblDraftedCaption.Margin = new Padding(5, 0, 5, 0);
            lblDraftedCaption.Name = "lblDraftedCaption";
            lblDraftedCaption.Size = new Size(127, 31);
            lblDraftedCaption.TabIndex = 0;
            lblDraftedCaption.Text = "Drafted";
            lblDraftedCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublishedCaption
            // 
            lblPublishedCaption.AutoSize = true;
            lblPublishedCaption.Dock = DockStyle.Fill;
            lblPublishedCaption.Font = new Font("Comic Sans MS", 10F);
            lblPublishedCaption.Location = new Point(279, 0);
            lblPublishedCaption.Margin = new Padding(5, 0, 5, 0);
            lblPublishedCaption.Name = "lblPublishedCaption";
            lblPublishedCaption.Size = new Size(127, 31);
            lblPublishedCaption.TabIndex = 1;
            lblPublishedCaption.Text = "Published";
            lblPublishedCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchivedCaption
            // 
            lblArchivedCaption.AutoSize = true;
            lblArchivedCaption.Dock = DockStyle.Fill;
            lblArchivedCaption.Font = new Font("Comic Sans MS", 10F);
            lblArchivedCaption.Location = new Point(416, 0);
            lblArchivedCaption.Margin = new Padding(5, 0, 5, 0);
            lblArchivedCaption.Name = "lblArchivedCaption";
            lblArchivedCaption.Size = new Size(127, 31);
            lblArchivedCaption.TabIndex = 2;
            lblArchivedCaption.Text = "Archived";
            lblArchivedCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 5;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.Controls.Add(lblStatusDates, 0, 0);
            tblStatusDates.Controls.Add(lblDateDrafted, 1, 0);
            tblStatusDates.Controls.Add(lblDatePublished, 2, 0);
            tblStatusDates.Controls.Add(lblDateArchived, 3, 0);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(3, 193);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 1;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblStatusDates.Size = new Size(691, 55);
            tblStatusDates.TabIndex = 3;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 0);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(132, 55);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(141, 0);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(132, 55);
            lblDateDrafted.TabIndex = 1;
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(279, 0);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(132, 55);
            lblDatePublished.TabIndex = 2;
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(417, 0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(132, 55);
            lblDateArchived.TabIndex = 3;
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusButtons
            // 
            tblStatusButtons.ColumnCount = 5;
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.625F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.916666F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.916666F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.916666F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.625F));
            tblStatusButtons.Controls.Add(btnPublish, 2, 1);
            tblStatusButtons.Controls.Add(btnDraft, 1, 1);
            tblStatusButtons.Controls.Add(btnArchive, 3, 1);
            tblStatusButtons.Dock = DockStyle.Fill;
            tblStatusButtons.Location = new Point(3, 254);
            tblStatusButtons.Name = "tblStatusButtons";
            tblStatusButtons.RowCount = 3;
            tblStatusButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tblStatusButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tblStatusButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tblStatusButtons.Size = new Size(691, 167);
            tblStatusButtons.TabIndex = 4;
            // 
            // btnPublish
            // 
            btnPublish.Dock = DockStyle.Fill;
            btnPublish.Location = new Point(268, 56);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(152, 52);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnDraft
            // 
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Location = new Point(110, 56);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(152, 52);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Dock = DockStyle.Fill;
            btnArchive.Location = new Point(426, 56);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(152, 52);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // tblStatusText
            // 
            tblStatusText.ColumnCount = 2;
            tblStatusText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatusText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatusText.Controls.Add(lblRecipeStatus, 1, 0);
            tblStatusText.Controls.Add(lblCurrentStatusTitle, 0, 0);
            tblStatusText.Dock = DockStyle.Fill;
            tblStatusText.Location = new Point(3, 88);
            tblStatusText.Name = "tblStatusText";
            tblStatusText.RowCount = 1;
            tblStatusText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusText.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblStatusText.Size = new Size(691, 60);
            tblStatusText.TabIndex = 5;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeStatus.Location = new Point(348, 0);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(340, 60);
            lblRecipeStatus.TabIndex = 1;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCurrentStatusTitle
            // 
            lblCurrentStatusTitle.AutoSize = true;
            lblCurrentStatusTitle.Dock = DockStyle.Fill;
            lblCurrentStatusTitle.Font = new Font("Comic Sans MS", 14F);
            lblCurrentStatusTitle.Location = new Point(3, 0);
            lblCurrentStatusTitle.Name = "lblCurrentStatusTitle";
            lblCurrentStatusTitle.Size = new Size(339, 60);
            lblCurrentStatusTitle.TabIndex = 0;
            lblCurrentStatusTitle.Text = "Current Status: ";
            lblCurrentStatusTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 424);
            Controls.Add(tblMain);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmChangeStatus";
            Text = "Recipe - ChangeStatus";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatusTitles.ResumeLayout(false);
            tblStatusTitles.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tblStatusButtons.ResumeLayout(false);
            tblStatusText.ResumeLayout(false);
            tblStatusText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private TableLayoutPanel tblStatusTitles;
        private Label lblDraftedCaption;
        private Label lblPublishedCaption;
        private Label lblArchivedCaption;
        private TableLayoutPanel tblStatusDates;
        private Label lblStatusDates;
        private TableLayoutPanel tblStatusButtons;
        private Button btnPublish;
        private Button btnDraft;
        private Button btnArchive;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TableLayoutPanel tblStatusText;
        private Label lblRecipeStatus;
        private Label lblCurrentStatusTitle;
    }
}