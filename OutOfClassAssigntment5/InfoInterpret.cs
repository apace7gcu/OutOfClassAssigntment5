using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfClassAssignment5
{/*
  *Amanda Pace
  *CST 117
  *Bill Hughes
  *12/20/2020
  *
  *Out of Class Assignment 5
  *
  *This is my own work.
  */
    public class InfoInterpret
    {
        /// <summary>
        /// Method that converts the birth year into a number based on criteria
        /// </summary>
        /// <param name="yearNum"></param>
        /// <returns></returns>
        public int convertYear (int yearNum)
        {
            //Different values are assigned to an int based on the year entered


            //Assigning variable
            int convertNum = 0;


            if (yearNum >= 2000)
            {
                convertNum = 5;
            }
            else if ( yearNum < 2000 && yearNum >= 1980)
            {
                convertNum = 10;
            }
            else if (yearNum < 1980 && yearNum >= 1960)
            {
                convertNum = 15;
            }
            else
            {
                convertNum = 20;
            }

            return (convertNum);
        }

        /// <summary>
        /// Method that converts month of birth into a number based on criteria
        /// </summary>
        /// <param name="monthName"></param>
        /// <returns></returns>
        public int convertMonth (string monthName)
        {
            //Assigning Variables

            int stringLength = monthName.Length;

            int monthNum;

            //If/else determines if number of characters is odd or even
            //If even, divides by two; or subtracts one then divides by 2.
            //Number of characters at the end is what is returned.

            if (stringLength % 2 == 0)
            {
                monthNum = stringLength/2;
            }

            else
            {
                monthNum = (stringLength - 1) / 2;
            }

            return monthNum;

        }

        /// <summary>
        /// Method that converts day into number based on criteria
        /// </summary>
        /// <param name="dayNum"></param>
        /// <returns></returns>
        public int convertDay (int dayNum)
        {
            //Based on how high the number is, substracts from it and returns the difference


            if (dayNum > 10 && dayNum <= 15)
            {
                return dayNum - 5;
            }
            else if (dayNum > 15 )
            {
                return dayNum - 10;
            }

            return dayNum;
        }
        /// <summary>
        /// Method that converts color to number based on criteria
        /// </summary>
        /// <param name="colorName"></param>
        /// <returns></returns>
        public int convertColor (string colorName)
        {
            //Assigning Variables

            string lowerColor = colorName.ToLower();

            int colorNum;


            //If statements determine color selected and assign a number based on that
            if (lowerColor == "red" || lowerColor == "orange" || lowerColor == "yellow")
            {
                colorNum = 1;
            }
            else if (lowerColor == "green" || lowerColor == "blue" || lowerColor == "purple")
            {
                colorNum = 2;
            }
            else if (lowerColor == "pink" || lowerColor == "white" || lowerColor == "grey")
            {
                colorNum = 3;
            }
            else
            {
                colorNum = 1/2;
            }

            return colorNum;
        }
    }
}
