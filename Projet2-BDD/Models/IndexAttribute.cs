using System;

namespace Projet2_BDD.Models
{
    internal class IndexAttribute : Attribute
    {
        public bool IsUnique { get; set; }
    }
}