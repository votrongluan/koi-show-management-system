﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using KoiShow.Data.Base;

namespace KoiShow.Data.Models;

#nullable enable
public partial class Account : BaseEntity
{
    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? FullName { get; set; }

    public int? Role { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public int? Status { get; set; }

    public DateOnly? BirthDay { get; set; }

    public virtual ICollection<Animal>? Animals { get; set; } = new List<Animal>();

    public virtual ICollection<New>? News { get; set; } = new List<New>();

    public virtual ICollection<Point>? Points { get; set; } = new List<Point>();
}