using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using COL.NEA.FAS;
using FluentValidation;

namespace WebApplicationTest.Classes.Validators
{
    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(request => request.RequestNumber).NotNull();
            RuleFor(request => request.RequestNumber).Length(5);
            RuleFor(request => request.Id).NotNull();
            RuleFor(request => request.PaperTitle).NotEqual(request => request.RequestNumber);
        }
    }
}