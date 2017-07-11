using System;
using System.Collections.Generic;
using System.Text;

namespace Wavelength.Api.Dtos
{
    public class ProfileDto
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Bio { get; set; }
        public int FavoriteBarId { get; set; }
    }
}
