using System;
using System.Collections.Generic;

namespace Spravo4nik;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CountryId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}
