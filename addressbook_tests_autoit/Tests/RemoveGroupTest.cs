using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class RemoveGroupTest : TestBase
    {
        [Test]
        public void TestGroupRemoveFirstGroup()
        {

            int countOldGroups = app.Groups.GetCountGroupList();
            if (countOldGroups == 1)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "testTest"
                };
                app.Groups.Add(newGroup);
                countOldGroups = app.Groups.GetCountGroupList();
            }
            app.Groups.Remove();
            int countNewGroups = app.Groups.GetCountGroupList();

            Assert.AreEqual(countOldGroups - 1, countNewGroups);
        }
    }
}
