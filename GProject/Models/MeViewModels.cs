using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GProject.Models
{
    // Modelos retornados por ações MeController.
    public class GetViewModel
    {
        public string Hometown { get; set; }
        public string Registration { get; set; }
    }
}