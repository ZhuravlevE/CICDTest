using UnityEngine;

/// <summary>
/// One
/// </summary>
public class Key : MonoBehaviour
{
    /// <summary>
    /// Two
    /// </summary>
    private GameObject _hold;

    /// <summary>
    /// Three
    /// </summary>
    private bool _pick = false;

    /// <summary>
    /// Four
    /// </summary>    
    void FixedUpdate()
    {
        if (_pick)
            transform.position = _hold.transform.position;
    }

    /// <summary>
    /// Five
    /// </summary>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.tag == "Green")
        {
            _pick = false;
            Debug.Log(11);
        }*/

        if (collision.tag == "Red")
        {
            _hold = collision.gameObject.transform.GetChild(2).gameObject;//.FindGameObjectWithTag("HoldKeyRed");
            _pick = true;
        }

    }
  

}
