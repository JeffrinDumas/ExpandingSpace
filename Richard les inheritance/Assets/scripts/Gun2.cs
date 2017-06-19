using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour {
    [SerializeField]
    private int clipSize;
    [SerializeField]
    private int currentAmmo;

    public virtual void Start()
    {
        currentAmmo = clipSize;
    }

    public virtual void Shoot()
    {
        if(currentAmmo > 0)
        {
            currentAmmo--;
            Debug.Log(currentAmmo);
        }
        else
        {
            Debug.Log("Out Of Ammo");
        }
    }

    public virtual void Reload()
    {
        currentAmmo = clipSize;
        Debug.Log(currentAmmo);
    }

}
