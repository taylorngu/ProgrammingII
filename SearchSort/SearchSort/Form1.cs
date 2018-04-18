using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; 
using System.Threading.Tasks;

namespace SearchSort
{
    public partial class Form1 : Form
    {

        #region FileI/O

        static string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\dataToSort.txt";

        static string[] readText = File.ReadAllLines(fileName);

        int[] unsorted = Array.ConvertAll(readText, Int32.Parse);

        public void FileWrite()
        {
            string sortedFileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\sortedData.txt";

            string[] numbers2 = Array.ConvertAll<int, string>(unsorted, new Converter<int, string>(s => s.ToString()));

            File.WriteAllLines(sortedFileName, numbers2);

        }

        #endregion

        public static int[] numbers = { 15, 2, 5, 8, 3, 34, 64, 12, 11, 32, 23, 82, 9, 78, 25, 67, 56, 73, 90, 1 };
        int[] copy = new int[numbers.Length];
        int wrap = 0;
        string print = "";
        bool run = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Array.Copy(numbers, copy, numbers.Length);
            wrap = 0;
            print = "";

            if (radSelection.Checked == true)
            {
                lstOutput.Items.Add("Selection Sort:");
                selectionSort(copy);

            }
            else if (radInsert.Checked == true)
            {
                lstOutput.Items.Add("Insertion Sort:");
                insertionSort(copy);
            }
            else if (radMerge.Checked == true)
            {
                lstOutput.Items.Add("Merge Sort:");
                MergeSort(copy);
            }
            else if (radBubble.Checked == true)
            {
                lstOutput.Items.Add("Bubble Sort:");
                bubbleSort(copy);
            }
            else if (radQuick.Checked == true)
            {
                lstOutput.Items.Add("QuickSort:");
                QuickSorting(copy, 0, copy.Length - 1);
            }
            else if (radRad.Checked == true)
            {
                lstOutput.Items.Add("Radix Sort:");
                RadixSort(copy);
            }
            else
            {
                MessageBox.Show("Please select a sort method");
                run = false;
            }

            //to print to list (with wrap text)
            if (run == true)
            {
                ArrayPrint(copy); 
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            int input = Convert.ToInt16(txtNumber.Text);
            bool found = false;


            if (radLin.Checked == true)
            {
                found = linearSearch(input);
                lstOutput.Items.Add("Using Linear Search...");
            }
            else if (radBin.Checked == true)
            {
                found = binarySearch(input, numbers);
                lstOutput.Items.Add("Using Binary Search...");
            }
            else
            {
                MessageBox.Show("Please select a search method");
                run = false;
            }

            if (run == true)
            {
                if (found == true)
                {
                    lstOutput.Items.Add(String.Format("Found: {0}", input));
                    lstOutput.Items.Add("");
                }
                else
                {
                    lstOutput.Items.Add(String.Format("Not Found: {0}", input));
                    lstOutput.Items.Add("");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Add("Original Array:");
            ArrayPrint(numbers); 
        }

        public void ArrayPrint(int[] array) // **PRINTS ARRAY TO THE LISTBOX WITH TEXTWRAP INCLUDED**
        {
            print = "";
            wrap = 0;

            foreach (int x in array)
            {
                print += x + ", ";
                wrap++;

                if (wrap == 15)
                {
                    lstOutput.Items.Add(print);
                    print = "";
                    wrap = 0;
                }
            }
            char[] MyChar = { ',', ' ' };
            lstOutput.Items.Add(print.TrimEnd(MyChar));
            lstOutput.Items.Add("");

        }

        #region Menu
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        //Searches

        #region LinearSearch
        public bool linearSearch(int input)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == input)
                {
                    return true;
                }
            }
            return false;

        }
        #endregion

        #region BinarySearch
        public bool binarySearch(int input, int[] numbers)
        {
            Array.Sort(numbers);

            int min = 0;
            int max = numbers.Length - 1;
            int mid = (min + max) / 2;
            int index = -1;

            do
            {
                if (numbers[mid] == input)
                {
                    index = mid;
                }
                else if (numbers[mid] < input)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }

                mid = (min + max) / 2;
            } while ((min <= max) && (index == -1));

