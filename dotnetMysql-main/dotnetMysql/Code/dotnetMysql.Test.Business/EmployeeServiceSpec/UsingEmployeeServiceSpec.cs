using NSubstitute;
using dotnetMysql.Test.Framework;
using dotnetMysql.Business.Services;
using dotnetMysql.Data.Interfaces;

namespace dotnetMysql.Test.Business.EmployeeServiceSpec
{
    public abstract class UsingEmployeeServiceSpec : SpecFor<EmployeeService>
    {
        protected IEmployeeRepository _employeeRepository;

        public override void Context()
        {
            _employeeRepository = Substitute.For<IEmployeeRepository>();
            subject = new EmployeeService(_employeeRepository);

        }

    }
}
