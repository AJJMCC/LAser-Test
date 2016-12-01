using UnityEngine;
using System.Collections.Generic;

public class GunScript : MonoBehaviour {

    private float cooldowntime;
    private float cooldowndifference = 0.1f;

    private float reloadtime;
    private float reloaddiff = 2;
    private float ammo ;
    private float clipsize = 2;

    private bool canfire = true;


    private GameObject muzzle;
    private GameObject butt;
    public GameObject bullethiteffect;

    public GameObject bullet;
    private float bulletspeed = 2500;

    void Start ()
    {
        ammo = clipsize;
        muzzle = this.gameObject.transform.GetChild(0).gameObject;
    }
	




	void Update ()
    {
        firechecks();
	}





    void firechecks()
    {

        cooldowntime -= Time.deltaTime;
        reloadtime -= Time.deltaTime;

        if (ammo == 0)
        {
            reloadtime = reloaddiff;
            ammo = clipsize;
            
        }
        if (cooldowntime <= 0 && reloadtime <= 0)
            canfire = true;
        else
            canfire = false;
 


        if (Input.GetMouseButtonDown(0))
        {
            if (canfire)
            {
                muzzle.GetComponent<ParticleSystem>().Play();

                 GameObject _bullet = Instantiate(bullet, muzzle.transform.position, muzzle.transform.rotation) as GameObject;
                _bullet.GetComponent<Rigidbody>().AddForce(muzzle.transform.forward *  bulletspeed);
                ammo--;
                cooldowntime = cooldowndifference;
            }
        }
    }





 
}
