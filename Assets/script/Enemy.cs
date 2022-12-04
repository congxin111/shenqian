using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    float timer = 0.5f;
    public GameObject projectilePrefab;
    public int HP = 100;
    public void GetHit()
    {
        HP -= 1;
        Debug.Log("敌人当前血量；" + HP);
        if (HP <= 0)
            SceneManager.LoadScene(6);

    }
    void Start()
    {
        
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = 0.15f;
            Launch();
        }
        
    }
    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, transform.position + new Vector3(-1,-1,0) * 30, Quaternion.identity);
        ProjectileE2 projectile = projectileObject.GetComponent<ProjectileE2>();
        projectile.dirction = new Vector3(-1, 0, 0);
        projectile.speed = 5500;
    }
}
