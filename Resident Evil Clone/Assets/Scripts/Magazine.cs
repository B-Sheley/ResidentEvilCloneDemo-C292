using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour, IPickupAble
{
    [SerializeField] private int maxAmmoCapacity;
    [SerializeField] private int currentLoadedAmmo;
    [SerializeField] string magType; // Pistol, Rifle, Shotgun, etc.

    //public enum weaponType()
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveRound() {
        
    
    }

    public void GetType() { }

    public void GetRoundCount() { }

    public void PickUp() { }

}
