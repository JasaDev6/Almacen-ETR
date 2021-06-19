
namespace Almacen_ETR.CapaPresentacion
{
    partial class SearchIncome
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
            this.comboBoxSearchUser = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.comboBoxListThree = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchThree = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearchTwo = new System.Windows.Forms.ComboBox();
            this.comboBoxListTwo = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchOne = new System.Windows.Forms.ComboBox();
            this.comboBoxListOne = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSearchUser
            // 
            this.comboBoxSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSearchUser.FormattingEnabled = true;
            this.comboBoxSearchUser.Location = new System.Drawing.Point(171, 47);
            this.comboBoxSearchUser.Name = "comboBoxSearchUser";
            this.comboBoxSearchUser.Size = new System.Drawing.Size(236, 22);
            this.comboBoxSearchUser.TabIndex = 0;
            this.comboBoxSearchUser.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSearchUser_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 157);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1134, 422);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.VirtualMode = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por usuario";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(483, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(35, 19);
            this.title.TabIndex = 3;
            this.title.Text = "title";
            // 
            // comboBoxListThree
            // 
            this.comboBoxListThree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxListThree.FormattingEnabled = true;
            this.comboBoxListThree.Location = new System.Drawing.Point(839, 118);
            this.comboBoxListThree.Name = "comboBoxListThree";
            this.comboBoxListThree.Size = new System.Drawing.Size(236, 22);
            this.comboBoxListThree.TabIndex = 22;
            this.comboBoxListThree.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListThree_SelectedIndexChanged);
            // 
            // comboBoxSearchThree
            // 
            this.comboBoxSearchThree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSearchThree.FormattingEnabled = true;
            this.comboBoxSearchThree.Location = new System.Drawing.Point(839, 82);
            this.comboBoxSearchThree.Name = "comboBoxSearchThree";
            this.comboBoxSearchThree.Size = new System.Drawing.Size(236, 22);
            this.comboBoxSearchThree.TabIndex = 21;
            this.comboBoxSearchThree.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchThree_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 119);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Dato del campo";
            // 
            // comboBoxSearchTwo
            // 
            this.comboBoxSearchTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSearchTwo.FormattingEnabled = true;
            this.comboBoxSearchTwo.Location = new System.Drawing.Point(505, 82);
            this.comboBoxSearchTwo.Name = "comboBoxSearchTwo";
            this.comboBoxSearchTwo.Size = new System.Drawing.Size(236, 22);
            this.comboBoxSearchTwo.TabIndex = 19;
            this.comboBoxSearchTwo.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchTwo_SelectedIndexChanged);
            // 
            // comboBoxListTwo
            // 
            this.comboBoxListTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxListTwo.FormattingEnabled = true;
            this.comboBoxListTwo.Location = new System.Drawing.Point(505, 117);
            this.comboBoxListTwo.Name = "comboBoxListTwo";
            this.comboBoxListTwo.Size = new System.Drawing.Size(236, 22);
            this.comboBoxListTwo.TabIndex = 18;
            this.comboBoxListTwo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListTwo_SelectedIndexChanged);
            // 
            // comboBoxSearchOne
            // 
            this.comboBoxSearchOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSearchOne.FormattingEnabled = true;
            this.comboBoxSearchOne.Location = new System.Drawing.Point(171, 81);
            this.comboBoxSearchOne.Name = "comboBoxSearchOne";
            this.comboBoxSearchOne.Size = new System.Drawing.Size(236, 22);
            this.comboBoxSearchOne.TabIndex = 17;
            this.comboBoxSearchOne.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchOne_SelectedIndexChanged);
            // 
            // comboBoxListOne
            // 
            this.comboBoxListOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxListOne.FormattingEnabled = true;
            this.comboBoxListOne.Location = new System.Drawing.Point(171, 116);
            this.comboBoxListOne.Name = "comboBoxListOne";
            this.comboBoxListOne.Size = new System.Drawing.Size(236, 22);
            this.comboBoxListOne.TabIndex = 16;
            this.comboBoxListOne.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListOne_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 83);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Elegir campo \r\n";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(1071, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SearchIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1158, 591);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBoxListThree);
            this.Controls.Add(this.comboBoxSearchThree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSearchTwo);
            this.Controls.Add(this.comboBoxListTwo);
            this.Controls.Add(this.comboBoxSearchOne);
            this.Controls.Add(this.comboBoxListOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBoxSearchUser);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchIncome";
            this.Text = "Buscar Ingresos por Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearchUser;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox comboBoxListThree;
        private System.Windows.Forms.ComboBox comboBoxSearchThree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearchTwo;
        private System.Windows.Forms.ComboBox comboBoxListTwo;
        private System.Windows.Forms.ComboBox comboBoxSearchOne;
        private System.Windows.Forms.ComboBox comboBoxListOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
    }
}