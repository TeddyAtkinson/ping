using System;
using System.Collections.Generic;

public class Ping
{
  static void Main()
  {
    int userNum = GetUserNum();
    NumArrayExpand(userNum);
  }

  static int GetUserNum(){
    Console.WriteLine("Enter a number: ");
    int userNum = int.Parse(Console.ReadLine());  //parse string to int
    return userNum;
  }

  static string NumArrayExpand(int userNum)
  {
    
    List<int> userNumList = new List<int>();

    for (int i = 1; i <= userNum; i++)
    {
      userNumList.Add(i);
      Console.WriteLine(i);
    }

    List<string> userString = new List<string>();

    foreach (int i in userNumList)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        userString.Add("ping-pong");
      }
      else if (i % 5 == 0)
      {
        userString.Add("pong");
      }
      else if (i % 3 == 0)
      {
        userString.Add("ping");
      }
      else
      {
        string intString = i.ToString();
        userString.Add(intString);
      }
    }

    string delim = ", ";
    string str = String.Join(delim, userString);
    Console.WriteLine(str);
    return str;

  }

}