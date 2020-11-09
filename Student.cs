using System;
using System.Collections.Generic;
using System.Text;

namespace DClass
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;

        Student() { }
        Student(string id, string name, string depart, float cgpa)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.cgpa = cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("id:" + id);
            Console.WriteLine("department:" + department);
            Console.WriteLine("cgpa:" + cgpa );

        }

    }
