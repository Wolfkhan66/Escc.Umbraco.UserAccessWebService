﻿using System.Collections.Generic;

namespace ESCC.Umbraco.UserAccessWebService.Models
{
    public class UserPagesModel
    {
        public UserPagesModel()
        {
            Pages = new List<UserPageModel>();
        }

        public UmbracoUserModel User { get; set; }

        public IList<UserPageModel> Pages { get; set; }

    }
}