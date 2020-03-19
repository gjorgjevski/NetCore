using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string messageType { get; protected set;}

        protected Message() {
            messageType = GetType().Name;
        }
    }
}
