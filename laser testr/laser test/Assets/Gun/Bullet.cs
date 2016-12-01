using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    private GameObject hiteffect;


    void Start ()
    {
       // hiteffect = 
        Destroy(this.gameObject, 2);
	}
	
	void Update ()
    {
	
	}

    void OnCollisionEnter(Collision other)
    {
        
    }
}
