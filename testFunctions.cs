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

            ListNode head1 = new ListNode(0);


            ListNode num1 = head1;
            num1.value = 2;
            num1.next = new ListNode(4);
            num1 = num1.next;
            num1.next = new ListNode(3);


            //declre the second list


            ListNode head2 = new ListNode(0);


            ListNode secondNode = head2;
            secondNode.value = 5;
            //secondNode.next = new ListNode(6);
            //secondNode = secondNode.next;
            //secondNode.next = new ListNode(4);

            AddTwoNumbers caluclateSumOfNumbers = new AddTwoNumbers();


            ListNode removingtheFirstNode = caluclateSumOfNumbers.Result(head1, head2);

           printListElements(removingtheFirstNode);
        }
      
        public void printListElements(ListNode result)
        {
            //using helper to dont lose the original data
             
            ListNode helper = result; 

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
