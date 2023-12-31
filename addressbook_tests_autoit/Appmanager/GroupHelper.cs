﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_tests_autoit
{
    public class GroupHelper : HelperBase
    {
        public static string GROUPWINTITLE = "Group editor";
        public GroupHelper(ApplicationManager manager) : base(manager) 
        { 
        }

        public void Add(GroupData newGroup)
        {
            OpenGroupsDialog();
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            aux.Send(newGroup.Name);
            aux.Send("{ENTER}");
            CloseGroupsDialog();
        }
        public void Remove()
        {
            OpenGroupsDialog();
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51","",1,37, 24);
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d51");
            aux.Send("{ENTER}");
            CloseGroupsDialog();
        }

        private void CloseGroupsDialog()
        {
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d54");
        }

        private void OpenGroupsDialog()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            aux.WinWait(GROUPWINTITLE);
        }

        public int GetCountGroupList()
        {
            OpenGroupsDialog();
            string GetItemCount = aux.ControlTreeView
                (GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51", "GetItemCount", "#0", "");
            int count = int.Parse(GetItemCount);

            //Данная часть кода не работает - получение списка групп
            //List<GroupData> list = new List<GroupData>();
            /*for (int i = 0; i < int.Parse(count); i++)
            {
                string item = aux.ControlTreeView
                (GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51", "GetText", "#0|#"+i, "");
                list.Add(new GroupData() { Name = item});
            }*/
            CloseGroupsDialog();
            return count;
        }
    }
}