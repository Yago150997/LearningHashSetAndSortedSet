using System;
using System.Collections.Generic;
using System.Text;

namespace LearningHashSetAndSortedSet.Entities
{
    class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord()
        {

        }

        public LogRecord(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {

            if(!(obj is LogRecord))
            {
                return false;
            }
            LogRecord Other = obj as LogRecord;

            return UserName.Equals(Other.UserName);
        }
    }
}
