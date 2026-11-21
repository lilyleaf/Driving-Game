using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
  //   if (Input.GetKeyDown(KeyCode.Return))
  //   {
  //       TakeDamage(20);
  //   }
  //   if (Input.GetKeyDown(KeyCode.Space))
  //   {
  //       Heal(5);
  //   }
    }
    
     private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag ("Enemy"))
        {
            TakeDamage(20);
        }
        if(col.gameObject.CompareTag ("Heal"))
        {
            Heal(20);
            Destroy(col.gameObject);
        }
    }


    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal (float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);
        healthBar.fillAmount = healthAmount / 100f;
    }
}
