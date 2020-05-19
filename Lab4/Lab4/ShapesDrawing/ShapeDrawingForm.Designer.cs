namespace ShapesDrawing
{
    partial class ShapeDrawingForm
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
            this.DrawingBoardPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShapesTypesListBox = new System.Windows.Forms.ListBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.shapeParametersGrid = new System.Windows.Forms.DataGridView();
            this.charColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentShapesListBox = new System.Windows.Forms.ListBox();
            this.ConnectPluginButon = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBoardPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeParametersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingBoardPictureBox
            // 
            this.DrawingBoardPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingBoardPictureBox.Location = new System.Drawing.Point(15, 12);
            this.DrawingBoardPictureBox.Name = "DrawingBoardPictureBox";
            this.DrawingBoardPictureBox.Size = new System.Drawing.Size(682, 431);
            this.DrawingBoardPictureBox.TabIndex = 0;
            this.DrawingBoardPictureBox.TabStop = false;
            this.DrawingBoardPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingBoardPictureBox_MouseDown);
            this.DrawingBoardPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingBoardPictureBox_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ConnectPluginButon);
            this.panel1.Controls.Add(this.ShapesTypesListBox);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.UndoButton);
            this.panel1.Controls.Add(this.DeserializeButton);
            this.panel1.Controls.Add(this.RedoButton);
            this.panel1.Controls.Add(this.SerializeButton);
            this.panel1.Location = new System.Drawing.Point(703, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 134);
            this.panel1.TabIndex = 7;
            // 
            // ShapesTypesListBox
            // 
            this.ShapesTypesListBox.FormattingEnabled = true;
            this.ShapesTypesListBox.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Rectangle",
            "Triangle",
            "Ellipse",
            "Line"});
            this.ShapesTypesListBox.Location = new System.Drawing.Point(3, 2);
            this.ShapesTypesListBox.Name = "ShapesTypesListBox";
            this.ShapesTypesListBox.Size = new System.Drawing.Size(65, 121);
            this.ShapesTypesListBox.TabIndex = 15;
            this.ShapesTypesListBox.SelectedIndexChanged += new System.EventHandler(this.ShapesTypesListBox_SelectedIndexChanged);
            // 
            // shapeParametersGrid
            // 
            this.shapeParametersGrid.AllowUserToAddRows = false;
            this.shapeParametersGrid.AllowUserToDeleteRows = false;
            this.shapeParametersGrid.AllowUserToResizeColumns = false;
            this.shapeParametersGrid.AllowUserToResizeRows = false;
            this.shapeParametersGrid.ColumnHeadersHeight = 25;
            this.shapeParametersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.shapeParametersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.charColumn,
            this.valueColumn});
            this.shapeParametersGrid.Location = new System.Drawing.Point(703, 266);
            this.shapeParametersGrid.MultiSelect = false;
            this.shapeParametersGrid.Name = "shapeParametersGrid";
            this.shapeParametersGrid.RowHeadersVisible = false;
            this.shapeParametersGrid.Size = new System.Drawing.Size(278, 177);
            this.shapeParametersGrid.TabIndex = 11;
            this.shapeParametersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shapeParametersGrid_CellContentClick);
            this.shapeParametersGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShapeParametersGrid_CellEndEdit);
            this.shapeParametersGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShapeParametersGrid_CellMouseUp);
            // 
            // charColumn
            // 
            this.charColumn.HeaderText = "Характеристика";
            this.charColumn.Name = "charColumn";
            this.charColumn.ReadOnly = true;
            this.charColumn.Width = 125;
            // 
            // valueColumn
            // 
            this.valueColumn.HeaderText = "Значение";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.Width = 70;
            // 
            // CurrentShapesListBox
            // 
            this.CurrentShapesListBox.FormattingEnabled = true;
            this.CurrentShapesListBox.Location = new System.Drawing.Point(703, 152);
            this.CurrentShapesListBox.Name = "CurrentShapesListBox";
            this.CurrentShapesListBox.Size = new System.Drawing.Size(278, 108);
            this.CurrentShapesListBox.TabIndex = 12;
            this.CurrentShapesListBox.SelectedIndexChanged += new System.EventHandler(this.CurrentShapesListBox_SelectedIndexChanged);
            // 
            // ConnectPluginButon
            // 
            this.ConnectPluginButon.Location = new System.Drawing.Point(174, 91);
            this.ConnectPluginButon.Name = "ConnectPluginButon";
            this.ConnectPluginButon.Size = new System.Drawing.Size(95, 37);
            this.ConnectPluginButon.TabIndex = 16;
            this.ConnectPluginButon.Text = "Подключить плагин";
            this.ConnectPluginButon.UseVisualStyleBackColor = true;
            this.ConnectPluginButon.Click += new System.EventHandler(this.ConnectPluginButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(73, 3);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(93, 37);
            this.UndoButton.TabIndex = 8;
            this.UndoButton.Text = "Назад";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(74, 91);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(92, 37);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Location = new System.Drawing.Point(73, 46);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(93, 39);
            this.RedoButton.TabIndex = 9;
            this.RedoButton.Text = "Вперед";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // SerializeButton
            // 
            this.SerializeButton.Location = new System.Drawing.Point(172, 3);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(97, 37);
            this.SerializeButton.TabIndex = 8;
            this.SerializeButton.Text = "Сохранить";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Location = new System.Drawing.Point(174, 46);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(97, 39);
            this.DeserializeButton.TabIndex = 13;
            this.DeserializeButton.Text = "Загрузить";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // ShapeDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 451);
            this.Controls.Add(this.CurrentShapesListBox);
            this.Controls.Add(this.shapeParametersGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DrawingBoardPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShapeDrawingForm";
            this.Text = "Лабораторная 1-2. Рисование фигур.";
            this.Load += new System.EventHandler(this.ShapeDrawingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBoardPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shapeParametersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawingBoardPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.DataGridView shapeParametersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn charColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.ListBox ShapesTypesListBox;
        private System.Windows.Forms.ListBox CurrentShapesListBox;
        private System.Windows.Forms.Button ConnectPluginButon;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button SerializeButton;
    }
}

