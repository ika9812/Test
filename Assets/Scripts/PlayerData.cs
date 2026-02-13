using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    public int hp;//HP
    public float sp;//スピード
    public float dsp;//走りスピード
    public float jp;//ジャンプ力
    public float mp;//マナ

}
