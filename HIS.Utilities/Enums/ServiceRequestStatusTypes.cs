namespace HIS.Utilities.Enums
{
    public enum ServiceRequestStatusTypes
    {
        NotExecuted = -2, // Không thực hiện
        Cancel = -1, // Hủy
        AddNew = 0, // Thêm mới
        Request = 1, // Gửi yêu cầu
        CollectingSpecimen = 2, // Lấy mẫu bệnh phẩm
        SampleReceiving = 3, // Tiếp nhận mẫu bệnh phẩm
        StartProcessing = 4, // Bắt đầu xử lý
        ProvideResults = 5, // Trả kết quả
        Other = 99 // Khác
    }
}
