using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory iv;
    // ����
    public List<GameObject> AllSlot;    // ��� ������ �������� ����Ʈ.
    public RectTransform InvenRect;     // �κ��丮�� Rect
    public GameObject OriginSlot;       // �������� ����.

    public float slotSize;              // ������ ������.
    public float slotGap;               // ���԰� ����.
    public float slotCountX;            // ������ ���� ����.
    public float slotCountY;            // ������ ���� ����.

    // �����.
    private float InvenWidth;           // �κ��丮 ���α���.
    private float InvenHeight;          // �ι��丮 ���α���.
    private float EmptySlot;            // �� ������ ����.
    public  string[] missionNameArray = new string[5];

    void Awake()
    {
        // �κ��丮 �̹����� ����, ���� ������ ����.
        InvenWidth = (slotCountX * slotSize) + (slotCountX * slotGap) + slotGap;
        InvenHeight = (slotCountY * slotSize) + (slotCountY * slotGap) + slotGap;

        // ���õ� ������� ũ�⸦ ����.
        InvenRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, InvenWidth); // ����.
        InvenRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, InvenHeight);  // ����.

        //���� �����ϱ�.
        for (int y = 0; y < 5; y++)
        {
            // ������ �����Ѵ�.
            GameObject slot = Instantiate(OriginSlot) as GameObject;
            // ������ RectTransform�� �����´�.
            RectTransform slotRect = slot.GetComponent<RectTransform>();
            // ������ �ڽ��� �����̹����� RectTransform�� �����´�.
            RectTransform mission = slot.transform.GetChild(0).GetComponent<RectTransform>();

            slot.name = "slot_" + y + "_"; // ���� �̸� ����.
            slot.transform.parent = transform; // ������ �θ� ����. (Inventory��ü�� �θ���.)


            // ������ �ڽ��� �����̹����� ������ �����ϱ�.
            slotRect.localScale = Vector3.one;
            slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotSize); // ����
            slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotSize);   // ����.

            // ������ ������ �����ϱ�.
            mission.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotSize - slotSize * 0.3f); // ����.
            mission.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotSize - slotSize * 0.3f);   // ����.

            // ����Ʈ�� ������ �߰�.
            AllSlot.Add(slot);

        }

        //�� ���� = ������ ����.
        EmptySlot = AllSlot.Count;
    }

    // �������� �ֱ����� ��� ������ �˻�.
    public bool AddMission(Mission mission)
    {
        // ���Կ� �� ����.
        int slotCount = AllSlot.Count;

        // �ֱ����� �������� ���Կ� �����ϴ��� �˻�.
        for (int i = 0; i < slotCount; i++)
        {
            // �� ������ ��ũ��Ʈ�� �����´�.
            Slot slot = AllSlot[i].GetComponent<Slot>();

            // ������ ��������� ���.
            if (!slot.isSlots())
                continue;
        }

        // �� ���Կ� �������� �ֱ����� �˻�.
        for (int i = 0; i < slotCount; i++)
        {
            Slot slot = AllSlot[i].GetComponent<Slot>();

            // ������ ������� ������ ���
            if (slot.isSlots())
                continue;

            slot.AddMission(mission);
            missionNameArray[i] = mission.missionName;
            return true;
        }

        // ���� ���ǿ� �ش�Ǵ� ���� ���� �� �������� ���� ����.
        return false;
    }
}