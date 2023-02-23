using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetMysql.Entities.Entities;

namespace dotnetMysql.Test.Business.EmployeeServiceSpec
{
    public class When_saving_employee : UsingEmployeeServiceSpec
    {
        private Employee _result;

        private Employee _employee;

        public override void Context()
        {
            base.Context();

            _employee = new Employee
            {
                name = "name"
            };

            _employeeRepository.Save(_employee).Returns(true);
        }
        public override void Because()
        {
            _result = subject.Save(_employee);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _employeeRepository.Received(1).Save(_employee);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<Employee>();

            _result.ShouldBe(_employee);
        }
    }
}
