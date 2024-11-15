﻿using Common.Models;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ISubscriptionService
    {
        IEnumerable<SubscriptionsForViewDTO> GetAllSubscriptions();
        Subscription? GetSubscriptionByName(string name);
    }
}