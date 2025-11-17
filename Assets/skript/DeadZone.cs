using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private PlatformMove player;
    private void Start()
    {
        player = GetComponent<PlatformMove>();
        player.transform.position = new Vector2(-2.206696f, -1.603927f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.position = player.transform.position;
        }
    }
}

