
namespace QLQuanCafe.User_Controls
{
    partial class CT_HoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Luoi_HD = new System.Windows.Forms.DataGridView();
            this.SoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.txtTienNhan = new System.Windows.Forms.TextBox();
            this.txtTienTra = new System.Windows.Forms.TextBox();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hóa đơn: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhân viên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiền nhận: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiền trả:";
            // 
            // Luoi_HD
            // 
            this.Luoi_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_HD.BackgroundColor = System.Drawing.Color.White;
            this.Luoi_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoMon,
            this.TenMon,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.Luoi_HD.Location = new System.Drawing.Point(344, 99);
            this.Luoi_HD.Name = "Luoi_HD";
            this.Luoi_HD.Size = new System.Drawing.Size(422, 207);
            this.Luoi_HD.TabIndex = 7;
            // 
            // SoMon
            // 
            this.SoMon.HeaderText = "#";
            this.SoMon.Name = "SoMon";
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.Name = "TenMon";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Danh sách món";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(150, 75);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(55, 20);
            this.lbMaHD.TabIndex = 9;
            this.lbMaHD.Text = "MaHD";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(150, 128);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(53, 20);
            this.lbMaNV.TabIndex = 10;
            this.lbMaNV.Text = "MaNV";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(150, 181);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(75, 20);
            this.lbTongTien.TabIndex = 11;
            this.lbTongTien.Text = "TongTien";
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Location = new System.Drawing.Point(153, 227);
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.Size = new System.Drawing.Size(157, 26);
            this.txtTienNhan.TabIndex = 12;
            // 
            // txtTienTra
            // 
            this.txtTienTra.Location = new System.Drawing.Point(154, 283);
            this.txtTienTra.Name = "txtTienTra";
            this.txtTienTra.Size = new System.Drawing.Size(156, 26);
            this.txtTienTra.TabIndex = 13;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(670, 334);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(96, 28);
            this.btnInHoaDon.TabIndex = 14;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(537, 334);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(109, 28);
            this.btnLuuHoaDon.TabIndex = 15;
            this.btnLuuHoaDon.Text = "Lưu hóa đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // CT_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLuuHoaDon);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.txtTienTra);
            this.Controls.Add(this.txtTienNhan);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Luoi_HD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CT_HoaDon";
            this.Size = new System.Drawing.Size(803, 397);
            this.Load += new System.EventHandler(this.CT_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_HD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Luoi_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.TextBox txtTienNhan;
        private System.Windows.Forms.TextBox txtTienTra;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnLuuHoaDon;
    }
}
