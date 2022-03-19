using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> noises;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        audioSource.clip = noises[Random.Range(0, noises.Count)];
        audioSource.Play();
    }

    protected abstract void Move();
}
