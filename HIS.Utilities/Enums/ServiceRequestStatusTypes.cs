namespace HIS.Utilities.Enums
{
    public enum ServiceRequestStatusTypes
    {
        NotExecuted = -2, // Không thực hiện
        Cancel = -1, // Hủy
        AddNew = 0, // Thêm mới
        Request = 1, // Gửi yêu cầu
        CollectingSpecimen = 2, // Lấy mẫu bệnh phẩm
        StartProcessing = 3, // Bắt đầu xử lý
        ProvideResults = 4, // Trả kết quả
        Other = 99 // Khác
    }
}
