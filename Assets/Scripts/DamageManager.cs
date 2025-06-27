using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (health + damageInflicted == 0)
        {
            Debug.Log("Moriste");
            SceneManager.LoadScene("FPS Parkour");
            return false;  // nos devuelve que es falso
        } else
        {
            health += damageInflicted;
            uiManager.UpdateHealthText(health.ToString());
            return true;
        }
        
    }
}
