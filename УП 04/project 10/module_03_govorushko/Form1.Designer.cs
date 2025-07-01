namespace PartnerManager;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataGridView dataGridViewPartners;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.PictureBox pictureBoxLogo;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.dataGridViewPartners = new System.Windows.Forms.DataGridView();
        this.buttonAdd = new System.Windows.Forms.Button();
        this.buttonEdit = new System.Windows.Forms.Button();
        this.buttonDelete = new System.Windows.Forms.Button();
        this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartners)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridViewPartners
        // 
        this.dataGridViewPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewPartners.Location = new System.Drawing.Point(12, 50);
        this.dataGridViewPartners.Name = "dataGridViewPartners";
        this.dataGridViewPartners.RowTemplate.Height = 25;
        this.dataGridViewPartners.Size = new System.Drawing.Size(760, 330);
        this.dataGridViewPartners.TabIndex = 0;
        this.dataGridViewPartners.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#F4E8D3");
        this.dataGridViewPartners.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
        // 
        // buttonAdd
        // 
        this.buttonAdd.Location = new System.Drawing.Point(12, 400);
        this.buttonAdd.Name = "buttonAdd";
        this.buttonAdd.Size = new System.Drawing.Size(120, 30);
        this.buttonAdd.TabIndex = 1;
        this.buttonAdd.Text = "Добавить";
        this.buttonAdd.UseVisualStyleBackColor = true;
        this.buttonAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#67BA80");
        this.buttonAdd.ForeColor = System.Drawing.Color.White;
        this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        // 
        // buttonEdit
        // 
        this.buttonEdit.Location = new System.Drawing.Point(150, 400);
        this.buttonEdit.Name = "buttonEdit";
        this.buttonEdit.Size = new System.Drawing.Size(120, 30);
        this.buttonEdit.TabIndex = 2;
        this.buttonEdit.Text = "Редактировать";
        this.buttonEdit.UseVisualStyleBackColor = true;
        this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
        // 
        // buttonDelete
        // 
        this.buttonDelete.Location = new System.Drawing.Point(290, 400);
        this.buttonDelete.Name = "buttonDelete";
        this.buttonDelete.Size = new System.Drawing.Size(120, 30);
        this.buttonDelete.TabIndex = 3;
        this.buttonDelete.Text = "Удалить";
        this.buttonDelete.UseVisualStyleBackColor = true;
        this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.buttonDelete.BackColor = System.Drawing.ColorTranslator.FromHtml("#F4E8D3");
        // 
        // pictureBoxLogo
        // 
        this.pictureBoxLogo.Location = new System.Drawing.Point(12, 5);
        this.pictureBoxLogo.Size = new System.Drawing.Size(120, 40);
        this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        // 
        // Form1
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.dataGridViewPartners);
        this.Controls.Add(this.buttonAdd);
        this.Controls.Add(this.buttonEdit);
        this.Controls.Add(this.buttonDelete);
        this.Controls.Add(this.pictureBoxLogo);
        this.Name = "Form1";
        this.Text = "Список партнёров";
        this.BackColor = System.Drawing.Color.White;
        this.Font = new System.Drawing.Font("Segoe UI", 10F);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartners)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion
}
