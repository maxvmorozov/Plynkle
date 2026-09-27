using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public Transform ProjectileSpawnPoint;
    public void Launch(Vector2 aimDirection)
    {
       GameObject projectileObject =  Instantiate(ProjectilePrefab, ProjectileSpawnPoint.position, Quaternion.identity);
        
        LaunchProjectile(projectileObject, aimDirection);
    }

    private void LaunchProjectile(GameObject projectileObject, Vector2 aimDirection)
    {
        Rigidbody2D projectileRigidBody = projectileObject.GetComponent<Rigidbody2D>();
        
        projectileRigidBody.AddForce(aimDirection * 5f, ForceMode2D.Impulse);
    }
}
