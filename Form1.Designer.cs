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
            this.ButtonPrintLine = new System.Windows.Forms.Button();
            this.ButtonDeleteLine = new System.Windows.Forms.Button();
            this.ButtonRotateForward = new System.Windows.Forms.Button();
            this.ButtonRotateBack = new System.Windows.Forms.Button();
            this.labelMove = new System.Windows.Forms.Label();
            this.labelLineForRotation = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.CoordinateX = new System.Windows.Forms.TextBox();
            this.CoordinateY = new System.Windows.Forms.TextBox();
            this.CoordinateZ = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelZ1 = new System.Windows.Forms.Label();
            this.CoordinateX1 = new System.Windows.Forms.TextBox();
            this.CoordinateY1 = new System.Windows.Forms.TextBox();
            this.CoordinateZ1 = new System.Windows.Forms.TextBox();
            this.MoveTextBox = new System.Windows.Forms.TextBox();
            this.MovePlusX = new System.Windows.Forms.Button();
            this.MovePlusY = new System.Windows.Forms.Button();
            this.MovePlusZ = new System.Windows.Forms.Button();
            this.MoveMinusZ = new System.Windows.Forms.Button();
            this.MoveMinusY = new System.Windows.Forms.Button();
            this.MoveMinusX = new System.Windows.Forms.Button();
            this.RotateTextBox = new System.Windows.Forms.TextBox();
            this.labelRotation = new System.Windows.Forms.Label();
            this.RotateLeftZ = new System.Windows.Forms.Button();
            this.RotateLeftY = new System.Windows.Forms.Button();
            this.RotateLeftX = new System.Windows.Forms.Button();
            this.RotateRightZ = new System.Windows.Forms.Button();
            this.RotateRightY = new System.Windows.Forms.Button();
            this.RotateRightX = new System.Windows.Forms.Button();
            this.MirrorXY = new System.Windows.Forms.Button();
            this.MirrorXZ = new System.Windows.Forms.Button();
            this.MirrorYZ = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.Decrease = new System.Windows.Forms.Button();
            this.labelOX = new System.Windows.Forms.Label();
            this.labelOY = new System.Windows.Forms.Label();
            this.labelOZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDeffaultPosition
            // 
            this.ButtonDeffaultPosition.Location = new System.Drawing.Point(13, 12);
            this.ButtonDeffaultPosition.Name = "buttonDeffaultPosition";
            this.ButtonDeffaultPosition.Size = new System.Drawing.Size(188, 35);
            this.ButtonDeffaultPosition.TabIndex = 0;
            this.ButtonDeffaultPosition.Text = "Начальная позиция";
            this.ButtonDeffaultPosition.UseVisualStyleBackColor = true;
            this.ButtonDeffaultPosition.Click += new System.EventHandler(this.buttonDeffaultPosition_Click);
            this.ButtonDeffaultPosition.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.Location = new System.Drawing.Point(13, 48);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(104, 21);
            this.labelMove.TabIndex = 1;
            this.labelMove.Text = "Перемещение";
            this.labelMove.BackColor = System.Drawing.Color.White;
            this.labelMove.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MoveTextBox
            // 
            this.MoveTextBox.Location = new System.Drawing.Point(123, 45);
            this.MoveTextBox.Name = "MoveTextBox";
            this.MoveTextBox.Size = new System.Drawing.Size(83, 27);
            this.MoveTextBox.TabIndex = 2;
            this.MoveTextBox.Text = "10";
            this.MoveTextBox.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MovePlusX
            // 
            this.MovePlusX.Location = new System.Drawing.Point(21, 73);
            this.MovePlusX.Name = "MovePlusX";
            this.MovePlusX.Size = new System.Drawing.Size(55, 35);
            this.MovePlusX.TabIndex = 3;
            this.MovePlusX.Text = "X+";
            this.MovePlusX.UseVisualStyleBackColor = true;
            this.MovePlusX.Click += (sender, e) => MoveX_Click(sender, e, true);
            this.MovePlusX.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MovePlusY
            // 
            this.MovePlusY.Location = new System.Drawing.Point(86, 73);
            this.MovePlusY.Name = "MovePlusY";
            this.MovePlusY.Size = new System.Drawing.Size(55, 35);
            this.MovePlusY.TabIndex = 4;
            this.MovePlusY.Text = "Y+";
            this.MovePlusY.UseVisualStyleBackColor = true;
            this.MovePlusY.Click += (sender, e) => MoveY_Click(sender, e, true);
            this.MovePlusY.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MovePlusZ
            // 
            this.MovePlusZ.Location = new System.Drawing.Point(151, 73);
            this.MovePlusZ.Name = "MovePlusZ";
            this.MovePlusZ.Size = new System.Drawing.Size(55, 35);
            this.MovePlusZ.TabIndex = 5;
            this.MovePlusZ.Text = "Z+";
            this.MovePlusZ.UseVisualStyleBackColor = true;
            this.MovePlusZ.Click += (sender, e) => MoveZ_Click(sender, e, true);
            this.MovePlusZ.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MoveMinusZ
            // 
            this.MoveMinusZ.Location = new System.Drawing.Point(151, 109);
            this.MoveMinusZ.Name = "MoveMinusZ";
            this.MoveMinusZ.Size = new System.Drawing.Size(55, 35);
            this.MoveMinusZ.TabIndex = 8;
            this.MoveMinusZ.Text = "Z-";
            this.MoveMinusZ.UseVisualStyleBackColor = true;
            this.MoveMinusZ.Click += (sender, e) => MoveZ_Click(sender, e, false);
            this.MoveMinusZ.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MoveMinusY
            // 
            this.MoveMinusY.Location = new System.Drawing.Point(86, 109);
            this.MoveMinusY.Name = "MoveMinusY";
            this.MoveMinusY.Size = new System.Drawing.Size(55, 35);
            this.MoveMinusY.TabIndex = 7;
            this.MoveMinusY.Text = "Y-";
            this.MoveMinusY.UseVisualStyleBackColor = true;
            this.MoveMinusY.Click += (sender, e) => MoveY_Click(sender, e, false);
            this.MoveMinusY.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MoveMinusX
            // 
            this.MoveMinusX.Location = new System.Drawing.Point(21, 109);
            this.MoveMinusX.Name = "MoveMinusX";
            this.MoveMinusX.Size = new System.Drawing.Size(55, 35);
            this.MoveMinusX.TabIndex = 6;
            this.MoveMinusX.Text = "X-";
            this.MoveMinusX.UseVisualStyleBackColor = true;
            this.MoveMinusX.Click += (sender, e) => MoveX_Click(sender, e, false);
            this.MoveMinusX.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // RotateTextBox
            // 
            this.RotateTextBox.Location = new System.Drawing.Point(123, 145);
            this.RotateTextBox.Name = "RotateTextBox";
            this.RotateTextBox.Size = new System.Drawing.Size(83, 27);
            this.RotateTextBox.TabIndex = 10;
            this.RotateTextBox.Text = "30";
            this.RotateTextBox.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelRotation
            // 
            this.labelRotation.AutoSize = true;
            this.labelRotation.Location = new System.Drawing.Point(13, 148);
            this.labelRotation.Name = "labelRotation";
            this.labelRotation.Size = new System.Drawing.Size(78, 21);
            this.labelRotation.TabIndex = 9;
            this.labelRotation.Text = "Вращение";
            this.labelRotation.BackColor = System.Drawing.Color.White;
            this.labelRotation.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // RotateLeftZ
            // 
            this.RotateLeftZ.Location = new System.Drawing.Point(151, 212);
            this.RotateLeftZ.Name = "RotateLeftZ";
            this.RotateLeftZ.Size = new System.Drawing.Size(60, 35);
            this.RotateLeftZ.TabIndex = 16;
            this.RotateLeftZ.Text = "Z<--";
            this.RotateLeftZ.UseVisualStyleBackColor = true;
            this.RotateLeftZ.Click += (sender, e) => RotateZ_Click(sender, e, "left");
            this.RotateLeftZ.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // RotateLeftY
            // 
            this.RotateLeftY.Location = new System.Drawing.Point(86, 212);
            this.RotateLeftY.Name = "RotateLeftY";
            this.RotateLeftY.Size = new System.Drawing.Size(60, 35);
            this.RotateLeftY.TabIndex = 15;
            this.RotateLeftY.Text = "Y<--";
            this.RotateLeftY.UseVisualStyleBackColor = true;
            this.RotateLeftY.Click += (sender, e) => RotateY_Click(sender, e, "left");
            this.RotateLeftY.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // RotateLeftX
            // 
            this.RotateLeftX.Location = new System.Drawing.Point(21, 212);
            this.RotateLeftX.Name = "RotateLeftX";
            this.RotateLeftX.Size = new System.Drawing.Size(60, 35);
            this.RotateLeftX.TabIndex = 14;
            this.RotateLeftX.Text = "X<--";
            this.RotateLeftX.UseVisualStyleBackColor = true;
            this.RotateLeftX.Click += (sender, e) => RotateX_Click(sender, e, "left");
            this.RotateLeftX.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // RotateRightZ
            // 
            this.RotateRightZ.Location = new System.Drawing.Point(151, 176);
            this.RotateRightZ.Name = "RotateRightZ";
            this.RotateRightZ.Size = new System.Drawing.Size(60, 35);
            this.RotateRightZ.TabIndex = 13;
            this.RotateRightZ.Text = "Z-->";
            this.RotateRightZ.UseVisualStyleBackColor = true;
            this.RotateRightZ.Click += (sender, e) => RotateZ_Click(sender, e, "right");
            this.RotateRightZ.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // RotateRightY
            // 
            this.RotateRightY.Location = new System.Drawing.Point(86, 176);
            this.RotateRightY.Name = "RotateRightY";
            this.RotateRightY.Size = new System.Drawing.Size(60, 35);
            this.RotateRightY.TabIndex = 12;
            this.RotateRightY.Text = "Y-->";
            this.RotateRightY.UseVisualStyleBackColor = true;
            this.RotateRightY.Click += (sender, e) => RotateY_Click(sender, e, "right");
            this.RotateRightY.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // RotateRightX
            // 
            this.RotateRightX.Location = new System.Drawing.Point(21, 176);
            this.RotateRightX.Name = "RotateRightX";
            this.RotateRightX.Size = new System.Drawing.Size(60, 35);
            this.RotateRightX.TabIndex = 11;
            this.RotateRightX.Text = "X-->";
            this.RotateRightX.UseVisualStyleBackColor = true;
            this.RotateRightX.Click += (sender, e) => RotateX_Click(sender, e, "right");
            this.RotateRightX.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MirrorXY
            // 
            this.MirrorXY.Location = new System.Drawing.Point(21, 248);
            this.MirrorXY.Name = "MirrorXY";
            this.MirrorXY.Size = new System.Drawing.Size(188, 35);
            this.MirrorXY.TabIndex = 17;
            this.MirrorXY.Text = "Отражение OXY";
            this.MirrorXY.UseVisualStyleBackColor = true;
            this.MirrorXY.Click += (sender, e) => Reflection(sender, e, "XY");
            this.MirrorXY.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MirrorXZ
            // 
            this.MirrorXZ.Location = new System.Drawing.Point(21, 284);
            this.MirrorXZ.Name = "MirrorXZ";
            this.MirrorXZ.Size = new System.Drawing.Size(188, 35);
            this.MirrorXZ.TabIndex = 18;
            this.MirrorXZ.Text = "Отражение OXZ";
            this.MirrorXZ.UseVisualStyleBackColor = true;
            this.MirrorXZ.Click += (sender, e) => Reflection(sender, e, "XZ");
            this.MirrorXZ.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MirrorYZ
            // 
            this.MirrorYZ.Location = new System.Drawing.Point(21, 320);
            this.MirrorYZ.Name = "MirrorYZ";
            this.MirrorYZ.Size = new System.Drawing.Size(188, 35);
            this.MirrorYZ.TabIndex = 19;
            this.MirrorYZ.Text = "Отражение OYZ";
            this.MirrorYZ.UseVisualStyleBackColor = true;
            this.MirrorYZ.Click += (sender, e) => Reflection(sender, e, "YZ");
            this.MirrorYZ.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // Increase
            // 
            this.Increase.Location = new System.Drawing.Point(21, 356);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(188, 35);
            this.Increase.TabIndex = 20;
            this.Increase.Text = "Растяжение";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += (sender, e) => Scaling_Click(sender, e, true);
            this.Increase.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // Decrease
            // 
            this.Decrease.Location = new System.Drawing.Point(21, 392);
            this.Decrease.Name = "Decrease";
            this.Decrease.Size = new System.Drawing.Size(188, 35);
            this.Decrease.TabIndex = 21;
            this.Decrease.Text = "Сжатие";
            this.Decrease.UseVisualStyleBackColor = true;
            this.Decrease.Click += (sender, e) => Scaling_Click(sender, e, false);
            this.Decrease.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelLineForRotation
            // 
            this.labelLineForRotation.AutoSize = true;
            this.labelLineForRotation.Location = new System.Drawing.Point(13, 429);
            this.labelLineForRotation.Name = "labelLineForRotation";
            this.labelLineForRotation.Size = new System.Drawing.Size(104, 21);
            this.labelLineForRotation.TabIndex = 1;
            this.labelLineForRotation.Text = "Прямая для вращения";
            this.labelLineForRotation.BackColor = System.Drawing.Color.White;
            this.labelLineForRotation.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(13, 452);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(104, 21);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X = ";
            this.labelX.BackColor = System.Drawing.Color.White;
            this.labelX.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(113, 452);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(104, 21);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y = ";
            this.labelY.BackColor = System.Drawing.Color.White;
            this.labelY.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(213, 452);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(104, 21);
            this.labelZ.TabIndex = 1;
            this.labelZ.Text = "Z = ";
            this.labelZ.BackColor = System.Drawing.Color.White;
            this.labelZ.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // CoordinateX
            // 
            this.CoordinateX.Location = new System.Drawing.Point(55, 448);
            this.CoordinateX.Name = "CoordinateX";
            this.CoordinateX.Size = new System.Drawing.Size(55, 27);
            this.CoordinateX.TabIndex = 2;
            this.CoordinateX.Text = "";
            this.CoordinateX.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // CoordinateY
            // 
            this.CoordinateY.Location = new System.Drawing.Point(155, 448);
            this.CoordinateY.Name = "CoordinateY";
            this.CoordinateY.Size = new System.Drawing.Size(55, 27);
            this.CoordinateY.TabIndex = 2;
            this.CoordinateY.Text = "";
            this.CoordinateY.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // CoordinateZ
            // 
            this.CoordinateZ.Location = new System.Drawing.Point(255, 448);
            this.CoordinateZ.Name = "CoordinateZ";
            this.CoordinateZ.Size = new System.Drawing.Size(55, 27);
            this.CoordinateZ.TabIndex = 2;
            this.CoordinateZ.Text = "";
            this.CoordinateZ.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(13, 482);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(104, 21);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "X1 = ";
            this.labelX1.BackColor = System.Drawing.Color.White;
            this.labelX1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(113, 482);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(104, 21);
            this.labelY1.TabIndex = 1;
            this.labelY1.Text = "Y1 = ";
            this.labelY1.BackColor = System.Drawing.Color.White;
            this.labelY1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelZ1
            // 
            this.labelZ1.AutoSize = true;
            this.labelZ1.Location = new System.Drawing.Point(213, 482);
            this.labelZ1.Name = "labelZ1";
            this.labelZ1.Size = new System.Drawing.Size(104, 21);
            this.labelZ1.TabIndex = 1;
            this.labelZ1.Text = "Z1 = ";
            this.labelZ1.BackColor = System.Drawing.Color.White;
            this.labelZ1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // CoordinateX1
            // 
            this.CoordinateX1.Location = new System.Drawing.Point(55, 478);
            this.CoordinateX1.Name = "CoordinateX1";
            this.CoordinateX1.Size = new System.Drawing.Size(55, 27);
            this.CoordinateX1.TabIndex = 2;
            this.CoordinateX1.Text = "";
            this.CoordinateX1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // CoordinateY1
            // 
            this.CoordinateY1.Location = new System.Drawing.Point(155, 478);
            this.CoordinateY1.Name = "CoordinateY1";
            this.CoordinateY1.Size = new System.Drawing.Size(55, 27);
            this.CoordinateY1.TabIndex = 2;
            this.CoordinateY1.Text = "";
            this.CoordinateY1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // CoordinateZ1
            // 
            this.CoordinateZ1.Location = new System.Drawing.Point(255, 478);
            this.CoordinateZ1.Name = "CoordinateZ1";
            this.CoordinateZ1.Size = new System.Drawing.Size(55, 27);
            this.CoordinateZ1.TabIndex = 2;
            this.CoordinateZ1.Text = "";
            this.CoordinateZ1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // ButtonPrintLine
            // 
            this.ButtonPrintLine.Location = new System.Drawing.Point(13, 508);
            this.ButtonPrintLine.Name = "ButtonPrintLine";
            this.ButtonPrintLine.Size = new System.Drawing.Size(188, 35);
            this.ButtonPrintLine.TabIndex = 0;
            this.ButtonPrintLine.Text = "Отобразить линию";
            this.ButtonPrintLine.UseVisualStyleBackColor = true;
            this.ButtonPrintLine.Click += new System.EventHandler(this.ButtonPrintLine_Click);
            this.ButtonPrintLine.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // ButtonDeleteLine
            // 
            this.ButtonDeleteLine.Location = new System.Drawing.Point(13, 543);
            this.ButtonDeleteLine.Name = "ButtonDeleteLine";
            this.ButtonDeleteLine.Size = new System.Drawing.Size(188, 35);
            this.ButtonDeleteLine.TabIndex = 0;
            this.ButtonDeleteLine.Text = "Удалить линию";
            this.ButtonDeleteLine.UseVisualStyleBackColor = true;
            this.ButtonDeleteLine.Click += new System.EventHandler(this.ButtonDeleteLine_Click);
            this.ButtonDeleteLine.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // ButtonRotateForward
            // 
            this.ButtonRotateForward.Location = new System.Drawing.Point(13, 578);
            this.ButtonRotateForward.Name = "ButtonRotateForward";
            this.ButtonRotateForward.Size = new System.Drawing.Size(188, 35);
            this.ButtonRotateForward.TabIndex = 0;
            this.ButtonRotateForward.Text = "Вращать вперед";
            this.ButtonRotateForward.UseVisualStyleBackColor = true;
            this.ButtonRotateForward.Click += (sender, e) => Rotate_Click(sender, e, "forward");
            this.ButtonRotateForward.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // ButtonRotateBack
            // 
            this.ButtonRotateBack.Location = new System.Drawing.Point(13, 613);
            this.ButtonRotateBack.Name = "ButtonRotateBack";
            this.ButtonRotateBack.Size = new System.Drawing.Size(188, 35);
            this.ButtonRotateBack.TabIndex = 0;
            this.ButtonRotateBack.Text = "Вращать назад";
            this.ButtonRotateBack.UseVisualStyleBackColor = true;
            this.ButtonRotateBack.Click += (sender, e) => Rotate_Click(sender, e, "back");
            this.ButtonRotateBack.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelOX
            // 
            this.labelOX.AutoSize = true;
            this.labelOX.Location = new System.Drawing.Point(1700, 500);
            this.labelOX.Name = "labelOX";
            this.labelOX.Size = new System.Drawing.Size(104, 21);
            this.labelOX.TabIndex = 1;
            this.labelOX.Text = "X";
            this.labelOX.BackColor = System.Drawing.Color.White;
            this.labelOX.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelOY
            // 
            this.labelOY.AutoSize = true;
            this.labelOY.Location = new System.Drawing.Point(1025, 0);
            this.labelOY.Name = "labelOY";
            this.labelOY.Size = new System.Drawing.Size(104, 21);
            this.labelOY.TabIndex = 1;
            this.labelOY.Text = "Y";
            this.labelOY.BackColor = System.Drawing.Color.White;
            this.labelOY.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // labelOZ
            // 
            this.labelOZ.AutoSize = true;
            this.labelOZ.Location = new System.Drawing.Point(775, 735);
            this.labelOZ.Name = "labelOZ";
            this.labelOZ.Size = new System.Drawing.Size(104, 21);
            this.labelOZ.TabIndex = 1;
            this.labelOZ.Text = "Z";
            this.labelOZ.BackColor = System.Drawing.Color.White;
            this.labelOZ.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.Decrease);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.MirrorYZ);
            this.Controls.Add(this.MirrorXZ);
            this.Controls.Add(this.MirrorXY);
            this.Controls.Add(this.RotateLeftZ);
            this.Controls.Add(this.RotateLeftY);
            this.Controls.Add(this.RotateLeftX);
            this.Controls.Add(this.RotateRightZ);
            this.Controls.Add(this.RotateRightY);
            this.Controls.Add(this.RotateRightX);
            this.Controls.Add(this.RotateTextBox);
            this.Controls.Add(this.labelRotation);
            this.Controls.Add(this.MoveMinusZ);
            this.Controls.Add(this.MoveMinusY);
            this.Controls.Add(this.MoveMinusX);
            this.Controls.Add(this.MovePlusZ);
            this.Controls.Add(this.MovePlusY);
            this.Controls.Add(this.MovePlusX);
            this.Controls.Add(this.MoveTextBox);
            this.Controls.Add(this.CoordinateX);
            this.Controls.Add(this.CoordinateY);
            this.Controls.Add(this.CoordinateZ);
            this.Controls.Add(this.CoordinateX1);
            this.Controls.Add(this.CoordinateY1);
            this.Controls.Add(this.CoordinateZ1);
            this.Controls.Add(this.labelMove);
            this.Controls.Add(this.labelLineForRotation);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelZ1);
            this.Controls.Add(this.ButtonDeffaultPosition);
            this.Controls.Add(this.ButtonPrintLine);
            this.Controls.Add(this.ButtonDeleteLine);
            this.Controls.Add(this.ButtonRotateForward);
            this.Controls.Add(this.ButtonRotateBack);
            this.Controls.Add(this.labelOX);
            this.Controls.Add(this.labelOY);
            this.Controls.Add(this.labelOZ);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление невидимых граней (линий)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDeffaultPosition;
        private System.Windows.Forms.Button ButtonPrintLine;
        private System.Windows.Forms.Button ButtonDeleteLine;
        private System.Windows.Forms.Button ButtonRotateForward;
        private System.Windows.Forms.Button ButtonRotateBack;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.Label labelLineForRotation;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TextBox CoordinateX;
        private System.Windows.Forms.TextBox CoordinateZ;
        private System.Windows.Forms.TextBox CoordinateY;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelZ1;
        private System.Windows.Forms.TextBox CoordinateX1;
        private System.Windows.Forms.TextBox CoordinateZ1;
        private System.Windows.Forms.TextBox CoordinateY1;
        private System.Windows.Forms.TextBox MoveTextBox;
        private System.Windows.Forms.Button MovePlusX;
        private System.Windows.Forms.Button MovePlusY;
        private System.Windows.Forms.Button MovePlusZ;
        private System.Windows.Forms.Button MoveMinusZ;
        private System.Windows.Forms.Button MoveMinusY;
        private System.Windows.Forms.Button MoveMinusX;
        private System.Windows.Forms.TextBox RotateTextBox;
        private System.Windows.Forms.Label labelRotation;
        private System.Windows.Forms.Button RotateLeftZ;
        private System.Windows.Forms.Button RotateLeftY;
        private System.Windows.Forms.Button RotateLeftX;
        private System.Windows.Forms.Button RotateRightZ;
        private System.Windows.Forms.Button RotateRightY;
        private System.Windows.Forms.Button RotateRightX;
        private System.Windows.Forms.Button MirrorXY;
        private System.Windows.Forms.Button MirrorXZ;
        private System.Windows.Forms.Button MirrorYZ;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button Decrease;
        private System.Windows.Forms.Label labelOX;
        private System.Windows.Forms.Label labelOY;
        private System.Windows.Forms.Label labelOZ;
    }

}