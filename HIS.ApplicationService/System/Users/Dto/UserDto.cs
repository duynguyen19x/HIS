using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Systems.Users.Dto
{
    public class UserDto : EntityDto<Guid?>
    {
        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        public virtual string Username { get; set; }

        /// <summary>
        /// Mật khẩu
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Tên người dùng
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Họ và tên đệm
        /// </summary>
        public virtual string LastName { get; set; }

        /// <summary>
        /// Họ và tên người dùng
        /// </summary>
        public virtual string FullName { get; set; }

        public virtual string Email { get; set; }

        public virtual string Tel { get; set; }

        public virtual string Mobile { get; set; }

        public virtual string Description { get; set; }

        /// <summary>
        /// Nhân viên sử dụng tài khoản người dùng
        /// </summary>
        public virtual Guid? EmployeeId { get; set; }

        /// <summary>
        /// Chi nhánh khởi tạo tài khoản người dùng (mặc định quyền đăng nhập vào chi nhánh khi tài khoản không bị khóa)
        /// </summary>
        public virtual Guid BranchId { get; set; }

        /// <summary>
        /// Chi nhánh người dùng làm việc cuối cùng
        /// </summary>
        public virtual Guid LastWorkingBranchId { get; set; }

        /// <summary>
        /// Số lần đăng nhập thất bại (khi quá số lần cho phép trong cấu hình thì khóa tài khoản, kho đăng nhập thành công thì làm gán bằng 0)
        /// </summary>
        public virtual int AccessFailedCount { get; set; }

        /// <summary>
        /// Khóa tài khoản người dùng
        /// </summary>
        public virtual bool Inactive { get; set; }

        /// <summary>
        /// Danh sách vai trò
        /// </summary>
        public virtual IList<Guid> Roles { get; set; }

        /// <summary>
        /// Danh sách phòng chức năng
        /// </summary>
        public virtual IList<Guid> Rooms { get; set; }

    }
}
