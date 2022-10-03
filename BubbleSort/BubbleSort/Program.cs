﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        // Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()

        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)

            {
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);

            }
        }
        public void display()
        {
            // Menampilkan Array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Elemen array yang telah tersusun ");
            Console.WriteLine("----------------------------------");
            for (int j = 0; j < n; j++)
            {
            
                Console.WriteLine(a[j]);

            }
            Console.WriteLine("");
        }

        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // For n - 1 passes
            {
                // Pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya

                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                    }
                }
            }
        }

        static void main(string[] args)
        {
            // Creating the object of the BubbleSort class
            program mylist = new program();

            // Pemanggilan fungsi untuk menerima elemen array
            mylist.read();
            // Pemanggilan fungsi untuk mengurutkan array
            mylist.BubbleSortArray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();
            // Exit
            Console.WriteLine("n\nTekan Tombol apa saja untuk keluar .");
            Console.Read();
        }
    }
}

    
