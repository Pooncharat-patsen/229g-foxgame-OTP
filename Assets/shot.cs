using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public Transform shootPoint;
    public Rigidbody2D bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            Vector2 projectileV = CalculateProjectile(shootPoint.position, hit.point, 1);

            Rigidbody2D spawnBullet = Instantiate(bullet, shootPoint.position, Quaternion.identity);
            spawnBullet.velocity = projectileV;
            projectileV.x = 0;
            projectileV.y = 0;
        }

    }
    Vector2 CalculateProjectile(Vector2 origin, Vector2 targetPoint, float time)
    {
        Vector2 distance = targetPoint - origin;
        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;

        Vector2 projecttileVelocity = new Vector2(velocityX, velocityY);

        return projecttileVelocity;
    }
}
