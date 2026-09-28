using UnityEngine;
using System.Collections.Generic;

public class Peg : MonoBehaviour
{
    public List<Sprite> PegSprites;
    public Sounds Sounds;
    public GameObject RingParticlePrefab;

    private int spriteNumber = 0;
    private SpriteRenderer spriteRenderer;

    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Start()
    {
        spriteRenderer.sprite = PegSprites[0];
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            HandleBallHit();
        }
    }

    private void HandleBallHit()
    {
        SpawnRingParticle();

        if (spriteNumber == PegSprites.Count - 1)
        {
            DestroyPeg();
        }
        else
        {
            ChangeToNextColor();
        }
    }

    private void SpawnRingParticle()
    {
        Instantiate(
            RingParticlePrefab,
            transform.position,
            Quaternion.identity
        );
    }

    private void ChangeToNextColor()
    {
        spriteNumber = spriteNumber + 1;
        spriteRenderer.sprite = PegSprites[spriteNumber];

        Sounds.PlayPegHitSound();
    }

    private void DestroyPeg()
    {
        Sounds.PlayPegDestroyedSound();
        Destroy(gameObject);
    }
}