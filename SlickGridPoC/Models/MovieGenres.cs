﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SlickGridPoC.Models;

public partial class MovieGenres
{
    public int MovieGenreId { get; set; }

    public int MovieId { get; set; }

    public int GenreId { get; set; }

    public virtual Genre Genre { get; set; }

    public virtual Movie Movie { get; set; }
}