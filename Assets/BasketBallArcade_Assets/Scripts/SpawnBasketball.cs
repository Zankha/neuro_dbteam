using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBasketball : MonoBehaviour
{
    public GameObject basketball;
    private int numChildren = 3;

    // Update is called once per frame
    void Update()
    {
        // if less than 3 child objects, spawn basketball
        if (this.transform.childCount < numChildren){

            GameObject newBall = Instantiate(basketball, this.transform.position, this.transform.rotation);
            newBall.transform.localScale = new Vector3(15f, 15f, 15f); // lazy change to fix scaling issue :P
            newBall.transform.parent = this.transform;

        }
        
    }
}
