﻿using System;
using System.Collections.Generic;

namespace Web_bestcoder.Data;

public partial class Location
{
    public int LocationId { get; set; }

    public string City { get; set; } = null!;

    public string District { get; set; } = null!;

    public string Ward { get; set; } = null!;

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual ICollection<CharityRegistration> CharityRegistrations { get; set; } = new List<CharityRegistration>();
}
