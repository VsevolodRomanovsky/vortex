using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

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

        public List<Visitor> AllVisitors()
        {
            using (var te = new TurnstileDbEntities())
            {
                te.Configuration.ProxyCreationEnabled = false;
                return te.Visitors.Include("Visits").ToList();
            }
        }

        public bool CheckValidation(int permitId, int enterType)
        {
            using (var te = new TurnstileDbEntities())
            {
                var visitor = te.Visitors.SingleOrDefault(p => p.PermitId == permitId);
                if (visitor == null)
                    return false;
                if (!visitor.IsValid)
                    return false;
                return InsertVisit(enterType, visitor.Id);
            }

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
