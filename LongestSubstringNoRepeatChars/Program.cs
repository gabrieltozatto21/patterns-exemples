using System;
using System.Collections.Generic;

namespace LongestSubstringNoRepeatChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LevelOrder(new Node(1, new List<Node> { new Node(2, new List<Node>()), new Node(3, new List<Node> { new Node(6), new Node(7, new List<Node> { new Node(11, new List<Node> { new Node(14) }) }) }), new Node(4, new List<Node> { new Node(8, new List<Node> { new Node(12) })}), new Node(5, new List<Node> { new Node(9, new List<Node> { new Node(13) }), new Node(10) }) })));
            // Console.WriteLine(MissingInteger(new int[] {3,4,5,1,12,14,13,15,16,17,18,19,20,21}));
            // Console.WriteLine(MissingInteger(new int[] {4,5,6,7,8,8,9,4,3,2,7}));
            // Console.WriteLine(MissingInteger(new int[] {38}));
            // Console.WriteLine(MissingInteger(new int[] {46,8,2,4,1,4,10,2,4,10,2,5,7,3,1}));
            // Console.WriteLine(MissingInteger(new int[] {3,4,5,1,12,14,13}));
            // Console.WriteLine(MissingInteger(new int[] {1,2,3,9,2,10,8,3,10,2}));
            // Console.WriteLine(MissingInteger(new int[] {1,2,3,9,8,7,6,5,4,3,10}));
        }

        public int LengthOfLongestSubstring(string s) {
            int maxLength = 0;
            int left = 0;
            
        }

    }
}

