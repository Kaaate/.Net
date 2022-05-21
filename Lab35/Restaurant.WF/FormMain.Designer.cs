namespace Restaurant
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBoxRestaurant = new System.Windows.Forms.ListBox();
            this.buttonAddRestaurant = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.textBoxNameBakerie = new System.Windows.Forms.TextBox();
            this.textBoxAddressBakerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDishManagement = new System.Windows.Forms.Button();
            this.buttonIngradientManagment = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRestaurant
            // 
            this.listBoxRestaurant.FormattingEnabled = true;
            this.listBoxRestaurant.ItemHeight = 15;
            this.listBoxRestaurant.Location = new System.Drawing.Point(10, 9);
            this.listBoxRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxRestaurant.Name = "listBoxRestaurant";
            this.listBoxRestaurant.Size = new System.Drawing.Size(232, 154);
            this.listBoxRestaurant.TabIndex = 1;
            // 
            // buttonAddRestaurant
            // 
            this.buttonAddRestaurant.Location = new System.Drawing.Point(10, 229);
            this.buttonAddRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddRestaurant.Name = "buttonAddRestaurant";
            this.buttonAddRestaurant.Size = new System.Drawing.Size(122, 22);
            this.buttonAddRestaurant.TabIndex = 0;
            this.buttonAddRestaurant.Text = "Add Restaurant";
            this.buttonAddRestaurant.UseVisualStyleBackColor = true;
            this.buttonAddRestaurant.Click += new System.EventHandler(this.buttonAddRestaurant_Click);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(10, 259);
            this.buttonRemoveSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(122, 22);
            this.buttonRemoveSelected.TabIndex = 0;
            this.buttonRemoveSelected.Text = "Remove Selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(283, 9);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(92, 22);
            this.buttonAbout.TabIndex = 0;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // textBoxNameBakerie
            // 
            this.textBoxNameBakerie.Location = new System.Drawing.Point(132, 166);
            this.textBoxNameBakerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameBakerie.Name = "textBoxNameBakerie";
            this.textBoxNameBakerie.Size = new System.Drawing.Size(110, 23);
            this.textBoxNameBakerie.TabIndex = 2;
            // 
            // textBoxAddressBakerie
            // 
            this.textBoxAddressBakerie.Location = new System.Drawing.Point(132, 191);
            this.textBoxAddressBakerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddressBakerie.Name = "textBoxAddressBakerie";
            this.textBoxAddressBakerie.Size = new System.Drawing.Size(110, 23);
            this.textBoxAddressBakerie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address Restaurant";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(283, 259);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 22);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDishManagement
            // 
            this.buttonDishManagement.Location = new System.Drawing.Point(283, 35);
            this.buttonDishManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDishManagement.Name = "buttonDishManagement";
            this.buttonDishManagement.Size = new System.Drawing.Size(92, 40);
            this.buttonDishManagement.TabIndex = 4;
            this.buttonDishManagement.Text = "Dish Management";
            this.buttonDishManagement.UseVisualStyleBackColor = true;
            this.buttonDishManagement.Click += new System.EventHandler(this.buttonDishManagement_Click);
            // 
            // buttonIngradientManagment
            // 
            this.buttonIngradientManagment.Location = new System.Drawing.Point(283, 79);
            this.buttonIngradientManagment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIngradientManagment.Name = "buttonIngradientManagment";
            this.buttonIngradientManagment.Size = new System.Drawing.Size(92, 40);
            this.buttonIngradientManagment.TabIndex = 4;
            this.buttonIngradientManagment.Text = "Ingradient Management";
            this.buttonIngradientManagment.UseVisualStyleBackColor = true;
            this.buttonIngradientManagment.Click += new System.EventHandler(this.buttonIngradientManagement_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(159, 258);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 22);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonIngradientManagment);
            this.Controls.Add(this.buttonDishManagement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddressBakerie);
            this.Controls.Add(this.textBoxNameBakerie);
            this.Controls.Add(this.listBoxRestaurant);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.buttonAddRestaurant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxRestaurant;
        private System.Windows.Forms.Button buttonAddRestaurant;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.TextBox textBoxNameBakerie;
        private System.Windows.Forms.TextBox textBoxAddressBakerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDishManagement;
        private System.Windows.Forms.Button buttonIngradientManagment;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

