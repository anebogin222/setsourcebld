using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL.BLL
{
    public class Jira
    {
        public JiraTask getJiraTaskByNumber(string taskNumber)
        {
            return new JiraTask { Number=taskNumber, Summary="Test Jira Task"};
        }
    }
}
