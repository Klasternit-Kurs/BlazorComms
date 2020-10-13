using BlazorComms.Shared;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComms.Client
{
	public class Validator : AbstractValidator<Primer>
	{
		public Validator()
		{
			RuleFor(p => p.Ovo).Must((pr, ovo) => ovo == pr.SaOvim)
				.WithMessage("Mora jednako!");
		}
	}
}
