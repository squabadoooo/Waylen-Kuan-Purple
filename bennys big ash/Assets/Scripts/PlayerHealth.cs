using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int currentPlayerHealth = 6;
    public int enemyDamage = 1;

    public PlayerExplosionParticles particles;

    private Animator playerAnimator;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        particles = GetComponent<PlayerExplosionParticles>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HitCollider")
        {
            HurtPlayer();
        }
    }

    public void HurtPlayer()
    {
        currentPlayerHealth -= enemyDamage;
        playerAnimator.SetTrigger("Hit");

        if (currentPlayerHealth <=1)
        {
            particles.Explode();
            Invoke("Reloadscene", 5);
        }
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene("CyberFu");
    }
}
