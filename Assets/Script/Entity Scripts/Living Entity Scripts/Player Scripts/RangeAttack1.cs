using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class RangeAttack1 : MonoBehaviour
{
    public float range = 500f;
    public float impactForce = 60f;
    public float fireRate = 3f;
    public float timer = 0f;

    public Camera fpsCam;
    public GameObject impactEffect;
    public GameObject player;

    public SwitchViewPerspective fpv;

    public TiyanakAttackPattern playerInRange;
    public PugotAttackPattern playerInRange2;
    public TiktikAttackPattern playerInRange3;

    void Update()
    {
        if (fpv.isFPV)
        {
            if (Input.GetButtonDown("Fire1") || Input.GetKeyDown("j"))
            {
                if (timer > 3f)
                {
                    Shoot();
                }

            }

            timer += Time.deltaTime;
        }

    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //UnityEngine.Debug.Log(hit.transform.name);

            if (hit.rigidbody != null)
            {
                //hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            //GameObject impact = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            GameObject impact = Instantiate(impactEffect, player.transform.position + player.transform.forward * 5f, Quaternion.LookRotation(hit.normal));
            if(playerInRange != null) playerInRange.playerAttackDetected = true;
            if (playerInRange2 != null) playerInRange2.playerAttackDetected = true;
            if (playerInRange3 != null) playerInRange3.playerAttackDetected = true;
            Destroy(impact, 5f);
        }
        timer = 0f;
    }
}
