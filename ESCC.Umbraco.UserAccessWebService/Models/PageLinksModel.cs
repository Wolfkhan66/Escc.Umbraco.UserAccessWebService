﻿using System.Collections.Generic;

namespace ESCC.Umbraco.UserAccessWebService.Models
{
    public class PageLinksModel
    {
        public PageLinksModel()
        {
            InboundLinksLocal = new List<PageInLinkModel>();
            InboundLinksRedirect = new List<PageInLinkModel>();
            InboundLinksExternal = new List<PageInLinkModel>();
        }

        public int PageId { get; set; }

        public string PageName { get; set; }

        public string PageUrl { get; set; }

        public List<PageInLinkModel> InboundLinksLocal { get; set; }
        public List<PageInLinkModel> InboundLinksRedirect { get; set; }
        public List<PageInLinkModel> InboundLinksExternal { get; set; }
    }
}