using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountText : MonoBehaviour
{
    int score=0;
    public Text ScoreText;

    public void SmallStar()
    {
        score+=25;
    }
    public void SmallCloud()
    {
        score+=20;
    }
    public void LargeCloud()
    {
        score+=15;
    }
    public void LargeStar()
    {
        score+=10;
    }

    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text="000"+score.ToString();
    }
}
