// See https://aka.ms/new-console-template for more information
using System;
using VotingApp.Enums;
using VotingApp.Models;
using VotingApp.Repositories;
using VotingApp.Menu;

namespace VotingApp.Menu
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu.WelcomePage();
        }
    }
}