﻿using System;

namespace AdvertAPI.Models
{
    public class ConfirmAdvertModel
    {
        public string Id { get; set; }
        public string FilePath { get; set; }
        public AdvertStatus Status { get; set; }
    }
}
