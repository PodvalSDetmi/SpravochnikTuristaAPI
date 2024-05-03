using System;
using System.Collections.Generic;

namespace Spravo4nik;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