            if (index != -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion

        //Sorts

        #region SelectionSort
        public int[] selectionSort(int[] numbers)
        {
            int smallestVal;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                smallestVal = i;

                for (int index = i; index < numbers.Length; index++)
                {
                    if (numbers[index] < numbers[smallestVal])

                        smallestVal = index;
                }

                if (smallestVal != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[smallestVal];
                    numbers[smallestVal] = temp;
                }
            }
            return numbers;
        }
        #endregion

        #region InsertionSort
        public int[] insertionSort(int[] numbers)
        {
            int insertVal;

            for (int next = 1; next < numbers.Length; next++)
            {
                insertVal = numbers[next];
                int move = next;

                while (move > 0 && numbers[move - 1] > insertVal)
                {
                    numbers[move] = numbers[move - 1];
                    move--;
                }

                numbers[move] = insertVal;
            }

            return numbers;
        }
        #endregion

        #region BubbleSort
        public int[] bubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                int numberOfSwaps = 0;
                for (int j = 0; j < numbers.Length - 1; j++)
                {

                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        numberOfSwaps++;
                    }
                }

                if (numberOfSwaps == 0)
                    break;
            }
            return numbers;
        }
        #endregion

        #region MergeSort
        public static void MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                MergeSortAlgorithm.Merge(input, low, middle, high);

            }
        }

        public void MergeSort(int[] input)
        {
            MergeSort(input, 0, input.Length - 1);
        }
        public class MergeSortAlgorithm
        {
            public static long MergeSort(int[] input, int low, int high)
            {
                if (low == high)
                    return 0;
                else
                {
                    long inversionCount = 0;
                    int middle = (low / 2) + (high / 2);
                    inversionCount += MergeSort(input, low, middle);
                    inversionCount += MergeSort(input, middle + 1, high);
                    inversionCount += Merge(input, low, middle, high);
                    return inversionCount;
                }
            }

            public long MergeSort(int[] input)
            {
                return MergeSort(input, 0, input.Length - 1);
            }

            public static long Merge(int[] input, int low, int middle, int high)
            {

                int left = low;
                int right = middle + 1;
                int[] tmp = new int[(high - low) + 1];
                int tmpIndex = 0;
                long inversionCount = 0;

                while ((left <= middle) && (right <= high))
                {
                    if (input[left] > input[right])
                    {
                        tmp[tmpIndex] = input[right];
                        right = right + 1;
                        inversionCount += ((middle - left) + 1);
                    }
                    else
                    {
                        tmp[tmpIndex] = input[left];
                        left = left + 1;
                    }
                    tmpIndex = tmpIndex + 1;
                }

                if (left <= middle)
                {
                    while (left <= middle)
                    {
                        tmp[tmpIndex] = input[left];
                        left = left + 1;
                        tmpIndex = tmpIndex + 1;
                    }
                }

                if (right <= high)
                {
                    while (right <= high)
                    {
                        tmp[tmpIndex] = input[right];
                        right = right + 1;
                        tmpIndex = tmpIndex + 1;
                    }
                }

                for (int i = 0; i < tmp.Length; i++)
                {
                    input[low + i] = tmp[i];
                }
                return inversionCount;
            }
        }
        #endregion 

        #region QuickSort
        public int[] QuickSort(int[] numbers)
        {
            return QuickSorting(numbers, 0, numbers.Length - 1);
        }

        private int[] QuickSorting(int[] numbers, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (numbers[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSorting(numbers, left, j);
            }

            if (i < right)
            {
                QuickSorting(numbers, i, right);
            }

            return numbers;

        }

        #endregion 

        #region RadixSort
        public void RadixSort(int[] numbers)
        {
            int i, j;
            int[] tmp = new int[numbers.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < numbers.Length; ++i)
                {
                    bool move = (numbers[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        numbers[i - j] = numbers[i];
                    else
                        tmp[j++] = numbers[i];
                }
                Array.Copy(tmp, 0, numbers, numbers.Length - j, j);
            }
        }
        #endregion 

    }
}



