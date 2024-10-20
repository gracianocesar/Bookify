﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events
{
    public sealed record BookingReservedDomainEnvet(Guid BookingId) : IDomainEvent;
    
}