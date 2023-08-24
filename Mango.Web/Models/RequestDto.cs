﻿using static Mango.Web.Utility.SD;

namespace Mango.Web.Models
{
    public class RequestDto
    {
        public ApitType ApiType { get; set; } = ApitType.GET;
        public string Url { get; set; }

        public object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
