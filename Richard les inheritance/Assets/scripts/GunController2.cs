using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController2 : MonoBehaviour
{
    AudioSource sound;
    public GameObject gun;
    private Gun2 pistol;
    private SniperRifle Snipert;
    private RocketLauncher Rocket;
    
    void Start()
    {
        sound = GetComponent<AudioSource>();
        pistol = gun.GetComponent<Gun2>();
        Snipert = gun.GetComponent<SniperRifle>();
        Rocket = gun.GetComponent<RocketLauncher>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            pistol.Shoot();
            sound.Play();
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            pistol.Reload();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pistol.Reload();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            pistol.Reload();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            pistol.Reload();
        }



    }
}
