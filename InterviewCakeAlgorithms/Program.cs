using System;
using System.Collections.Generic;

namespace InterviewCakeAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(hasTwoMoviesForFlight(30, 
                new int[]{ 11, 15, 12, 20, 10 }));

            Console.WriteLine(canTwoMoviesFillFlight(30,
                new int[] { 11, 15, 12, 20, 10 }));

        }

        //My solution
        public static bool hasTwoMoviesForFlight(int flight_length,
                                                 int[] movie_lengths)
        {
            HashSet<int> needed_lengths = new HashSet<int>();

            for (int i = 0; i < movie_lengths.Length; i++)
            {
                if (needed_lengths.Contains(flight_length - movie_lengths[i]))
                    return true;

                needed_lengths.Add(movie_lengths[i]);
            }

            return false;
        }

        //InterviewCake's solution
        public static bool canTwoMoviesFillFlight(int flight_length,
                                                  int[] movie_lengths)
        {
            HashSet<int> needed_lengths = new HashSet<int>();

            for (int i = 0; i < movie_lengths.Length; i++)
            {
                int matchingMovingLength = flight_length - movie_lengths[i];
                if (needed_lengths.Contains(matchingMovingLength))
                    return true;

                needed_lengths.Add(movie_lengths[i]);
            }

            return false;
        }
    }
}
