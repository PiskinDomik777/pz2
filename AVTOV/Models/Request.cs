using System;
using System.Collections.Generic;

namespace AVTOV.Models;

public partial class Request
{
    public int RequestId { get; set; }

    public DateOnly StartDate { get; set; }

    public string CarType { get; set; } = null!;

    public string CarModel { get; set; } = null!;

    public string ProblemDescryption { get; set; } = null!;

    public string RequestStatus { get; set; } = null!;

    public DateOnly? CompletionDate { get; set; }

    public string? RepairParts { get; set; }

    public int? MasterId { get; set; }

    public int ClientId { get; set; }

    public virtual User Client { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual User? Master { get; set; }
}
