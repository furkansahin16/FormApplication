﻿using FormApplication.Base.Entities.Abstract;

namespace FormApplication.Base.Entities.Concrete
{
    public class BaseEntity : IEntity, ICreatable
    {
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Id { get; set; }
        public Status Status { get; set; }
    }
}