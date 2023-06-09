using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class Objectives
/// </summary>
public class Objectives : MonoBehaviour
{
    [SerializeField] private string _nextLevel;

    [SerializeField] private AudioClip _keyUp;
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private int _keyCount;

    /// <summary>
    /// void Update
    /// </summary>
    private void Update()
    {
        if(Input.GetKey(KeyCode.N))
            SceneManager.LoadScene(_nextLevel);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Key")
        {
            _audioSource.PlayOneShot(_keyUp);

            _keyCount--;
            Destroy(collision.gameObject);

            if (_keyCount <= 0)
            {
                GameObject.FindGameObjectWithTag("CloseDoor").SetActive(false);

                GameObject.FindGameObjectWithTag("OpenDoor").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("OpenDoor").GetComponent<BoxCollider2D>().enabled = true;
            }
            

        }

        if (collision.tag == "OpenDoor")
        {
            SceneManager.LoadScene(_nextLevel);
        }
    }
    

}
