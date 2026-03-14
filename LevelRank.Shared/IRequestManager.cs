namespace LevelRank.Shared;

public interface IRequestManager
{
    const string Identity = "LevelRank.IRequestManager";

    Task<RankInfo> GetUserRankInfo(ulong steamId, ulong defaultScore = 0);

    Task UpdateUserInfo(ulong steamId, RankInfo info);
}