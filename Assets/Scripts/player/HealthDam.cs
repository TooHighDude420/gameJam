using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDam : MonoBehaviour
{
    public Transform respawnPoint;
    private Rigidbody2D playerBod;
    private int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        playerBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 0)
        {
            // levend
        }

        else if (health <= 0)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        this.playerBod.position.Set(this.respawnPoint.position.x, this.respawnPoint.position.y);
    }

    public int GetHealth()
    {
        return this.health;
    }

    public void SetHealth(int newHealth)
    {
        this.health = newHealth;
    }
}
