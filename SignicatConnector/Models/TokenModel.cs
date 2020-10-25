using System;
using System.Collections.Generic;
using System.Text;

namespace SignicatConnector.Models
{
    class TokenModel
    {
        public string Access_token { get; set; }

        public int Expires_in { get; set; }

        public string Token_type { get; set; }
    }
}
