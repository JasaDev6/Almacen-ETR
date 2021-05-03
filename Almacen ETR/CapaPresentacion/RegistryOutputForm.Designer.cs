
namespace Almacen_ETR.CapaPresentacion
{
    partial class RegistryOutputForm
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.btnEditRegisterOutput = new System.Windows.Forms.Button();
            this.btnDeleteRegisterOutput = new System.Windows.Forms.Button();
            this.comboBoxListThree = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchThree = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearchTwo = new System.Windows.Forms.ComboBox();
            this.comboBoxListTwo = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchOne = new System.Windows.Forms.ComboBox();
            this.comboBoxListOne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 145);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1134, 370);
            this.dataGridView.TabIndex = 0;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(512, 30);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(33, 16);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "title";
            // 
            // btnEditRegisterOutput
            // 
            this.btnEditRegisterOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRegisterOutput.Location = new System.Drawing.Point(798, 521);
            this.btnEditRegisterOutput.Name = "btnEditRegisterOutput";
            this.btnEditRegisterOutput.Size = new System.Drawing.Size(171, 30);
            this.btnEditRegisterOutput.TabIndex = 16;
            this.btnEditRegisterOutput.Text = "Editar";
            this.btnEditRegisterOutput.UseVisualStyleBackColor = true;
            this.btnEditRegisterOutput.Click += new System.EventHandler(this.btnEditRegisterOutput_Click);
            // 
            // btnDeleteRegisterOutput
            // 
            this.btnDeleteRegisterOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRegisterOutput.Location = new System.Drawing.Point(975, 521);
            this.btnDeleteRegisterOutput.Name = "btnDeleteRegisterOutput";
            this.btnDeleteRegisterOutput.Size = new System.Drawing.Size(171, 30);
            this.btnDeleteRegisterOutput.TabIndex = 15;
            this.btnDeleteRegisterOutput.Text = "Eliminar";
            this.btnDeleteRegisterOutput.UseVisualStyleBackColor = true;
            this.btnDeleteRegisterOutput.Click += new System.EventHandler(this.btnDeleteRegisterOutput_Click);
            // 
            // comboBoxListThree
            // 
            this.comboBoxListThree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListThree.FormattingEnabled = true;
            this.comboBoxListThree.Location = new System.Drawing.Point(844, 109);
            this.comboBoxListThree.Name = "comboBoxListThree";
            this.comboBoxListThree.Size = new System.Drawing.Size(302, 21);
            this.comboBoxListThree.TabIndex = 24;
            this.comboBoxListThree.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListThree_SelectedIndexChanged);
            // 
            // comboBoxSearchThree
            // 
            this.comboBoxSearchThree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchThree.FormattingEnabled = true;
            this.comboBoxSearchThree.Location = new System.Drawing.Point(844, 73);
            this.comboBoxSearchThree.Name = "comboBoxSearchThree";
            this.comboBoxSearchThree.Size = new System.Drawing.Size(302, 21);
            this.comboBoxSearchThree.TabIndex = 23;
            this.comboBoxSearchThree.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchThree_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dato del campo";
            // 
            // comboBoxSearchTwo
            // 
            this.comboBoxSearchTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchTwo.FormattingEnabled = true;
            this.comboBoxSearchTwo.Location = new System.Drawing.Point(515, 73);
            this.comboBoxSearchTwo.Name = "comboBoxSearchTwo";
            this.comboBoxSearchTwo.Size = new System.Drawing.Size(302, 21);
            this.comboBoxSearchTwo.TabIndex = 21;
            this.comboBoxSearchTwo.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchTwo_SelectedIndexChanged);
            // 
            // comboBoxListTwo
            // 
            this.comboBoxListTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListTwo.FormattingEnabled = true;
            this.comboBoxListTwo.Location = new System.Drawing.Point(515, 109);
            this.comboBoxListTwo.Name = "comboBoxListTwo";
            this.comboBoxListTwo.Size = new System.Drawing.Size(302, 21);
            this.comboBoxListTwo.TabIndex = 20;
            this.comboBoxListTwo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListTwo_SelectedIndexChanged);
            // 
            // comboBoxSearchOne
            // 
            this.comboBoxSearchOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchOne.FormattingEnabled = true;
            this.comboBoxSearchOne.Location = new System.Drawing.Point(182, 73);
            this.comboBoxSearchOne.Name = "comboBoxSearchOne";
            this.comboBoxSearchOne.Size = new System.Drawing.Size(302, 21);
            this.comboBoxSearchOne.TabIndex = 19;
            this.comboBoxSearchOne.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchOne_SelectedIndexChanged);
            // 
            // comboBoxListOne
            // 
            this.comboBoxListOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListOne.FormattingEnabled = true;
            this.comboBoxListOne.Location = new System.Drawing.Point(182, 109);
            this.comboBoxListOne.Name = "comboBoxListOne";
            this.comboBoxListOne.Size = new System.Drawing.Size(302, 21);
            this.comboBoxListOne.TabIndex = 18;
            this.comboBoxListOne.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListOne_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 72);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Elegir campo \r\n";
            // 
            // RegistryOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1158, 557);
            this.Controls.Add(this.comboBoxListThree);
            this.Controls.Add(this.comboBoxSearchThree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSearchTwo);
            this.Controls.Add(this.comboBoxListTwo);
            this.Controls.Add(this.comboBoxSearchOne);
            this.Controls.Add(this.comboBoxListOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditRegisterOutput);
            this.Controls.Add(this.btnDeleteRegisterOutput);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistryOutputForm";
            this.Text = "Registro de salidas ";
            this.Load += new System.EventHandler(this.RegistryOutputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button btnEditRegisterOutput;
        private System.Windows.Forms.Button btnDeleteRegisterOutput;
        private System.Windows.Forms.ComboBox comboBoxListThree;
        private System.Windows.Forms.ComboBox comboBoxSearchThree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearchTwo;
        private System.Windows.Forms.ComboBox comboBoxListTwo;
        private System.Windows.Forms.ComboBox comboBoxSearchOne;
        private System.Windows.Forms.ComboBox comboBoxListOne;
        private System.Windows.Forms.Label label1;
    }
}