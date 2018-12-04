using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkKollare : MonoBehaviour
{

    public int isGrounded;
     
    // om jag e på marken kan jag hoppa.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded++;
    }
    // om jag inte e på marken kan jag inte hoppa.
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded--;
    }


}
