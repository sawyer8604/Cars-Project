﻿namespace Cars.Data.Models
{
    using System;

    using Cars.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        // The contents of the image is in the file system
        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        public string Extension { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
