using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public bool BulletInPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        BulletInPlayer = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
