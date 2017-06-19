using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public int clipSize;
    public int currentAmmo;
    
    public void Shoot()
    {
       currentAmmo--;
        
       
    }

    public void Reload()
    {
       currentAmmo = clipSize;
    }


}
