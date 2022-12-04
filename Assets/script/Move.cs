using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public Rigidbody2D rBody;
    public float speed = 500;
    public GameObject projectilePrefab;
    public int HP = 500;
    public void GetHit() {
        HP -= 1; 
        Debug.Log("玩家当前血量；" + HP);
        if (HP <= 0)
            SceneManager.LoadScene(0);

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Launch();
        }
    }

    private void FixedUpdate()
    {
        float gx = Input.GetAxisRaw("Horizontal");
        float gy = Input.GetAxisRaw("Vertical");

        if ((gx < 0 && transform.localPosition.x < 100) || (gx > 0 && transform.localPosition.x > 1820))
        {
            gx = 0;
        }
        if((gy < 0 && transform.localPosition.y < 100) || (gy > 0 && transform.localPosition.y > 980))
        {
            gy = 0;
        }
        Vector2 movement = new Vector2(gx, gy);
        Vector2 targetPos = rBody.position + movement * Time.deltaTime * speed;

        rBody.MovePosition(targetPos);
    }
    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, transform.position + Vector3.right * 30, Quaternion.identity);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(Vector3.right, 100000);
    }

}
