using LojaIO.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaIO.Core.DomainObjects
{
    public class DomainEvent : Event
    {
        public DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
