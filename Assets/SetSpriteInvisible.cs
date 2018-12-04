using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // när spelet startar blir vissa väggar och killtriggern osynliga för spelaren.
        GetComponent<SpriteRenderer>().enabled = false;
    }
    
    
        
    


}
