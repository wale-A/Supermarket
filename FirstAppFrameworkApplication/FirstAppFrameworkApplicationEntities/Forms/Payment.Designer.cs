namespace FirstAppFrameworkApplicationEntities.Forms
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formDataGridView1 = new AppFramework.Controls.FormDataGridView();
            this.formDataGridView2 = new AppFramework.Controls.FormDataGridView();
            this.buttonGroup1 = new AppFramework.Controls.ButtonGroup();
            this.runnableFormButton1 = new AppFramework.Controls.RunnableFormButton();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView2)).BeginInit();
            this.buttonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formDataGridView1
            // 
            this.formDataGridView1.AllowArgsAssociation = true;
            this.formDataGridView1.AllowUserAdd = true;
            this.formDataGridView1.AllowUserDelete = true;
            this.formDataGridView1.AllowUserToOrderColumns = true;
            this.formDataGridView1.AllowUserUpdate = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.formDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.formDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formDataGridView1.AssociatedDataGrid = null;
            this.formDataGridView1.AutoFields = true;
            this.formDataGridView1.AutoFieldsGroup = "nonsystem";
            this.formDataGridView1.AutoLoad = true;
            this.formDataGridView1.AutoSelectGridOnTabChange = true;
            this.formDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.formDataGridView1.Caption = "";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.formDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formDataGridView1.Criteria = "";
            this.formDataGridView1.DiscardUserSettings = false;
            this.formDataGridView1.DrillDownEnabled = true;
            this.formDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.formDataGridView1.EnittyViewTypeFullName = null;
            this.formDataGridView1.EntityBaseNamespace = "";
            this.formDataGridView1.EntityBaseTypeName = "Order";
            this.formDataGridView1.HelpTopic = null;
            this.formDataGridView1.Location = new System.Drawing.Point(0, 27);
            this.formDataGridView1.Name = "formDataGridView1";
            this.formDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.formDataGridView1.ShowGridFilter = false;
            this.formDataGridView1.Size = new System.Drawing.Size(676, 121);
            this.formDataGridView1.SortColumn = "ID";
            this.formDataGridView1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.formDataGridView1.StartPosition = AppFramework.Controls.ScrollPosition.First;
            this.formDataGridView1.TabIndex = 1;
            // 
            // formDataGridView2
            // 
            this.formDataGridView2.AllowArgsAssociation = true;
            this.formDataGridView2.AllowUserAdd = true;
            this.formDataGridView2.AllowUserDelete = true;
            this.formDataGridView2.AllowUserToOrderColumns = true;
            this.formDataGridView2.AllowUserUpdate = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.formDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.formDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formDataGridView2.AssociatedDataGrid = this.formDataGridView1;
            this.formDataGridView2.AutoFields = true;
            this.formDataGridView2.AutoFieldsGroup = "grid";
            this.formDataGridView2.AutoLoad = true;
            this.formDataGridView2.AutoSelectGridOnTabChange = true;
            this.formDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.formDataGridView2.Caption = "";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.formDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formDataGridView2.Criteria = "";
            this.formDataGridView2.DiscardUserSettings = false;
            this.formDataGridView2.DrillDownEnabled = true;
            this.formDataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.formDataGridView2.EnittyViewTypeFullName = null;
            this.formDataGridView2.EntityBaseNamespace = "";
            this.formDataGridView2.EntityBaseTypeName = "Payment";
            this.formDataGridView2.HelpTopic = null;
            this.formDataGridView2.Location = new System.Drawing.Point(0, 145);
            this.formDataGridView2.Name = "formDataGridView2";
            this.formDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.formDataGridView2.ShowGridFilter = false;
            this.formDataGridView2.Size = new System.Drawing.Size(676, 131);
            this.formDataGridView2.SortColumn = "ID";
            this.formDataGridView2.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.formDataGridView2.StartPosition = AppFramework.Controls.ScrollPosition.First;
            this.formDataGridView2.TabIndex = 2;
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Controls.Add(this.runnableFormButton1);
            this.buttonGroup1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGroup1.Location = new System.Drawing.Point(675, 25);
            this.buttonGroup1.Name = "buttonGroup1";
            this.buttonGroup1.Size = new System.Drawing.Size(130, 251);
            this.buttonGroup1.TabIndex = 3;
            // 
            // runnableFormButton1
            // 
            this.runnableFormButton1.AllowAssociatedGridMultiSelect = false;
            this.runnableFormButton1.ArgsValueString = null;
            this.runnableFormButton1.AssociatedDataGrid = this.formDataGridView2;
            this.runnableFormButton1.DiscardUserSettings = false;
            this.runnableFormButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.runnableFormButton1.EnableEvenIfAssociatedGridIsEmpty = false;
            this.runnableFormButton1.HelpTopic = null;
            this.runnableFormButton1.Location = new System.Drawing.Point(3, 3);
            this.runnableFormButton1.Name = "runnableFormButton1";
            this.runnableFormButton1.ReloadGridAfter = false;
            this.runnableFormButton1.ReloadSelectedEntityAfter = false;
            this.runnableFormButton1.RequiredLicense = "";
            this.runnableFormButton1.RequiredPermissionLevel = AppFramework.AppClasses.AccessLevel.None;
            this.runnableFormButton1.RunnableInteractive = false;
            this.runnableFormButton1.RunnableTypeName = "ReceiptReport";
            this.runnableFormButton1.RunnableTypeNamespace = "FirstAppFrameworkApplicationEntities.ReportClasses";
            this.runnableFormButton1.SaveCurrentEntity = true;
            this.runnableFormButton1.Size = new System.Drawing.Size(130, 40);
            this.runnableFormButton1.TabIndex = 0;
            this.runnableFormButton1.Text = "Generate Receipt";
            this.runnableFormButton1.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 300);
            this.Controls.Add(this.buttonGroup1);
            this.Controls.Add(this.formDataGridView2);
            this.Controls.Add(this.formDataGridView1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Controls.SetChildIndex(this.formDataGridView1, 0);
            this.Controls.SetChildIndex(this.formDataGridView2, 0);
            this.Controls.SetChildIndex(this.buttonGroup1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView2)).EndInit();
            this.buttonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppFramework.Controls.FormDataGridView formDataGridView1;
        private AppFramework.Controls.FormDataGridView formDataGridView2;
        private AppFramework.Controls.ButtonGroup buttonGroup1;
        private AppFramework.Controls.RunnableFormButton runnableFormButton1;
    }
}