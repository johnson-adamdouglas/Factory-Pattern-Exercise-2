using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What database type would you like to use? Type list, sql, or mongo");

            var preferredType = Console.ReadLine().ToLower();

            IDataAccess database = DataAccessFactory.GetDataAccessType(preferredType);
            database.LoadData();
            database.SaveData();

//            In one solution, you will need to create some new types.
//DONE A class called Product with 2 properties, Name and Price
//DONE An interface called IDataAccess with 2 methods, LoadData() and SaveData()
//DONE 3 classes that implement the interface and its members(the methods), ListDataAccess, SQLDataAccess, and MongoDataAccess
//DONE Last you will need to create a class called DataAccessFactory


//The 3 classes that implement your IDataAccess interface should provide implementations for the 2 methods
//LoadData(): Just print to the console “I am reading data from {whatever type class this is, i.e: list, SQL database, mongo database
//    }” and then return a new list of Product.
//SaveData(): Print “I am saving data to a { whatever type }
//    database” to the console


//Once those 3 classes have the methods implemented, you will need to fill out your factory
//DONE This shall be a public static class
//DONE There will be one method with the following signature: 				public static IDataAccess GetDataAccessType(string databaseType)
//DONE Switch on the databaseType variable
//DONE If a user types in “list” this should return a new instance of the ListDataAccess
//DONE If a user types in “sql” this should return a new instance of the SQLDataAccess
//DONE If a user types in “mongo” this should return a new instance of the MongoDataAccess


//Lastly in the Main()
//Ask the user what database they want to use: a List, SQL, or Mongo
//Store their response in a variable
//Call your factory method and pass in what the user types and store what your factory method returns in an IDataAccess variable
//Call the LoadData and SaveData methods of the IDataAccess variable
//Run the program a few times using the different types.

        }
    }
}
