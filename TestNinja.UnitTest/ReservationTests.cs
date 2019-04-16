using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_IsAdmin_ReturnsTrue()
        {
            // arrange
            var reservation = new Reservation();

            // act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //Assert.That(result == true);
        }

        [Test]
//        [Ignore("just want to ignore same user")]
        public void CanBeCancelledBy_IsSameUser_ReturnsTrue()
        {
            // arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // act
            var result = reservation.CanBeCancelledBy(user);

            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_IsNotSameUser_ReturnsFalse()
        {
            // arrange
            var reservation = new Reservation {MadeBy = new User()};

            // act
            var result = reservation.CanBeCancelledBy(new User());

            // assert
            Assert.IsFalse(result);
        }
    }
}
