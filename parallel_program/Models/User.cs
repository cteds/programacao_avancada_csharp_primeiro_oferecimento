﻿namespace parallel_program.Models
{
    internal class User
    {
        public Guid IdUser { get; set; }

        public string Name { get; set; } = string.Empty;

        public string JobTitle { get; set; } = string.Empty;
    }
}
