using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite sprites;
    [HideInInspector] public bool BulletInPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        TurretScript.OnDetectEvent.AddListener(ChangeSprite);
    }
    public void ChangeSprite()
    {
        GetComponent<SpriteRenderer>().sprite = sprites;
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
