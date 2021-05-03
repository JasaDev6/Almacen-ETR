
namespace Almacen_ETR
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListOne = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchOne = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchTwo = new System.Windows.Forms.ComboBox();
            this.comboBoxListTwo = new System.Windows.Forms.ComboBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.comboBoxSearchThree = new System.Windows.Forms.ComboBox();
            this.comboBoxListThree = new System.Windows.Forms.ComboBox();
            this.btnExportIntoExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 136);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1134, 424);
            this.dataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 62);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elegir campo \r\n";
            // 
            // comboBoxListOne
            // 
            this.comboBoxListOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxListOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListOne.FormattingEnabled = true;
            this.comboBoxListOne.Location = new System.Drawing.Point(176, 97);
            this.comboBoxListOne.Name = "comboBoxListOne";
            this.comboBoxListOne.Size = new System.Drawing.Size(302, 21);
            this.comboBoxListOne.TabIndex = 4;
            this.comboBoxListOne.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListOne_SelectedIndexChanged);
            // 
            // comboBoxSearchOne
            // 
            this.comboBoxSearchOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSearchOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchOne.FormattingEnabled = true;
            this.comboBoxSearchOne.Location = new System.Drawing.Point(176, 63);
            this.comboBoxSearchOne.Name = "comboBoxSearchOne";
            this.comboBoxSearchOne.Size = new System.Drawing.Size(302, 21);
            this.comboBoxSearchOne.TabIndex = 5;
            this.comboBoxSearchOne.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchOne_SelectedIndexChanged);
            // 
            // comboBoxSearchTwo
            // 
            this.comboBoxSearchTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSearchTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchTwo.FormattingEnabled = true;
            this.comboBoxSearchTwo.Location = new System.Drawing.Point(510, 63);
            this.comboBoxSearchTwo.Name = "comboBoxSearchTwo";
            this.comboBoxSearchTwo.Size = new System.Drawing.Size(302, 21);
            this.comboBoxSearchTwo.TabIndex = 9;
            this.comboBoxSearchTwo.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchTwo_SelectedIndexChanged);
            // 
            // comboBoxListTwo
            // 
            this.comboBoxListTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxListTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListTwo.FormattingEnabled = true;
            this.comboBoxListTwo.Location = new System.Drawing.Point(510, 98);
            this.comboBoxListTwo.Name = "comboBoxListTwo";
            this.comboBoxListTwo.Size = new System.Drawing.Size(302, 21);
            this.comboBoxListTwo.TabIndex = 8;
            this.comboBoxListTwo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListTwo_SelectedIndexChanged);
            // 
            // btnOutput
            // 
            this.btnOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutput.AutoSize = true;
            this.btnOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.Location = new System.Drawing.Point(962, 566);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(184, 30);
            this.btnOutput.TabIndex = 10;
            this.btnOutput.Text = "Registrar salida";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 96);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dato del campo";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(435, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(34, 17);
            this.title.TabIndex = 12;
            this.title.Text = "title";
            // 
            // comboBoxSearchThree
            // 
            this.comboBoxSearchThree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSearchThree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchThree.FormattingEnabled = true;
            this.comboBoxSearchThree.Location = new System.Drawing.Point(844, 62);
            this.comboBoxSearchThree.Name = "comboBoxSearchThree";
            this.comboBoxSearchThree.Size = new System.Drawing.Size(302, 21);
            this.comboBoxSearchThree.TabIndex = 13;
            this.comboBoxSearchThree.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchThree_SelectedIndexChanged);
            // 
            // comboBoxListThree
            // 
            this.comboBoxListThree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxListThree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListThree.FormattingEnabled = true;
            this.comboBoxListThree.Location = new System.Drawing.Point(844, 99);
            this.comboBoxListThree.Name = "comboBoxListThree";
            this.comboBoxListThree.Size = new System.Drawing.Size(302, 21);
            this.comboBoxListThree.TabIndex = 14;
            this.comboBoxListThree.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListThree_SelectedIndexChanged);
            // 
            // btnExportIntoExcel
            // 
            this.btnExportIntoExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportIntoExcel.AutoSize = true;
            this.btnExportIntoExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportIntoExcel.Location = new System.Drawing.Point(772, 566);
            this.btnExportIntoExcel.Name = "btnExportIntoExcel";
            this.btnExportIntoExcel.Size = new System.Drawing.Size(184, 30);
            this.btnExportIntoExcel.TabIndex = 16;
            this.btnExportIntoExcel.Text = "Exportar a Excel";
            this.btnExportIntoExcel.UseVisualStyleBackColor = true;
            this.btnExportIntoExcel.Click += new System.EventHandler(this.btnExportIntoExcel_Click);
            // 
            // SearchIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1158, 608);
            this.Controls.Add(this.btnExportIntoExcel);
            this.Controls.Add(this.comboBoxListThree);
            this.Controls.Add(this.comboBoxSearchThree);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.comboBoxSearchTwo);
            this.Controls.Add(this.comboBoxListTwo);
            this.Controls.Add(this.comboBoxSearchOne);
            this.Controls.Add(this.comboBoxListOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchIncome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Buscar Ingresados";
            this.Load += new System.EventHandler(this.SearchIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListOne;
        private System.Windows.Forms.ComboBox comboBoxSearchOne;
        private System.Windows.Forms.ComboBox comboBoxSearchTwo;
        private System.Windows.Forms.ComboBox comboBoxListTwo;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox comboBoxSearchThree;
        private System.Windows.Forms.ComboBox comboBoxListThree;
        private System.Windows.Forms.Button btnExportIntoExcel;
    }
}