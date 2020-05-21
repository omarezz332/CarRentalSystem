namespace Car
{
    partial class Garage2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Garage2));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ADDC = new System.Windows.Forms.Button();
            this.EDITC = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.garageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDataSet15 = new CarRentalDataSet15();
            this.Addc1 = new System.Windows.Forms.Button();
            this.cphc1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ADC = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LC = new System.Windows.Forms.Label();
            this.FC = new System.Windows.Forms.Label();
            this.garageTableAdapter = new CarRentalDataSet15TableAdapters.garageTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.ADDC);
            this.flowLayoutPanel1.Controls.Add(this.EDITC);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(161, 375);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // ADDC
            // 
            this.ADDC.FlatAppearance.BorderSize = 0;
            this.ADDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADDC.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDC.ForeColor = System.Drawing.Color.Black;
            this.ADDC.Image = ((System.Drawing.Image)(resources.GetObject("ADDC.Image")));
            this.ADDC.Location = new System.Drawing.Point(3, 3);
            this.ADDC.Name = "ADDC";
            this.ADDC.Size = new System.Drawing.Size(158, 184);
            this.ADDC.TabIndex = 2;
            this.ADDC.Text = "ADD";
            this.ADDC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ADDC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ADDC.UseVisualStyleBackColor = true;
            this.ADDC.Click += new System.EventHandler(this.ADDC_Click);
            // 
            // EDITC
            // 
            this.EDITC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EDITC.FlatAppearance.BorderSize = 0;
            this.EDITC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EDITC.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITC.Image = ((System.Drawing.Image)(resources.GetObject("EDITC.Image")));
            this.EDITC.Location = new System.Drawing.Point(3, 193);
            this.EDITC.Name = "EDITC";
            this.EDITC.Size = new System.Drawing.Size(158, 262);
            this.EDITC.TabIndex = 1;
            this.EDITC.Text = "Edit";
            this.EDITC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EDITC.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 461);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 387);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(320, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 25);
            this.button4.TabIndex = 32;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(360, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 25);
            this.button6.TabIndex = 44;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.Addc1);
            this.panel2.Controls.Add(this.cphc1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.ADC);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.LC);
            this.panel2.Controls.Add(this.FC);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(115, -23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 421);
            this.panel2.TabIndex = 47;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.garageBindingSource;
            this.comboBox1.DisplayMember = "NAMEGARAGE";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 83);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.ValueMember = "NAMEGARAGE";
            // 
            // garageBindingSource
            // 
            this.garageBindingSource.DataMember = "garage";
            this.garageBindingSource.DataSource = this.carRentalDataSet15;
            // 
            // carRentalDataSet15
            // 
            this.carRentalDataSet15.DataSetName = "CarRentalDataSet15";
            this.carRentalDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Addc1
            // 
            this.Addc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Addc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addc1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addc1.ForeColor = System.Drawing.Color.Yellow;
            this.Addc1.Location = new System.Drawing.Point(98, 339);
            this.Addc1.Name = "Addc1";
            this.Addc1.Size = new System.Drawing.Size(229, 45);
            this.Addc1.TabIndex = 64;
            this.Addc1.Text = "EDIT";
            this.Addc1.UseVisualStyleBackColor = false;
            this.Addc1.Click += new System.EventHandler(this.Addc1_Click);
            // 
            // cphc1
            // 
            this.cphc1.FormattingEnabled = true;
            this.cphc1.Location = new System.Drawing.Point(98, 288);
            this.cphc1.Name = "cphc1";
            this.cphc1.Size = new System.Drawing.Size(46, 21);
            this.cphc1.TabIndex = 63;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(150, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 61;
            this.label5.Text = "Phone Number : ";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.textBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Location = new System.Drawing.Point(98, 236);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 20);
            this.textBox4.TabIndex = 60;
            // 
            // ADC
            // 
            this.ADC.AutoSize = true;
            this.ADC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADC.Location = new System.Drawing.Point(100, 163);
            this.ADC.Name = "ADC";
            this.ADC.Size = new System.Drawing.Size(85, 22);
            this.ADC.TabIndex = 59;
            this.ADC.Text = "Adress : ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(98, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 20);
            this.textBox2.TabIndex = 58;
            // 
            // LC
            // 
            this.LC.AutoSize = true;
            this.LC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC.Location = new System.Drawing.Point(98, 211);
            this.LC.Name = "LC";
            this.LC.Size = new System.Drawing.Size(87, 22);
            this.LC.TabIndex = 57;
            this.LC.Text = "Range : ";
            // 
            // FC
            // 
            this.FC.AutoSize = true;
            this.FC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FC.Location = new System.Drawing.Point(63, 46);
            this.FC.Name = "FC";
            this.FC.Size = new System.Drawing.Size(81, 22);
            this.FC.TabIndex = 55;
            this.FC.Text = "Name : ";
            // 
            // garageTableAdapter
            // 
            this.garageTableAdapter.ClearBeforeFill = true;
            // 
            // Garage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 375);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Garage2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage2";
            this.Load += new System.EventHandler(this.Garage2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ADDC;
        private System.Windows.Forms.Button EDITC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Addc1;
        private System.Windows.Forms.ComboBox cphc1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ADC;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LC;
        private System.Windows.Forms.Label FC;
        private System.Windows.Forms.ComboBox comboBox1;
        private CarRentalDataSet15 carRentalDataSet15;
        private System.Windows.Forms.BindingSource garageBindingSource;
        private CarRentalDataSet15TableAdapters.garageTableAdapter garageTableAdapter;
    }
}