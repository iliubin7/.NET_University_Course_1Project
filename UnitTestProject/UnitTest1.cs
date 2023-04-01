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
                  /*  int w = 0, v = 0, wopt=0, vopt=0;
                    while(wopt <= cap_of_knapsack)
                    {
                      
                        wopt += itemList[n_items].value;
                    } */
                  Assert.AreEqual(n_items, problem.wOpt);
                  Assert.AreEqual(20, problem.vOpt);  
                }
             }
        }

        // Test sprawdzajacy przypadek, gdy ladownosc plecaka wynosi 0
        [TestMethod]
        public void TestMethod2() 
        {
            for (int n_items = 1; n_items <= 50; n_items++)
            {
            Knapsack knapsack = new Lab1_NET.Knapsack(n_items);
            Problem problem = new Problem(0, knapsack);
            Assert.AreEqual(-1, problem.wOpt); // jesli ladownosc plecaka wynosi 0, to wartosc optymalna przyjmie wartosc -1
            }
        }
    }
}
