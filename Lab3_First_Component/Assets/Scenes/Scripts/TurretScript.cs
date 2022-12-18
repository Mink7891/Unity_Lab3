using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurretScript : MonoBehaviour
{
    public GameObject placeBullet, bullet;
    private GameObject goBullet;
    private bool bulletOforOn = false;
    [HideInInspector] public static UnityEvent OnDetectEvent = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Corout());
    }
    IEnumerator Corout()
    {
        yield return new WaitForSeconds(3f);
        goBullet = Instantiate(bullet, placeBullet.transform.position, bullet.transform.rotation);
        goBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(-20f, 0, 0);
        bulletOforOn = true;

    }
    void Update()
    {
        
        if (bulletOforOn && goBullet.GetComponent<BulletScript>().BulletInPlayer)
        {
            OnDetectEvent?.Invoke();
        }
    }
}
