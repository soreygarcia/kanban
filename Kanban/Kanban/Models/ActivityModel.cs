﻿using Kanban.Enumerations;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Models
{
    public class ActivityModel
    {
        [PrimaryKey]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int State { get; set; }
    }
}
