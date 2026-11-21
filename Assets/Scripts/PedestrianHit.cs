using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PedestrianHit : MonoBehaviour
{
  //  public float launchForce; 
  public GameObject bloodParticles;
  public BloodBar bloodManager;
  public bool isAlive; 
    // Start is called before the first frame update
    void Start()
    {
      GameObject playa  = GameObject.Find("PlayerCar");
      bloodManager = playa.GetComponent<BloodBar>(); 
      isAlive = true; 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
      if(col.gameObject.CompareTag ("Player") || col.gameObject.CompareTag ("NPC") )
      {
        suckBlood();
        Rigidbody civ = gameObject.GetComponent<Rigidbody>();
        civ.isKinematic = false;
        bloodParticles.SetActive(true);
        Destroy(gameObject,5);

        
      }
       
    }


    public void suckBlood()
    {
      if (isAlive == true)
      {
        bloodManager.addBlood(20);
        isAlive = false;
      }
      
    } 
}
