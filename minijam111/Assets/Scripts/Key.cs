using UnityEngine;

/// <summary>
/// Класс ключа
/// </summary>
public class Key : MonoBehaviour
{
    /// <summary>
    /// Объект, несущий ключ
    /// </summary>
    private GameObject _hold;

    /// <summary>
    /// Флаг поднятого ключа
    /// </summary>
    private bool _pick = false;

    /// <summary>
    /// Изменение позиции ключа
    /// </summary>    
    void FixedUpdate()
    {
        if (_pick)
            transform.position = _hold.transform.position;
    }

    /// <summary>
    /// При конакте с красным НИПом ключ подбирается
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
