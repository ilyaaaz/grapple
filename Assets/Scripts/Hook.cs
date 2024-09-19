using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Hook : MonoBehaviour
{
    public float hookLaunchingSpeed;
    Rigidbody2D rb;
    PolygonCollider2D cld;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cld = GetComponent<PolygonCollider2D>();
        transform.position = GameManager.instance.player.transform.position;
        shootOff();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void shootOff()
    {
        //direction
        Vector3 mousePos = GameManager.instance.getMousePos();
        Vector3 direction = (mousePos - transform.position).normalized;
        //add lauching force
        rb.AddForce(direction * hookLaunchingSpeed);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == GameManager.instance.player)
        {
            cld.isTrigger = false;
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
