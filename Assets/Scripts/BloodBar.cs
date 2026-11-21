using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodBar : MonoBehaviour
{
    public Image bloodBarUI;
    public float bloodAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {
    // bloodBarUI.fillAmount = 0f;
         bloodAmount -= 100f;
        bloodBarUI.fillAmount = bloodAmount / 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addBlood(float blood)
    {

    //     bloodAmount -= blood;
    //   bloodBarUI.fillAmount = bloodAmount / 100f;

        bloodAmount += blood;
        bloodAmount = Mathf.Clamp(bloodAmount, 0, 100);
        bloodBarUI.fillAmount = bloodAmount / 100f;
    }

 // public void Heal (float healingAmount)
 // {
 //     healthAmount += healingAmount;
 //     healthAmount = Mathf.Clamp(healthAmount, 0, 100);
 //     healthBar.fillAmount = healthAmount / 100f;
 // }
}
