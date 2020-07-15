using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
    public AudioSource audioSource;
     private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Ball")
        {
            audioSource.PlayOneShot(audioSource.clip, 0.5f);
            string wallName = transform.name;
            GameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("ResetBall");
        }
    }
}
