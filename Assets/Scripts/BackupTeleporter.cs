using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackupTeleporter : MonoBehaviour
{
    public Transform target;
    public Transform player;
    // Start is called before the first frame update
    public void Backup()
    {
        player.transform.position = target.position;
    }
}
