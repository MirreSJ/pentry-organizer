using NSubstitute;
using NUnit.Framework;
using pentry.application;
using pentry.Controllers;
using pentry.domain;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class RoomsController_When
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void getting_all_rooms_Then_status_code_is_200()
        {
            var facade = Substitute.For<IRoomFacade>();
            var controller = new RoomsController(facade);

            var returnedRooms = controller.Get();

            returnedRooms.As<OkObjectResult>().StatusCode.Should().Be(200);
        }

        [Test]
        public void getting_all_rooms_Then_all_rooms_are_returned()
        {
            var facade = Substitute.For<IRoomFacade>();
            var rooms = new[] { new Room { Name = "Küche" }, new Room { Name = "Wohnzimmer" } };
            facade.GetAll().Returns(rooms);
            var controller = new RoomsController(facade);

            var returnedRooms = controller.Get();
            
            returnedRooms.As<OkObjectResult>().Value.Should().BeEquivalentTo(rooms);
        }
    }
}