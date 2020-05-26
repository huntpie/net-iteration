using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

  public static class Iteration
  {
    /*
       Welcome to Interation
       Down below you will find instructions for code to write.
       As you write and save your code, you can look in your terminal where you
       ran `dotnet watch test` to see if your code is working. The tests continuously check
       your work each time you save. If a test is failing you have not yet completed that method
       Once you finish a method and have it correct, the test will tell you how
       the next method is working.
    */


    //  
    // 1) Complete the method named `yelling` that takes an list of
    //    words as an argument and returns a new list with all
    //    the words forced to uppercase.
    //


    public static IEnumerable<string> Yelling(List<string> words)
    {
      var upperCase = words.Select(x => x.ToUpper()).ToList();
      return upperCase;
      //throw new System.NotImplementedException();
    }


    // 
    // 2) Complete the method named `Double` that takes an list of
    //    numbers as an argument and returns a new list with all
    //    the numbers multiplied by 2.
    // 
    public static IEnumerable<int> Double(List<int> numbers)
    {

      var result = numbers.Select(n => n * 2);
      foreach (var item in result)
      {
        Console.WriteLine(item);
      }
      return result;
      throw new System.NotImplementedException();
    }


    // 
    // 3) Complete the method `StringyIndexes` that takes an list of
    //    strings as an argument and returns a new list with each
    //    string suffixed with " is at index X" where X is the index
    //    of the element.
    // 
    public static IEnumerable<string> StringyIndexes(List<string> data)
    {
      List<string> data2 = new List<string>();
      foreach (string item in data)
      {
        int index = data.IndexOf(item);
        string itemIndexOf = item + " is at index " + index;
        string suffixedElement = String.Join(null, itemIndexOf);
        data2.Add(suffixedElement);
      }
      return data2;
      //int index = data.FindIndex(item);
      //var suffixedElement = String.Join(" is at index " + index, data);
      // data2.Add(suffixedElement);

      //throw new System.NotImplementedException();

    }


    // 
    // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
    //    numbers and returns only the elements that are even.
    // 
    public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
    {
      List<int> data2 = new List<int>();
      foreach (var number in data)
      {
        if (number % 2 == 0)
        {
          data2.Add(number);
        }
        else
        {
          data2.Remove(number);
        }
      }
      return data2;
      throw new System.NotImplementedException();
    }


    // 
    // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts an
    //    list of numbers and returns only the elements at indexes that
    //    are even.
    // 
    public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
    {
      var odd = data.ToList().Where((c, i) => i % 2 != 0);
      var even = data.ToList().Where((c, i) => i % 2 == 0);
      return even;
      throw new System.NotImplementedException();
    }


    // 
    // 6) Complete the method BestMoviesOfTheYear that accepts an list of
    //    movie objects AND a year and returns the names of movies that are
    //    from that year AND have a score more than 90.
    // 
    // A movie object looks like this:
    // 
    // {
    //   name: "Get Out",
    //   year: "2017",
    //   score: 99
    // }
    // 

    public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
    {
      //accepts a list of objects && year
      //returns string of names of movies from year and object(score) > 90

      var nameYearScore = data.Select(movie => $"{movie.Name}, {movie.Year}, {movie.Score} ");
      List<string> names = new List<string>();

      foreach (var mov in data)
      {
        if (mov.Year == year && mov.Score > 90)
        {
          var namer = mov.Name;
          string nameString = namer.ToString();
          names.Add(nameString);
        }
      }
      return names;




      throw new System.NotImplementedException();
    }


    // 
    // 7) Complete the method EveryoneIsOdd that accepts an list of
    //    numbers and returns true if every element of the list is odd.
    // 
    public static bool EveryoneIsOdd(List<int> data)
    {
      if (data.TrueForAll(x => x % 2 != 0))
      {
        return true;
      }
      else
      {
        return false;
      }

      throw new System.NotImplementedException();
    }


    // 
    // 8) Complete the method FindTheNeedle that accepts an list of
    //    strings and returns the one string that contains the word
    //    `needle`.
    // 
    public static string FindTheNeedle(List<string> data)
    {

      foreach (string s in data)
      {
        var dataSetUp = s.Contains("needle");
        if (dataSetUp == true)
        {
          return s;
        }
      }



      throw new System.NotImplementedException();
    }


    // 
    // 9) Complete the method FindTheNeedleIndex that accepts an list of
    //    strings and returns the index of the string that contains
    //    the word `needle` inside.
    // 
    public static int FindTheNeedleIndex(List<string> data)
    {
      foreach (string s in data)
      {
        var dataSetUp = s.Contains("needle");
        if (dataSetUp == true)
        {
          return data.IndexOf(s);
        }
      }
      throw new System.NotImplementedException();
    }


    // 
    // 10) Complete the method SomeoneToLove that accepts an list of
    //     strings and returns true if at least one string is exactly
    //     four characters long.
    // 
    public static bool SomeoneToLove(List<string> data)
    {
      bool result = data.Any(val => val.Length == 4);
      return result;
      throw new System.NotImplementedException();
    }
  }
}