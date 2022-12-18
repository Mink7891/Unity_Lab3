using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour, IMovable
{
    public GameObject placeBullet2, bullet2;
    private GameObject goBullet;
    public void Shoot(GameObject placeBullet, GameObject bullet)
    {
        goBullet = Instantiate(bullet, placeBullet.transform.position, bullet.transform.rotation);
        goBullet.transform.localScale = new Vector3(0.25f, 0.25f, 1f);
        goBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 30.0f, 0);
        Destroy(goBullet, 3.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Space))
        {
            Shoot(placeBullet2, bullet2);
            
            GetComponent<Animator>().Play("ShootTurret");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Animator>().Play("IdleTurret");
        }

    }
}
