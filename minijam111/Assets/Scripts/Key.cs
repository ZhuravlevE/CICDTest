using UnityEngine;

/// <summary>
/// ����� �����
/// </summary>
public class Key : MonoBehaviour
{
    /// <summary>
    /// ������, ������� ����
    /// </summary>
    private GameObject _hold;

    /// <summary>
    /// ���� ��������� �����
    /// </summary>
    private bool _pick = false;

    /// <summary>
    /// ��������� ������� �����
    /// </summary>    
    void FixedUpdate()
    {
        if (_pick)
            transform.position = _hold.transform.position;
    }

    /// <summary>
    /// ��� ������� � ������� ����� ���� �����������
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
