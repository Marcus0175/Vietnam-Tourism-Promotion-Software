namespace App.Utilities
{
    internal static class TinhThanhHienTai
    {
        public static TinhThanh tinhThanhHienTai {  get; set; }

        static TinhThanhHienTai()
        {
            if (tinhThanhHienTai == null)
            {
                tinhThanhHienTai = new TinhThanh();
            }
        }
    }
}
