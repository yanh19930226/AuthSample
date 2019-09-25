using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCookieSample.ViewModels
{
    public class InputConsentViewModel
    {
        public string Button { get; set; }
        public IEnumerable<string> DisplayName { get; set; }
        public bool Descripton { get; set; }
        public string ReturnUrl { get; set; }
    }
}
