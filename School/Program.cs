using System;
using System.Collections.Generic;

namespace School
{
    public class Major
    {
        public int code;
        public String name;

        public Major(int code, String name)
        {
            this.code = code;
            this.name = name;
        }
    }

    public class Student
    {
        public String id;
        public String name;
        public int grade;
        public List<Major> major;
        public DateTime birthDay;

        public Student(String id, String name, DateTime birthDay)
        {
            this.id = id;
            this.name = name;
            this.birthDay = birthDay;
        }

        public void AddMajor(int code, String name)
        {
            this.major.Add(new Major(code, name));
        }

        public void DeleteMajor(int code, String name)
        {
            this.major.Remove(new Major(code, name));
        }
    }



    public class Teacher
    {
        public String name;
        public Major major;

        public Teacher(String name, int code, String majorName)
        {
            this.name = name;
            this.major = new Major(code, majorName);
        }

        public Teacher(String name, Major major)
        {
            this.name = name;
            this.major = major;
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Hello C# World!");

            List<Teacher> teacherList = new List<Teacher>();
            SetTeacherList(teacherList);
        }

        static List<Teacher> SetTeacherList(List<Teacher> teacherList)
        {
            teacherList.Add(new Teacher("함기훈", 10, "정보컴퓨터"));
            teacherList.Add(new Teacher("박성래", 11, "수학"));
            teacherList.Add(new Teacher("민주리", 10, "정보컴퓨터"));
            teacherList.Add(new Teacher("박지김", 10, "정보컴퓨터"));
            teacherList.Add(new Teacher("김보경", 12, "가정"));
            teacherList.Add(new Teacher("장민주", 13, "디자인"));

            return teacherList;
        }
    }
}


