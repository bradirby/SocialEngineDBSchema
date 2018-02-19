using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using NPoco;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DataAccess.IntgTests
{
    public class UserRepositoryIntgTest
    {
        private Database DB { get; set; }
        private UserRepository sut { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            DB = new Database("SocialEngineDB");
            sut = new UserRepository(DB);
        }

        [Test]
        public void GetById_ValidId_GetsData()
        {
            var usr = sut.GetById(1);
            Assert.IsNotNull(usr);
            Assert.AreEqual(1, usr.user_id);
            Assert.AreEqual("AmandaJones", usr.username);
        }


        [Test]
        public void UpdateDisplayName_VAlidName_IsUpdated()
        {
            var usr = sut.GetById(1);
            var saveName = usr.displayname;
            var newName = Guid.NewGuid().ToString();
            var snapshot = sut.GetSnapshot(usr);
            usr.displayname = newName;
            sut.Update(usr, snapshot);

            var updatedUsr = sut.GetById(1);
            Assert.AreEqual(newName, updatedUsr.displayname);

            snapshot = sut.GetSnapshot(updatedUsr);
            updatedUsr.displayname = saveName;
            sut.Update(updatedUsr, snapshot);

        }
    }
}
