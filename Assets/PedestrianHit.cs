using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianHit : MonoBehaviour
{
  //  public float launchForce; 
  public GameObject bloodParticles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag ("Player") || col.gameObject.CompareTag ("NPC") )
        {
        Rigidbody civ = gameObject.GetComponent<Rigidbody>();
        // gameObject.GetComponent<CapsuleCollider>().enabled = false; 
  
        civ.isKinematic = false;
        bloodParticles.SetActive(true);

        
        //Vector3 flingDirection = col.ClosestPoint(0).normal;
        //  civ.AddForce(flingDirection * launchForce, ForceMode.Impulse);
    
        Destroy(gameObject,5);
        //gameObject.GetComponent<CapsuleCollider>().enabled = true; 
        }
    }

//   private void OnCollisionEnter(Collision col)
// {
//     if(col.gameObject.CompareTag ("Player"))
//     {
//   Rigidbody civ = gameObject.GetComponent<Rigidbody>();
// 
//
//   
//   Vector3 flingDirection = col.GetContact(0).normal;
//   civ.AddForce(flingDirection * launchForce, ForceMode.Impulse);
//     
// 
//     
//     //gameObject.GetComponent<CapsuleCollider>().enabled = true; 
//     }
// }
       
}
