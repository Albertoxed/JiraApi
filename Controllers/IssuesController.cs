using ApiJira.Dto;
using ApiJira.Models;
using ApiJira.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJira.Controllers
{
    [Authorize]
    public class IssuesController : BaseController<Issue, IssueDto>
    {
        public IssuesController(IIssueService issueService) : base(issueService)
        {

        }
    }
}
