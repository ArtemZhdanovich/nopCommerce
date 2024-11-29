﻿using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Support;
using Nop.Web.Areas.Admin.Models.Support;
using Nop.Services.Support;

namespace Nop.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class SupportRequestController : BaseAdminController
{
    protected readonly ISupportRequestService _supportRequestService;
    protected readonly IWorkContext _workContext;
    protected readonly int _currentUserId;

    public SupportRequestController(ISupportRequestService supportRequestService, IWorkContext workContext)
    {
        _supportRequestService = supportRequestService;
        _workContext = workContext;
        _currentUserId = _workContext.GetCurrentCustomerAsync().Result.Id;
    }
    
    #region Request List
    
    public async Task<IActionResult> List(string sortBy = "date_dsc")
    {
        var requestList = _supportRequestService.GetAllSupportRequests(sortBy == "date_dsc");

        var viewModel = new SupportListViewModel()
        {
            Requests = requestList.Select(request => new SupportRequestModel(request)).ToList(),
            SelectedSortOption = sortBy
        };
        
        return View(viewModel);
    }
    
    #endregion
    
    #region Chat
    
    public IActionResult Chat(int requestId)
    { 
        var supportRequest = _supportRequestService.GetSupportRequestById(requestId);
        var baseMessages = _supportRequestService.GetSupportRequestMessages(requestId);
        var viewModel = new SupportChatViewModel()
        {
            RequestId = supportRequest.Id,
            Subject = supportRequest.Subject,
            Status = supportRequest.Status,
            Messages = baseMessages.Select(message => new SupportMessageModel(message)).ToList()
        };
        
        return View(viewModel);
        
    }

    [HttpPost]
    public IActionResult AddMessage(SupportChatViewModel model)
    {
        var entityModel = new SupportMessage()
        {
            RequestId = model.RequestId,
            AuthorId = _currentUserId,
            Message = model.NewMessage
        };
        
        _supportRequestService.CreateSupportMessage(entityModel);
        
        return RedirectToAction("Chat", new { requestId = model.RequestId });
    }

    
    #endregion
    
}