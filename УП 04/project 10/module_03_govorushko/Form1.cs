namespace PartnerManager;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Reflection;

public partial class Form1 : Form
{
    private List<Partner> partners = new List<Partner>();

    public Form1()
    {
        InitializeComponent();
        LoadPartnersFromFile();
        LoadPartners();
        buttonAdd.Click += ButtonAdd_Click;
        buttonEdit.Click += ButtonEdit_Click;
        buttonDelete.Click += ButtonDelete_Click;
        this.FormClosing += Form1_FormClosing;

        try
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("PartnerManager.images.logo.png"))
            {
                if (stream != null)
                    this.pictureBoxLogo.Image = System.Drawing.Image.FromStream(stream);
            }
            using (var iconStream = assembly.GetManifestResourceStream("PartnerManager.images.icon.ico"))
            {
                if (iconStream != null)
                    this.Icon = new System.Drawing.Icon(iconStream);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка при загрузке ресурсов: " + ex.Message);
        }
    }

    // Загрузка списка партнёров из файла при запуске приложения
    private void LoadPartnersFromFile()
    {
        try
        {
            if (File.Exists("partners.json"))
            {
                var json = File.ReadAllText("partners.json");
                // Десериализация списка партнёров из JSON
                partners = JsonSerializer.Deserialize<List<Partner>>(json) ?? new List<Partner>();
            }
        }
        catch (Exception ex)
        {
            // Сообщение об ошибке при загрузке
            MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Сохранение списка партнёров в файл при закрытии приложения
    private void SavePartnersToFile()
    {
        try
        {
            // Сериализация списка партнёров в JSON
            var json = JsonSerializer.Serialize(partners);
            File.WriteAllText("partners.json", json);
        }
        catch (Exception ex)
        {
            // Сообщение об ошибке при сохранении
            MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        SavePartnersToFile();
    }

    private void LoadPartners()
    {
        dataGridViewPartners.DataSource = null;
        dataGridViewPartners.DataSource = partners;
    }

    private void ButtonAdd_Click(object sender, System.EventArgs e)
    {
        try
        {
            var form = new PartnerEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!ValidatePartner(form.Partner, out string error))
                {
                    MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                partners.Add(form.Partner);
                LoadPartners();
                MessageBox.Show("Партнёр успешно добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (System.Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonEdit_Click(object sender, System.EventArgs e)
    {
        if (dataGridViewPartners.CurrentRow == null)
        {
            MessageBox.Show("Выберите партнёра для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var partner = dataGridViewPartners.CurrentRow.DataBoundItem as Partner;
        if (partner == null) return;
        try
        {
            var form = new PartnerEditForm(partner);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!ValidatePartner(form.Partner, out string error))
                {
                    MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadPartners();
                MessageBox.Show("Данные партнёра обновлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (System.Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Удаление выбранного партнёра
    private void ButtonDelete_Click(object? sender, EventArgs e)
    {
        if (dataGridViewPartners.CurrentRow == null)
        {
            MessageBox.Show("Выберите партнёра для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var partner = dataGridViewPartners.CurrentRow.DataBoundItem as Partner;
        if (partner == null) return;
        var result = MessageBox.Show($"Удалить партнёра '{partner.Name}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            partners.Remove(partner);
            LoadPartners();
            SavePartnersToFile();
            MessageBox.Show("Партнёр удалён.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Проверка корректности данных партнёра перед добавлением/редактированием
    private bool ValidatePartner(Partner partner, out string error)
    {
        if (string.IsNullOrWhiteSpace(partner.Name))
        {
            error = "Наименование не может быть пустым.";
            return false;
        }
        if (string.IsNullOrWhiteSpace(partner.PartnerType))
        {
            error = "Выберите тип партнёра.";
            return false;
        }
        if (partner.Rating < 0)
        {
            error = "Рейтинг не может быть отрицательным.";
            return false;
        }
        error = null;
        return true;
    }
}
