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

namespace VGFeed.WinUI.Igre
{
    public partial class frmIgre : Form
    {
        private readonly APIService _platforme = new APIService("Platforme");
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        private readonly APIService _service = new APIService("Igre");
        private static readonly ImageConverter _imageConverter = new ImageConverter();
        private int? _id =null;
        Model.Igre igra;
        IgreInsertRequest request = new IgreInsertRequest();
        public frmIgre(int? igraid =null)
        {
            InitializeComponent();
            _id = igraid;
        }

        private async void frmIgre_Load(object sender, EventArgs e)
        {
            await LoadPlatforme();
            await LoadZanrovi();
            if (_id.HasValue)
            {
                igra = await _service.GetById<Model.Igre>(_id);
                cmbPlatforma.SelectedValue = igra.PlatformId;
                cmbZanr.SelectedValue = igra.ZanrId;
                txtNaziv.Text = igra.Naziv;
                txtDeveloper.Text = igra.Developer;
                txtIzdavac.Text = igra.Izdavac;
                txtMetacritic.Text = igra.MetacriticOcjena.ToString();
                txtOpis.Text = igra.Opis;
                txtOrigCijena.Text = igra.OriginalnaCijena.ToString();
                txtTrenCijena.Text = igra.TrenutnaCijena.ToString();
                dtpDatumIzlaska.Value = igra.DatumIzlaska;
                var slika = igra.Slika;
                var slikaThumb = igra.SlikaThumb;
                var image = GetImageFromByteArray(slikaThumb);
                pbSlika.Image = image;
               
            }
          
        }

        private async Task LoadPlatforme()
        {
            var result = await _platforme.Get<List<Model.Platforme>>(null);
            result.Insert(0, new Model.Platforme());
            cmbPlatforma.DisplayMember = "Naziv";
            cmbPlatforma.ValueMember = "PlatformId";
            cmbPlatforma.DataSource = result;
        }
        private async Task LoadZanrovi()
        {
            var result = await _zanrovi.Get<List<Model.Zanrovi>>(null);
            result.Insert(0, new Model.Zanrovi());
            cmbZanr.DisplayMember = "Naziv";
            cmbZanr.ValueMember = "ZanrId";
            cmbZanr.DataSource = result;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                var platformidObj = cmbPlatforma.SelectedValue;
                if (int.TryParse(platformidObj.ToString(), out int platid))
                {
                    request.PlatformId = platid;
                }

                var zanridObj = cmbZanr.SelectedValue;
                if (int.TryParse(zanridObj.ToString(), out int zanrid))
                {
                    request.ZanrId = zanrid;
                }
                request.Naziv = txtNaziv.Text;
                request.Developer = txtDeveloper.Text;
                request.Izdavac = txtIzdavac.Text;
                request.Multiplayer = chbMultiplayer.Checked;
                request.OriginalnaCijena = double.Parse(txtOrigCijena.Text);
                request.TrenutnaCijena = double.Parse(txtTrenCijena.Text);
                request.Opis = txtOpis.Text;
                request.MetacriticOcjena = int.Parse(txtMetacritic.Text);
                request.DatumIzlaska = dtpDatumIzlaska.Value.Date;
                if (request.Slika == null)
                {
                    request.Slika = igra.Slika;
                }
                if (request.SlikaThumb == null)
                {
                    request.SlikaThumb = igra.SlikaThumb;
                }

                Model.Igre entity = null;
                if (_id.HasValue)
                {
                    entity = await _service.Update<Model.Igre>(_id, request);
                }
                else
                {
                    entity = await _service.Insert<Model.Igre>(request);
                }
                if (entity != null)
                {
                    MessageBox.Show("Operacija uspješna");
                }
            }
        }

        private async void cmbPlatforma_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnPlatforma_Click(object sender, EventArgs e)
        {
            
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
        private void btnSlika_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName).GetThumbnailImage(pbSlika.Width,pbSlika.Height,null, IntPtr.Zero);
                request.SlikaThumb = CopyImageToByteArray(image);
                pbSlika.Image = image;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void txtOrigCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrigCijena.Text) || !double.TryParse(txtOrigCijena.Text,out var result))
            {
                errorProvider.SetError(txtOrigCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOrigCijena, null);
            }
        }

        private void txtTrenCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrenCijena.Text) || !double.TryParse(txtTrenCijena.Text, out var result))
            {
                errorProvider.SetError(txtTrenCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTrenCijena, null);
            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                errorProvider.SetError(txtOpis, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOpis, null);
            }
        }

        private void txtDeveloper_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeveloper.Text))
            {
                errorProvider.SetError(txtDeveloper, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDeveloper, null);
            }
        }

        private void txtIzdavac_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzdavac.Text))
            {
                errorProvider.SetError(txtIzdavac, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIzdavac, null);
            }
        }

        private void cmbPlatforma_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPlatforma.SelectedItem == null)
            {
                errorProvider.SetError(cmbPlatforma, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbPlatforma, null);
            }
        }

        private void cmbZanr_Validating(object sender, CancelEventArgs e)
        {
            if (cmbZanr.SelectedItem == null)
            {
                errorProvider.SetError(cmbZanr, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbZanr, null);
            }
        }

        private void dtpDatumIzlaska_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpDatumIzlaska.Text))
            {
                errorProvider.SetError(dtpDatumIzlaska, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpDatumIzlaska, null);
            }
        }

        private void txtMetacritic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMetacritic.Text) || !double.TryParse(txtMetacritic.Text, out var result) || result<0 || result>100)
            {
                errorProvider.SetError(txtMetacritic, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtMetacritic, null);
            }
        }
    }
}
