using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
namespace SnowBall
{
public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab, cameraPrefab, rightHandPrefab, vrRightHand, leftHandPrefab, vrLeftHand, torsoPrefab, vrTorso;

    // Start is called before the first frame update
    void Start()
    {
        GameObject spawnedPlayer = PhotonNetwork.Instantiate(playerPrefab.name, cameraPrefab.transform.position, Quaternion.identity);
        GameObject spawnedLeftHand = PhotonNetwork.Instantiate(leftHandPrefab.name,vrLeftHand.transform.position,Quaternion.identity);
        GameObject spawnedRightHand = PhotonNetwork.Instantiate(rightHandPrefab.name,vrRightHand.transform.position,Quaternion.identity);
        GameObject spawnedTorso = PhotonNetwork.Instantiate(torsoPrefab.name,vrTorso.transform.position,Quaternion.identity);
        spawnedPlayer.transform.parent = cameraPrefab.transform;
        spawnedLeftHand.transform.parent = vrLeftHand.transform;
        spawnedRightHand.transform.parent = vrRightHand.transform;
        spawnedTorso.transform.parent = vrTorso.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}