using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equin.ApplicationFramework;
using Microsoft.Access.Data.WorkingClasses;

namespace Microsoft.Access.Data.LanguageExtensions
{
    public static class BindingSourceExtensions
    {
        public static CustomerEntity CurrentCustomerEntity(this BindingSource sender)
        {
            return ((ObjectView<CustomerEntity>)sender.Current).Object;
        }
    }
}
