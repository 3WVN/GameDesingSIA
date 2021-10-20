using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UserSelf : MonoBehaviour
{
    public static string getUsername;
    public TMP_Text username;
    public List<UserInfo> userInfo;
    private void Awake()
    {
        username.text = $"Username: {getUsername}";
    }
}
