using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntNode n = Arr2Node(new int[] { 1, 2, 3 });
            Console.WriteLine(n);

            AddAfterFirst(n, 4);
            Console.WriteLine(n); //1423

            AddAfterLast(n, 8);
            Console.WriteLine(n); //14238

            DeleteSecond(n);
            Console.WriteLine(n); //1238

            n = DeleteFirst(n);
            Console.WriteLine(n); //238

            n = AddBeforeFirst(n, 5);
            Console.WriteLine(n); //5238

            n = DeleteFirst(n);
            Console.WriteLine(n); //238


        }

        static IntNode Arr2Node(int[] arr)
        {
            IntNode first = new IntNode(arr[0]);
            IntNode curr = first;
            for (int i = 1; i < arr.Length; i++)
            {
                curr.SetNext(new IntNode(arr[i]));
                curr = curr.GetNext();
            }
            return first;
        }


        // 1
        // add after first
        // param1 : IntNode, param2: int
        // return : void
        // example: before: ->1->2->3, param2 = 4, after: ->1->4->2->3
        // note: IntNode isn't null

        static void AddAfterFirst(IntNode first, int num)
        {

        }

        // 2
        // add after last
        // param1 : IntNode, param2: int
        // return : void
        // example: before: ->1->2->3, param2 = 4, after: ->1->2->3->4
        // note: IntNode isn't null

        static void AddAfterLast(IntNode first, int num)
        {

        }

        // 3
        // delete second
        // param1 : IntNode
        // return : void
        // example: before: ->1->2->3, after: ->1->3
        // note: at least 2 nodes

        static void DeleteSecond(IntNode first)
        {
        }

        // 4
        // delete first
        // param1 : IntNode, param2
        // return : IntNode
        // example: before: ->1->2->3, after: ->2->3
        // note: IntNode isn't null
        // Q: why do we return IntNode and not void?
        // Q2: how do we use this in Main?

        static IntNode DeleteFirst(IntNode first)
        {
            return null;
        }


        // 5
        // add before first
        // param1 : IntNode, param2: int
        // return : IntNode
        // example: before: ->1->2->3, param2 = 4, after: ->4->1->2->3
        // note: IntNode isn't null
        // Q: why do we return IntNode and not void?
        // Q2: how do we use this in Main?

        static IntNode AddBeforeFirst(IntNode first, int num)
        {
            return null;
        }




    }
}
