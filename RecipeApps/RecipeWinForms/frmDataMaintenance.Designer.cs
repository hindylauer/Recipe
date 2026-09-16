namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            pnlOptionButtons = new FlowLayoutPanel();
            gData = new DataGridView();
            optWebUser = new RadioButton();
            optCuisine = new RadioButton();
            optIngredient = new RadioButton();
            optMeasurement = new RadioButton();
            optCourse = new RadioButton();
            btnSave = new Button();
            tblMain.SuspendLayout();
            pnlOptionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tblMain.Controls.Add(pnlOptionButtons, 0, 0);
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 4, 4, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblMain.Size = new Size(1082, 657);
            tblMain.TabIndex = 0;
            // 
            // pnlOptionButtons
            // 
            pnlOptionButtons.Controls.Add(optWebUser);
            pnlOptionButtons.Controls.Add(optCuisine);
            pnlOptionButtons.Controls.Add(optIngredient);
            pnlOptionButtons.Controls.Add(optMeasurement);
            pnlOptionButtons.Controls.Add(optCourse);
            pnlOptionButtons.Dock = DockStyle.Fill;
            pnlOptionButtons.FlowDirection = FlowDirection.TopDown;
            pnlOptionButtons.Location = new Point(3, 3);
            pnlOptionButtons.Name = "pnlOptionButtons";
            tblMain.SetRowSpan(pnlOptionButtons, 2);
            pnlOptionButtons.Size = new Size(264, 651);
            pnlOptionButtons.TabIndex = 0;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(273, 3);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.Size = new Size(806, 552);
            gData.TabIndex = 1;
            // 
            // optWebUser
            // 
            optWebUser.AutoSize = true;
            optWebUser.Location = new Point(5, 20);
            optWebUser.Margin = new Padding(5, 20, 5, 20);
            optWebUser.Name = "optWebUser";
            optWebUser.Size = new Size(89, 32);
            optWebUser.TabIndex = 0;
            optWebUser.TabStop = true;
            optWebUser.Text = "Users";
            optWebUser.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            optCuisine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            optCuisine.AutoSize = true;
            optCuisine.Location = new Point(5, 92);
            optCuisine.Margin = new Padding(5, 20, 5, 20);
            optCuisine.Name = "optCuisine";
            optCuisine.Size = new Size(108, 32);
            optCuisine.TabIndex = 1;
            optCuisine.TabStop = true;
            optCuisine.Text = "Cuisines";
            optCuisine.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            optIngredient.AutoSize = true;
            optIngredient.Location = new Point(5, 164);
            optIngredient.Margin = new Padding(5, 20, 5, 20);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(143, 32);
            optIngredient.TabIndex = 2;
            optIngredient.TabStop = true;
            optIngredient.Text = "Ingredients";
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            optMeasurement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            optMeasurement.AutoSize = true;
            optMeasurement.Location = new Point(5, 236);
            optMeasurement.Margin = new Padding(5, 20, 5, 20);
            optMeasurement.Name = "optMeasurement";
            optMeasurement.Size = new Size(167, 32);
            optMeasurement.TabIndex = 3;
            optMeasurement.TabStop = true;
            optMeasurement.Text = "Measurements";
            optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            optCourse.AutoSize = true;
            optCourse.Location = new Point(5, 308);
            optCourse.Margin = new Padding(5, 20, 5, 20);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(107, 32);
            optCourse.TabIndex = 4;
            optCourse.TabStop = true;
            optCourse.Text = "Courses";
            optCourse.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(933, 603);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 51);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 657);
            Controls.Add(tblMain);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDataMaintenance";
            Text = "Hearty Hearth - Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlOptionButtons.ResumeLayout(false);
            pnlOptionButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optCourse;
        private RadioButton optWebUser;
        private RadioButton optCuisine;
        private RadioButton optIngredient;
        private RadioButton optMeasurement;
        private DataGridView gData;
        private Button btnSave;
    }
}