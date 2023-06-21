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
        //Arrange(koþul)
        var hero = new Controller();
        //Act(test)
        float x = hero.CalculateMovement(1, 0, 1, 1).x;
        //Assert(sonuç)
        Assert.AreEqual(1, x);
    }


    [Test]
    public void VerticalTest() 
    {
        //Arrange(koþul)
        var hero = new Controller();
        //Act(test)
        float z = hero.CalculateMovement(0, 1, 1, 1).z;
        //Assert(sonuç)
        Assert.AreEqual(1, z);
    }
   
}
