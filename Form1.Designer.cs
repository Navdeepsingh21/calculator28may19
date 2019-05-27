namespace calculator28may19
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
            this.lbl_firstnumber = new System.Windows.Forms.Label();
            this.lbl_secondnumber = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_firstnumber = new System.Windows.Forms.TextBox();
            this.txt_secondnumber = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_firstnumber
            // 
            this.lbl_firstnumber.AutoSize = true;
            this.lbl_firstnumber.Location = new System.Drawing.Point(288, 52);
            this.lbl_firstnumber.Name = "lbl_firstnumber";
            this.lbl_firstnumber.Size = new System.Drawing.Size(58, 13);
            this.lbl_firstnumber.TabIndex = 0;
            this.lbl_firstnumber.Text = "firstnumber";
            // 
            // lbl_secondnumber
            // 
            this.lbl_secondnumber.AutoSize = true;
            this.lbl_secondnumber.Location = new System.Drawing.Point(288, 89);
            this.lbl_secondnumber.Name = "lbl_secondnumber";
            this.lbl_secondnumber.Size = new System.Drawing.Size(77, 13);
            this.lbl_secondnumber.TabIndex = 1;
            this.lbl_secondnumber.Text = "secondnumber";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(290, 125);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(32, 13);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "result";
            // 
            // txt_firstnumber
            // 
            this.txt_firstnumber.Location = new System.Drawing.Point(370, 52);
            this.txt_firstnumber.Name = "txt_firstnumber";
            this.txt_firstnumber.Size = new System.Drawing.Size(100, 20);
            this.txt_firstnumber.TabIndex = 3;
            // 
            // txt_secondnumber
            // 
            this.txt_secondnumber.Location = new System.Drawing.Point(370, 89);
            this.txt_secondnumber.Name = "txt_secondnumber";
            this.txt_secondnumber.Size = new System.Drawing.Size(100, 20);
            this.txt_secondnumber.TabIndex = 4;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(370, 122);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(215, 178);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(321, 178);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "sub";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.Btn_sub_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(420, 178);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(75, 23);
            this.btn_mult.TabIndex = 8;
            this.btn_mult.Text = "mult";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.Btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(520, 178);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 9;
            this.btn_div.Text = "div";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.Btn_div_Click);
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(541, 125);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 10;
            this.btn_click.Text = "clear";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.Btn_click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_secondnumber);
            this.Controls.Add(this.txt_firstnumber);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_secondnumber);
            this.Controls.Add(this.lbl_firstnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstnumber;
        private System.Windows.Forms.Label lbl_secondnumber;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt_firstnumber;
        private System.Windows.Forms.TextBox txt_secondnumber;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_click;
    }
}

