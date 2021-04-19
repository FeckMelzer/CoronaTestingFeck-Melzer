using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoronaTest.Core.Contracts;
using CoronaTest.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoronaTest.Web.Pages.Security
{
    public class SuccessModel : PageModel
    {
        private IUnitOfWork _unitOfWork;

        public SuccessModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<IActionResult> OnGetAsync(Guid verificationIdentifier)
        {
            AuthToken verificationToken = await _unitOfWork.AuthTokens.GetTokenByIdentifierAsync(verificationIdentifier);

            if (verificationToken?.Identifier == verificationIdentifier && verificationToken.ValidUntil >= DateTime.Now)
            {
                return RedirectToPage("/User/Index", new { verificationIdentifier = verificationToken.Identifier });
            }
            else
            {
                return RedirectToPage("/Security/TokenError");
            }
        }
    }
}
