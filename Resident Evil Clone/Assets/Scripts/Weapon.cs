using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected int ammoCapacity;
    [SerializeField] protected int currentLoadedAmmo;
    [SerializeField] protected int currentSpareAmmo;
    [SerializeField] protected bool canFire;
    [SerializeField] protected Transform firepoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Reload()
    {
        if(currentLoadedAmmo < ammoCapacity) {
            if(currentSpareAmmo > 0)
            {
                int bulletsToLoad = ammoCapacity - currentSpareAmmo;
                if(currentSpareAmmo >= bulletsToLoad)
                {
                    currentLoadedAmmo = ammoCapacity;
                    currentSpareAmmo -= bulletsToLoad;
                }
                else
                {
                    currentLoadedAmmo += currentSpareAmmo;
                    currentSpareAmmo -= currentSpareAmmo;
                }
            }
        }
    }

    protected virtual void Fire() {
        if (currentLoadedAmmo <= 0)
        {
            canFire = false;
        }
        if (canFire == true)
        {
            currentLoadedAmmo--;
            RaycastHit hit;
            if (Physics.Raycast(firepoint.position, firepoint.forward, out hit, 100))
            {
                Debug.DrawRay(firepoint.position, firepoint.forward * hit.distance, Color.red, 2f);
                if (hit.transform.CompareTag("Zombie"))
                {
                   hit.transform.GetComponent<Enemy>().TakeDamage(1);
                }
            }
        }
    }
}
