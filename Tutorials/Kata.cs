using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Tutorials
{
    
    
public static class Kata
{
  public static string Likes(string[] name)
  {
    if (name.Length == 0 ){
      return "no one likes this";
    }
    else if (name.Length == 1){
      return $"{name[0]} likes this";
    }
    else if (name.Length == 2){
      return $"{name[0]} and {name[1]} like this";
    }
   else if (name.Length == 3){
      return $"{name[0]}, {name[1]} and {name[2]} like this";
    }
  else{
      return $"{name[0]}, {name[1]} and {name.Length-2} others like this";
    }
  }
}
    
  [TestFixture]
  public class SolutionTest
  {
    [Test, Description("It should return correct text")]
    public void SampleTest()
    {
      Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
      Assert.AreEqual("Peter likes this", Kata.Likes(new string[] {"Peter"}));
      Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] {"Jacob", "Alex"}));
      Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] {"Max", "John", "Mark"}));
      Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}));
    }
  }
    
    
}
