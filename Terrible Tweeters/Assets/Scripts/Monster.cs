using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private Sprite deadSprite;
    [SerializeField] private ParticleSystem particles;
    
    private bool _hasDied = false;

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (ShouldDieFromCollision(collision2D))
            Die();
            
    }

    private bool ShouldDieFromCollision(Collision2D collision2D)
    {
        if (_hasDied)
            return false;
        
        Bird bird = collision2D.gameObject.GetComponent<Bird>();

        if (bird != null)
            return true;

        if (collision2D.contacts[0].normal.y < -0.5)
            return true;
        
        return false;
    }

    private void Die()
    {
        _hasDied = true;
        GetComponent<SpriteRenderer>().sprite = deadSprite;
        particles.Play();
        // gameObject.SetActive(false);
    }
}
