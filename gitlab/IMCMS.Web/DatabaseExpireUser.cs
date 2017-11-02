using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppHarbor.Web.Security;
using IMCMS.Models.DAL;
using IMCMS.Models.Repository;

namespace IMCMS.Web
{
    public class DatabaseExpireUser : IExpireTest
    {
        public bool IsExpired(Guid ticketGuid)
        {
            var repo = new AdminUserSessionRepository(new DataContext());
            return repo.IsGuidExpired(ticketGuid);
        }
    }
}