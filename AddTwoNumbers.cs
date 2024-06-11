using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lettCode
{


      public class ListNode {
          public int val;
         public ListNode next;
          public ListNode(int val=0, ListNode next=null) {
              this.val = val;
              this.next = next;
          }
      }
     
    public class AddTwoNumbers
    {
        public ListNode AddTwoNumberss(ListNode l1, ListNode l2)
        {


            ListNode head = null;
            ListNode result = new ListNode(0);
            head = result;

            int curray = 0;



            while (l1 != null && l2 != null)
            {
                int resultValue = l1.val + l2.val + curray;
                curray = resultValue / 10;


                result.val = resultValue % 10;

                result = result.next;
                l1 = l1.next;
                l2 = l2.next;
            }



            while (l1 != null)
            {
                int resultValue = l1.val + curray;
                curray = resultValue / 10;


                result.val = resultValue % 10;

                result = result.next;
                l1 = l1.next;
            }




            while (l2 != null)
            {
                int resultValue = l2.val + curray;
                curray = resultValue / 10;


                result.val = resultValue % 10;

                result = result.next;
                l2 = l2.next;
            }



            return head.next;

        }
    }
}
