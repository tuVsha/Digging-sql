namespace TestWork23
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
            this.txtNameFirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJurAdr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostAdr = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dtgResult = new System.Windows.Forms.DataGridView();
            this.dtgByFirm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgByFirm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameFirm
            // 
            this.txtNameFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameFirm.Location = new System.Drawing.Point(211, 12);
            this.txtNameFirm.MaxLength = 120;
            this.txtNameFirm.Name = "txtNameFirm";
            this.txtNameFirm.Size = new System.Drawing.Size(399, 29);
            this.txtNameFirm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название компании";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Юридический адрес";
            // 
            // txtJurAdr
            // 
            this.txtJurAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtJurAdr.Location = new System.Drawing.Point(211, 47);
            this.txtJurAdr.MaxLength = 20;
            this.txtJurAdr.Name = "txtJurAdr";
            this.txtJurAdr.Size = new System.Drawing.Size(399, 29);
            this.txtJurAdr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Почтовый адрес";
            // 
            // txtPostAdr
            // 
            this.txtPostAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPostAdr.Location = new System.Drawing.Point(211, 82);
            this.txtPostAdr.MaxLength = 20;
            this.txtPostAdr.Name = "txtPostAdr";
            this.txtPostAdr.Size = new System.Drawing.Size(399, 29);
            this.txtPostAdr.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(644, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(178, 99);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dtgResult
            // 
            this.dtgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResult.Location = new System.Drawing.Point(12, 145);
            this.dtgResult.Name = "dtgResult";
            this.dtgResult.Size = new System.Drawing.Size(810, 457);
            this.dtgResult.TabIndex = 7;
            this.dtgResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResult_CellContentClick);
            // 
            // dtgByFirm
            // 
            this.dtgByFirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgByFirm.Location = new System.Drawing.Point(12, 639);
            this.dtgByFirm.Name = "dtgByFirm";
            this.dtgByFirm.Size = new System.Drawing.Size(810, 468);
            this.dtgByFirm.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 1119);
            this.Controls.Add(this.dtgByFirm);
            this.Controls.Add(this.dtgResult);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPostAdr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJurAdr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameFirm);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgByFirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameFirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJurAdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostAdr;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dtgResult;
        private System.Windows.Forms.DataGridView dtgByFirm;
    }
}

