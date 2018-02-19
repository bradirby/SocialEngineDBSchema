using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using NPoco;
using NUnit.Framework;

namespace DataAccess.IntgTests
{
    public class UserRepositoryIntgTest
    {
        [Test]
        public void GetById_ValidId_GetsData()
        {
            var db = new Database("SocialEngineDB");

            var sut = new UserRepository(db);
            var usr = sut.GetById(1);
            Assert.IsNotNull(usr);
            Assert.AreEqual(1, usr.user_id);
            Assert.AreEqual("AmandaJones", usr.username);
        }
    }
}
