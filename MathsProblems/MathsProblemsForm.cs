using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace MathsProblems
{   //  https://projecteuler.net
    public partial class MathsProblemsForm : Form
    {
        delegate string DecisionProblemMethod();

        private static MathsProblemsForm form;

        public MathsProblemsForm()
        {
            InitializeComponent();

            form = this;
        }

        private void RunTest(DecisionProblemMethod method)
        {
            if (method == null)
                return;

            this.ResultTextBox.Clear();
            var task = new Task(() => {
                MathsProblemsForm.Log("========================Start=======================");
                MathsProblemsForm.Log(method.ToString());
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var res = method();
                watch.Stop();
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds,
                    watch.Elapsed.Milliseconds / 10);
                MathsProblemsForm.Log("========================Finnish=====================");
                MathsProblemsForm.Log("Result:");
                MathsProblemsForm.Log(res);
                MathsProblemsForm.Log("");
                MathsProblemsForm.Log("Time: ");
                MathsProblemsForm.Log(elapsedTime);
                MathsProblemsForm.Log("========================Finnish=====================");
            });
            task.Start();
        }

        internal static void Log(string str)
        {

            if (form != null)
            {
                form.Invoke(new Action(() =>
                {
                    form.ResultTextBox.AppendText(str + Environment.NewLine);
                }));
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            RunAllTests();
        }

        private void RunAllTests()
        {
            //this.RunTest(Problem1.Multiples_of_3_and_5);
            //this.RunTest(Problem2.Even_Fibonacci_numbers);
            //this.RunTest(Problem3.Largest_prime_factor);
            //this.RunTest(Problem4.Largest_palindrome_product);
            //this.RunTest(Problem5.Smallest_multiple);
            //this.RunTest(Problem6.Sum_square_difference);
            //this.RunTest(Problem7.st_prime);
            //this.RunTest(Problem8.Largest_product_in_a_series);
            //this.RunTest(Problem9.Special_Pythagorean_triplet);
            //this.RunTest(Problem10.Summation_of_primes);
            //this.RunTest(Problem11.Largest_product_in_a_grid);
            //this.RunTest(Problem12.Highly_divisible_triangular_number);
            //this.RunTest(Problem13.Large_sum);
            //this.RunTest(Problem14.Longest_Collatz_sequence);
            //this.RunTest(Problem15.Lattice_paths);
            //this.RunTest(Problem16.Power_Digit_Sum);
            //this.RunTest(Problem17.Number_Letter_Counts);
            //this.RunTest(Problem18.Maximum_path_sum_I);
            //this.RunTest(Problem19.Counting_Sundays);
            //this.RunTest(Problem20.Factorial_digit_sum);
            //this.RunTest(Problem21.Amicable_numbers);
            //this.RunTest(Problem22.Names_scores);
            //this.RunTest(Problem23.Non_abundant_sums);
            //this.RunTest(Problem24.Lexicographic_permutations);
            //this.RunTest(Problem25.Thousannd_digit_Fibonacci_number);
            //this.RunTest(Problem26.Reciprocal_cycles);
            //this.RunTest(Problem27.Quadratic_primes);
            //this.RunTest(Problem28.Number_spiral_diagonals);
            //this.RunTest(Problem29.Distinct_powers);
            //this.RunTest(Problem30.Digit_fifth_powers);
            //this.RunTest(Problem31.Coin_sums);
            //this.RunTest(Problem32.Pandigital_products);
            //this.RunTest(Problem33.Digit_cancelling_fractions);
            //this.RunTest(Problem34.Digit_factorials);
            //this.RunTest(Problem35.Circular_primes);
            //this.RunTest(Problem36.Double_base_palindromes);
            //this.RunTest(Problem37.Truncatable_primes);
            //this.RunTest(Problem38.Pandigital_multiples);
            //this.RunTest(Problem39.Integer_right_triangles);
            //this.RunTest(Problem40.Champernownes_constant);
            //this.RunTest(Problem41.Pandigital_prime);
            //this.RunTest(Problem42.Coded_triangle_numbers);
            //this.RunTest(Problem43.Sub_string_divisibility);
            //this.RunTest(Problem44.Pentagon_numbers);
            this.RunTest(Problem45.Triangular_pentagonal_and_hexagonal);

        }


    }

  
}
