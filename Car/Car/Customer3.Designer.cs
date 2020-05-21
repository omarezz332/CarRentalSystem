namespace Car
{
    partial class Customer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer2));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button = new System.Windows.Forms.Button();
            this.addc2 = new System.Windows.Forms.Button();
            this.editc2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPHC1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edc2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fisrt_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.combo = new System.Windows.Forms.ComboBox();
            this.customerphone = new customerphone();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new customerphoneTableAdapters.customerTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.button);
            this.flowLayoutPanel1.Controls.Add(this.addc2);
            this.flowLayoutPanel1.Controls.Add(this.editc2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(161, 410);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // button
            // 
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.Black;
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.Location = new System.Drawing.Point(3, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(158, 135);
            this.button.TabIndex = 34;
            this.button.Text = "Show All";
            this.button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // addc2
            // 
            this.addc2.FlatAppearance.BorderSize = 0;
            this.addc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addc2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addc2.ForeColor = System.Drawing.Color.Black;
            this.addc2.Image = ((System.Drawing.Image)(resources.GetObject("addc2.Image")));
            this.addc2.Location = new System.Drawing.Point(3, 144);
            this.addc2.Name = "addc2";
            this.addc2.Size = new System.Drawing.Size(158, 114);
            this.addc2.TabIndex = 2;
            this.addc2.Text = "ADD";
            this.addc2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addc2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addc2.UseVisualStyleBackColor = true;
            this.addc2.Click += new System.EventHandler(this.addc2_Click);
            // 
            // editc2
            // 
            this.editc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editc2.FlatAppearance.BorderSize = 0;
            this.editc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editc2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editc2.Image = ((System.Drawing.Image)(resources.GetObject("editc2.Image")));
            this.editc2.Location = new System.Drawing.Point(3, 264);
            this.editc2.Name = "editc2";
            this.editc2.Size = new System.Drawing.Size(158, 207);
            this.editc2.TabIndex = 1;
            this.editc2.Text = "Edit";
            this.editc2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editc2.UseVisualStyleBackColor = true;
            this.editc2.Click += new System.EventHandler(this.editc2_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(483, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 25);
            this.button6.TabIndex = 30;
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
            this.button4.Location = new System.Drawing.Point(452, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 25);
            this.button4.TabIndex = 18;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Adress : ";
            // 
            // CPHC1
            // 
            this.CPHC1.FormattingEnabled = true;
            this.CPHC1.Location = new System.Drawing.Point(169, 323);
            this.CPHC1.Name = "CPHC1";
            this.CPHC1.Size = new System.Drawing.Size(46, 21);
            this.CPHC1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone Number : ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(146, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 69);
            this.panel1.TabIndex = 28;
            // 
            // edc2
            // 
            this.edc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edc2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edc2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.edc2.Location = new System.Drawing.Point(169, 361);
            this.edc2.Name = "edc2";
            this.edc2.Size = new System.Drawing.Size(236, 34);
            this.edc2.TabIndex = 29;
            this.edc2.Text = "Submit";
            this.edc2.UseVisualStyleBackColor = false;
            this.edc2.Click += new System.EventHandler(this.edc2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phone Number ";
            // 
            // fisrt_name
            // 
            this.fisrt_name.Location = new System.Drawing.Point(171, 179);
            this.fisrt_name.Name = "fisrt_name";
            this.fisrt_name.Size = new System.Drawing.Size(234, 20);
            this.fisrt_name.TabIndex = 36;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(171, 227);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(234, 20);
            this.last_name.TabIndex = 37;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(169, 275);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(234, 20);
            this.address.TabIndex = 38;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(221, 324);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(184, 20);
            this.phone.TabIndex = 39;
            // 
            // combo
            // 
            this.combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo.DataSource = this.customerBindingSource;
            this.combo.DisplayMember = "phone";
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(171, 119);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(234, 21);
            this.combo.TabIndex = 40;
            this.combo.ValueMember = "phone";
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged_1);
            // 
            // customerphone
            // 
            this.customerphone.DataSetName = "customerphone";
            this.customerphone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.customerphone;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Customer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(525, 410);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.address);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.fisrt_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.edc2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CPHC1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer2";
            this.Load += new System.EventHandler(this.Customer2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addc2;
        private System.Windows.Forms.Button editc2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CPHC1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edc2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox fisrt_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox combo;
        private customerphone customerphone;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private customerphoneTableAdapters.customerTableAdapter customerTableAdapter;
       
 
    }
}