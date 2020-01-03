namespace AssessorsUI
{
    partial class frmAssessorsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssessorsViewer));
            this.dgvAssessorsList = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintImage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTaxDeclarationNo = new System.Windows.Forms.Label();
            this.txtTaxDeclarationNo = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBookNoColorRevised = new System.Windows.Forms.Label();
            this.txtBookNoColorRevised = new System.Windows.Forms.TextBox();
            this.lblSurveyNo = new System.Windows.Forms.Label();
            this.txtSurveyNo = new System.Windows.Forms.TextBox();
            this.lblDeclarationCancelsTDNo = new System.Windows.Forms.Label();
            this.txtDeclarationCancelsTDNo = new System.Windows.Forms.TextBox();
            this.pctrBoxImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnZoomAnImage = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.pctrBoxSearchLegend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessorsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxSearchLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAssessorsList
            // 
            this.dgvAssessorsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAssessorsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssessorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssessorsList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssessorsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAssessorsList.Location = new System.Drawing.Point(12, 69);
            this.dgvAssessorsList.Name = "dgvAssessorsList";
            this.dgvAssessorsList.Size = new System.Drawing.Size(634, 419);
            this.dgvAssessorsList.TabIndex = 0;
            this.dgvAssessorsList.TabStop = false;
            this.dgvAssessorsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssessorsList_CellClick);
            this.dgvAssessorsList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvAssessorsList_RowPrePaint);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSearch.Location = new System.Drawing.Point(7, 2);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 28);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(12, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(634, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(239, 674);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(451, 674);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 25);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintImage
            // 
            this.btnPrintImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnPrintImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPrintImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintImage.ForeColor = System.Drawing.Color.Black;
            this.btnPrintImage.Location = new System.Drawing.Point(900, 674);
            this.btnPrintImage.Name = "btnPrintImage";
            this.btnPrintImage.Size = new System.Drawing.Size(115, 25);
            this.btnPrintImage.TabIndex = 4;
            this.btnPrintImage.TabStop = false;
            this.btnPrintImage.Text = "&Print an Image";
            this.btnPrintImage.UseVisualStyleBackColor = true;
            this.btnPrintImage.Click += new System.EventHandler(this.btnPrintImage_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1295, 674);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTaxDeclarationNo
            // 
            this.lblTaxDeclarationNo.AutoSize = true;
            this.lblTaxDeclarationNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTaxDeclarationNo.Location = new System.Drawing.Point(73, 537);
            this.lblTaxDeclarationNo.Name = "lblTaxDeclarationNo";
            this.lblTaxDeclarationNo.Size = new System.Drawing.Size(160, 23);
            this.lblTaxDeclarationNo.TabIndex = 5;
            this.lblTaxDeclarationNo.Text = "Tax Declaration No.";
            // 
            // txtTaxDeclarationNo
            // 
            this.txtTaxDeclarationNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxDeclarationNo.Location = new System.Drawing.Point(239, 530);
            this.txtTaxDeclarationNo.Name = "txtTaxDeclarationNo";
            this.txtTaxDeclarationNo.Size = new System.Drawing.Size(407, 30);
            this.txtTaxDeclarationNo.TabIndex = 2;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblOwner.Location = new System.Drawing.Point(164, 573);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(69, 23);
            this.lblOwner.TabIndex = 5;
            this.lblOwner.Text = "Owner :";
            // 
            // txtOwner
            // 
            this.txtOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOwner.Location = new System.Drawing.Point(239, 566);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(407, 30);
            this.txtOwner.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(559, 674);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBookNoColorRevised
            // 
            this.lblBookNoColorRevised.AutoSize = true;
            this.lblBookNoColorRevised.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblBookNoColorRevised.Location = new System.Drawing.Point(12, 501);
            this.lblBookNoColorRevised.Name = "lblBookNoColorRevised";
            this.lblBookNoColorRevised.Size = new System.Drawing.Size(218, 23);
            this.lblBookNoColorRevised.TabIndex = 5;
            this.lblBookNoColorRevised.Text = "Book No./Brgy/Color/Year :";
            // 
            // txtBookNoColorRevised
            // 
            this.txtBookNoColorRevised.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookNoColorRevised.Location = new System.Drawing.Point(239, 494);
            this.txtBookNoColorRevised.Name = "txtBookNoColorRevised";
            this.txtBookNoColorRevised.Size = new System.Drawing.Size(407, 30);
            this.txtBookNoColorRevised.TabIndex = 1;
            // 
            // lblSurveyNo
            // 
            this.lblSurveyNo.AutoSize = true;
            this.lblSurveyNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSurveyNo.Location = new System.Drawing.Point(141, 609);
            this.lblSurveyNo.Name = "lblSurveyNo";
            this.lblSurveyNo.Size = new System.Drawing.Size(92, 23);
            this.lblSurveyNo.TabIndex = 5;
            this.lblSurveyNo.Text = "Survey No.";
            // 
            // txtSurveyNo
            // 
            this.txtSurveyNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurveyNo.Location = new System.Drawing.Point(239, 602);
            this.txtSurveyNo.Name = "txtSurveyNo";
            this.txtSurveyNo.Size = new System.Drawing.Size(407, 30);
            this.txtSurveyNo.TabIndex = 5;
            // 
            // lblDeclarationCancelsTDNo
            // 
            this.lblDeclarationCancelsTDNo.AutoSize = true;
            this.lblDeclarationCancelsTDNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblDeclarationCancelsTDNo.Location = new System.Drawing.Point(28, 645);
            this.lblDeclarationCancelsTDNo.Name = "lblDeclarationCancelsTDNo";
            this.lblDeclarationCancelsTDNo.Size = new System.Drawing.Size(205, 23);
            this.lblDeclarationCancelsTDNo.TabIndex = 5;
            this.lblDeclarationCancelsTDNo.Text = "Cancels TD No. w/ Owner";
            // 
            // txtDeclarationCancelsTDNo
            // 
            this.txtDeclarationCancelsTDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeclarationCancelsTDNo.Location = new System.Drawing.Point(239, 638);
            this.txtDeclarationCancelsTDNo.Name = "txtDeclarationCancelsTDNo";
            this.txtDeclarationCancelsTDNo.Size = new System.Drawing.Size(407, 30);
            this.txtDeclarationCancelsTDNo.TabIndex = 7;
            // 
            // pctrBoxImage
            // 
            this.pctrBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxImage.Image")));
            this.pctrBoxImage.Location = new System.Drawing.Point(652, 2);
            this.pctrBoxImage.Name = "pctrBoxImage";
            this.pctrBoxImage.Size = new System.Drawing.Size(693, 666);
            this.pctrBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxImage.TabIndex = 7;
            this.pctrBoxImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBrowseImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBrowseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseImage.Location = new System.Drawing.Point(652, 674);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(116, 25);
            this.btnBrowseImage.TabIndex = 4;
            this.btnBrowseImage.TabStop = false;
            this.btnBrowseImage.Text = "&Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Visible = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(345, 674);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 25);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnContact
            // 
            this.btnContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.Black;
            this.btnContact.Location = new System.Drawing.Point(1223, 674);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(66, 25);
            this.btnContact.TabIndex = 4;
            this.btnContact.TabStop = false;
            this.btnContact.Text = "Co&ntact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnZoomAnImage
            // 
            this.btnZoomAnImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnZoomAnImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnZoomAnImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnZoomAnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomAnImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomAnImage.ForeColor = System.Drawing.Color.Black;
            this.btnZoomAnImage.Location = new System.Drawing.Point(1021, 674);
            this.btnZoomAnImage.Name = "btnZoomAnImage";
            this.btnZoomAnImage.Size = new System.Drawing.Size(111, 25);
            this.btnZoomAnImage.TabIndex = 4;
            this.btnZoomAnImage.TabStop = false;
            this.btnZoomAnImage.Text = "&Zoom an Image";
            this.btnZoomAnImage.UseVisualStyleBackColor = true;
            this.btnZoomAnImage.Click += new System.EventHandler(this.btnZoomAnImage_Click);
            // 
            // btnOption
            // 
            this.btnOption.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.ForeColor = System.Drawing.Color.Black;
            this.btnOption.Location = new System.Drawing.Point(1351, 663);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(5, 5);
            this.btnOption.TabIndex = 4;
            this.btnOption.TabStop = false;
            this.btnOption.Text = "&Option";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.Black;
            this.btnCalculator.Location = new System.Drawing.Point(1138, 674);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(79, 25);
            this.btnCalculator.TabIndex = 4;
            this.btnCalculator.TabStop = false;
            this.btnCalculator.Text = "Calculato&r";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBlue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBlue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnBlue.Location = new System.Drawing.Point(603, 2);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(43, 25);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.TabStop = false;
            this.btnBlue.Text = "B&lue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // pctrBoxSearchLegend
            // 
            this.pctrBoxSearchLegend.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxSearchLegend.Image")));
            this.pctrBoxSearchLegend.Location = new System.Drawing.Point(12, 494);
            this.pctrBoxSearchLegend.Name = "pctrBoxSearchLegend";
            this.pctrBoxSearchLegend.Size = new System.Drawing.Size(634, 174);
            this.pctrBoxSearchLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxSearchLegend.TabIndex = 8;
            this.pctrBoxSearchLegend.TabStop = false;
            // 
            // frmAssessorsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1362, 706);
            this.Controls.Add(this.pctrBoxSearchLegend);
            this.Controls.Add(this.txtDeclarationCancelsTDNo);
            this.Controls.Add(this.lblDeclarationCancelsTDNo);
            this.Controls.Add(this.txtSurveyNo);
            this.Controls.Add(this.lblSurveyNo);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.txtBookNoColorRevised);
            this.Controls.Add(this.lblBookNoColorRevised);
            this.Controls.Add(this.txtTaxDeclarationNo);
            this.Controls.Add(this.lblTaxDeclarationNo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintImage);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnZoomAnImage);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvAssessorsList);
            this.Controls.Add(this.pctrBoxImage);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAssessorsViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessors Documents";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessorsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxSearchLegend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssessorsList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrintImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTaxDeclarationNo;
        private System.Windows.Forms.TextBox txtTaxDeclarationNo;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBookNoColorRevised;
        private System.Windows.Forms.TextBox txtBookNoColorRevised;
        private System.Windows.Forms.Label lblSurveyNo;
        private System.Windows.Forms.TextBox txtSurveyNo;
        private System.Windows.Forms.Label lblDeclarationCancelsTDNo;
        private System.Windows.Forms.TextBox txtDeclarationCancelsTDNo;
        private System.Windows.Forms.PictureBox pctrBoxImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnZoomAnImage;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.PictureBox pctrBoxSearchLegend;
    }
}

