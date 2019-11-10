 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Data.Models;
using SimpleImageGallery.Models;

namespace SimpleImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var imageTag1 = new ImageTag()
            {
                Description = "Adventure",
                Id = 0
            };

            var imageTag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1
            };

            var imageTag3 = new ImageTag()
            {
                Description = "New York",
                Id = 2
            };

            hikingImageTags.Add(imageTag1);
            cityImageTags.AddRange( new List<ImageTag>{ imageTag2, imageTag3 });

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Trip",
                    Url = "https://images.pexels.com/photos/1576937/pexels-photo-1576937.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                new GalleryImage()
                {
                    Title = "On the trail",
                    Url = "https://images.pexels.com/photos/547116/pexels-photo-547116.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://images.pexels.com/photos/290386/pexels-photo-290386.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                },

            };

            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuey = ""
            };

            return View(model);
        }
    }
}