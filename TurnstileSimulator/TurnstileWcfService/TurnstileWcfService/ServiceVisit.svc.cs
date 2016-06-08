using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Caching;

namespace TurnstileWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceVisit" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceVisit.svc or ServiceVisit.svc.cs at the Solution Explorer and start debugging.

    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(Visitor))]
    [KnownType(typeof(Visit))]
    [KnownType(typeof(ICollection<Visit>))]
    public class ServiceVisit : IServiceVisit
    {
        private const string CacheKey = "availableVisitors";

        public List<Visitor> AllVisitors()
        {
            using (var te = new TurnstileDbEntities())
            {
                te.Configuration.ProxyCreationEnabled = false;
                return te.Visitors.Include("Visits").ToList();
            }
        }

        private static Dictionary<int, Visitor> GetChechedData()
        {

            var cache = MemoryCache.Default;
            if (cache.Contains(CacheKey)) return (Dictionary<int, Visitor>) cache.Get(CacheKey);

            using (var te = new TurnstileDbEntities())
            {
                var visitors = te.Visitors.ToDictionary(p => p.PermitId, p => p);

                // Store data in the cache
                var cacheItemPolicy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTime.Now.AddHours(12.0)
                };
                cache.Add(CacheKey, visitors, cacheItemPolicy);
                return visitors;
            }
        }

        public bool CheckValidation(int permitId, int enterType)
        {
            var visitor = GetChechedData().SingleOrDefault(p => p.Value.PermitId == permitId).Value;
            return visitor != null && (visitor.IsValid && InsertVisit(enterType, visitor.Id));
        }

        private bool InsertVisit(int enterType, int visitorId)
        {
            var visit = new Visit()
            {
                Visitor_Id = visitorId,
                VisitDate = DateTime.Now,
                VisitType = enterType

            };
            using (var te = new TurnstileDbEntities())
            {
                te.Visits.Add(visit);
                te.SaveChanges();
                return true;
            }
        }
    }
}
