using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VGFeed.Model.Requests;

namespace VGFeed.WinUI.Platforme
{
    public partial class frmPlatforma : Form
    {
        private readonly APIService _platforme = new APIService("Platforme");
        private int? _id = null;
        PlatformeInsertRequest request = new PlatformeInsertRequest();
        private static readonly ImageConverter _imageConverter = new ImageConverter();
        Model.Platforme platforme = new Model.Platforme();
        public frmPlatforma(int? platformid=null)
        {
            InitializeComponent();
            _id = platformid;
        }

        private async void frmPlatforma_Load(object sender, EventArgs e)
        {
            await LoadPlatforme();
            if (_id.HasValue)
            {
                platforme = await _platforme.GetById<Model.Platforme>(_id);
                txtNaziv.Text = platforme.Naziv;
                txtSkracenica.Text = platforme.Skracenica;
                var logo = platforme.Logo; 
                if(logo != null)
                { 
                   var image = GetImageFromByteArray(logo);
                   pbLogo.Image = image;
                }

            }

        }
        public static byte[] CopyImageToByteArray(Image theImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                theImage.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }
        public static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);
                txtLogo.Text = fileName;

                Image image = Image.FromFile(fileName).GetThumbnailImage(pbLogo.Width, pbLogo.Height, null, IntPtr.Zero);
                request.Logo = CopyImageToByteArray(image);
                pbLogo.Image = image;
            }
        }

        private async void btnSačuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Naziv = txtNaziv.Text;
                request.Skracenica = txtSkracenica.Text;
                if (request.Logo == null)
                {
                    request.Logo = platforme.Logo;
                }
                Model.Platforme entity = null;
                if (_id.HasValue)
                {
                    entity = await _platforme.Update<Model.Platforme>(_id, request);
                }
                else
                {
                    entity = await _platforme.Insert<Model.Platforme>(request);
                }
                if (entity != null)
                {
                    MessageBox.Show("Operacija uspješna");
                }
            }
        }
        private async Task LoadPlatforme()
        {
            var result = await _platforme.Get<List<Model.Platforme>>(null);
            dgvPlatforme.AutoGenerateColumns = false;
            dgvPlatforme.DataSource = result;
        }

        private void dgvPlatforme_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPlatforme.SelectedRows[0] != null)
            {
                var id = dgvPlatforme.SelectedRows[0].Cells[0].Value;

                frmPlatforma frm = new frmPlatforma(int.Parse(id.ToString()));
                frm.Show();
                this.Close();
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || txtNaziv.Text.Length < 5)
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void txtSkracenica_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSkracenica.Text) || txtSkracenica.Text.Length < 3)
            {
                errorProvider.SetError(txtSkracenica, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSkracenica, null);
            }
        }

        private void pbLogo_Validating(object sender, CancelEventArgs e)
        {
            if (pbLogo.Image==null)
            {
                errorProvider.SetError(pbLogo, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(pbLogo, null);
            }
        }
    }
}
