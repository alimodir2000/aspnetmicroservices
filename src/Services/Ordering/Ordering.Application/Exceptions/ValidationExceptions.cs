using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Exceptions
{
    public class ValidationExceptions : ApplicationException
    {
        public IDictionary<string, string[]> Errors { get; set; }

        public ValidationExceptions()
            :base("One or more validation failures have occured!")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationExceptions(IEnumerable<ValidationFailure> errors)
        {
            Errors = errors.GroupBy(x => x.PropertyName, x => x.ErrorMessage)
                .ToDictionary(y => y.Key, y => y.ToArray());
        }
    }
}
