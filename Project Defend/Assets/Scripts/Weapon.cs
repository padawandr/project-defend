using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject slider;
    public GameObject projectile;
    public Transform shotPoint;
    public float timeBetweenShots;
    public bool canShoot;

    private float shotTime;

    //variaveis sfx
    public AudioClip sfxShot;
    public AudioController audioController;

    private void Start()
    {
        canShoot = true;
    }

    void Update()
    {
        Vector3 direction = slider.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
        transform.rotation = rotation;

        if (canShoot && Time.time > shotTime) {
            Instantiate(projectile, shotPoint.position, transform.rotation);
            shotTime = Time.time + timeBetweenShots;
            audioController.ToqueSFX(sfxShot);
        }
    }
}
