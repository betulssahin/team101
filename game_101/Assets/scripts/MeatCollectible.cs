using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatCollectible : MonoBehaviour
{
    [SerializeField] private AudioClip eatSound;
    private int count=0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.gameObject.CompareTag("Collectible"))
        {
            Debug.Log(count);
            count++;
            AudioSource.PlayClipAtPoint(eatSound, collision.transform.position);
            Destroy(collision.gameObject);
        }
    }
}
