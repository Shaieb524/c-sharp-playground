﻿using System;
using PesonalPasswordManager.Helpers;
using System.Data.SqlClient;

namespace PesonalPasswordManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey Bitch! you are a bitch cuz you r here :D");
            Console.WriteLine("Enter your master fookin password bitch..");

            string masterPassword = Console.ReadLine();

            // TODO get from env
            if (masterPassword != "123")
            {
                Console.WriteLine("Get da fuck outa here bitch ╭∩╮ .|. ");
            }
            else
            {
                Console.WriteLine("Welcome bitch *P");
                Console.WriteLine("Getting Connection ...");

                // TODO get from env
                var datasource = @"localhost";
                var database = "my_passes";
                var username = "sa"; 
                var password = "22419945As"; 

                string connString = @"Data Source=" + datasource + ";Initial Catalog="
                            + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

                SqlConnection conn = new SqlConnection(connString);
                try
                {
                    Console.WriteLine("Openning Connection ...");
                    conn.Open();
                    Console.WriteLine("Connection successful!");



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    Environment.Exit(0);
                }

                var helper = new ConsoleHelper();

                Console.WriteLine("What you fuckin want bithc?");
                Console.WriteLine("1: Check old password");
                Console.WriteLine("2: Add a new password");
                Console.WriteLine("3: Just say hi!");
                string Purpose = Console.ReadLine();

                switch (Purpose)
                {
                    case "1":
                        helper.CheckOldPassword(conn);
                        break;

                    case "2":
                        helper.AddNewServicePassword(conn);
                        break;

                    case "3":
                        Console.WriteLine("333");
                        break;
                }

                Console.Read();
            }
        }


    }
}

