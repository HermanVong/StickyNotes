﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StickyNotes.Models;

namespace StickyNotes.UnitTest.Models
{
    [TestClass]
    public class NotificationTest
    {
        [TestMethod]
        public void TestNotification()
        {
            string id = "555555";
            //string id2 = "3124123";
            Notification toast = new Notification();
            int now = toast.Show().Count;
            toast.Create(DateTime.Now.AddMinutes(5), id);
            Assert.AreEqual(1 + now, toast.Show().Count);
            //toast.Delete(id2);
            //Assert.AreEqual(1 + now, toast.Show().Count);
            toast.Delete(id);
            Assert.AreEqual(now, toast.Show().Count);
        }

    }
}
