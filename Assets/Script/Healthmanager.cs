using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthmanager : MonoBehaviour
{
    public  Image healthBar;
    public float HealthAmount = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Takedamage(float damage)
    {
        HealthAmount -= damage;
        healthBar.fillAmount = HealthAmount / 100f;
    }
    public void Heal(float healingAmount)
    {
        HealthAmount += healingAmount;
        HealthAmount = Mathf.Clamp(HealthAmount, 0, 100);

        healthBar.fillAmount= HealthAmount / 100f;
    }
}
