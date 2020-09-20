namespace Coordinate_and_tail_length
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
            this.Find = new System.Windows.Forms.Button();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumberOfProbe = new System.Windows.Forms.Label();
            this.lblNameOfProbe = new System.Windows.Forms.Label();
            this.lblNumberOfLine = new System.Windows.Forms.Label();
            this.cmbNumberOfSensor = new System.Windows.Forms.ComboBox();
            this.cmbNameOfLine = new System.Windows.Forms.ComboBox();
            this.cmbNumberOfLine = new System.Windows.Forms.ComboBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumberOfPat = new System.Windows.Forms.Label();
            this.txbNumberOfPat = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblTail = new System.Windows.Forms.Label();
            this.txbX = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.txbTailLength = new System.Windows.Forms.TextBox();
            this.pbVC = new System.Windows.Forms.PictureBox();
            this.btnTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbName.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVC)).BeginInit();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.Enabled = false;
            this.Find.FlatAppearance.BorderSize = 0;
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Find.Location = new System.Drawing.Point(338, 363);
            this.Find.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(258, 79);
            this.Find.TabIndex = 0;
            this.Find.Text = "Найти";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.tableLayoutPanel1);
            this.gbName.Location = new System.Drawing.Point(72, 140);
            this.gbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbName.Name = "gbName";
            this.gbName.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbName.Size = new System.Drawing.Size(782, 135);
            this.gbName.TabIndex = 1;
            this.gbName.TabStop = false;
            this.gbName.Text = "Имя зонда";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblNumberOfProbe, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNameOfProbe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNumberOfLine, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbNumberOfSensor, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbNameOfLine, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbNumberOfLine, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNumberOfProbe
            // 
            this.lblNumberOfProbe.AutoSize = true;
            this.lblNumberOfProbe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumberOfProbe.Location = new System.Drawing.Point(506, 24);
            this.lblNumberOfProbe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfProbe.Name = "lblNumberOfProbe";
            this.lblNumberOfProbe.Size = new System.Drawing.Size(258, 25);
            this.lblNumberOfProbe.TabIndex = 0;
            this.lblNumberOfProbe.Text = "№ зонда";
            // 
            // lblNameOfProbe
            // 
            this.lblNameOfProbe.AutoSize = true;
            this.lblNameOfProbe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNameOfProbe.Location = new System.Drawing.Point(256, 24);
            this.lblNameOfProbe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNameOfProbe.Name = "lblNameOfProbe";
            this.lblNameOfProbe.Size = new System.Drawing.Size(238, 25);
            this.lblNameOfProbe.TabIndex = 1;
            this.lblNameOfProbe.Text = "Имя линейки";
            // 
            // lblNumberOfLine
            // 
            this.lblNumberOfLine.AutoSize = true;
            this.lblNumberOfLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumberOfLine.Location = new System.Drawing.Point(6, 24);
            this.lblNumberOfLine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfLine.Name = "lblNumberOfLine";
            this.lblNumberOfLine.Size = new System.Drawing.Size(238, 25);
            this.lblNumberOfLine.TabIndex = 2;
            this.lblNumberOfLine.Text = "№ линейки";
            // 
            // cmbNumberOfSensor
            // 
            this.cmbNumberOfSensor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfSensor.FormattingEnabled = true;
            this.cmbNumberOfSensor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39"});
            this.cmbNumberOfSensor.Location = new System.Drawing.Point(506, 55);
            this.cmbNumberOfSensor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbNumberOfSensor.Name = "cmbNumberOfSensor";
            this.cmbNumberOfSensor.Size = new System.Drawing.Size(238, 33);
            this.cmbNumberOfSensor.TabIndex = 3;
            this.cmbNumberOfSensor.SelectedIndexChanged += new System.EventHandler(this.cmbNumberOfSensor_SelectedIndexChanged);
            // 
            // cmbNameOfLine
            // 
            this.cmbNameOfLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameOfLine.FormattingEnabled = true;
            this.cmbNameOfLine.Items.AddRange(new object[] {
            "DF_n",
            "DF_p",
            "MGDP"});
            this.cmbNameOfLine.Location = new System.Drawing.Point(256, 55);
            this.cmbNameOfLine.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbNameOfLine.Name = "cmbNameOfLine";
            this.cmbNameOfLine.Size = new System.Drawing.Size(238, 33);
            this.cmbNameOfLine.TabIndex = 4;
            this.cmbNameOfLine.SelectedIndexChanged += new System.EventHandler(this.cmbNameOfLine_SelectedIndexChanged);
            this.cmbNameOfLine.SelectedValueChanged += new System.EventHandler(this.cmbNameOfLine_SelectedValueChanged);
            // 
            // cmbNumberOfLine
            // 
            this.cmbNumberOfLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfLine.FormattingEnabled = true;
            this.cmbNumberOfLine.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbNumberOfLine.Location = new System.Drawing.Point(6, 55);
            this.cmbNumberOfLine.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbNumberOfLine.Name = "cmbNumberOfLine";
            this.cmbNumberOfLine.Size = new System.Drawing.Size(238, 33);
            this.cmbNumberOfLine.TabIndex = 5;
            this.cmbNumberOfLine.SelectedIndexChanged += new System.EventHandler(this.cmbNumberOfLine_SelectedIndexChanged);
            this.cmbNumberOfLine.SelectedValueChanged += new System.EventHandler(this.cmbNumberOfLine_SelectedValueChanged);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tableLayoutPanel2);
            this.gbResult.Location = new System.Drawing.Point(72, 494);
            this.gbResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbResult.Size = new System.Drawing.Size(776, 237);
            this.gbResult.TabIndex = 2;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblNumberOfPat, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txbNumberOfPat, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblX, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblY, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTail, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txbX, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbY, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txbTailLength, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 201);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblNumberOfPat
            // 
            this.lblNumberOfPat.AutoSize = true;
            this.lblNumberOfPat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumberOfPat.Location = new System.Drawing.Point(6, 176);
            this.lblNumberOfPat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfPat.Name = "lblNumberOfPat";
            this.lblNumberOfPat.Size = new System.Drawing.Size(370, 25);
            this.lblNumberOfPat.TabIndex = 8;
            this.lblNumberOfPat.Text = "Номер патрубка";
            this.lblNumberOfPat.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbNumberOfPat
            // 
            this.txbNumberOfPat.Location = new System.Drawing.Point(388, 135);
            this.txbNumberOfPat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbNumberOfPat.Name = "txbNumberOfPat";
            this.txbNumberOfPat.ReadOnly = true;
            this.txbNumberOfPat.Size = new System.Drawing.Size(196, 31);
            this.txbNumberOfPat.TabIndex = 7;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblX.Location = new System.Drawing.Point(6, 18);
            this.lblX.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(370, 25);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "Координата x,мм";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblY.Location = new System.Drawing.Point(6, 61);
            this.lblY.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(370, 25);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Координата y, мм";
            // 
            // lblTail
            // 
            this.lblTail.AutoSize = true;
            this.lblTail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTail.Location = new System.Drawing.Point(6, 104);
            this.lblTail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTail.Name = "lblTail";
            this.lblTail.Size = new System.Drawing.Size(370, 25);
            this.lblTail.TabIndex = 2;
            this.lblTail.Text = "Длина хвоста, м";
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(388, 6);
            this.txbX.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbX.Name = "txbX";
            this.txbX.ReadOnly = true;
            this.txbX.Size = new System.Drawing.Size(196, 31);
            this.txbX.TabIndex = 3;
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(388, 49);
            this.txbY.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbY.Name = "txbY";
            this.txbY.ReadOnly = true;
            this.txbY.Size = new System.Drawing.Size(196, 31);
            this.txbY.TabIndex = 4;
            // 
            // txbTailLength
            // 
            this.txbTailLength.Location = new System.Drawing.Point(388, 92);
            this.txbTailLength.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbTailLength.Name = "txbTailLength";
            this.txbTailLength.ReadOnly = true;
            this.txbTailLength.Size = new System.Drawing.Size(196, 31);
            this.txbTailLength.TabIndex = 5;
            // 
            // pbVC
            // 
            this.pbVC.Enabled = false;
            this.pbVC.Location = new System.Drawing.Point(866, 23);
            this.pbVC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbVC.Name = "pbVC";
            this.pbVC.Size = new System.Drawing.Size(1140, 1442);
            this.pbVC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVC.TabIndex = 3;
            this.pbVC.TabStop = false;
            this.pbVC.Click += new System.EventHandler(this.pbVC_Click);
            this.pbVC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbVC_MouseClick);
            this.pbVC.MouseCaptureChanged += new System.EventHandler(this.pbVC_MouseCaptureChanged);
            // 
            // btnTab
            // 
            this.btnTab.Enabled = false;
            this.btnTab.FlatAppearance.BorderSize = 0;
            this.btnTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTab.Location = new System.Drawing.Point(338, 846);
            this.btnTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(258, 79);
            this.btnTab.TabIndex = 4;
            this.btnTab.Text = "Таблица";
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 1471);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Длина хвоста";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2038, 1496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.pbVC);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.Find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Координаты и длина хвоста зонда";
            this.gbName.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNumberOfProbe;
        private System.Windows.Forms.Label lblNameOfProbe;
        private System.Windows.Forms.Label lblNumberOfLine;
        private System.Windows.Forms.ComboBox cmbNumberOfSensor;
        private System.Windows.Forms.ComboBox cmbNameOfLine;
        private System.Windows.Forms.ComboBox cmbNumberOfLine;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbVC;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblTail;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.TextBox txbTailLength;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Label lblNumberOfPat;
        private System.Windows.Forms.TextBox txbNumberOfPat;
        private System.Windows.Forms.Label label1;
    }
}

