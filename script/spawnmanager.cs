using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject [] spawnpositions;
    public GameObject [] animalprefabs;
    private float xrangepos=8,zpos=10,startdelay=0.5f,spawninterval=1;
    
    // Start is called before the first frame update
    void Start()
    {
          InvokeRepeating("SpawnEnimals",startdelay,spawninterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void SpawnEnimals(){
             int indexanimal=Random.Range(0,animalprefabs.Length);
             int indexpositions=Random.Range(0,spawnpositions.Length);
             Vector3 spawnpos=new Vector3(Random.Range(xrangepos,-xrangepos),0,zpos);
             Instantiate(animalprefabs[indexanimal],spawnpos,animalprefabs[indexanimal].transform.rotation);
           //Instantiate(animalprefabs[indexanimal],new Vector3(0,0,15),animalprefabs[indexanimal].transform.rotation);
           //Instantiate(animalprefabs[indexanimal],spawnpositions[indexpositions].transform.position,animalprefabs[indexanimal].transform.rotation);
 
    }
}
