using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MoveTest
{
    
    [Test]

    public void HorizontalTest()
    {
        //Arrange(ko�ul)
        var hero = new Controller();
        //Act(test)
        float x = hero.CalculateMovement(1, 0, 1, 1).x;
        //Assert(sonu�)
        Assert.AreEqual(1, x);
    }


    [Test]
    public void VerticalTest() 
    {
        //Arrange(ko�ul)
        var hero = new Controller();
        //Act(test)
        float z = hero.CalculateMovement(0, 1, 1, 1).z;
        //Assert(sonu�)
        Assert.AreEqual(1, z);
    }
   
}
