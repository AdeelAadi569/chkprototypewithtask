using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speed=10f,xrange=8,horizontaal;
    public GameObject prefabpiza;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontaal=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontaal*Time.deltaTime*speed);
        if(transform.position.x<-xrange){
            transform.position=new Vector3(-xrange,transform.position.y,transform.position.z);
        }
        if(transform.position.x>xrange){
            transform.position=new Vector3(xrange,transform.position.y,transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(prefabpiza,new Vector3(transform.position.x,transform.position.y,-9f),prefabpiza.transform.rotation);

        }
    }
}
