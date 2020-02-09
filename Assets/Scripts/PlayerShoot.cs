using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerShoot : NetworkBehaviour
{
    public PlayerWeapon weapon;

    [SerializeField]
    private Camera cam;
    
    // Start is called before the first frame update
    void Start()
    {
        if(cam == null)
        {
            Debug.Log("PlayerShoot: No camera referenced");
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
