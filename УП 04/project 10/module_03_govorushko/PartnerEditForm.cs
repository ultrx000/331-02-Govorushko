using System;
using System.Windows.Forms;

namespace PartnerManager
{
    public partial class PartnerEditForm : Form
    {
        public Partner Partner { get; private set; }

        public PartnerEditForm()
        {
            InitializeComponent();
            Partner = new Partner();
        }

        public PartnerEditForm(Partner partner)
        {
            InitializeComponent();
            Partner = partner;
            textBoxName.Text = partner.Name;
            comboBoxType.Text = partner.PartnerType;
            numericUpDownRating.Value = partner.Rating;
            textBoxAddress.Text = partner.Address;
            textBoxDirector.Text = partner.DirectorFullName;
            textBoxPhone.Text = partner.Phone;
            textBoxEmail.Text = partner.Email;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Partner.Name = textBoxName.Text;
            Partner.PartnerType = comboBoxType.Text;
            Partner.Rating = (int)numericUpDownRating.Value;
            Partner.Address = textBoxAddress.Text;
            Partner.DirectorFullName = textBoxDirector.Text;
            Partner.Phone = textBoxPhone.Text;
            Partner.Email = textBoxEmail.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
} 