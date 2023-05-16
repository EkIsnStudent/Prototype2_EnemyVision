using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    [SerializeField] private float timer = 5;
    private float bulletTime;

    public GameObject enemyBullet;
    private Transform spawnPoint;
    public float enemySpeed;

    void Start()
    {
        enemySpeed = 1500;
        spawnPoint = this.gameObject.transform.GetChild(3);
    }

    void Update()
    {
        ShootAtPlayer();
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;
        if (bulletTime > 0) return;

        bulletTime = timer;

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        bulletObj.SetActive(true);
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObj, 5f);
    }

}
