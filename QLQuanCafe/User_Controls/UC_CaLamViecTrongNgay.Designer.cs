
namespace QLQuanCafe.User_Controls
{
   partial class UC_CaLamViecTrongNgay
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
         this.lbGioKT = new System.Windows.Forms.Label();
         this.lbGioBD = new System.Windows.Forms.Label();
         this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
         this.lbNgay = new System.Windows.Forms.Label();
         this.lbTenNV = new System.Windows.Forms.Label();
         this.lbQLCa = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lbGioKT
         // 
         this.lbGioKT.AutoSize = true;
         this.lbGioKT.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbGioKT.Location = new System.Drawing.Point(536, 164);
         this.lbGioKT.Name = "lbGioKT";
         this.lbGioKT.Size = new System.Drawing.Size(100, 21);
         this.lbGioKT.TabIndex = 11;
         this.lbGioKT.Text = "Giờ kết thúc";
         // 
         // lbGioBD
         // 
         this.lbGioBD.AutoSize = true;
         this.lbGioBD.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbGioBD.Location = new System.Drawing.Point(339, 164);
         this.lbGioBD.Name = "lbGioBD";
         this.lbGioBD.Size = new System.Drawing.Size(96, 21);
         this.lbGioBD.TabIndex = 10;
         this.lbGioBD.Text = "Giờ bắt đầu";
         // 
         // dateTimePicker1
         // 
         this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dateTimePicker1.Location = new System.Drawing.Point(160, 117);
         this.dateTimePicker1.Name = "dateTimePicker1";
         this.dateTimePicker1.Size = new System.Drawing.Size(262, 25);
         this.dateTimePicker1.TabIndex = 9;
         // 
         // lbNgay
         // 
         this.lbNgay.AutoSize = true;
         this.lbNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbNgay.Location = new System.Drawing.Point(47, 117);
         this.lbNgay.Name = "lbNgay";
         this.lbNgay.Size = new System.Drawing.Size(58, 25);
         this.lbNgay.TabIndex = 8;
         this.lbNgay.Text = "Ngày";
         // 
         // lbTenNV
         // 
         this.lbTenNV.AutoSize = true;
         this.lbTenNV.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTenNV.Location = new System.Drawing.Point(83, 164);
         this.lbTenNV.Name = "lbTenNV";
         this.lbTenNV.Size = new System.Drawing.Size(116, 21);
         this.lbTenNV.TabIndex = 7;
         this.lbTenNV.Text = "Tên nhân viên";
         // 
         // lbQLCa
         // 
         this.lbQLCa.AutoSize = true;
         this.lbQLCa.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbQLCa.Location = new System.Drawing.Point(41, 36);
         this.lbQLCa.Name = "lbQLCa";
         this.lbQLCa.Size = new System.Drawing.Size(581, 65);
         this.lbQLCa.TabIndex = 6;
         this.lbQLCa.Text = "Ca Làm Việc Trong Ngày";
         // 
         // UC_CaLamViecTrongNgay
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.lbGioKT);
         this.Controls.Add(this.lbGioBD);
         this.Controls.Add(this.dateTimePicker1);
         this.Controls.Add(this.lbNgay);
         this.Controls.Add(this.lbTenNV);
         this.Controls.Add(this.lbQLCa);
         this.Name = "UC_CaLamViecTrongNgay";
         this.Size = new System.Drawing.Size(731, 510);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lbGioKT;
      private System.Windows.Forms.Label lbGioBD;
      private System.Windows.Forms.DateTimePicker dateTimePicker1;
      private System.Windows.Forms.Label lbNgay;
      private System.Windows.Forms.Label lbTenNV;
      private System.Windows.Forms.Label lbQLCa;
   }
}
