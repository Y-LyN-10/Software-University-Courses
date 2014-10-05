using System;

namespace SchoolSystem
{
    public class TestSchoolSystem
    {
        static void Main()
        {
            var someSchool = new School();
            var eveningClass = new Class("Level#2");
            var trainer = new Teacher("Mr. NakMan");
            var disciplineClassA = new Discipline("OOP", 2, 2);

            var firstStudent = new Student("Anamalech", 1);
            var thirdStudent = new Student("Corson", 3);
            var secondStudent = new Student("Boruta", 2);
            var forthStudent = new Student("Lucifer", 4);

            //Okay. Let's summon the demons... pardon, Demos!
            someSchool.AddClass(eveningClass);
            eveningClass.AddTeacher(trainer);
            trainer.AddDiscipline(disciplineClassA);
            
            eveningClass.AddStudent(firstStudent);
            eveningClass.AddStudent(secondStudent);
            eveningClass.AddStudent(thirdStudent);
            eveningClass.AddStudent(forthStudent);

            Console.WriteLine(eveningClass.ToString());
            Console.WriteLine();
        }
    }
}
