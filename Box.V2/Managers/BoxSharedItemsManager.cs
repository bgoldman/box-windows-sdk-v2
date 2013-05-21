﻿using Box.V2.Auth;
using Box.V2.Contracts;
using Box.V2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box.V2.Managers
{
    public class BoxSharedItemsManager : BoxResourceManager
    {
        public BoxSharedItemsManager(IBoxConfig config, IBoxService service, IAuthRepository auth)
            : base(config, service, auth)
        {

        }

    }
}
