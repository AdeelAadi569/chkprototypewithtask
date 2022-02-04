using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyoutofbound : MonoBehaviour
{
    public float uperbound=30f,lowerbound=-15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>uperbound){
            Destroy(gameObject);
        }
        else if(transform.position.z<lowerbound){
           Destroy(gameObject);
        }
    }
}
