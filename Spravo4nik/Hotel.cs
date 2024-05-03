using System;
using System.Collections.Generic;

namespace Spravo4nik;

public partial class Hotel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Rating { get; set; } = null!;

    public int CityId { get; set; }

    public decimal MaxPrice { get; set; }

    public decimal MinPrice { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual City City { get; set; } = null!;
}
