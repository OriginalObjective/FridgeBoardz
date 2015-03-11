using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FridgeBoardz.Domain;
using FridgeBoardz.Domain.Boardz;
using Moq;
using NUnit.Framework;

namespace FridgeBoardz.Test.Domain
{
    [TestFixture]
    public class BoardFixture
    {
        private Guid _userIdA;
        private Guid _userIdB;
        private Guid _userIdC;
        private User _fakeUserA;
        private User _fakeUserB;
        private User _fakeUserC;
        private Guid _groupId;
        private Group _fakeGroup;
     
        [SetUp]
        public void SetUp()
        {
            _userIdA = Guid.Parse("97756c2e-c714-4c43-b0e1-493382ecba37");
            _userIdB = Guid.Parse("2f07265e-657d-4449-acf2-ab9f2d0d7712");
            _userIdC = Guid.Parse("f2726d3d-87a7-40d6-8af5-91ffed75815f");
            _groupId = Guid.Parse("00d63bdf-fa9b-428e-a638-5526b74f237e");
            _fakeUserA = new User() { UserId = _userIdA, UserName = "dillorscroft", FirstName="Matt", LastName="Perry" };
            _fakeUserB = new User() { UserId = _userIdB, UserName = "tiggerflid", FirstName = "Jessica", LastName = "Cottrell" };
            _fakeUserB = new User() { UserId = _userIdC, UserName = "pinkflid", FirstName = "Michelle", LastName = "Perry" };
            _fakeGroup = new Group()
            {
                GroupName = "The Perrys",
                GroupId = _groupId,
                Users = new List<User>() { _fakeUserA, _fakeUserB,_fakeUserC}
            };
        }

        [Test]
        public void Can_Create_A_New_ShoppingList()
        {
            var sut = new ShoppingListBoard("Perry's ShoopingList", _fakeGroup, _fakeUserA);
            Assert.IsInstanceOf<ShoppingListBoard>(sut);

        }

        [Test]
        public void Can_Create_A_New_Location()
        {
            var sut = new LocationBoard("Where are the Perry's", _fakeGroup, _fakeUserB);
            Assert.IsInstanceOf<LocationBoard>(sut);
        }


        [Test]
        public void Can_Create_A_New_Diary()
        {
            var sut = new DiaryBoard("Perry's Diary", _fakeGroup, _fakeUserC);
            Assert.IsInstanceOf<DiaryBoard>(sut);
        }
    }
}
