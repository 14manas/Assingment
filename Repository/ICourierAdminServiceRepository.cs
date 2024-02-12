using CManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CManagement.Repository
{
    internal interface ICourierAdminServiceRepository
    {
        int AddCourierStaff(Employee employee);

    }
}
