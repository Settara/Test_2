using System;
using System.Windows.Forms;

namespace ComputerGraphics1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonDeffaultPosition = new System.Windows.Forms.Button();
            this.RotateTextBox = new System.Windows.Forms.TextBox();
            this.labelRotation = new System.Windows.Forms.Label();
            this.RotateLeftZ = new System.Windows.Forms.Button();
            this.RotateLeftY = new System.Windows.Forms.Button();
            this.RotateLeftX = new System.Windows.Forms.Button();
            this.RotateRightZ = new System.Windows.Forms.Button();
            this.RotateRightY = new System.Windows.Forms.Button();
            this.RotateRightX = new System.Windows.Forms.Button();
            this.labelOX = new System.Windows.Forms.Label();
            this.labelOY = new System.Windows.Forms.Label();
            this.labelOZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonDeffaultPosition
            // 
            this.ButtonDeffaultPosition.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.ButtonDeffaultPosition.Location = new System.Drawing.Point(13, 12);
            this.ButtonDeffaultPosition.Name = "ButtonDeffaultPosition";
            this.ButtonDeffaultPosition.Size = new System.Drawing.Size(188, 35);
            this.ButtonDeffaultPosition.TabIndex = 0;
            this.ButtonDeffaultPosition.Text = "Начальная позиция";
            this.ButtonDeffaultPosition.UseVisualStyleBackColor = true;
            this.ButtonDeffaultPosition.Click += new System.EventHandler(this.buttonDefaultPosition_Click);
            // 
            // RotateTextBox
            // 
            this.RotateTextBox.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.RotateTextBox.Location = new System.Drawing.Point(118, 60);
            this.RotateTextBox.Name = "RotateTextBox";
            this.RotateTextBox.Size = new System.Drawing.Size(83, 25);
            this.RotateTextBox.TabIndex = 10;
            this.RotateTextBox.Text = "10";
            // 
            // labelRotation
            // 
            this.labelRotation.AutoSize = true;
            this.labelRotation.BackColor = System.Drawing.Color.White;
            this.labelRotation.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.labelRotation.Location = new System.Drawing.Point(12, 65);
            this.labelRotation.Name = "labelRotation";
            this.labelRotation.Size = new System.Drawing.Size(81, 20);
            this.labelRotation.TabIndex = 9;
            this.labelRotation.Text = "Вращение";
            // 
            // RotateLeftZ
            // 
            this.RotateLeftZ.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.RotateLeftZ.Location = new System.Drawing.Point(144, 146);
            this.RotateLeftZ.Name = "RotateLeftZ";
            this.RotateLeftZ.Size = new System.Drawing.Size(60, 35);
            this.RotateLeftZ.TabIndex = 16;
            this.RotateLeftZ.Text = "Z<--";
            this.RotateLeftZ.UseVisualStyleBackColor = true;
            this.RotateLeftZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateLeftZ_MouseDown);
            this.RotateLeftZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateLeftZ_MouseUp);
            // 
            // RotateLeftY
            // 
            this.RotateLeftY.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.RotateLeftY.Location = new System.Drawing.Point(78, 146);
            this.RotateLeftY.Name = "RotateLeftY";
            this.RotateLeftY.Size = new System.Drawing.Size(60, 35);
            this.RotateLeftY.TabIndex = 15;
            this.RotateLeftY.Text = "Y<--";
            this.RotateLeftY.UseVisualStyleBackColor = true;
            this.RotateLeftY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateLeftY_MouseDown);
            this.RotateLeftY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateLeftY_MouseUp);
            // 
            // RotateLeftX
            // 
            this.RotateLeftX.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.RotateLeftX.Location = new System.Drawing.Point(12, 146);
            this.RotateLeftX.Name = "RotateLeftX";
            this.RotateLeftX.Size = new System.Drawing.Size(60, 35);
            this.RotateLeftX.TabIndex = 14;
            this.RotateLeftX.Text = "X<--";
            this.RotateLeftX.UseVisualStyleBackColor = true;
            this.RotateLeftX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateLeftX_MouseDown);
            this.RotateLeftX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateLeftX_MouseUp);
            // 
            // RotateRightZ
            // 
            this.RotateRightZ.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.RotateRightZ.Location = new System.Drawing.Point(144, 105);
            this.RotateRightZ.Name = "RotateRightZ";
            this.RotateRightZ.Size = new System.Drawing.Size(60, 35);
            this.RotateRightZ.TabIndex = 13;
            this.RotateRightZ.Text = "Z-->";
            this.RotateRightZ.UseVisualStyleBackColor = true;
            this.RotateRightZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateRightZ_MouseDown);
            this.RotateRightZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateRightZ_MouseUp);
            // 
            // RotateRightY
            // 
            this.RotateRightY.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.RotateRightY.Location = new System.Drawing.Point(78, 105);
            this.RotateRightY.Name = "RotateRightY";
            this.RotateRightY.Size = new System.Drawing.Size(60, 35);
            this.RotateRightY.TabIndex = 12;
            this.RotateRightY.Text = "Y-->";
            this.RotateRightY.UseVisualStyleBackColor = true;
            this.RotateRightY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateRightY_MouseDown);
            this.RotateRightY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateRightY_MouseUp);
            // 
            // RotateRightX
            // 
            this.RotateRightX.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.RotateRightX.Location = new System.Drawing.Point(13, 105);
            this.RotateRightX.Name = "RotateRightX";
            this.RotateRightX.Size = new System.Drawing.Size(60, 35);
            this.RotateRightX.TabIndex = 11;
            this.RotateRightX.Text = "X-->";
            this.RotateRightX.UseVisualStyleBackColor = true;
            this.RotateRightX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateRightX_MouseDown);
            this.RotateRightX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateRightX_MouseUp);
            // 
            // labelOX
            // 
            this.labelOX.AutoSize = true;
            this.labelOX.BackColor = System.Drawing.Color.White;
            this.labelOX.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.labelOX.Location = new System.Drawing.Point(1700, 500);
            this.labelOX.Name = "labelOX";
            this.labelOX.Size = new System.Drawing.Size(20, 22);
            this.labelOX.TabIndex = 1;
            this.labelOX.Text = "X";
            // 
            // labelOY
            // 
            this.labelOY.AutoSize = true;
            this.labelOY.BackColor = System.Drawing.Color.White;
            this.labelOY.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.labelOY.Location = new System.Drawing.Point(1025, 0);
            this.labelOY.Name = "labelOY";
            this.labelOY.Size = new System.Drawing.Size(20, 22);
            this.labelOY.TabIndex = 1;
            this.labelOY.Text = "Y";
            // 
            // labelOZ
            // 
            this.labelOZ.AutoSize = true;
            this.labelOZ.BackColor = System.Drawing.Color.White;
            this.labelOZ.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.labelOZ.Location = new System.Drawing.Point(775, 735);
            this.labelOZ.Name = "labelOZ";
            this.labelOZ.Size = new System.Drawing.Size(20, 22);
            this.labelOZ.TabIndex = 1;
            this.labelOZ.Text = "Z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.RotateLeftZ);
            this.Controls.Add(this.RotateLeftY);
            this.Controls.Add(this.RotateLeftX);
            this.Controls.Add(this.RotateRightZ);
            this.Controls.Add(this.RotateRightY);
            this.Controls.Add(this.RotateRightX);
            this.Controls.Add(this.RotateTextBox);
            this.Controls.Add(this.labelRotation);
            this.Controls.Add(this.ButtonDeffaultPosition);
            this.Controls.Add(this.labelOX);
            this.Controls.Add(this.labelOY);
            this.Controls.Add(this.labelOZ);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление невидимых граней(линий)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ButtonDeffaultPosition;
        private System.Windows.Forms.TextBox RotateTextBox;
        private System.Windows.Forms.Label labelRotation;
        private System.Windows.Forms.Button RotateLeftZ;
        private System.Windows.Forms.Button RotateLeftY;
        private System.Windows.Forms.Button RotateLeftX;
        private System.Windows.Forms.Button RotateRightZ;
        private System.Windows.Forms.Button RotateRightY;
        private System.Windows.Forms.Button RotateRightX;
        private System.Windows.Forms.Label labelOX;
        private System.Windows.Forms.Label labelOY;
        private System.Windows.Forms.Label labelOZ;
    }
}
