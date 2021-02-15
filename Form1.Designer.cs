namespace Translator
{
    partial class Convertor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convertor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hexBox = new System.Windows.Forms.TextBox();
            this.decBox = new System.Windows.Forms.TextBox();
            this.octBox = new System.Windows.Forms.TextBox();
            this.binBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число в любом поле";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "HEX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "DEC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "OCT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(48, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "BIN";
            // 
            // hexBox
            // 
            this.hexBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.hexBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hexBox.Location = new System.Drawing.Point(125, 100);
            this.hexBox.Name = "hexBox";
            this.hexBox.Size = new System.Drawing.Size(340, 41);
            this.hexBox.TabIndex = 5;
            this.hexBox.TextChanged += new System.EventHandler(this.hexBox_TextChanged);
            // 
            // decBox
            // 
            this.decBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.decBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.decBox.Location = new System.Drawing.Point(125, 175);
            this.decBox.Name = "decBox";
            this.decBox.Size = new System.Drawing.Size(340, 41);
            this.decBox.TabIndex = 6;
            this.decBox.TextChanged += new System.EventHandler(this.decBox_TextChanged);
            // 
            // octBox
            // 
            this.octBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.octBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.octBox.Location = new System.Drawing.Point(125, 250);
            this.octBox.Name = "octBox";
            this.octBox.Size = new System.Drawing.Size(340, 41);
            this.octBox.TabIndex = 7;
            this.octBox.TextChanged += new System.EventHandler(this.octBox_TextChanged);
            // 
            // binBox
            // 
            this.binBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.binBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.binBox.Location = new System.Drawing.Point(125, 325);
            this.binBox.Name = "binBox";
            this.binBox.Size = new System.Drawing.Size(340, 41);
            this.binBox.TabIndex = 8;
            this.binBox.TextChanged += new System.EventHandler(this.binBox_TextChanged);
            // 
            // Convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 403);
            this.Controls.Add(this.binBox);
            this.Controls.Add(this.octBox);
            this.Controls.Add(this.decBox);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Convertor";
            this.Text = "Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hexBox;
        private System.Windows.Forms.TextBox decBox;
        private System.Windows.Forms.TextBox octBox;
        private System.Windows.Forms.TextBox binBox;
    }
}

