using UnityEngine;

public class NPC : MonoBehaviour
{
    /// <summary>
    /// ���
    /// </summary>
    /// <param name="dialogue">��ܪ����e</param>
    private void Dialogue(string dialogue) 
    {
        
    }

    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns>�}��</returns>
    public bool OpenStore()
    {
        return true;
    }

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="propPrice">�D�����</param>
    /// <returns>0��</returns>
    public int BuyProp(int propPrice = 100)
    {
        return 0;
    }

    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="missionNumber">���Ƚs��</param>
    public void GetMission(int missionNumber)
    {

    }

    /// <summary>
    /// ��s����
    /// </summary>
    /// <param name="getMissionPropCount">��o���ȹD��ƶq</param>
    /// <returns>0��</returns>
    private int ReMission(int getMissionPropCount = 1)
    {
        return 0;
    }

    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="missionNumber">���Ƚs��</param>
    /// <returns>������</returns>
    private bool CompleteMission(int missionNumber)
    {
        return false;
    }
}
