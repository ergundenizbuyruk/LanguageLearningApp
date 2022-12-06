using Abp.Authorization.Users;
using Abp.AutoMapper;
using LanguageLearning.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.Users.Dto
{
    [AutoMapFrom(typeof(User))]
    public class CommentUserGetDto
    {
        
        public string UserName { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }

        public bool IsActive { get; set; }

        public string FullName { get; set; }

    }
}

