using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeSchool
{
    public class School
    {
        private Dictionary<string, int> Roster = new Dictionary<string, int>();
        
        public void Add(string student, int grade)
        {
            if (!Roster.ContainsKey(student))
            { 
                Roster.Add(student, grade);
            }
        }

        public Dictionary<string, int> ShowRoster()
        {
            return SortedRoster();
        }

        public Dictionary<string, int> SortedRoster()
        {
            return new Dictionary<string, int>(Roster.OrderBy(i => i.Key));

        }

        public Dictionary<string, int> Grade(int grade)
        { 
            var studentsInGrade = new Dictionary<string, int>();
            var sortedByName = SortedRoster();
          foreach (var student in sortedByName)
          {
              if (student.Value == grade)
              {
                 studentsInGrade.Add(student.Key, student.Value);
              }
          }
          return studentsInGrade;
        }
    }
}