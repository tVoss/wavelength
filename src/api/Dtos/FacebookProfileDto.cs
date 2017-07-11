﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wavelength.Api.Dtos
{
    public class FacebookProfileDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public bool Verified { get; set; }
    }
}
