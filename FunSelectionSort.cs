using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using static System.Console;
using static System.Math;

namespace FunSort
{
    class Funsort
    {
        static int _cnt;
        static void Main(string[] args)
        {
            _cnt = 0;
            int[] s = { 4123, 84, 22, 3, 97, 1, 6, 9, 413, 25555, 23, 252, 4, 8, 6849, 113, 554, 94, 74, 75, 46, 64 };
            WriteLine("配列要素数 : " + s.Length);
            WriteLine(string.Join(" ", s));
            WriteLine("*キー入力でセレクションソート");
            ReadLine();
            SelectionSort(s);
            WriteLine("*ソート完了");
            WriteLine("計算回数 : " + _cnt);
        }
        /// <summary>
        /// 選択ソートを行う関数
        /// 計算量はO(n^2)で非常に低速
        /// Swap関数を用いる
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void SelectionSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Clear();
                int min = i;    // 最小値のインデックス保持用
                                // このループが終われば min には最小値のインデックスが入ることになる
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min].CompareTo(array[j]) > 0)
                    {
                        min = j;
                    }
                    _cnt++;
                }
                // 見つかった最小値の値を交換する
                Swap(ref array[min], ref array[i]);
                WriteLine(string.Join(" ", array));
                System.Threading.Thread.Sleep(100);
            }
        }

        /// <summary>
        /// aとbをスワップさせる関数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap<T>(ref T a, ref T b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }
    }
}