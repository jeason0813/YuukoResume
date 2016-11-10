﻿using System;
using System.ComponentModel.DataAnnotations;

namespace YuukoResume.Models
{
    public class Project
    {
        public long Id { get; set; }

        [MaxLength(128)]
        [Localized]
        public string Title { get; set; }

        [Localized]
        public string Description { get; set; }

        [Localized]
        [MaxLength(256)]
        public string Tags { get; set; }

        [MaxLength(256)]
        public string GitHub { get; set; }

        [MaxLength(256)]
        public string DemoUrl { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }

        [Localized]
        [MaxLength(128)]
        public string Catalog { get; set; }
    }
}
