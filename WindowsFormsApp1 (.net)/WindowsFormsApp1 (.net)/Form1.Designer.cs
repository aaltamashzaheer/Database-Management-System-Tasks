namespace WindowsFormsApp1__.net_
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
            this.view_database_button = new System.Windows.Forms.Button();
            this.id_input = new System.Windows.Forms.TextBox();
            this.contact_name_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_database_button = new System.Windows.Forms.Button();
            this.process_log = new System.Windows.Forms.TextBox();
            this.count_records_button = new System.Windows.Forms.Button();
            this.database_view = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.database_view)).BeginInit();
            this.SuspendLayout();
            // 
            // view_database_button
            // 
            this.view_database_button.Location = new System.Drawing.Point(310, 515);
            this.view_database_button.Name = "view_database_button";
            this.view_database_button.Size = new System.Drawing.Size(154, 32);
            this.view_database_button.TabIndex = 1;
            this.view_database_button.Text = "View Database";
            this.view_database_button.UseVisualStyleBackColor = true;
            this.view_database_button.Click += new System.EventHandler(this.view_database_button_Click);
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(150, 46);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(192, 20);
            this.id_input.TabIndex = 2;
            // 
            // contact_name_input
            // 
            this.contact_name_input.Location = new System.Drawing.Point(150, 101);
            this.contact_name_input.Name = "contact_name_input";
            this.contact_name_input.Size = new System.Drawing.Size(192, 20);
            this.contact_name_input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact Name";
            // 
            // update_database_button
            // 
            this.update_database_button.Location = new System.Drawing.Point(160, 146);
            this.update_database_button.Name = "update_database_button";
            this.update_database_button.Size = new System.Drawing.Size(132, 29);
            this.update_database_button.TabIndex = 6;
            this.update_database_button.Text = "Update Database";
            this.update_database_button.UseVisualStyleBackColor = true;
            this.update_database_button.Click += new System.EventHandler(this.update_database_button_Click);
            // 
            // process_log
            // 
            this.process_log.Location = new System.Drawing.Point(444, 23);
            this.process_log.Multiline = true;
            this.process_log.Name = "process_log";
            this.process_log.ReadOnly = true;
            this.process_log.Size = new System.Drawing.Size(333, 123);
            this.process_log.TabIndex = 7;
            // 
            // count_records_button
            // 
            this.count_records_button.Location = new System.Drawing.Point(527, 160);
            this.count_records_button.Name = "count_records_button";
            this.count_records_button.Size = new System.Drawing.Size(143, 26);
            this.count_records_button.TabIndex = 8;
            this.count_records_button.Text = "Count Records";
            this.count_records_button.UseVisualStyleBackColor = true;
            this.count_records_button.Click += new System.EventHandler(this.count_records_button_Click);
            // 
            // database_view
            // 
            this.database_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database_view.Location = new System.Drawing.Point(44, 335);
            this.database_view.Name = "database_view";
            this.database_view.Size = new System.Drawing.Size(708, 174);
            this.database_view.TabIndex = 9;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(164, 192);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(127, 26);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Delete Record";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(358, 262);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Orders Table";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(358, 295);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Employees Table";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(358, 227);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Customers Table";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.database_view);
            this.Controls.Add(this.count_records_button);
            this.Controls.Add(this.process_log);
            this.Controls.Add(this.update_database_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contact_name_input);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.view_database_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button view_database_button;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.TextBox contact_name_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_database_button;
        private System.Windows.Forms.TextBox process_log;
        private System.Windows.Forms.Button count_records_button;
        private System.Windows.Forms.DataGridView database_view;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

