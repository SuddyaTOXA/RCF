using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using IMCMS.Models.DAL;
using IMCMS.Models.Repository;
using IMCMS.Web.ViewModels;
using StackExchange.Profiling;
using IMCMS.Models.Entities;
using IMCMS.Models.Services;
using System.Collections.Generic;
using System.Web.Caching;
using IMCMS.Common;

namespace IMCMS.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IUnitOfWork _uow;

        public BaseController() : this(new DataContext())
        {
        }

        public BaseController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        /// <summary>
        /// Gets or sets a condition if the current request can see unpublished items
        /// </summary>
        public virtual bool CanSeeUnpublished
        {
            get
            {
                return User.Identity.IsAuthenticated;
            }
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

            using (MiniProfiler.Current.Step("ViewModel"))
            {
                var viewResult = filterContext.Result as ViewResult;
                if (viewResult == null)
                    return;


                var model = (viewResult.ViewData.Model as BaseViewModel) ?? new BaseViewModel();

                viewResult.ViewData.Model = model;
            }
        }
    }
}