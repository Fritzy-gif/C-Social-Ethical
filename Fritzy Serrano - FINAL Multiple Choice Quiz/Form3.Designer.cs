namespace Fritzy_Serrano___FINAL_Multiple_Choice_Quiz
{
    partial class Form3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.questionLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 207);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(3, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(637, 207);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.D, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.C, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.B, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.A, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 225);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(643, 213);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // D
            // 
            this.D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(324, 109);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(316, 101);
            this.D.TabIndex = 3;
            this.D.Tag = "4";
            this.D.Text = "button4";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // C
            // 
            this.C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(3, 109);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(315, 101);
            this.C.TabIndex = 2;
            this.C.Tag = "3";
            this.C.Text = "button3";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // B
            // 
            this.B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(324, 3);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(316, 100);
            this.B.TabIndex = 1;
            this.B.Tag = "2";
            this.B.Text = "button2";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // A
            // 
            this.A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(3, 3);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(315, 100);
            this.A.TabIndex = 0;
            this.A.Tag = "1";
            this.A.Text = "button1";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button A;
    }
}