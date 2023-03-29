using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab1_NET;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            for (int cap_of_knapsack = 10; cap_of_knapsack <= 50; cap_of_knapsack += 10)
             {
              for (int n_items = 1; n_items <= cap_of_knapsack; n_items++)
               {         
                  Knapsack knapsack = new Lab1_NET.Knapsack(n_items);
                  Problem problem = new Problem(cap_of_knapsack, knapsack);
                  Assert.AreEqual(n_items, problem.vOpt);
                  Assert.AreEqual(20, problem.vOpt);  
                }
             }
        }
    }
}
