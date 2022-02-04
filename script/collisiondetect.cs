using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class collisiondetect : MonoBehaviour
{
    private Text scoretext;
    public static int counterscore=0;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col){
       Destroy(gameObject);
       Destroy(col.gameObject);
       counterscore+=1;
       if(counterscore==1){
           counterscore+=2;
            scoretext.text="Score :"+counterscore;
       }
       if(counterscore>3){
           counterscore+=4;
            scoretext.text="Score :"+counterscore;
           //counterscore+= 2;
       }
      
      
    }
}
