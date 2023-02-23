using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Systems.Login
{
    public class TokenResultDto
    {
        public string? AcceptToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
