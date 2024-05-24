namespace Pool_Club_Project
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlTable6 = new Pool_Club_Project.ctrlTable();
            this.ctrlTable5 = new Pool_Club_Project.ctrlTable();
            this.ctrlTable4 = new Pool_Club_Project.ctrlTable();
            this.ctrlTable3 = new Pool_Club_Project.ctrlTable();
            this.ctrlTable2 = new Pool_Club_Project.ctrlTable();
            this.ctrlTable1 = new Pool_Club_Project.ctrlTable();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Pool_Club_Project.Properties.Resources.eradicate;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1314, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlTable6
            // 
            this.ctrlTable6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ctrlTable6.HourlyRate = 15F;
            this.ctrlTable6.Location = new System.Drawing.Point(924, 452);
            this.ctrlTable6.Name = "ctrlTable6";
            this.ctrlTable6.Size = new System.Drawing.Size(450, 396);
            this.ctrlTable6.TabIndex = 5;
            this.ctrlTable6.TablePlayer = "Ali";
            this.ctrlTable6.TableTitle = "Ali Table";
            this.ctrlTable6.OnTableComplate += new System.EventHandler<Pool_Club_Project.ctrlTable.TableComplateEventArgs>(this.ctrlTable6_OnTableComplate);
            // 
            // ctrlTable5
            // 
            this.ctrlTable5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ctrlTable5.HourlyRate = 15F;
            this.ctrlTable5.Location = new System.Drawing.Point(468, 452);
            this.ctrlTable5.Name = "ctrlTable5";
            this.ctrlTable5.Size = new System.Drawing.Size(450, 396);
            this.ctrlTable5.TabIndex = 4;
            this.ctrlTable5.TablePlayer = "Player 5";
            this.ctrlTable5.TableTitle = "Table 5";
            this.ctrlTable5.OnTableComplate += new System.EventHandler<Pool_Club_Project.ctrlTable.TableComplateEventArgs>(this.ctrlTable5_OnTableComplate);
            // 
            // ctrlTable4
            // 
            this.ctrlTable4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ctrlTable4.HourlyRate = 10F;
            this.ctrlTable4.Location = new System.Drawing.Point(12, 452);
            this.ctrlTable4.Name = "ctrlTable4";
            this.ctrlTable4.Size = new System.Drawing.Size(450, 396);
            this.ctrlTable4.TabIndex = 3;
            this.ctrlTable4.TablePlayer = "Player 4";
            this.ctrlTable4.TableTitle = "Table 4";
            this.ctrlTable4.OnTableComplate += new System.EventHandler<Pool_Club_Project.ctrlTable.TableComplateEventArgs>(this.ctrlTable4_OnTableComplate);
            // 
            // ctrlTable3
            // 
            this.ctrlTable3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ctrlTable3.HourlyRate = 10F;
            this.ctrlTable3.Location = new System.Drawing.Point(924, 60);
            this.ctrlTable3.Name = "ctrlTable3";
            this.ctrlTable3.Size = new System.Drawing.Size(450, 396);
            this.ctrlTable3.TabIndex = 2;
            this.ctrlTable3.TablePlayer = "Player 3";
            this.ctrlTable3.TableTitle = "Table 3";
            this.ctrlTable3.OnTableComplate += new System.EventHandler<Pool_Club_Project.ctrlTable.TableComplateEventArgs>(this.ctrlTable3_OnTableComplate);
            // 
            // ctrlTable2
            // 
            this.ctrlTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ctrlTable2.HourlyRate = 10F;
            this.ctrlTable2.Location = new System.Drawing.Point(468, 60);
            this.ctrlTable2.Name = "ctrlTable2";
            this.ctrlTable2.Size = new System.Drawing.Size(450, 396);
            this.ctrlTable2.TabIndex = 1;
            this.ctrlTable2.TablePlayer = "Player 2";
            this.ctrlTable2.TableTitle = "Table 2";
            this.ctrlTable2.OnTableComplate += new System.EventHandler<Pool_Club_Project.ctrlTable.TableComplateEventArgs>(this.ctrlTable2_OnTableComplate);
            // 
            // ctrlTable1
            // 
            this.ctrlTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ctrlTable1.HourlyRate = 10F;
            this.ctrlTable1.Location = new System.Drawing.Point(12, 60);
            this.ctrlTable1.Name = "ctrlTable1";
            this.ctrlTable1.Size = new System.Drawing.Size(450, 396);
            this.ctrlTable1.TabIndex = 0;
            this.ctrlTable1.TablePlayer = "Ömer MEMES";
            this.ctrlTable1.TableTitle = "Table 1";
            this.ctrlTable1.OnTableComplate += new System.EventHandler<Pool_Club_Project.ctrlTable.TableComplateEventArgs>(this.ctrlTable1_OnTableComplate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1388, 857);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlTable6);
            this.Controls.Add(this.ctrlTable5);
            this.Controls.Add(this.ctrlTable4);
            this.Controls.Add(this.ctrlTable3);
            this.Controls.Add(this.ctrlTable2);
            this.Controls.Add(this.ctrlTable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTable ctrlTable1;
        private ctrlTable ctrlTable2;
        private ctrlTable ctrlTable3;
        private ctrlTable ctrlTable4;
        private ctrlTable ctrlTable5;
        private ctrlTable ctrlTable6;
        private System.Windows.Forms.Button btnClose;
    }
}

