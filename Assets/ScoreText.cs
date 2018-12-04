using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{

    private Text text;

	// Use this for initialization
	void Start ()
    {
        // kallar på texten från unity.
        text = GetComponent<Text>();
	}

    // så att texten är framme och synlig hela tiden.
    void Update ()
    {
        text.text = string.Format("Score: {0:0000}", Coin.Score);
	}







}
