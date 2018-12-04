using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour {
    public int minimunScoreNeeded = 0;


    public string sceneToLoad = "platformer";


    
    private void OnTriggerEnter2D(Collider2D collision)
    {// printar trigger enter i consolen när spelet är igång. 
        print("Trigger Enter");
        //gör så att målet(den blåa flaggan) inte är aktiverat förens spelaren tagit så många mynt som behöves.
        if (collision.tag == "Player" && Coin.Score >= minimunScoreNeeded)
        {
            Coin.Score = 0;
            SceneManager.LoadScene(sceneToLoad);
        }
    }

}
