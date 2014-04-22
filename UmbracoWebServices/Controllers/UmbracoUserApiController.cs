﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using Umbraco.Web.WebApi;
using UmbracoWebServices.Models;
using UmbracoWebServices.Services;

namespace UmbracoWebServices.Controllers
{
    [Authorize]
    public class UmbracoUserApiController : UmbracoApiController
    {
        private readonly IUserAdminService userAdminService;

        public UmbracoUserApiController(IUserAdminService userAdminService)
        {
            this.userAdminService = userAdminService;
        }

        [HttpGet]
        public HttpResponseMessage GetAllUsersByEmail(string emailaddress)
        {
            try
            {
                var users = userAdminService.LookupUser(emailaddress);
                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        public HttpResponseMessage PostNewUsers(UmbracoUserModel model)
        {
            try
            {
                userAdminService.CreateUmbracoUser(model);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        public HttpResponseMessage PostResetPassword(PasswordResetModel model)
        {
            try
            {
                userAdminService.ResetUsersPassword(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        public HttpResponseMessage PostCreateUser(UmbracoUserModel model)
        {
            try
            {
                userAdminService.CreateUmbracoUser(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        public HttpResponseMessage PostDisableUser(UmbracoUserModel model)
        {
            try
            {
                userAdminService.DisableUser(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadGateway, ex);
            }
        }

        [HttpPost]
        public HttpResponseMessage PostEnableUser(UmbracoUserModel model)
        {
            try
            {
                userAdminService.EnableUser(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadGateway, ex);
            }
        }
    }
}