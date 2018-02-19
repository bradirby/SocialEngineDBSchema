using System;
using NUnit.Framework;
using SocialEngine.DataAccess.Repositories;

namespace SocialEngine.DataAccess.IntgTests
{
    public class UserRepositoryIntgTest
    {
        private RegisteredUserRepository sut { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var DB = new SocialEngineDbFactory();
            sut = new RegisteredUserRepository(DB);
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
        public void GetByEmail_ValidEmail_GetsData()
        {
            var usr = sut.GetByEmail("brad@bradirby.com");
            Assert.IsNotNull(usr);
            Assert.AreEqual(2, usr.user_id);
            Assert.AreEqual("BradIrby", usr.username);
        }

        [Test]
        public void GetByUsername_ValidUsername_GetsData()
        {
            var usr = sut.GetByUsername("BradIrby");
            Assert.IsNotNull(usr);
            Assert.AreEqual(2, usr.user_id);
            Assert.AreEqual("brad@bradirby.com", usr.email);
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

        [Test]
        public void InsertDelete_NewUser_IsInsertedThenDeleted()
        {
            var usr = sut.GetById(1);
            usr.email = Guid.NewGuid().ToString();
            usr.username = Guid.NewGuid().ToString();
            usr.displayname = Guid.NewGuid().ToString();
            sut.Insert(usr);

            var queriedUser = sut.GetByEmail(usr.email);
            Assert.IsNotNull(queriedUser);
            Assert.AreEqual(usr.email, queriedUser.email);

            sut.Delete(usr);
        }
    }
}
