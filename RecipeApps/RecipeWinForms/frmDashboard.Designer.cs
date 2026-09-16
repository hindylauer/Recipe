namespace RecipeWinForms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            tblMain = new TableLayoutPanel();
            lblTitle = new Label();
            lblDescription = new Label();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblDataGrid = new TableLayoutPanel();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblTitle, 0, 0);
            tblMain.Controls.Add(lblDescription, 0, 1);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Controls.Add(tblDataGrid, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0048714F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0048771F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2526932F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7375612F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1094, 107);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Hearty Hearth Desktop App";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Location = new Point(3, 107);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1094, 107);
            lblDescription.TabIndex = 1;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 5;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4961548F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6692276F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6692276F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6692276F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4961548F));
            tblButtons.Controls.Add(btnRecipeList, 1, 0);
            tblButtons.Controls.Add(btnMealList, 2, 0);
            tblButtons.Controls.Add(btnCookbookList, 3, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 539);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(1094, 88);
            tblButtons.TabIndex = 2;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Location = new Point(227, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(209, 82);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Location = new Point(442, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(209, 82);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Location = new Point(657, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(209, 82);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // tblDataGrid
            // 
            tblDataGrid.ColumnCount = 3;
            tblDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDataGrid.Controls.Add(gData, 1, 0);
            tblDataGrid.Dock = DockStyle.Fill;
            tblDataGrid.Location = new Point(3, 217);
            tblDataGrid.Name = "tblDataGrid";
            tblDataGrid.RowCount = 1;
            tblDataGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDataGrid.Size = new Size(1094, 316);
            tblDataGrid.TabIndex = 3;
            // 
            // gData
            // 
            gData.Anchor = AnchorStyles.None;
            gData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Location = new Point(276, 3);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.Size = new Size(541, 310);
            gData.TabIndex = 0;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblTitle;
        private Label lblDescription;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private TableLayoutPanel tblDataGrid;
        private DataGridView gData;
    }
}