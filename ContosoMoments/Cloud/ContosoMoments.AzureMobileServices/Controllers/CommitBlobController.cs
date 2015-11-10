<<<<<<< HEAD
﻿using System.Web.Http;
using System.Web.Http.Cors;
using ContosoMoments.Common.Srorage;
using Microsoft.WindowsAzure.Mobile.Service;

namespace ContosoMoments.AzureMobileServices.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class CommitBlobController : ApiController
    {
        public ApiServices Services { get; set; }

        // POST: api/Default
        public bool Post([FromBody]CommitBlobRequest commitBlobRequest)
        {
            var cs = new ContosoStorage();
            return cs.CommitUpload(commitBlobRequest);

        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ContosoMoments.Common.Srorage;
using Microsoft.WindowsAzure.Mobile.Service;

namespace ContosoMoments.MobileServices.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class CommitBlobController : ApiController
    {
        public ApiServices Services { get; set; }

        // POST: api/Default
        public bool Post([FromBody]CommitBlobRequest commitBlobRequest)
        {
            var cs = new ContosoStorage();
            return cs.CommitUpload(commitBlobRequest);

        }

    }
}
>>>>>>> e8dea8fbb97f19cfd7c518eb7fe7672598be2304