using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Qlh
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public string? Sdt { get; set; }

    public string? Diachi { get; set; }

    public DateTime Ngaylam { get; set; }

    public string? Loaicongviec { get; set; }

    public int? Tiencong { get; set; }

    public int? Tongtien { get; set; }

    public int? Tiendathanhtoan { get; set; }
}
