﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleImageGallery.Models
{
    public class GalleryDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Url { get; set; }
        
    }
}
