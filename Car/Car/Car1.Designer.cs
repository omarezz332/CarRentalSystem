namespace Car
{
    partial class Car1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.ADDC = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.car_model = new System.Windows.Forms.ComboBox();
            this.carmodelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDataSet5 = new CarRentalDataSet5();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.purchase_date = new System.Windows.Forms.DateTimePicker();
            this.purchase_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ins_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ins_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.regesteration_num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.year_of_prod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.num_of_pas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.engine_size = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fueltype = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Addc1 = new System.Windows.Forms.Button();
            this.car_modelTableAdapter = new CarRentalDataSet5TableAdapters.car_modelTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carmodelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet5)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.ADDC);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(161, 570);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 243);
            this.button1.TabIndex = 3;
            this.button1.Text = "ADD";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ADDC
            // 
            this.ADDC.FlatAppearance.BorderSize = 0;
            this.ADDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADDC.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDC.ForeColor = System.Drawing.Color.Black;
            this.ADDC.Image = ((System.Drawing.Image)(resources.GetObject("ADDC.Image")));
            this.ADDC.Location = new System.Drawing.Point(3, 252);
            this.ADDC.Name = "ADDC";
            this.ADDC.Size = new System.Drawing.Size(158, 295);
            this.ADDC.TabIndex = 2;
            this.ADDC.Text = "Delete";
            this.ADDC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ADDC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ADDC.UseVisualStyleBackColor = true;
            this.ADDC.Click += new System.EventHandler(this.ADDC_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(726, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 25);
            this.button6.TabIndex = 24;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(686, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 25);
            this.button4.TabIndex = 23;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(343, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 70);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 66);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(86, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 61);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.car_model);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.purchase_date);
            this.panel2.Controls.Add(this.purchase_price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ins_num);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ins_type);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(160, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 412);
            this.panel2.TabIndex = 26;
            // 
            // car_model
            // 
            this.car_model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.car_model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.car_model.DataSource = this.carmodelBindingSource;
            this.car_model.DisplayMember = "name";
            this.car_model.FormattingEnabled = true;
            this.car_model.Location = new System.Drawing.Point(7, 43);
            this.car_model.Name = "car_model";
            this.car_model.Size = new System.Drawing.Size(224, 21);
            this.car_model.TabIndex = 0;
            this.car_model.ValueMember = "id";
            this.car_model.SelectedIndexChanged += new System.EventHandler(this.car_model_SelectedIndexChanged);
            // 
            // carmodelBindingSource
            // 
            this.carmodelBindingSource.DataMember = "car_model";
            this.carmodelBindingSource.DataSource = this.carRentalDataSet5;
            // 
            // carRentalDataSet5
            // 
            this.carRentalDataSet5.DataSetName = "CarRentalDataSet5";
            this.carRentalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(7, 113);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(224, 20);
            this.name.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Car Name  :";
            // 
            // purchase_date
            // 
            this.purchase_date.Location = new System.Drawing.Point(7, 369);
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.Size = new System.Drawing.Size(220, 20);
            this.purchase_date.TabIndex = 5;
            this.purchase_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // purchase_price
            // 
            this.purchase_price.Location = new System.Drawing.Point(3, 302);
            this.purchase_price.Name = "purchase_price";
            this.purchase_price.Size = new System.Drawing.Size(224, 20);
            this.purchase_price.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Purchase Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Purchacse Price  :";
            // 
            // ins_num
            // 
            this.ins_num.Location = new System.Drawing.Point(3, 241);
            this.ins_num.Name = "ins_num";
            this.ins_num.Size = new System.Drawing.Size(224, 20);
            this.ins_num.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insurance Number :";
            // 
            // ins_type
            // 
            this.ins_type.Location = new System.Drawing.Point(7, 163);
            this.ins_type.Name = "ins_type";
            this.ins_type.Size = new System.Drawing.Size(224, 20);
            this.ins_type.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insurance Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car ID :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.regesteration_num);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.year_of_prod);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.s);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.num_of_pas);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.engine_size);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.fueltype);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(463, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 412);
            this.panel3.TabIndex = 27;
            // 
            // regesteration_num
            // 
            this.regesteration_num.Location = new System.Drawing.Point(4, 55);
            this.regesteration_num.Name = "regesteration_num";
            this.regesteration_num.Size = new System.Drawing.Size(237, 20);
            this.regesteration_num.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Registration Number :";
            // 
            // year_of_prod
            // 
            this.year_of_prod.Location = new System.Drawing.Point(3, 370);
            this.year_of_prod.Name = "year_of_prod";
            this.year_of_prod.Size = new System.Drawing.Size(238, 20);
            this.year_of_prod.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Year Of Production :";
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(5, 300);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(236, 20);
            this.s.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Rent Price :";
            // 
            // num_of_pas
            // 
            this.num_of_pas.Location = new System.Drawing.Point(5, 242);
            this.num_of_pas.Name = "num_of_pas";
            this.num_of_pas.Size = new System.Drawing.Size(236, 20);
            this.num_of_pas.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-4, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Number Of Passenger :";
            // 
            // engine_size
            // 
            this.engine_size.Location = new System.Drawing.Point(3, 181);
            this.engine_size.Name = "engine_size";
            this.engine_size.Size = new System.Drawing.Size(238, 20);
            this.engine_size.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-1, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "Engine Size  :";
            // 
            // fueltype
            // 
            this.fueltype.Location = new System.Drawing.Point(3, 121);
            this.fueltype.Name = "fueltype";
            this.fueltype.Size = new System.Drawing.Size(238, 20);
            this.fueltype.TabIndex = 7;
            this.fueltype.TextChanged += new System.EventHandler(this.fueltype_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-1, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "Fuel Type :";
            // 
            // Addc1
            // 
            this.Addc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Addc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addc1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Addc1.Location = new System.Drawing.Point(463, 503);
            this.Addc1.Name = "Addc1";
            this.Addc1.Size = new System.Drawing.Size(297, 55);
            this.Addc1.TabIndex = 12;
            this.Addc1.Text = "Submit";
            this.Addc1.UseVisualStyleBackColor = false;
            this.Addc1.Click += new System.EventHandler(this.Addc1_Click);
            // 
            // car_modelTableAdapter
            // 
            this.car_modelTableAdapter.ClearBeforeFill = true;
            // 
            // Car1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(772, 570);
            this.Controls.Add(this.Addc1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Car1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car1";
            this.Load += new System.EventHandler(this.Car1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carmodelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ADDC;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox purchase_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ins_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ins_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox year_of_prod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox num_of_pas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox engine_size;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fueltype;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Addc1;
        private System.Windows.Forms.DateTimePicker purchase_date;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox regesteration_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox car_model;
        private CarRentalDataSet5 carRentalDataSet5;
        private System.Windows.Forms.BindingSource carmodelBindingSource;
        private CarRentalDataSet5TableAdapters.car_modelTableAdapter car_modelTableAdapter;
    }
}