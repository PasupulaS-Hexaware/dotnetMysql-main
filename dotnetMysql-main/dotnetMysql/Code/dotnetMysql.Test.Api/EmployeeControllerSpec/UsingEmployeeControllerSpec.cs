using NSubstitute;
using dotnetMysql.Test.Framework;
using dotnetMysql.Api.Controllers;
using dotnetMysql.Business.Interfaces;


namespace dotnetMysql.Test.Api.EmployeeControllerSpec
{
    public abstract class UsingEmployeeControllerSpec : SpecFor<EmployeeController>
    {
        protected IEmployeeService _employeeService;

        public override void Context()
        {
            _employeeService = Substitute.For<IEmployeeService>();
            subject = new EmployeeController(_employeeService);

        }

    }
}
