
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FastReport;
using FastReport.Export.Pdf;

public static class ReportHelper
{
    // 1. MỞ THIẾT KẾ BÁO CÁO
    public static void ThietKe(
        DataTable dt,
        string tenBaoCao)
    {
        try
        {
            using var report = new Report();

            string path = LayDuongDan(tenBaoCao);

            if (File.Exists(path))
                report.Load(path);

            report.RegisterData(dt, "DuLieu");
            report.GetDataSource("DuLieu").Enabled = true;

            report.Design();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi thiết kế: " + ex.Message);
        }
    }

    // 2. XEM TRƯỚC BÁO CÁO
    public static void XemBaoCao(
        DataTable dt,
        string tenBaoCao)
    {
        try
        {
            using var report = TaoBaoCao(dt, tenBaoCao);
            report.ShowPrepared();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi xem báo cáo: " + ex.Message);
        }
    }

    // 3. XUẤT FILE PDF
    public static void XuatPDF(
        DataTable dt,
        string tenBaoCao)
    {
        try
        {
            using var report = TaoBaoCao(dt, tenBaoCao);

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                FileName = Path.GetFileNameWithoutExtension(
                    tenBaoCao) + ".pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            using var pdf = new PDFExport();
            report.Export(pdf, sfd.FileName);

            MessageBox.Show("Xuất PDF thành công!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi xuất PDF: " + ex.Message);
        }
    }

    // 4. TẠO BÁO CÁO TỪ MẪU
    private static Report TaoBaoCao(
        DataTable dt,
        string tenBaoCao)
    {
        string path = LayDuongDan(tenBaoCao);

        if (!File.Exists(path))
            throw new FileNotFoundException(
                "Chưa có mẫu báo cáo: " + path);

        var report = new Report();

        try
        {
            report.Load(path);
            report.RegisterData(dt, "DuLieu");
            report.GetDataSource("DuLieu").Enabled = true;
            report.Prepare();

            return report;
        }
        catch
        {
            report.Dispose();
            throw;
        }
    }

    // 5. ĐƯỜNG DẪN MẪU BÁO CÁO
    private static string LayDuongDan(string tenBaoCao)
    {
        string folder = Path.Combine(
            AppContext.BaseDirectory, "Reports");

        Directory.CreateDirectory(folder);

        string fileName = Path.GetFileName(tenBaoCao);

        if (!fileName.EndsWith(
            ".frx", StringComparison.OrdinalIgnoreCase))
        {
            fileName += ".frx";
        }

        return Path.Combine(folder, fileName);
    }
}
