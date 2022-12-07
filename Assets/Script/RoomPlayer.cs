using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;


public class RoomPlayer : NetworkRoomPlayer
{
    [SyncVar] // ��Ʈ��ũ ���� ����ȭ
    public EPlayerColor playerColor;

    public void Start()
    {
        base.Start();

        if (isServer)
        {
            SpawnLobbyPlayerCharacter();
        }
    }

    private void SpawnLobbyPlayerCharacter()
    {
        // ���ǿ� ���� ���� �÷��̾ ������
        var roomSlots = (NetworkManager.singleton as RoomManager).roomSlots;
        EPlayerColor color = EPlayerColor.Red;
        // �÷��̾���� �� roomSlots�� ���鼭 ������� �ʴ� ���� ��
        for (int i = 0; i < (int)EPlayerColor.Lime + 1; i++)
        {
            bool isFindSameColor = false;
            foreach (var roomPlayer in roomSlots)
            {
                var amongUsRoomPlayer = roomPlayer as RoomPlayer;
                if (amongUsRoomPlayer.playerColor == (EPlayerColor)i && roomPlayer.netId != netId)
                {
                    isFindSameColor = true;
                    break;
                }
            }
            if (!isFindSameColor)
            {
                color = (EPlayerColor)i;
                break;
            }
        }
        // �ڽ��� �������� ����
        playerColor = color;

        // AmongUsRoomManager���� �Űܿ�
       // Vector3 spawnPos = FindObjectOfType<SpawnPositions>().GetSpawnPosition();


        var playerCharacter = Instantiate(RoomManager.singleton.spawnPrefabs[0].GetComponent<CharacterMover>());
        NetworkServer.Spawn(playerCharacter.gameObject, connectionToClient);
        playerCharacter.playerColor = color;
        // 

    }
}