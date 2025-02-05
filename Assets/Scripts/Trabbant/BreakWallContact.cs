using UnityEngine;
using System.Collections;

public class BreakWallContact : MonoBehaviour
{
    public float explosionForce = 10f;
    public float explosionRadius = 5f;
    public float upwardsModifier = 0f;
    public float destroyDelay = 5f;
    public float maxVerticalVelocity = 5f; // Neue Variable zur Begrenzung der vertikalen Geschwindigkeit
    private bool isBroken = false;
    public AudioSource crashSound;

    private void OnCollisionStay(Collision collision)
    {
        if (!isBroken)
        {
            Rigidbody carRigidBody = collision.gameObject.GetComponent<Rigidbody>();

            if (carRigidBody != null)
            {
                BreakWall(collision.contacts[0].point); // Übergabe des Kollisionspunkts
            }
        }
    }

    void BreakWall(Vector3 collisionPoint)
    {
        isBroken = true;
        crashSound.Play();
        foreach (Transform child in transform)
        {
            Rigidbody rb = child.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
                rb.useGravity = false;

                // Richtung vom Kollisionspunkt zum Bruchteil
                Vector3 forceDirection = (child.position - collisionPoint).normalized;

                // Kraft anwenden, aber ohne Z-Komponente, um seitliches Wegfliegen zu reduzieren
                rb.AddForce(forceDirection * explosionForce, ForceMode.Impulse);

                // Alternative: Explode Force mit angepasstem Zentrum und geringerem upwardsModifier
                //rb.AddExplosionForce(explosionForce, collisionPoint, explosionRadius, 0.1f, ForceMode.Impulse);

                rb.mass = 1f;
                rb.drag = 0.5f;
                rb.angularDrag = 0.5f;

                // Begrenzung der vertikalen Geschwindigkeit
                if (rb.velocity.y > maxVerticalVelocity)
                {
                    rb.velocity = new Vector3(rb.velocity.x, maxVerticalVelocity, rb.velocity.z);
                }


                StartCoroutine(DestroyAfterDelay(child.gameObject, destroyDelay));
            }
        }
    }

    IEnumerator DestroyAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(obj);
    }
}