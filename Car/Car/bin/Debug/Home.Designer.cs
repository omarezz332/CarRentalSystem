namespace Car
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.services = new System.Windows.Forms.Button();
            this.cars = new System.Windows.Forms.Button();
            this.garage = new System.Windows.Forms.Button();
            this.ex = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(15, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 392);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.customer);
            this.panel3.Location = new System.Drawing.Point(197, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 109);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(388, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(419, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer
            // 
            this.customer.FlatAppearance.BorderSize = 0;
            this.customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.customer.Image = ((System.Drawing.Image)(resources.GetObject("customer.Image")));
            this.customer.Location = new System.Drawing.Point(-2, -3);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(456, 109);
            this.customer.TabIndex = 0;
            this.customer.Text = "Customer";
            this.customer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.services, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cars, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.garage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ex, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(197, 112);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.05195F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.94805F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 275);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // services
            // 
            this.services.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("services.BackgroundImage")));
            this.services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.services.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.services.FlatAppearance.BorderSize = 0;
            this.services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.services.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.services.Location = new System.Drawing.Point(231, 135);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(222, 137);
            this.services.TabIndex = 3;
            this.services.Text = "   services";
            this.services.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.services.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.services.UseVisualStyleBackColor = true;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // cars
            // 
            this.cars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cars.BackgroundImage")));
            this.cars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cars.FlatAppearance.BorderSize = 0;
            this.cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cars.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cars.Location = new System.Drawing.Point(3, 3);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(222, 126);
            this.cars.TabIndex = 1;
            this.cars.Text = "Cars";
            this.cars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cars.UseVisualStyleBackColor = true;
            this.cars.Click += new System.EventHandler(this.cars_Click);
            // 
            // garage
            // 
            this.garage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("garage.BackgroundImage")));
            this.garage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.garage.FlatAppearance.BorderSize = 0;
            this.garage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.garage.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.garage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.garage.Location = new System.Drawing.Point(231, 3);
            this.garage.Name = "garage";
            this.garage.Size = new System.Drawing.Size(222, 126);
            this.garage.TabIndex = 2;
            this.garage.Text = "Garage";
            this.garage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.garage.UseVisualStyleBackColor = true;
            this.garage.Click += new System.EventHandler(this.garage_Click);
            // 
            // ex
            // 
            this.ex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ex.BackgroundImage")));
            this.ex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ex.FlatAppearance.BorderSize = 0;
            this.ex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ex.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ex.Location = new System.Drawing.Point(3, 135);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(222, 137);
            this.ex.TabIndex = 4;
            this.ex.Text = "Expenditeure";
            this.ex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ex.UseVisualStyleBackColor = true;
            this.ex.Click += new System.EventHandler(this.ex_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 392);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(669, 392);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button services;
        private System.Windows.Forms.Button cars;
        private System.Windows.Forms.Button garage;
        private System.Windows.Forms.Button ex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

