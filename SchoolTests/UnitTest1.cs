using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace SchoolTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Teacher> Teachers = new List<Teacher>();
            Program.setTeacherList(Teachers);

            Assert.AreEqual("함기훈", Teachers[0].name, "실패");
        }

        [TestMethod]
        public void T01_add_major()
        {
            Student student = new Student("3117", "이지아", new DateTime(2002, 07, 07));
            student.addMajor(0, "정보컴퓨터");
        }

        
    }
}
