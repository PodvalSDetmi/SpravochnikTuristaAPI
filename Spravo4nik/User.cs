﻿using System;
using System.Collections.Generic;

namespace Spravo4nik;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;
}
