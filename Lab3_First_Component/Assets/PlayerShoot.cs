using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour, IMovable
{
    public GameObject placeBullet2, bullet2;
    private GameObject goBullet;
    public void Shoot(GameObject placeBullet, GameObject bullet)
    {
        goBullet = Instantiate(bullet, placeBullet.transform.position, bullet.transform.rotation);
        goBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 25.0f, 0);
        Destroy(goBullet, 3.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Shoot(placeBullet2, bullet2);
        }
    }
}
