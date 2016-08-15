using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace myAbacus.Models
{
  public class AbacusViewModel
  {
    [Required(ErrorMessage = "Both sides are required")]
    [Range(0, int.MaxValue)]
    public string LeftSide { get; set; } = "";

    [Required(ErrorMessage = "Both sides are required")]
    [Range(0, int.MaxValue)]
    public string RightSide { get; set; } = "";

    public string Sum { get; set; } = "";
  }
}