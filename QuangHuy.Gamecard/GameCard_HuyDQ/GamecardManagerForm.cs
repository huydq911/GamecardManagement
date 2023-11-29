using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCard_HuyDQ
{
    public partial class GamecardManagerForm : Form
    {
        private GamecardService gamecardService = new GamecardService();
        private ProviderService providerService = new ProviderService();  
        public GamecardManagerForm(MemberAccount b)
        {
            InitializeComponent();

            member = b;
            string fullName = b.MemberFullName;
            int? role = b.Role;
            string roleName;

            switch (role)
            {
                case 1:
                    roleName = "Administrator";
                    break;
                case 2:
                    roleName = "Staff";
                    break;
                case 3:
                    roleName = "Manager";
                    break;
                default:
                    roleName = "Customer";
                    break;
            }

            lblUserNameAndRole.Text = fullName + " | " + roleName;
        }
        private MemberAccount member;
        private void GamecardManagerForm_Load(object sender, EventArgs e)
        {
            var result = gamecardService.GetAllGamecards();

            var displayList = result.Select(sunglass => new
            {
                sunglass.GameCardId,
                sunglass.GameCardName,
                sunglass.GameDescription,
                sunglass.GamePlatform,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ProviderId,
                ProviderName = sunglass.Provider?.ProviderName
            }).ToList();

            dgvGamecardList.DataSource = null;
            dgvGamecardList.DataSource = displayList;

            cboProvider.DataSource = providerService.GetAllProviders();
            cboProvider.DisplayMember = "ProviderName";
            cboProvider.ValueMember = "ProviderId";
        }

        private void GamecardManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = gamecardService.SearchGamecard(txtKeyword.Text.Trim());

            if (result.Count == 0)
            {
                MessageBox.Show("Cannot find the result!!!",
                    "Search keyword cannot find",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var displayList = result.Select(sunglass => new
            {
                sunglass.GameCardId,
                sunglass.GameCardName,
                sunglass.GameDescription,
                sunglass.GamePlatform,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ProviderId,
                ProviderName = sunglass.Provider?.ProviderName
            }).ToList();

            dgvGamecardList.DataSource = null;
            dgvGamecardList.DataSource = displayList;

            cboProvider.DataSource = providerService.GetAllProviders();
            cboProvider.DisplayMember = "ProviderName";
            cboProvider.ValueMember = "ProviderId";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("The gamecard ID is invalid. Please input a number!!!",
                    "Invalid Sunglass ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                gamecardService.DeleteAGamecard(id);

                var gamecards = gamecardService.GetAllGamecards();

                var displayList = gamecards.Select(sunglass => new
                {
                    sunglass.GameCardId,
                    sunglass.GameCardName,
                    sunglass.GameDescription,
                    sunglass.GamePlatform,
                    sunglass.Price,
                    sunglass.Quantity,
                    sunglass.CreatedDate,
                    sunglass.ProviderId,
                    ProviderName = sunglass.Provider?.ProviderName
                }).ToList();

                dgvGamecardList.DataSource = null;
                dgvGamecardList.DataSource = displayList;

                cboProvider.DataSource = providerService.GetAllProviders();
                cboProvider.DisplayMember = "ProviderName";
                cboProvider.ValueMember = "ProviderId";
            }
        }

        private void dgvSunglassList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGamecardList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedSunglass = dgvGamecardList.SelectedRows[0];
                txtId.Text = selectedSunglass.Cells[0].Value.ToString();
                txtName.Text = selectedSunglass.Cells[1].Value.ToString();
                txtDesc.Text = selectedSunglass.Cells[2].Value.ToString();
                txtPlatform.Text = selectedSunglass.Cells[3].Value.ToString();
                if (selectedSunglass.Cells[6].Value is DateTime)
                {
                    dtpCreatedDate.Value = (DateTime)selectedSunglass.Cells[6].Value;
                }
                txtQuantity.Text = selectedSunglass.Cells[5].Value.ToString();
                txtPrice.Text = selectedSunglass.Cells[4].Value.ToString();
                cboProvider.SelectedValue = selectedSunglass.Cells[7].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("The Gamecard ID is invalid. Please select a row in the grid to edit or input a number!!!",
                    "Invalid gamecard ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GamecardForm gamecardForm = new GamecardForm();
            gamecardForm.GameCardId = int.Parse(txtId.Text);
            gamecardForm.ShowDialog();

            var result = gamecardService.GetAllGamecards();

            var displayList = result.Select(sunglass => new
            {
                sunglass.GameCardId,
                sunglass.GameCardName,
                sunglass.GameDescription,
                sunglass.GamePlatform,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ProviderId,
                ProviderName = sunglass.Provider?.ProviderName
            }).ToList();

            dgvGamecardList.DataSource = null;
            dgvGamecardList.DataSource = displayList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GamecardForm gamecardForm = new GamecardForm();
            gamecardForm.GameCardId = null;
            gamecardForm.ShowDialog();

            var result = gamecardService.GetAllGamecards();

            var displayList = result.Select(sunglass => new
            {
                sunglass.GameCardId,
                sunglass.GameCardName,
                sunglass.GameDescription,
                sunglass.GamePlatform,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ProviderId,
                ProviderName = sunglass.Provider?.ProviderName
            }).ToList();

            dgvGamecardList.DataSource = null;
            dgvGamecardList.DataSource = displayList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
