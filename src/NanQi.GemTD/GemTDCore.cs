using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NanQi.GemTD
{
    public class Core
    {
        public const int GEM_COUNT = 33 * 2;

        private byte[] _matrix = new byte[GEM_COUNT * GEM_COUNT];

        public byte[] Matrix
        {
            get { return _matrix; }
            set { _matrix = value; }
        }

        #region public Method

        /// <summary>
        /// 判断该玩家区域是否垂直
        /// </summary>
        /// <param name="playNum"></param>
        /// <returns></returns>
        public static bool GetMapIsVertical(int playNum)
        {
            return (playNum % 2 == 0 ? playNum : playNum + 1) / 2 % 2 == 1;
        }

        #endregion
    }
}
