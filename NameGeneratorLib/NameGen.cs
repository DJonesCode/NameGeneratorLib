/* 
 NameGeneratorLib
 Author: Daniel Jones
 Date: 1/28/2022
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace NameGeneratorLib
{
    public static class NameGen
    {

        //Data for the male names list
        private static string MaleNamesFile = "NameGeneratorLib.MaleNames.txt";
        private static int MaleNames_Start = 6;
        private static int MaleNames_End = 2949;

        //Data for the female names list
        private static string FemaleNamesFile = "NameGeneratorLib.FemaleNames.txt";
        private static int FemaleNames_Start = 6;
        private static int FemaleNames_End = 5007;

        //Data for the surnames list
        private static string LastNamesFile = "NameGeneratorLib.LastNames.txt";
        private static int LastNames_Start = 3;
        private static int LastNames_End = 88025;

        public enum NAME_GENDER { MALE, FEMALE, OTHER };
        public enum NAME_OPTION { FULL_NAME, FIRST_NAME, SURNAME };

        private static Random Rand = new Random();

        /// <summary>
        /// Retrieves a random name with options for the the kind of name to retrieve.
        /// </summary>
        /// <param name="option">Determines if a first name, surname, or full name is returned.</param>
        /// <param name="gender">Determines if the name should be female, male, or either.</param>
        /// <returns>String of the name</returns>
        public static string GetName(NAME_OPTION option, NAME_GENDER gender)
        {
            string name = "";

            if (option == NAME_OPTION.FIRST_NAME || option == NAME_OPTION.FULL_NAME)
            {
                if (gender == NAME_GENDER.MALE)
                {
                    name += GetResourceEntry(MaleNamesFile, Rand.Next(MaleNames_Start, MaleNames_End));

                }
                else if (gender == NAME_GENDER.FEMALE)
                {
                    name += GetResourceEntry(FemaleNamesFile, Rand.Next(FemaleNames_Start, FemaleNames_End));
                }
                else
                {
                    //Generate a random name
                    if (Rand.Next(0, 2) == 1)
                    {
                        name += GetResourceEntry(MaleNamesFile, Rand.Next(MaleNames_Start, MaleNames_End));
                    }
                    else
                    {
                        name += GetResourceEntry(FemaleNamesFile, Rand.Next(FemaleNames_Start, FemaleNames_End));
                    }
                }
            }

            if (option == NAME_OPTION.FULL_NAME || option == NAME_OPTION.SURNAME)
            {
                //Add a space for full names
                if (option == NAME_OPTION.FULL_NAME)
                {
                    name += " ";
                }

                //Generate a last name
                name += GetResourceEntry(LastNamesFile, Rand.Next(LastNames_Start, LastNames_End));
            }

            return name;
        }

        /// <summary>
        /// Reads a line from the embedded resource file and returns its contents in string form.
        /// </summary>
        /// <param name="resourceName">The name of the resource.</param>
        /// <param name="start">The starting line to begin reading from.</param>
        /// <param name="end">The line to stop reading at.</param>
        /// <param name="lineNumber">The number of lines to read.</param>
        /// <returns>a single string line from the resource</returns>
        private static string GetResourceEntry(string resourceName, int lineNumber)
        {
            string result = "";
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                for (int i = 0; i < lineNumber - 1; i++)
                {
                    reader.ReadLine();
                }

                result += reader.ReadLine();
            }
            return result;
        }
    }
}
