using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestProject.Models.DTO
{
    // отображение растения
    public class PlantDTO
    {
        public int Id { get; set; }
        public string NameRu { get; set; }
        public string DescriptionRu { get; set; }
        public string PictureUrl { get; set; }


    }
}