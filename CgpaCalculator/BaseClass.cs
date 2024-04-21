using System;

namespace CgpaCalculator
{
    public abstract class BaseClass
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
