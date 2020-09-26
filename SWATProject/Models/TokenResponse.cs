using System;
namespace SWATProject.Models
{
    public class TokenResponse
    {
        public string access_token { get; set; }

        public string token_type { get; set; }

        public string expiresIn { get; set; }

        public string userName { get; set; }

        public string issued { get; set; }

        public string expires { get; set; }
    }
}
