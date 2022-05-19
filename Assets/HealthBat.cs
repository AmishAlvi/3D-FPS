using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBat : MonoBehaviour
{
    public Health BossHealth;
    private float bossHealth;
    public Image HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bossHealth = ((float)BossHealth.currentHealth / BossHealth.maximumHealth);
        Debug.Log(bossHealth);
        Debug.Log(BossHealth.currentHealth + ' ' + HealthBar.fillAmount);
        HealthBar.fillAmount = bossHealth;
    }
}
