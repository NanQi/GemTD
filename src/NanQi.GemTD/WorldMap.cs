using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace NanQi.GemTD
{
    public class WorldMap : UserControl
    {
        #region Properties

        /// <summary>
        /// 获取或设置是否显示网格
        /// </summary>
        [Category("宝石TD"),
        Description("是否显示网格"),
        DefaultValue(false)]
        public bool IsShowGrid
        {
            get { return _isShowGrid; }
            set { _isShowGrid = value; Invalidate(); }
        }

        #endregion

        #region Fields

        private byte[] _matrix = new byte[Core.GEM_COUNT * Core.GEM_COUNT];

        public byte[] Matrix
        {
            get { return _matrix; }
        }
        private byte[] _matrixBackground = new byte[Core.GEM_COUNT * Core.GEM_COUNT];
        private bool _isShowGrid;

        #endregion

        #region ctor

        public WorldMap()
        {
            SetStyle(
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.ResizeRedraw |
               ControlStyles.AllPaintingInWmPaint, true);
        }

        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            float cellWidth = (float)Width / Core.GEM_COUNT;
            float cellHeight = (float)Height / Core.GEM_COUNT;
            float line = 0;
            if (_isShowGrid) { line = 2F; }
            Graphics painter = e.Graphics;
            // 清除
            painter.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height));

            for (int y = 0; y < Core.GEM_COUNT; y++)
            {
                for (int x = 0; x < Core.GEM_COUNT; x++)
                {
                    var backgroundState = (GridState)_matrixBackground[x + y * Core.GEM_COUNT];

                    if (backgroundState == GridState.Way)
                    {
                        painter.FillRectangle(new SolidBrush(GetColor(backgroundState)), x * cellWidth, y * cellHeight, cellWidth * 2 - line, cellHeight * 2 - line);
                    }
                }
            }

            for (int y = 0; y < Core.GEM_COUNT; y++)
            {
                for (int x = 0; x < Core.GEM_COUNT; x++)
                {
                    var backgroundState = (GridState)_matrixBackground[x + y * Core.GEM_COUNT];
                    var curState = (GridState)_matrix[x + y * Core.GEM_COUNT];
                    SolidBrush brush = new SolidBrush(GetColor(curState));

                    if (curState == GridState.None)
                    {
                        if (backgroundState == GridState.None)
                        {
                            painter.FillRectangle(brush, x * cellWidth, y * cellHeight, cellWidth - line, cellHeight - line);
                        }
                    }
                    else if (curState == GridState.Placeholder)
                    {

                    }
                    else
                    {
                        painter.FillRectangle(brush, x * cellWidth, y * cellHeight, cellWidth * 2 - line, cellHeight * 2 - line);
                    }
                }
            }
        }
        #endregion

        #region Public Methods

        public Color GetColor(GridState state)
        {
            Color ret = Color.White;    

            switch (state)
            {
                case GridState.None:
                    break;
                case GridState.Wall:
                    ret = SystemColors.WindowFrame;
                    break;
                case GridState.Note:
                    ret = Color.DarkGreen;
                    break;
                case GridState.Way:
                    //ret = Color.Transparent;
                    ret = Color.LightGreen;
                    break;
                case GridState.Stone:
                    ret = Color.Olive;
                    break;
                default:
                    break;
            }

            return ret;
        }

        public void CreateWorld(int playNum)
        {
            if (playNum < 1 || playNum > 8)
            {
                throw new ArgumentException("指定玩家错误,只能是1-8之间", "playNum");
            }

            _matrix = new byte[Core.GEM_COUNT * Core.GEM_COUNT];

            SetGrid(9, 5, GridState.Note);
            SetGrid(11, 5, GridState.Note);
            SetGrid(13, 5, GridState.Note);
            SetGrid(11, 7, GridState.Note);

            SetGrid(11, 9, GridState.Way);
            SetGrid(11, 11, GridState.Way);
            SetGrid(11, 13, GridState.Way);
            SetGrid(11, 15, GridState.Way);
            SetGrid(11, 17, GridState.Way);
            SetGrid(11, 19, GridState.Way);
            SetGrid(11, 21, GridState.Way);
            SetGrid(11, 23, GridState.Way);
            SetGrid(11, 25, GridState.Way);

            SetGrid(11, 27, GridState.Note);
            SetGrid(11, 29, GridState.Note);
            SetGrid(11, 31, GridState.Note);
            SetGrid(13, 29, GridState.Note);

            SetGrid(15, 29, GridState.Way);
            SetGrid(17, 29, GridState.Way);
            SetGrid(19, 29, GridState.Way);
            SetGrid(21, 29, GridState.Way);
            SetGrid(23, 29, GridState.Way);
            SetGrid(25, 29, GridState.Way);
            SetGrid(27, 29, GridState.Way);
            SetGrid(29, 29, GridState.Way);
            SetGrid(31, 29, GridState.Way);
            SetGrid(33, 29, GridState.Way);
            SetGrid(35, 29, GridState.Way);
            SetGrid(37, 29, GridState.Way);
            SetGrid(39, 29, GridState.Way);

            SetGrid(41, 29, GridState.Note);
            SetGrid(43, 29, GridState.Note);
            SetGrid(45, 29, GridState.Note);
            SetGrid(43, 27, GridState.Note);

            SetGrid(43, 25, GridState.Way);
            SetGrid(43, 23, GridState.Way);
            SetGrid(43, 21, GridState.Way);
            SetGrid(43, 19, GridState.Way);
            SetGrid(43, 17, GridState.Way);
            SetGrid(43, 15, GridState.Way);
            SetGrid(43, 13, GridState.Way);
            SetGrid(43, 11, GridState.Way);
            SetGrid(43, 9, GridState.Way);
            SetGrid(43, 7, GridState.Way);
            SetGrid(43, 5, GridState.Way);

            SetGrid(43, 3, GridState.Note);
            SetGrid(43, 5, GridState.Note);
            SetGrid(43, 7, GridState.Note);
            SetGrid(41, 5, GridState.Note);

            SetGrid(39, 5, GridState.Way);
            SetGrid(37, 5, GridState.Way);
            SetGrid(35, 5, GridState.Way);
            SetGrid(33, 5, GridState.Way);
            SetGrid(31, 5, GridState.Way);
            SetGrid(29, 5, GridState.Way);
            SetGrid(27, 5, GridState.Way);

            SetGrid(25, 5, GridState.Note);
            SetGrid(27, 5, GridState.Note);
            SetGrid(29, 5, GridState.Note);
            SetGrid(27, 7, GridState.Note);

            SetGrid(27, 9, GridState.Way);
            SetGrid(27, 11, GridState.Way);
            SetGrid(27, 13, GridState.Way);
            SetGrid(27, 15, GridState.Way);
            SetGrid(27, 17, GridState.Way);
            SetGrid(27, 19, GridState.Way);
            SetGrid(27, 21, GridState.Way);
            SetGrid(27, 23, GridState.Way);
            SetGrid(27, 25, GridState.Way);
            SetGrid(27, 27, GridState.Way);
            SetGrid(27, 29, GridState.Way);
            SetGrid(27, 31, GridState.Way);
            SetGrid(27, 33, GridState.Way);
            SetGrid(27, 35, GridState.Way);
            SetGrid(27, 37, GridState.Way);
            SetGrid(27, 39, GridState.Way);
            SetGrid(27, 41, GridState.Way);

            SetGrid(27, 43, GridState.Note);
            SetGrid(27, 45, GridState.Note);
            SetGrid(27, 47, GridState.Note);
            SetGrid(29, 45, GridState.Note);

            SetGrid(31, 45, GridState.Way);
            SetGrid(33, 45, GridState.Way);
            SetGrid(35, 45, GridState.Way);
            SetGrid(37, 45, GridState.Way);
            SetGrid(39, 45, GridState.Way);
            SetGrid(41, 45, GridState.Way);
            SetGrid(43, 45, GridState.Way);
            SetGrid(45, 45, GridState.Way);
            SetGrid(47, 45, GridState.Way);
            SetGrid(49, 45, GridState.Way);
            SetGrid(51, 45, GridState.Way);
            SetGrid(53, 45, GridState.Way);
            SetGrid(55, 45, GridState.Way);
            SetGrid(57, 45, GridState.Way);
            SetGrid(59, 45, GridState.Way);
            SetGrid(61, 45, GridState.Way);

            SetGrid(50, 0, GridState.Wall);
            SetGrid(50, 2, GridState.Wall);
            SetGrid(50, 4, GridState.Wall);
            SetGrid(50, 6, GridState.Wall);
            SetGrid(50, 8, GridState.Wall);
            SetGrid(50, 10, GridState.Wall);
            SetGrid(50, 12, GridState.Wall);
            SetGrid(50, 14, GridState.Wall);
            SetGrid(50, 16, GridState.Wall);
            SetGrid(50, 18, GridState.Wall);
            SetGrid(50, 20, GridState.Wall);
            SetGrid(52, 20, GridState.Wall);
            SetGrid(54, 20, GridState.Wall);
            SetGrid(54, 22, GridState.Wall);
            SetGrid(54, 24, GridState.Wall);
            SetGrid(54, 26, GridState.Wall);
            SetGrid(56, 26, GridState.Wall);
            SetGrid(58, 26, GridState.Wall);
            SetGrid(58, 28, GridState.Wall);
            SetGrid(58, 30, GridState.Wall);
            SetGrid(58, 32, GridState.Wall);
            SetGrid(60, 32, GridState.Wall);
            SetGrid(62, 32, GridState.Wall);
            SetGrid(62, 34, GridState.Wall);
            SetGrid(62, 36, GridState.Wall);
            SetGrid(62, 38, GridState.Wall);
            SetGrid(64, 38, GridState.Wall);
            
        }

        public GridState GetGridState(int x, int y)
        {
            var curState = (GridState)_matrix[x + y * Core.GEM_COUNT];
            var rightState = (GridState)_matrix[x + 1 + y * Core.GEM_COUNT];
            var downState = (GridState)_matrix[x + (y + 1) * Core.GEM_COUNT];
            var diagState = (GridState)_matrix[x + 1 + (y + 1) * Core.GEM_COUNT];

            if (curState == GridState.None && rightState == GridState.None
             && downState == GridState.None && diagState == GridState.None)
            {
                return GridState.None;
            }
            else if ((curState == GridState.Way)
                && (rightState == GridState.Placeholder)
                && (downState == GridState.Placeholder)
                && (diagState == GridState.Placeholder))
            {
                return GridState.Way;
            }
            else if ((curState == GridState.Stone)
                && (rightState == GridState.Placeholder)
                && (downState == GridState.Placeholder)
                && (diagState == GridState.Placeholder))
            {
                return GridState.Stone;
            }

            return GridState.Placeholder;
        }

        public void SetGrid(int x, int y, GridState state)
        {
            if (state == GridState.None)
            {
                _matrix[x + y * Core.GEM_COUNT] = (byte)state;
                _matrix[x + 1 + y * Core.GEM_COUNT] = (byte)state;
                _matrix[x + (y + 1) * Core.GEM_COUNT] = (byte)state;
                _matrix[x + 1 + (y + 1) * Core.GEM_COUNT] = (byte)state;
            }
            else if (state == GridState.Way)
            {
                _matrixBackground[x + y * Core.GEM_COUNT] = (byte)state;
                _matrixBackground[x + 1 + y * Core.GEM_COUNT] = (byte)GridState.Placeholder;
                _matrixBackground[x + (y + 1) * Core.GEM_COUNT] = (byte)GridState.Placeholder;
                _matrixBackground[x + 1 + (y + 1) * Core.GEM_COUNT] = (byte)GridState.Placeholder;
            }
            else
            {
                _matrix[x + y * Core.GEM_COUNT] = (byte)state;
                _matrix[x + 1 + y * Core.GEM_COUNT] = (byte)GridState.Placeholder;
                _matrix[x + (y + 1) * Core.GEM_COUNT] = (byte)GridState.Placeholder;
                _matrix[x + 1 + (y + 1) * Core.GEM_COUNT] = (byte)GridState.Placeholder;
            }
        }

        public bool SetCell(int x, int y, bool isLeft)
        {
            var state = GetGridState(x, y);

            if (isLeft && (state == GridState.None || state == GridState.Way))
            {
                SetGrid(x, y, GridState.Stone);

                this.Invalidate();
                return true;
            }
            else if (!isLeft && state == GridState.Stone)
            {
                SetGrid(x, y, GridState.None);

                this.Invalidate();
                return true;
            }

            return false;
        }
      
        #endregion
    }
}
