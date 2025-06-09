using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage = 20;
    public DamageManager damageManager;

    void Start()
    {
        damageManager = FindObjectOfType<DamageManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            damageManager.HealthUpdate(-damage);
        }
    }

}
