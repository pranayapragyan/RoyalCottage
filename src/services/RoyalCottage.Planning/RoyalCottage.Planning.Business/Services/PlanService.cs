﻿using RoyalCottage.Planning.Business.Interfaces;
using RoyalCottage.Planning.Models;
using RoyalCottage.Framework.Couchbase.Repositories;
using RoyalCottage.Framework.Domain;

namespace RoyalCottage.Planning.Business.Services
{
    public class PlanService : EntityService<Plan>, IPlanService
    {
        //private ApplicationContext _appContext;
        protected override ICouchbaseRepository<Plan> Repository { get; }

        public PlanService(IPlanRepository repository)
        {
            Repository = repository;
        }
    }
}
