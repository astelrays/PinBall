using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ=-6.5f;

    private GameObject gameoverText;

    private GameObject scoreText;

    GameObject Count;
    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText=GameObject.Find("GameOverText");
    
        this.Count=GameObject.Find("GameObject");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z<this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text="Game Over";
        }
        
        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="LargeStarTag")
        {
            Debug.Log("10point");
            Count.GetComponent<CountText>().LargeStar();
            

        }
        if(other.gameObject.tag=="LargeCloud")
        {
            Debug.Log("15point");
            Count.GetComponent<CountText>().LargeCloud();
        }
        if(other.gameObject.tag=="SmallCloudTag")
        {
            Debug.Log("20poitn");
            Count.GetComponent<CountText>().SmallCloud();
        }
        if(other.gameObject.tag=="SmallStarTag")
        {
            Debug.Log("25point");
            Count.GetComponent<CountText>() .SmallStar();
        }

    }

    
}
