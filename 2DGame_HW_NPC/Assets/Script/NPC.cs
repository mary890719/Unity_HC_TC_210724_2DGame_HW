using UnityEngine;

public class NPC : MonoBehaviour
{
    /// <summary>
    /// 對話
    /// </summary>
    /// <param name="dialogue">對話的內容</param>
    private void Dialogue(string dialogue) 
    {
        
    }

    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns>開啟</returns>
    public bool OpenStore()
    {
        return true;
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="propPrice">道具價錢</param>
    /// <returns>0元</returns>
    public int BuyProp(int propPrice = 100)
    {
        return 0;
    }

    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="missionNumber">任務編號</param>
    public void GetMission(int missionNumber)
    {

    }

    /// <summary>
    /// 更新任務
    /// </summary>
    /// <param name="getMissionPropCount">獲得任務道具數量</param>
    /// <returns>0個</returns>
    private int ReMission(int getMissionPropCount = 1)
    {
        return 0;
    }

    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="missionNumber">任務編號</param>
    /// <returns>未完成</returns>
    private bool CompleteMission(int missionNumber)
    {
        return false;
    }
}
