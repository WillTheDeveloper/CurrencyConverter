namespace CurrencyCalculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.currenciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencies = new CurrencyCalculator.currencies();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.darkmode = new System.Windows.Forms.CheckBox();
            this.plus1 = new System.Windows.Forms.Button();
            this.minus1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.clearBtn = new System.Windows.Forms.Button();
            this.convertRateFrom = new System.Windows.Forms.Label();
            this.convertRateTo = new System.Windows.Forms.Label();
            this.toRate = new System.Windows.Forms.Label();
            this.fromRate = new System.Windows.Forms.Label();
            this.usdRate = new System.Windows.Forms.Label();
            this.gbpRate = new System.Windows.Forms.Label();
            this.gbplabel = new System.Windows.Forms.Label();
            this.usdlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // currenciesBindingSource1
            // 
            this.currenciesBindingSource1.DataMember = "currencies";
            this.currenciesBindingSource1.DataSource = this.currenciesBindingSource;
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataSource = this.currencies;
            this.currenciesBindingSource.Position = 0;
            // 
            // currencies
            // 
            this.currencies.DataSetName = "currencies";
            this.currencies.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(439, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(289, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Converting from:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Converting to:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(38, 122);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 61);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(439, 122);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(285, 61);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // darkmode
            // 
            this.darkmode.AutoSize = true;
            this.darkmode.Location = new System.Drawing.Point(709, 9);
            this.darkmode.Name = "darkmode";
            this.darkmode.Size = new System.Drawing.Size(79, 17);
            this.darkmode.TabIndex = 7;
            this.darkmode.Text = "Dark Mode";
            this.darkmode.UseVisualStyleBackColor = true;
            this.darkmode.CheckedChanged += new System.EventHandler(this.darkmode_CheckedChanged);
            // 
            // plus1
            // 
            this.plus1.Location = new System.Drawing.Point(38, 189);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(24, 23);
            this.plus1.TabIndex = 8;
            this.plus1.Text = "+";
            this.plus1.UseVisualStyleBackColor = true;
            this.plus1.Click += new System.EventHandler(this.plus1_Click);
            // 
            // minus1
            // 
            this.minus1.Location = new System.Drawing.Point(68, 189);
            this.minus1.Name = "minus1";
            this.minus1.Size = new System.Drawing.Size(24, 23);
            this.minus1.TabIndex = 9;
            this.minus1.Text = "-";
            this.minus1.UseVisualStyleBackColor = true;
            this.minus1.Click += new System.EventHandler(this.minus1_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(709, 32);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // convertRateFrom
            // 
            this.convertRateFrom.AutoSize = true;
            this.convertRateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertRateFrom.Location = new System.Drawing.Point(41, 246);
            this.convertRateFrom.Name = "convertRateFrom";
            this.convertRateFrom.Size = new System.Drawing.Size(158, 20);
            this.convertRateFrom.TabIndex = 11;
            this.convertRateFrom.Text = "Convert Rate (From):";
            // 
            // convertRateTo
            // 
            this.convertRateTo.AutoSize = true;
            this.convertRateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertRateTo.Location = new System.Drawing.Point(41, 266);
            this.convertRateTo.Name = "convertRateTo";
            this.convertRateTo.Size = new System.Drawing.Size(139, 20);
            this.convertRateTo.TabIndex = 12;
            this.convertRateTo.Text = "Convert Rate (To):";
            // 
            // toRate
            // 
            this.toRate.AutoSize = true;
            this.toRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRate.Location = new System.Drawing.Point(186, 266);
            this.toRate.Name = "toRate";
            this.toRate.Size = new System.Drawing.Size(58, 20);
            this.toRate.TabIndex = 13;
            this.toRate.Text = "toRate";
            this.toRate.Click += new System.EventHandler(this.toRate_Click);
            // 
            // fromRate
            // 
            this.fromRate.AutoSize = true;
            this.fromRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromRate.Location = new System.Drawing.Point(205, 246);
            this.fromRate.Name = "fromRate";
            this.fromRate.Size = new System.Drawing.Size(76, 20);
            this.fromRate.TabIndex = 14;
            this.fromRate.Text = "fromRate";
            this.fromRate.Click += new System.EventHandler(this.fromRate_Click);
            // 
            // usdRate
            // 
            this.usdRate.AutoSize = true;
            this.usdRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdRate.Location = new System.Drawing.Point(398, 246);
            this.usdRate.Name = "usdRate";
            this.usdRate.Size = new System.Drawing.Size(87, 20);
            this.usdRate.TabIndex = 15;
            this.usdRate.Text = "USD Rate:";
            // 
            // gbpRate
            // 
            this.gbpRate.AutoSize = true;
            this.gbpRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpRate.Location = new System.Drawing.Point(399, 266);
            this.gbpRate.Name = "gbpRate";
            this.gbpRate.Size = new System.Drawing.Size(86, 20);
            this.gbpRate.TabIndex = 16;
            this.gbpRate.Text = "GBP Rate:";
            // 
            // gbplabel
            // 
            this.gbplabel.AutoSize = true;
            this.gbplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbplabel.Location = new System.Drawing.Point(491, 266);
            this.gbplabel.Name = "gbplabel";
            this.gbplabel.Size = new System.Drawing.Size(36, 20);
            this.gbplabel.TabIndex = 17;
            this.gbplabel.Text = "gbp";
            // 
            // usdlabel
            // 
            this.usdlabel.AutoSize = true;
            this.usdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdlabel.Location = new System.Drawing.Point(491, 246);
            this.usdlabel.Name = "usdlabel";
            this.usdlabel.Size = new System.Drawing.Size(35, 20);
            this.usdlabel.TabIndex = 18;
            this.usdlabel.Text = "usd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usdlabel);
            this.Controls.Add(this.gbplabel);
            this.Controls.Add(this.gbpRate);
            this.Controls.Add(this.usdRate);
            this.Controls.Add(this.fromRate);
            this.Controls.Add(this.toRate);
            this.Controls.Add(this.convertRateTo);
            this.Controls.Add(this.convertRateFrom);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.minus1);
            this.Controls.Add(this.plus1);
            this.Controls.Add(this.darkmode);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox darkmode;
        private System.Windows.Forms.BindingSource currenciesBindingSource1;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        public currencies currencies;
        private System.Windows.Forms.Button plus1;
        private System.Windows.Forms.Button minus1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label convertRateFrom;
        private System.Windows.Forms.Label convertRateTo;
        private System.Windows.Forms.Label toRate;
        private System.Windows.Forms.Label fromRate;
        private System.Windows.Forms.Label usdRate;
        private System.Windows.Forms.Label gbpRate;
        private System.Windows.Forms.Label gbplabel;
        private System.Windows.Forms.Label usdlabel;
    }
}

