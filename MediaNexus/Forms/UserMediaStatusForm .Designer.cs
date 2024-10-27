using System.Drawing;
using System.Windows.Forms;

namespace MediaNexus.Forms
{
    partial class UserMediaStatusForm
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
            // Налаштування розміру форми
            this.Text = "Edit Media Status";
            this.Size = new Size(300, 150);
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Фіксований розмір
            this.MaximizeBox = false; // Вимкнути кнопку максимізації
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black; // Чорний фон

            // Створення випадаючого списку (ComboBox)
            statusComboBox = new ComboBox();
            statusComboBox.Location = new Point(20, 20);
            statusComboBox.Width = 240;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Items.AddRange(new string[] { "In Process", "Completed", "Planned", "Dropped" });
            statusComboBox.SelectedIndex = 0; // Вибрати перший елемент за замовчуванням
            this.Controls.Add(statusComboBox);

            // Створення кнопки "Зберегти зміни"
            saveButton = new Button();
            saveButton.Text = "Save";
            saveButton.Location = new Point(20, 60);
            saveButton.BackColor = Color.Green; // Зелений фон
            saveButton.ForeColor = Color.White; // Білий текст
            saveButton.Click += SaveButton_Click;
            this.Controls.Add(saveButton);

            // Створення кнопки "Видалити"
            deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Location = new Point(150, 60);
            deleteButton.BackColor = Color.Red; // Червоний фон
            deleteButton.ForeColor = Color.White; // Білий текст
            deleteButton.Click += DeleteButton_Click;
            this.Controls.Add(deleteButton);
        }
        #endregion

        private ComboBox statusComboBox;
        private Button saveButton;
        private Button deleteButton;
    }
}