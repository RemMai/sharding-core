using ShardingCore.DbContexts.ShardingDbContexts;

namespace ShardingCore.DbContexts
{
/*
* @Author: xjm
* @Description:
* @Date: Tuesday, 29 December 2020 15:22:06
* @Email: 326308290@qq.com
*/
    public interface IShardingParallelDbContextFactory
    {
        ShardingDbContext Create(string tail);
    }
}