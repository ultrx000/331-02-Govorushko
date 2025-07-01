namespace PartnerManager
{
    partial class PartnerEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Text = "Наименование:";
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Size = new System.Drawing.Size(120, 23);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(140, 12);
            this.textBoxName.Size = new System.Drawing.Size(200, 23);
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // labelType
            // 
            this.labelType.Text = "Тип партнёра:";
            this.labelType.Location = new System.Drawing.Point(12, 45);
            this.labelType.Size = new System.Drawing.Size(120, 23);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Location = new System.Drawing.Point(140, 42);
            this.comboBoxType.Size = new System.Drawing.Size(200, 23);
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Items.AddRange(new object[] {"Розничный", "Оптовый", "Интернет-магазин", "Другое"});
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // labelRating
            // 
            this.labelRating.Text = "Рейтинг:";
            this.labelRating.Location = new System.Drawing.Point(12, 75);
            this.labelRating.Size = new System.Drawing.Size(120, 23);
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Location = new System.Drawing.Point(140, 72);
            this.numericUpDownRating.Size = new System.Drawing.Size(200, 23);
            this.numericUpDownRating.Minimum = 0;
            this.numericUpDownRating.Maximum = 100;
            this.numericUpDownRating.DecimalPlaces = 0;
            this.numericUpDownRating.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // labelAddress
            // 
            this.labelAddress.Text = "Адрес:";
            this.labelAddress.Location = new System.Drawing.Point(12, 105);
            this.labelAddress.Size = new System.Drawing.Size(120, 23);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(140, 102);
            this.textBoxAddress.Size = new System.Drawing.Size(200, 23);
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // labelDirector
            // 
            this.labelDirector.Text = "ФИО директора:";
            this.labelDirector.Location = new System.Drawing.Point(12, 135);
            this.labelDirector.Size = new System.Drawing.Size(120, 23);
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(140, 132);
            this.textBoxDirector.Size = new System.Drawing.Size(200, 23);
            this.textBoxDirector.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // labelPhone
            // 
            this.labelPhone.Text = "Телефон:";
            this.labelPhone.Location = new System.Drawing.Point(12, 165);
            this.labelPhone.Size = new System.Drawing.Size(120, 23);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(140, 162);
            this.textBoxPhone.Size = new System.Drawing.Size(200, 23);
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // labelEmail
            // 
            this.labelEmail.Text = "Электронная почта:";
            this.labelEmail.Location = new System.Drawing.Point(12, 195);
            this.labelEmail.Size = new System.Drawing.Size(120, 23);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(140, 192);
            this.textBoxEmail.Size = new System.Drawing.Size(200, 23);
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // buttonOK
            // 
            this.buttonOK.Text = "OK";
            this.buttonOK.Location = new System.Drawing.Point(140, 230);
            this.buttonOK.Size = new System.Drawing.Size(100, 30);
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonOK.BackColor = System.Drawing.ColorTranslator.FromHtml("#67BA80");
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            // 
            // PartnerEditForm
            // 
            this.ClientSize = new System.Drawing.Size(370, 280);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.numericUpDownRating);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonOK);
            this.Text = "Партнёр";
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
} 