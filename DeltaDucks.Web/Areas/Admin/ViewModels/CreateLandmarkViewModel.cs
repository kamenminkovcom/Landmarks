﻿using System.Web.Mvc;

namespace DeltaDucks.Web.Areas.Admin.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class CreateLandmarkViewModel
    {
        [Required]
        [Display(Name="Име")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Номер")]
        [Range(1, 100)]
        [Remote("IsNumberAvailable", "Landmark", ErrorMessage = "Номерът трябва да бъде уникален!")]
        public int Number { get; set; }

        [Display(Name = "Описание")]
        [StringLength(500)]
        public string Description { get; set; }

        [Display(Name = "Информация")]
        [StringLength(int.MaxValue)]
        public string Information { get; set; }

        [Display(Name = "Снимки")]
        public ICollection<byte[]> Pictures { get; set; }

        [Required]
        [Display(Name = "Точки")]
        public int Points { get; set; }

        [Required]
        [Column(TypeName = "nchar(5)")]
        [Display(Name = "Уникален код")]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Географска ширина")]
        public double Latitude { get; set; }

        [Required]
        [Display(Name = "Географска дължина")]
        public double Longitude { get; set; }

        [Required]
        [Display(Name="Град")]
        public string Town { get; set; }
    }
}