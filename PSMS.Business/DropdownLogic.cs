using PSMS.Repository;
using PSMS.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Business
{
    public static class DropdownLogic
    {
        public static List<Dropdown> Customers()
        {
            return new DropdownRepository().GetDropdown("select CustomerId Id, CustomerName Name from psms.Customer", isQuery: true);
        }

        //public static List<Dropdown> ActiveLoans()
        //{
        //    return new DropdownRepository().GetDropdown("select LoanID ID, LoanRefNo Name from Loan", isQuery: true);
        //}

        //public static List<Dropdown> IdentificationDocType()
        //{
        //    return new DropdownRepository().GetDropdown("select DocumentTypeID ID, DocumentTypeName Name from mst.DocumentType", isQuery: true);
        //}

        //public static List<Dropdown> AccountHolders()
        //{
        //    return new DropdownRepository().GetDropdown("select AccountHolderID ID, AccountHolderName Name from acc.AccountHolder", isQuery: true);
        //}
    }
}
