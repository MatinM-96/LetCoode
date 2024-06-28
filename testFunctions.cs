using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lettCode;


namespace lettCode
{


    public class testFunctions
    {


      public void addTwoNumbersTest()
        {

            Node head1 = new Node(0);


            Node num1 = head1;
            num1.value = 2;
            num1.next = new Node(4);
            num1 = num1.next;
            num1.next = new Node(3);


            //declre the second list


            Node head2 = new Node(0);


            Node secondNode = head2;
            secondNode.value = 5;
            //secondNode.next = new ListNode(6);
            //secondNode = secondNode.next;
            //secondNode.next = new ListNode(4);

            AddTwoNumbers caluclateSumOfNumbers = new AddTwoNumbers();


            Node removingtheFirstNode = caluclateSumOfNumbers.Result(head1, head2);

           printListElements(removingtheFirstNode);
        }
      


        //this function is responsilbe for two print elements from the list 
        public void printListElements(Node result)
        {
            //using helper to dont lose the original data
             
            Node helper = result; 
            //ListNode current = result; 
            while (helper != null)
            {
                Console.WriteLine(helper.value);

                //moving to the next node 
                helper = helper.next;
            }
        }
    }

}
