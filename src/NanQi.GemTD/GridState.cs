using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NanQi.GemTD
{
    public enum GridState : byte
    {
        
        /// <summary>
        /// 空白
        /// </summary>
        None = 0,
        /// <summary>
        /// 墙壁
        /// 表示四周边界
        /// </summary>
        Wall = 1,
        /// <summary>
        /// 节点
        /// 表示游戏三角处
        /// </summary>
        Note = 2,
        /// <summary>
        /// 路线
        /// 可放置石头,会被放置石头覆盖
        /// </summary>
        Way = 3,
        /// <summary>
        /// 石头
        /// 放置的石头,不可重叠
        /// </summary>
        Stone = 4,
        /// <summary>
        /// 占位
        /// </summary>
        Placeholder = 255
    }
}
