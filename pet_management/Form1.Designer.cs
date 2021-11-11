
namespace pet_management
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
            this.dgvDemo = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDemo
            // 
            this.dgvDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDemo.Location = new System.Drawing.Point(0, 60);
            this.dgvDemo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDemo.Name = "dgvDemo";
            this.dgvDemo.RowHeadersWidth = 51;
            this.dgvDemo.RowTemplate.Height = 24;
            this.dgvDemo.Size = new System.Drawing.Size(546, 292);
            this.dgvDemo.TabIndex = 0;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(35, 11);
            this.Insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(56, 31);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "button1";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 352);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.dgvDemo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDemo;
        private System.Windows.Forms.Button Insert;
    }
}

