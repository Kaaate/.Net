namespace Restaurant
{
    partial class FormDishManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDishManagement));
            this.labelRecipeDish = new System.Windows.Forms.Label();
            this.labelNameDish = new System.Windows.Forms.Label();
            this.textBoxRecipeDish = new System.Windows.Forms.TextBox();
            this.textBoxNameDish = new System.Windows.Forms.TextBox();
            this.listBoxDish = new System.Windows.Forms.ListBox();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonAddDish = new System.Windows.Forms.Button();
            this.listBoxIngradients = new System.Windows.Forms.ListBox();
            this.listBoDishIngradients = new System.Windows.Forms.ListBox();
            this.buttonAddIngradient = new System.Windows.Forms.Button();
            this.buttonRemoveIngradient = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRecipeDish
            // 
            this.labelRecipeDish.AutoSize = true;
            this.labelRecipeDish.Location = new System.Drawing.Point(12, 262);
            this.labelRecipeDish.Name = "labelRecipeDish";
            this.labelRecipeDish.Size = new System.Drawing.Size(87, 20);
            this.labelRecipeDish.TabIndex = 3;
            this.labelRecipeDish.Text = "Recipe Dish";
            // 
            // labelNameDish
            // 
            this.labelNameDish.AutoSize = true;
            this.labelNameDish.Location = new System.Drawing.Point(12, 229);
            this.labelNameDish.Name = "labelNameDish";
            this.labelNameDish.Size = new System.Drawing.Size(82, 20);
            this.labelNameDish.TabIndex = 3;
            this.labelNameDish.Text = "Name Dish";
            // 
            // textBoxRecipeDish
            // 
            this.textBoxRecipeDish.Location = new System.Drawing.Point(151, 255);
            this.textBoxRecipeDish.Name = "textBoxRecipeDish";
            this.textBoxRecipeDish.Size = new System.Drawing.Size(125, 27);
            this.textBoxRecipeDish.TabIndex = 2;
            // 
            // textBoxNameDish
            // 
            this.textBoxNameDish.Location = new System.Drawing.Point(151, 222);
            this.textBoxNameDish.Name = "textBoxNameDish";
            this.textBoxNameDish.Size = new System.Drawing.Size(125, 27);
            this.textBoxNameDish.TabIndex = 2;
            // 
            // listBoxDish
            // 
            this.listBoxDish.FormattingEnabled = true;
            this.listBoxDish.ItemHeight = 20;
            this.listBoxDish.Location = new System.Drawing.Point(12, 12);
            this.listBoxDish.Name = "listBoxDish";
            this.listBoxDish.Size = new System.Drawing.Size(264, 204);
            this.listBoxDish.TabIndex = 1;
            this.listBoxDish.SelectedIndexChanged += new System.EventHandler(this.listBoxDish_SelectedIndexChanged);
            this.listBoxDish.SelectedValueChanged += new System.EventHandler(this.listBoxDish_SelectedValueChanged);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(12, 345);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(140, 29);
            this.buttonRemoveSelected.TabIndex = 0;
            this.buttonRemoveSelected.Text = "Remove Selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonAddDish
            // 
            this.buttonAddDish.Location = new System.Drawing.Point(12, 305);
            this.buttonAddDish.Name = "buttonAddDish";
            this.buttonAddDish.Size = new System.Drawing.Size(140, 29);
            this.buttonAddDish.TabIndex = 0;
            this.buttonAddDish.Text = "Add Dish";
            this.buttonAddDish.UseVisualStyleBackColor = true;
            this.buttonAddDish.Click += new System.EventHandler(this.buttonAddDish_Click);
            // 
            // listBoxIngradients
            // 
            this.listBoxIngradients.FormattingEnabled = true;
            this.listBoxIngradients.ItemHeight = 20;
            this.listBoxIngradients.Location = new System.Drawing.Point(758, 12);
            this.listBoxIngradients.Name = "listBoxIngradients";
            this.listBoxIngradients.Size = new System.Drawing.Size(264, 384);
            this.listBoxIngradients.TabIndex = 1;
            this.listBoxIngradients.SelectedIndexChanged += new System.EventHandler(this.listBoxIngradients_SelectedIndexChanged);
            // 
            // listBoDishIngradients
            // 
            this.listBoDishIngradients.FormattingEnabled = true;
            this.listBoDishIngradients.ItemHeight = 20;
            this.listBoDishIngradients.Location = new System.Drawing.Point(375, 12);
            this.listBoDishIngradients.Name = "listBoDishIngradients";
            this.listBoDishIngradients.Size = new System.Drawing.Size(264, 384);
            this.listBoDishIngradients.TabIndex = 1;
            // 
            // buttonAddIngradient
            // 
            this.buttonAddIngradient.Location = new System.Drawing.Point(645, 115);
            this.buttonAddIngradient.Name = "buttonAddIngradient";
            this.buttonAddIngradient.Size = new System.Drawing.Size(107, 60);
            this.buttonAddIngradient.TabIndex = 0;
            this.buttonAddIngradient.Text = "Add Ingradient";
            this.buttonAddIngradient.UseVisualStyleBackColor = true;
            this.buttonAddIngradient.Click += new System.EventHandler(this.buttonAddIngradient_Click);
            // 
            // buttonRemoveIngradient
            // 
            this.buttonRemoveIngradient.Location = new System.Drawing.Point(645, 181);
            this.buttonRemoveIngradient.Name = "buttonRemoveIngradient";
            this.buttonRemoveIngradient.Size = new System.Drawing.Size(107, 60);
            this.buttonRemoveIngradient.TabIndex = 0;
            this.buttonRemoveIngradient.Text = "Remove Ingradient";
            this.buttonRemoveIngradient.UseVisualStyleBackColor = true;
            this.buttonRemoveIngradient.Click += new System.EventHandler(this.buttonRemoveIngradient_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(159, 344);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 29);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormDishManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 404);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRemoveIngradient);
            this.Controls.Add(this.buttonAddIngradient);
            this.Controls.Add(this.buttonAddDish);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.listBoDishIngradients);
            this.Controls.Add(this.listBoxIngradients);
            this.Controls.Add(this.listBoxDish);
            this.Controls.Add(this.textBoxNameDish);
            this.Controls.Add(this.textBoxRecipeDish);
            this.Controls.Add(this.labelNameDish);
            this.Controls.Add(this.labelRecipeDish);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDishManagement";
            this.Text = "FormDishManagment";
            this.Load += new System.EventHandler(this.FormDishManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRecipeDish;
        private System.Windows.Forms.Label labelNameDish;
        private System.Windows.Forms.TextBox textBoxRecipeDish;
        private System.Windows.Forms.TextBox textBoxNameDish;
        private System.Windows.Forms.ListBox listBoxDish;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonAddDish;
        private System.Windows.Forms.ListBox listBoxIngradients;
        private System.Windows.Forms.ListBox listBoDishIngradients;
        private System.Windows.Forms.Button buttonAddIngradient;
        private System.Windows.Forms.Button buttonRemoveIngradient;
        private System.Windows.Forms.Button buttonUpdate;
    }
}