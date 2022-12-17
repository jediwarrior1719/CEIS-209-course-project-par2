using System;

namespace Johnston_CourseProject_Part2
{
    partial class MainForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.PrintPaychecksButton = new System.Windows.Forms.Button();
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.PaleGreen;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(75, 35);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(146, 60);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add ";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.PaleGreen;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(326, 35);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(146, 60);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.PaleGreen;
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(576, 35);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(146, 60);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // PrintPaychecksButton
            // 
            this.PrintPaychecksButton.BackColor = System.Drawing.Color.PaleGreen;
            this.PrintPaychecksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPaychecksButton.Location = new System.Drawing.Point(826, 35);
            this.PrintPaychecksButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintPaychecksButton.Name = "PrintPaychecksButton";
            this.PrintPaychecksButton.Size = new System.Drawing.Size(146, 60);
            this.PrintPaychecksButton.TabIndex = 3;
            this.PrintPaychecksButton.Text = "Print Paychecks ";
            this.PrintPaychecksButton.UseVisualStyleBackColor = false;
            this.PrintPaychecksButton.Click += new System.EventHandler(this.PrintPaychecksButton_Click);
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EmployeesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesListBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.HorizontalExtent = 2000;
            this.EmployeesListBox.HorizontalScrollbar = true;
            this.EmployeesListBox.ItemHeight = 16;
            this.EmployeesListBox.Location = new System.Drawing.Point(32, 117);
            this.EmployeesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(998, 356);
            this.EmployeesListBox.TabIndex = 4;
            this.EmployeesListBox.DoubleClick += new System.EventHandler(this.EmployeesListBox_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1059, 585);
            this.Controls.Add(this.EmployeesListBox);
            this.Controls.Add(this.PrintPaychecksButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Payroll System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button PrintPaychecksButton;
        private System.Windows.Forms.ListBox EmployeesListBox;

        public EventHandler button4_Click { get; private set; }
    }
}

