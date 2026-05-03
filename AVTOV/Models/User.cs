using System;
using System.Collections.Generic;

namespace AVTOV.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Fio { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Type { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Request> RequestClients { get; set; } = new List<Request>();

    public virtual ICollection<Request> RequestMasters { get; set; } = new List<Request>();
}
