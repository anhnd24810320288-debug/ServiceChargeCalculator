namespace ServiceChargeCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTongTien;

        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiamGia;

        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnLamMoi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();

            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();

            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.Name = "Form1";
            this.Text = "Service Charge Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Label đơn giá
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(40, 35);
            this.lblDonGia.Text = "Đơn giá dịch vụ:";

            // TextBox đơn giá
            this.txtDonGia.Location = new System.Drawing.Point(180, 32);
            this.txtDonGia.Size = new System.Drawing.Size(200, 23);
            this.txtDonGia.TabIndex = 0;

            // Label số lượng
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(40, 80);
            this.lblSoLuong.Text = "Số lượng khách:";

            // TextBox số lượng
            this.txtSoLuong.Location = new System.Drawing.Point(180, 77);
            this.txtSoLuong.Size = new System.Drawing.Size(200, 23);
            this.txtSoLuong.TabIndex = 1;

            // Label giảm giá
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(40, 125);
            this.lblGiamGia.Text = "Giảm giá (%):";

            // TextBox giảm giá
            this.txtGiamGia.Location = new System.Drawing.Point(180, 122);
            this.txtGiamGia.Size = new System.Drawing.Size(200, 23);
            this.txtGiamGia.TabIndex = 2;

            // Label tổng tiền
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTongTien.Location = new System.Drawing.Point(40, 170);
            this.lblTongTien.Text = "Tổng tiền: 0 VNĐ";

            // Button tính tiền
            this.btnTinhTien.Location = new System.Drawing.Point(80, 220);
            this.btnTinhTien.Size = new System.Drawing.Size(120, 35);
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);

            // Button làm mới
            this.btnLamMoi.Location = new System.Drawing.Point(220, 220);
            this.btnLamMoi.Size = new System.Drawing.Size(120, 35);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // Thêm control vào Form
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtDonGia);

            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtSoLuong);

            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.txtGiamGia);

            this.Controls.Add(this.lblTongTien);

            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnLamMoi);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}