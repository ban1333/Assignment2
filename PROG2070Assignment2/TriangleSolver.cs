using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROG2070Assignment2
{
    public static class TriangleSolver
    {
        /// <summary>
        /// returns a string telling the user if the number is a triangle or not
        /// if it is a triangle, it says what kind of triangle it is
        /// </summary>
        /// <param name="dimensionOne"></param>
        /// <param name="dimensionTwo"></param>
        /// <param name="dimensionThree"></param>
        /// <returns></returns>
        public static string Analyze(int dimensionOne, int dimensionTwo, int dimensionThree)
        {
            string retValue = "";

            //is it a triangle
            if(dimensionOne + dimensionTwo > dimensionThree &&
               dimensionOne + dimensionThree > dimensionTwo &&
               dimensionTwo + dimensionThree > dimensionOne)
            {
                //numbers form to make a triangle


                //what kind of triangle is it?
                //testing for scalene triangle
                if(dimensionOne != dimensionTwo &&
                   dimensionOne != dimensionThree &&
                   dimensionTwo != dimensionThree)
                {
                    retValue += "a Scalene";
                }
                //testing for equilateral triangle
                else if(dimensionOne == dimensionTwo &&
                        dimensionTwo == dimensionThree)
                {
                    retValue += "an Equilateral";
                }
                else
                {
                    retValue += "an Isosceles";
                }
            }
            else
            {
                //not a triangle
                retValue = "";
            }

            return retValue;
        }
    }
}
