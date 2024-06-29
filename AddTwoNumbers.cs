using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lettCode
{




    //create node to holde the value and the address of the next node
    public class Node
    {
        public int value;
        public Node next;

        public Node(int value, Node next = null)
        {

            this.value = value;
            this.next = next;

        }
    }

    public class AddTwoNumbers
    {

        public Node addTowNumberssFunction(Node listOne, Node listTwo) 
        {
            Node head  = new Node(0);
            Node result = head;



            

            int curray = 0;

           


            //the first senario where both list one and list two is equal
            while (listOne != null && listTwo != null)
            {
                // caculate the sum of two numbers
                int sum = listOne.value+listTwo.value+curray;

                curray = sum /10; //calculate the reminder 


                // append the result into a list
                // before that we calcutale the reminder of the resultnumber by %
                
                result.next = new Node(sum%10);  
              
                //moving to the next node 
                
                listOne = listOne.next; 
                listTwo = listTwo.next;
                result = result.next;
               
            }
            

            //second senario where the list one is null 


            while (listTwo != null)
            {
                int sum = listTwo.value + curray;
                
                curray = sum / 10;


                result.next = new Node (sum%10);
                result = result.next;
                listTwo = listTwo.next; 
            }
            //if the list-two is empty

            while (listOne != null)
            {
                int sum = listOne.value + curray;
                curray = sum / 10;


                result.next = new Node(sum % 10);
                result = result.next;
                listOne = listOne.next;
            }




            // last senario where both list-one and list-two is empty, and the carry is greater than 0 
            if(curray > 0)
            {
                result.next = new Node(curray);
            }

            return head; 
        }


        // this function is responsilbe to remove the first initate value into the Node.
        public Node Result(Node node1, Node node2)
        {

           
            Node result = addTowNumberssFunction(node1, node2);
            
            if(result == null)
            {
                return result;
            }
            else
            {
                result = result.next;
                return result;
            }           
    
        }

    }
}
