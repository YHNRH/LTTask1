namespace LTTask1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fACTLOADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lTTask1DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lTTask1DBDataSet = new LTTask1.LTTask1DBDataSet();
            this.fACTLOADTableAdapter = new LTTask1.LTTask1DBDataSetTableAdapters.FACTLOADTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTLOADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTTask1DBDataSetBindingSource)).BeginInit();
    //        ((System.ComponentModel.ISupportInitialize)(this.lTTask1DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // fACTLOADBindingSource
            // 
            this.fACTLOADBindingSource.DataMember = "FACTLOAD";
            this.fACTLOADBindingSource.DataSource = this.lTTask1DBDataSetBindingSource;
            // 
            // lTTask1DBDataSetBindingSource
            // 
            this.lTTask1DBDataSetBindingSource.DataSource = this.lTTask1DBDataSet;
            this.lTTask1DBDataSetBindingSource.Position = 0;
            // 
            // lTTask1DBDataSet
            // 
            this.lTTask1DBDataSet.DataSetName = "LTTask1DBDataSet";
            this.lTTask1DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTLOADTableAdapter
            // 
            this.fACTLOADTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Получить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Задание";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTLOADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTTask1DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTTask1DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lTTask1DBDataSetBindingSource;
        private LTTask1DBDataSet lTTask1DBDataSet;
        private System.Windows.Forms.BindingSource fACTLOADBindingSource;
        private LTTask1.LTTask1DBDataSetTableAdapters.FACTLOADTableAdapter fACTLOADTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

