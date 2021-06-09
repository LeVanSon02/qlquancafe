
namespace QLQuanCafe.User_Controls
{
   partial class UC_TheMonAnNho
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.lbTenMon = new System.Windows.Forms.Label();
         this.lbGia = new System.Windows.Forms.Label();
         this.btnSua = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.White;
         this.pictureBox1.Location = new System.Drawing.Point(9, 9);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(100, 100);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // lbTenMon
         // 
         this.lbTenMon.AutoSize = true;
         this.lbTenMon.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTenMon.Location = new System.Drawing.Point(113, 27);
         this.lbTenMon.Name = "lbTenMon";
         this.lbTenMon.Size = new System.Drawing.Size(85, 25);
         this.lbTenMon.TabIndex = 1;
         this.lbTenMon.Text = "Tên món";
         // 
         // lbGia
         // 
         this.lbGia.AutoSize = true;
         this.lbGia.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbGia.Location = new System.Drawing.Point(113, 65);
         this.lbGia.Name = "lbGia";
         this.lbGia.Size = new System.Drawing.Size(61, 25);
         this.lbGia.TabIndex = 2;
         this.lbGia.Text = "$0.00";
         // 
         // btnSua
         // 
         this.btnSua.BackColor = System.Drawing.Color.Black;
         this.btnSua.FlatAppearance.BorderSize = 0;
         this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSua.ForeColor = System.Drawing.Color.White;
         this.btnSua.Location = new System.Drawing.Point(217, 82);
         this.btnSua.Name = "btnSua";
         this.btnSua.Size = new System.Drawing.Size(75, 27);
         this.btnSua.TabIndex = 3;
         this.btnSua.Text = "Sửa";
         this.btnSua.UseVisualStyleBackColor = false;
         // 
         // UC_TheMonAnNho
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.btnSua);
         this.Controls.Add(this.lbGia);
         this.Controls.Add(this.lbTenMon);
         this.Controls.Add(this.pictureBox1);
         this.Name = "UC_TheMonAnNho";
         this.Size = new System.Drawing.Size(302, 119);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label lbTenMon;
      private System.Windows.Forms.Label lbGia;
      private System.Windows.Forms.Button btnSua;
   }
}
