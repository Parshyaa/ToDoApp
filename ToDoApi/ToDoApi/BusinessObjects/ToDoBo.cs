﻿using System;
using ToDoApi.BusinessObjects.Interface;

namespace ToDoApi.BusinessObjects
{
    public class ToDoBo : IToDoBo
    {
        public long ToDoId { get; set; }

        public string TaskName { get; set; }

        public bool IsComplete { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
