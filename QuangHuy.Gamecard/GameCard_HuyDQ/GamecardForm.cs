using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCard_HuyDQ
{
    public partial class GamecardForm : Form
    {
        public int? GameCardId { get; set; }
        private GamecardService gamecardService = new();
        private ProviderService providerService = new();
        public GamecardForm()
        {
            InitializeComponent();
        }

        private void GamecardForm_Load(object sender, EventArgs e)
        {
            cboProvider.DataSource = providerService.GetAllProviders();
            cboProvider.DisplayMember = "ProviderName";
            cboProvider.ValueMember = "ProviderId";

            if (this.GameCardId != null)
            {

                var gameCardInfo = gamecardService.GetAGamecard((int)GameCardId);

                txtId.Text = gameCardInfo.GameCardId.ToString();
                txtName.Text = gameCardInfo.GameCardName;
                txtDesc.Text = gameCardInfo.GameDescription;
                txtPlatform.Text = gameCardInfo.GamePlatform;
                txtPrice.Text = gameCardInfo.Price.ToString();
                txtQuantity.Text = gameCardInfo.Quantity.ToString();
                dtpCreatedDate.Value = (DateTime)gameCardInfo.CreatedDate;
                cboProvider.SelectedValue = gameCardInfo.ProviderId;
                lblFormTitle.Text = "Update a Gamecard";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDesc.Text) ||
                string.IsNullOrWhiteSpace(txtPlatform.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                cboProvider.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all the information.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a non-negative integer.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Price must be a non-negative number.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sunglassesName = txtName.Text.Trim();
            if (sunglassesName.Length < 2 || sunglassesName.Length > 60)
            {
                MessageBox.Show("GamecardName must have a length between 2 and 60 characters.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] words = sunglassesName.Split(' ');

            foreach (string word in words)
            {

                if (!char.IsUpper(word.FirstOrDefault()) && !char.IsDigit(word.FirstOrDefault()))
                {
                    MessageBox.Show("GamecardName must start with an uppercase letter or a digit from 0 to 9.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                foreach (char character in word)
                {
                    if (!char.IsLetterOrDigit(character) && !char.IsWhiteSpace(character))
                    {
                        MessageBox.Show("GamecardName cannot contain special characters, " +
                            "and each word must start with an uppercase letter or a digit from 0 to 9.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            GameCardInfo gameCardInfo = new()
            {
                GameCardId = int.Parse(txtId.Text.Trim()),
                GameCardName = txtName.Text.Trim(),
                GameDescription = txtDesc.Text.Trim(),
                GamePlatform = txtPlatform.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                CreatedDate = dtpCreatedDate.Value.Date,
                ProviderId = cboProvider.SelectedValue.ToString()
            };

            if (GameCardId != null)
                gamecardService.UpdateAGamecard(gameCardInfo);
            else
                gamecardService.AddAGamecard(gameCardInfo);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
