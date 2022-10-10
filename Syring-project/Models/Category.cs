﻿namespace Syring_project.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CategoryComponent> CategoryComponents { get; set; }
    }
}
