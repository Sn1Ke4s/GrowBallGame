using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrel : MonoBehaviour
{
    public GameObject Barrel, Explosion;

    public GameObject _spawnPointPosition;

    [SerializeField] private AudioSource _audioExplosion;

    private void Awake()
    {
        Barrel.SetActive(true);
        Explosion.SetActive(false);

    }

    public void Explode()
    {
        Barrel.SetActive(false);
        Explosion.SetActive(true);
        _audioExplosion.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<AimBall>())
        {
            Explode();
            collision.gameObject.SetActive(false);
            collision.transform.position = _spawnPointPosition.transform.position;
            collision.transform.localScale = new Vector3(0, 0, 0);

        }
    }
}
