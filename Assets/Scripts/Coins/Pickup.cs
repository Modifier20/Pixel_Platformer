using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float timeRemaining = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        if (manager)
        {
            bool pickedUp = manager.PickupItem(gameObject);
            if (pickedUp)
            {
                Destroy(gameObject);
            }

        }
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        } else if (timeRemaining <= 0)
        {
            Destroy(gameObject);
        }
    }


}
