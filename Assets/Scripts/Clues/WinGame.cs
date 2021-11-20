using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject uiMenu;
    public AudioSource playSound;

    // Start is called before the first frame update
    void Start()
    {
        uiMenu.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uiMenu.SetActive(true);
            playSound.Play();
        }
    }


}
