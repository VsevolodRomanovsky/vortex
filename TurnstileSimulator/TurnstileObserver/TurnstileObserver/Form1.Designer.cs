namespace TurnstileObserver
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvVisitors = new System.Windows.Forms.DataGridView();
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.gbVisitors = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitor_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.gbVisitors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitors
            // 
            this.dgvVisitors.AutoGenerateColumns = false;
            this.dgvVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.PermitId,
            this.RegistrationDate,
            this.IsValid});
            this.dgvVisitors.DataSource = this.visitorBindingSource;
            this.dgvVisitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisitors.Location = new System.Drawing.Point(3, 16);
            this.dgvVisitors.Name = "dgvVisitors";
            this.dgvVisitors.ReadOnly = true;
            this.dgvVisitors.Size = new System.Drawing.Size(531, 245);
            this.dgvVisitors.TabIndex = 0;
            this.dgvVisitors.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVisitors_CellFormatting);
            this.dgvVisitors.SelectionChanged += new System.EventHandler(this.dgvVisitors_SelectionChanged);
            // 
            // visitorBindingSource
            // 
            this.visitorBindingSource.DataSource = typeof(TurnstileObserver.TurnstileService.Visitor);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(409, 12);
            this.pbPhoto.MaximumSize = new System.Drawing.Size(140, 172);
            this.pbPhoto.MinimumSize = new System.Drawing.Size(140, 172);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(140, 172);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 1;
            this.pbPhoto.TabStop = false;
            // 
            // dgvVisits
            // 
            this.dgvVisits.AutoGenerateColumns = false;
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Visitor_Id,
            this.VisitType,
            this.VisitDate});
            this.dgvVisits.DataSource = this.visitsBindingSource;
            this.dgvVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisits.Location = new System.Drawing.Point(3, 16);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.ReadOnly = true;
            this.dgvVisits.Size = new System.Drawing.Size(385, 153);
            this.dgvVisits.TabIndex = 2;
            this.dgvVisits.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVisits_CellFormatting);
            // 
            // gbVisitors
            // 
            this.gbVisitors.Controls.Add(this.dgvVisitors);
            this.gbVisitors.Location = new System.Drawing.Point(12, 204);
            this.gbVisitors.Name = "gbVisitors";
            this.gbVisitors.Size = new System.Drawing.Size(537, 264);
            this.gbVisitors.TabIndex = 4;
            this.gbVisitors.TabStop = false;
            this.gbVisitors.Text = "Посетители";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVisits);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 172);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дата и время прихода и ухода";
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "Visits";
            this.visitsBindingSource.DataSource = this.visitorBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // Visitor_Id
            // 
            this.Visitor_Id.DataPropertyName = "Visitor_Id";
            this.Visitor_Id.HeaderText = "Visitor_Id";
            this.Visitor_Id.Name = "Visitor_Id";
            this.Visitor_Id.Visible = false;
            // 
            // VisitType
            // 
            this.VisitType.DataPropertyName = "VisitType";
            this.VisitType.HeaderText = "";
            this.VisitType.Name = "VisitType";
            // 
            // VisitDate
            // 
            this.VisitDate.DataPropertyName = "VisitDate";
            this.VisitDate.HeaderText = "Дата";
            this.VisitDate.Name = "VisitDate";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // PermitId
            // 
            this.PermitId.DataPropertyName = "PermitId";
            this.PermitId.HeaderText = "Код ключа";
            this.PermitId.Name = "PermitId";
            this.PermitId.ReadOnly = true;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.DataPropertyName = "RegistrationDate";
            this.RegistrationDate.HeaderText = "Дата регистрации";
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            // 
            // IsValid
            // 
            this.IsValid.DataPropertyName = "IsValid";
            this.IsValid.HeaderText = "Статус";
            this.IsValid.Name = "IsValid";
            this.IsValid.ReadOnly = true;
            this.IsValid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsValid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbVisitors);
            this.Controls.Add(this.pbPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.gbVisitors.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVisitors;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.BindingSource visitorBindingSource;
        private System.Windows.Forms.GroupBox gbVisitors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitor_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitDate;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsValid;
    }
}

