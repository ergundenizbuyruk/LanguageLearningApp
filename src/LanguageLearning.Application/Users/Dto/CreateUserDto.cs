using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using LanguageLearning.Authorization.Users;
using System.ComponentModel.DataAnnotations;

namespace LanguageLearning.Users.Dto
{
    [AutoMapTo(typeof(User))]
    public class CreateUserDto
    {
        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxSurnameLength)]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        public bool IsActive { get; set; }

        public string RoleName { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }

    }
}
