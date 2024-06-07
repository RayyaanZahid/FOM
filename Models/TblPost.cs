using System;
using System.Collections.Generic;

namespace FOM.Models;

public partial class TblPost
{
    public long Pid { get; set; }
    public string? Slug { get; set; }
    public long? Likes { get; set; }
    public long? Dislikes { get; set; }
    public long? Views { get; set; }
    public string? Category { get; set; }
    public string? Tags { get; set; }
    public string? Size { get; set; }
    public string? Mcategory { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public string? Img { get; set; }
    public string? Tlink1 { get; set; }
    public string? Link1 { get; set; }
    public string? Tlink2 { get; set; }
    public string? Link2 { get; set; }
    public string? Tlink3 { get; set; }
    public string? Link3 { get; set; }
    public string? Tlink4 { get; set; }
    public string? Link4 { get; set; }
    public string? Tlink5 { get; set; }
    public string? Link5 { get; set; }
    public long? Year { get; set; }
    public string? Meta { get; set; }
    public string? Tlink6 { get; set; }
    public string? Link6 { get; set; }
    public DateTime DateInserted { get; set; }
}
