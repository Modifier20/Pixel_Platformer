using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int coinCount;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    public bool PickupItem(GameObject obj)
    {
        switch (obj.tag)
        {
            case "BronzeCoin":
                audioSource.PlayOneShot(clip, volume);
                coinCount = coinCount + 5;
                return true;

            case "SilverCoin":
                audioSource.PlayOneShot(clip, volume);
                coinCount = coinCount + 10;
                return true;

            case "GoldCoin":
                audioSource.PlayOneShot(clip, volume);
                coinCount = coinCount + 15;
                return true;
            
            case "LoadNextLevel":
                SceneManager.LoadScene("Level 2");
                return true;
            
            default:
                Debug.LogWarning($"WARNING: No handler implemented for tag {obj.tag}.");
                return false;
        }
    }
}
