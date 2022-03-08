using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    private  HingeJoint myHingeJoint;
    private float defaultAngle=20;
    private float flickAngle=-20;



    // Start is called before the first frame update
    void Start()
    {
       this.myHingeJoint=GetComponent<HingeJoint>();
       SetAngle(this.defaultAngle);
      
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.A))&&tag=="LeftFripperTag")
        {
            SetAngle(this.flickAngle);
            
            
            
        }
        if((Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.D))&&tag=="RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }   
        if((Input.GetKeyUp(KeyCode.LeftArrow)||Input.GetKeyUp(KeyCode.A))&&tag=="LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }     
        if((Input.GetKeyUp(KeyCode.RightArrow)||Input.GetKeyUp(KeyCode.D))&&tag=="RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if(Input.touchCount>0)
        {
            SetAngle(this.defaultAngle);

        }
        if(Input.touchCount>0)
        {
            Touch touch =Input.GetTouch(0);
            if(Input.mousePosition.x>=Screen.width/2)
            {
                if(touch.phase==TouchPhase.Began&&tag=="RightFripperTag")
              {
                SetAngle(this.flickAngle);
              }
            }
            else 
            {
                if(touch.phase==TouchPhase.Began&&tag=="LeftFripperTag")
                {
                    SetAngle(this.flickAngle);
                }
            }
            
        }
    
    
    }
    public void SetAngle(float angle)
        {
            JointSpring joinSpr=this.myHingeJoint.spring;
            joinSpr.targetPosition=angle;
            this.myHingeJoint.spring=joinSpr;

        }
}