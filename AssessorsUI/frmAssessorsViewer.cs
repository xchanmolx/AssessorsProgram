using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace AssessorsUI
{
    public partial class frmAssessorsViewer : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=ALOGUINSAN\SQLEXPRESS;Initial Catalog=AssessorsDB;Integrated Security=True");
        int documentId = 0;
        Image DefaultImage;

        DataTable dtblDoc = new DataTable();
        SqlDataAdapter sqlda = new SqlDataAdapter();
        OpenFileDialog open = new OpenFileDialog();

        public frmAssessorsViewer()
        {
            InitializeComponent();
            DefaultImage = pctrBoxImage.Image;
            RefreshImageGrid();
        }

        void Clear()
        {
            documentId = 0;
            pctrBoxImage.Image = DefaultImage;

            txtBookNoColorRevised.Text = "";
            txtTaxDeclarationNo.Text = "";
            txtOwner.Text = "";
            txtSurveyNo.Text = "";
            txtDeclarationCancelsTDNo.Text = "";
        }
        
        void RefreshImageGrid()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            sqlda = new SqlDataAdapter("spDocuments_GetAll", sqlCon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            dtblDoc = new DataTable("AssessorDocuments");
            sqlda.Fill(dtblDoc);

            dgvAssessorsList.DataSource = dtblDoc;

            dgvAssessorsList.Columns[0].Visible = false; // Id
            dgvAssessorsList.Columns[1].Width = 250;     // Book No. / Color / Revised
            dgvAssessorsList.Columns[2].Width = 120;     // TD No.
            dgvAssessorsList.Columns[3].Width = 400;     // Owner
            dgvAssessorsList.Columns[4].Width = 150;     // Survey No.
            dgvAssessorsList.Columns[5].Width = 230;     // Cancels TD No. with Owner
            dgvAssessorsList.Columns[6].Visible = false; // Image string path
        }

        private void dgvAssessorsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAssessorsList.CurrentRow.Index != -1)
                {
                    sqlda = new SqlDataAdapter("spDocuments_GetAll", sqlCon);
                    sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dtblDoc = new DataTable("AssessorDocuments");
                    sqlda.Fill(dtblDoc);

                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                    documentId = Convert.ToInt32(dgvAssessorsList.CurrentRow.Cells[0].Value.ToString());
                    txtBookNoColorRevised.Text = dgvAssessorsList.CurrentRow.Cells[1].Value.ToString();
                    txtTaxDeclarationNo.Text = dgvAssessorsList.CurrentRow.Cells[2].Value.ToString();
                    txtOwner.Text = dgvAssessorsList.CurrentRow.Cells[3].Value.ToString();
                    txtSurveyNo.Text = dgvAssessorsList.CurrentRow.Cells[4].Value.ToString();
                    txtDeclarationCancelsTDNo.Text = dgvAssessorsList.CurrentRow.Cells[5].Value.ToString();
                    pctrBoxImage.Image = Image.FromFile(paths + dgvAssessorsList.CurrentRow.Cells[6].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Datagridview Document Lists CellClick Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pctrBoxSearchLegend.Hide();

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                string correctFileName = Path.GetFileName(open.FileName);

                SqlCommand sqlCmd = new SqlCommand("spDocuments", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Action", "Insert");
                sqlCmd.Parameters.AddWithValue("@Id", documentId);
                sqlCmd.Parameters.AddWithValue("@Book_No_Brgy_Color_Year", txtBookNoColorRevised.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@TD_No", txtTaxDeclarationNo.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Owner", txtOwner.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Survey_No", txtSurveyNo.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Cancels_TD_No_Owner", txtDeclarationCancelsTDNo.Text.Trim());              
                sqlCmd.Parameters.AddWithValue("@Path_Image", @"\Images\img1\" + correctFileName);

                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();

                MessageBox.Show("Saved successfully.", "Save Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
                RefreshImageGrid();

                txtBookNoColorRevised.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                string correctFileName = Path.GetFileName(open.FileName);

                SqlCommand sqlCmd = new SqlCommand("spDocuments", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Action", "Update");
                sqlCmd.Parameters.AddWithValue("@Id", documentId);
                sqlCmd.Parameters.AddWithValue("@Book_No_Brgy_Color_Year", txtBookNoColorRevised.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@TD_No", txtTaxDeclarationNo.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Owner", txtOwner.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Survey_No", txtSurveyNo.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Cancels_TD_No_Owner", txtDeclarationCancelsTDNo.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Path_Image", @"\Images\img1\" + correctFileName);

                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();

                MessageBox.Show("Edited successfully.", "Edit Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
                RefreshImageGrid();

                txtBookNoColorRevised.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            try
            {
                //open.InitialDirectory = "C:\\";
                open.Filter = "Image Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                open.FilterIndex = 1;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {
                        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        string correctFileName = Path.GetFileName(open.FileName);
                        File.Copy(open.FileName, paths + @"\Images\img1\" + correctFileName);

                        paths = open.FileName.ToString();
                        pctrBoxImage.Image = new Bitmap(paths);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Browse Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnSave.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("spDocuments", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Action", "Delete");
                sqlCmd.Parameters.AddWithValue("@Id", documentId);

                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();

                MessageBox.Show("Deleted successfully.", "Delete Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
                RefreshImageGrid();
            }
            else
            {
                txtBookNoColorRevised.Focus();
            }
        }

        private void btnPrintImage_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Bitmap bm = new Bitmap(pctrBoxImage.Width, pctrBoxImage.Height);
            //pctrBoxImage.DrawToBitmap(bm, new Rectangle(0, 0, pctrBoxImage.Width, pctrBoxImage.Height));
            //e.Graphics.DrawImage(bm, 0, 0);
            //bm.Dispose();

            using (var bmp = new Bitmap(pctrBoxImage.Width = 700, pctrBoxImage.Height = 1000))
            {
                pctrBoxImage.DrawToBitmap(bmp, new Rectangle(0, 0, pctrBoxImage.Width, pctrBoxImage.Height));
                Image resized = ResizeImage(bmp, new Size(770, 1900));
                e.Graphics.DrawImage(resized, 0, 0);
                resized.Dispose();
            }
        }

        public Image ResizeImage(Image image, Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;
            if (preserveAspectRatio)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        private void dgvAssessorsList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                dgvAssessorsList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Datagridview Document Lists RowPrePaint Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dtblDoc.DefaultView;
                if (dv != null)
                {
                    dv.RowFilter = string.Format("Book_No_Brgy_Color_Year Like '%{0}%' Or TD_No Like '%{0}%' Or Owner Like '%{0}%' Or Survey_No Like '%{0}%' Or Cancels_TD_No_Owner Like '%{0}%'", txtSearch.Text);
                    dgvAssessorsList.DataSource = dv.ToTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;

            txtBookNoColorRevised.Focus();
        }

        private void btnZoomAnImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Magnify.exe");
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            pctrBoxSearchLegend.Hide();

            txtBookNoColorRevised.Focus();

            btnSave.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnClear.Visible = true;
            btnBrowseImage.Visible = true;

            txtBookNoColorRevised.TabStop = true;
            txtTaxDeclarationNo.TabStop = true;
            txtOwner.TabStop = true;
            txtSurveyNo.TabStop = true;
            txtDeclarationCancelsTDNo.TabStop = true;

            txtSearch.TabStop = false;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            pctrBoxSearchLegend.Show();

            btnSave.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnClear.Visible = false;
            btnBrowseImage.Visible = false;

            txtBookNoColorRevised.TabStop = false;
            txtTaxDeclarationNo.TabStop = false;
            txtOwner.TabStop = false;
            txtSurveyNo.TabStop = false;
            txtDeclarationCancelsTDNo.TabStop = false;

            Clear();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please call or text at 0916-360-9855, if you have found a problem about the application. Thank you! ( Chiantine P. Manigos )", "Contact Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "B-13-";
            txtSearch.MaxLength++;
            txtSearch.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
            else
            {
                txtSearch.Focus();
            }
        }
    }
}
