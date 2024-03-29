using System;
// Created a bad habit goal category where the user loses points if he does that bad habit
// and loses a bonus points if he does as many times as he sets it. 
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}