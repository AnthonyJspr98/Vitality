using System;

namespace Vitality.Domain.Entities
{
    public class User
    {
        public Guid UID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }
}