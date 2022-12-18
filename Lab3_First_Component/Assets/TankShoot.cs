using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour, IMovable
{
    public GameObject placeBullet2, bullet2;
    private GameObject goBullet;
    private float time = 0f;
    public void Shoot(GameObject placeBullet, GameObject bullet)
    {
        goBullet = Instantiate(bullet, placeBullet.transform.position, bullet.transform.rotation);
        goBullet.transform.localScale = new Vector3(0.25f, 0.25f, 1f);
        goBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 35.0f, 0);
        Destroy(goBullet, 3.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0f)
        {
            
            time -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && time <= 0)
        {
            Shoot(placeBullet2, bullet2);
            time = 2f;
        }
        if (time <= 1)
        {
            GetComponent<Animator>().Play("TankIdle");
        }
        else
        {
            GetComponent<Animator>().Play("TankShoot");
        }
    }
}
