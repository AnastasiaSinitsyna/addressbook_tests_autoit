using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            int countOldGroups = app.Groups.GetCountGroupList();
            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };
            app.Groups.Add(newGroup);

            int countNewGroups = app.Groups.GetCountGroupList();

            Assert.AreEqual(countOldGroups + 1, countNewGroups);
        }
    }
}
