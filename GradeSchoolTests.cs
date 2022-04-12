using System.Collections.Generic;
using Xunit;

namespace GradeSchool
{
    public class GradeSchoolTests
    {
        [Fact]
        public void Adding_a_student_adds_them_to_the_sorted_roster()
        {
            var gradeSchool = new School();
            gradeSchool.Add("Aimee", 2);
            var expected = new Dictionary<string, int>
            {
                {"Aimee", 2}
            };
            Assert.Equal(expected, gradeSchool.ShowRoster());
        }

        [Fact]
        public void Adding_more_students_adds_them_to_the_sorted_roster()
        {
            var gradeSchool = new School();
            gradeSchool.Add("Blair", 2);
            gradeSchool.Add("James", 2);
            gradeSchool.Add("Paul", 2);
            var expected = new Dictionary<string, int>
            {
                {"Blair", 2},
                {"James", 2},
                {"Paul", 2 },
            };
            Assert.Equal(expected, gradeSchool.ShowRoster());
        }
        
        [Fact]
        public void Adding_students_to_different_grades_adds_them_to_the_same_sorted_roster()
        {
            var sut = new School();
            sut.Add("Chelsea", 3);
            sut.Add("Logan", 7);
            var expected = new Dictionary<string, int>
            {
                {"Chelsea", 3},
                {"Logan", 7},
            }; 
            Assert.Equal(expected, sut.ShowRoster());
        }
        
        [Fact]
        public void Roster_returns_an_empty_list_if_there_are_no_students_enrolled()
        {
            var sut = new School();
            Assert.Empty(sut.ShowRoster());
        }

        [Fact]
        public void Student_names_with_grades_are_displayed_in_the_same_sorted_roster()
        {
            var sut = new School();
            sut.Add("Peter", 2);
            sut.Add("Anna", 1);
            sut.Add("Barb", 1);
            sut.Add("Zoe", 2);
            sut.Add("Alex", 2);
            sut.Add("Jim", 3);
            sut.Add("Charlie", 1);
            
            var expected = new Dictionary<string, int>() { 
                {"Anna", 1},
                {"Barb", 1},
                {"Charlie", 1},
                {"Alex", 2},
                {"Peter", 2},
                {"Zoe", 2},
                {"Jim", 3}
            };
            Assert.Equal(expected, sut.ShowRoster());
        }
        
        [Fact]
        public void Grade_returns_the_students_in_that_grade_in_alphabetical_order()
        {
            var sut = new School();
            sut.Add("Franklin", 5);
            sut.Add("Bradley", 5);
            sut.Add("Jeff", 1);
            var expected = new Dictionary<string, int>
            {               
                {"Bradley", 5},
                {"Franklin", 5},
            }; 
            Assert.Equal(expected, sut.Grade(5));
        }
        
        [Fact]
        public void Grade_returns_an_empty_list_if_there_are_no_students_in_that_grade()
        {
            var sut = new School();
            sut.Add("Jeff", 8);
            Assert.Empty(sut.Grade(1));
        }
    }
}