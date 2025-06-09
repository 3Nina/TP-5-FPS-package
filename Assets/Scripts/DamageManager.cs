using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public int health;
    public UiManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
    }

    public bool HealthUpdate(int damageInflicted)
    {
        if (health <= damageInflicted)
        {
            Debug.Log("Moriste");
            return false;  // nos devuelve que es falso
        }
        health -= damageInflicted;
        uiManager.UpdateHealthText(health.ToString());
        return true;
    }
}
