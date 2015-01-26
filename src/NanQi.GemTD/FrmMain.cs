using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NanQi.GemTD
{
    public partial class FrmMain : Form
    {
        Point _prePoint = Point.Empty;
        bool _isMouseDown = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            worldMap.CreateWorld(1);
            openDLG.Filter = "迷宫文件|*.td|所有文件|*.*";
            saveDLG.Filter = "迷宫文件|*.td";
        }

        private void worldMap_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)(((float)e.X) * Core.GEM_COUNT / worldMap.Width);
            int y = (int)(((float)e.Y) * Core.GEM_COUNT / worldMap.Height);

            if (x < 0 || x >= Core.GEM_COUNT - 1 || y <0 || y >= Core.GEM_COUNT - 1)
            {
                return;
            }

            var pnt = new Point(x, y);

            sbpLocation.Text = pnt.ToString();

            if (_prePoint != pnt)
            {
                if (_isMouseDown)
                {
                    worldMap_MouseDown(null, e);
                }

                _prePoint = pnt;
                worldMap.Invalidate();
            }

            float cellWidth = (float)worldMap.Width / Core.GEM_COUNT;
            float cellHeight = (float)worldMap.Height / Core.GEM_COUNT;

            var g = worldMap.CreateGraphics();

            Brush brush = SystemBrushes.Highlight;

            var state = worldMap.GetGridState(x, y);

            if (state == GridState.Placeholder)
            {
                brush = Brushes.Red;
            }

            g.FillRectangle(brush, x * cellWidth, y * cellHeight, cellWidth * 2 - 2, cellHeight * 2 - 2);
        }

        private void worldMap_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (int)(((float)e.X) * Core.GEM_COUNT / worldMap.Width);
            int y = (int)(((float)e.Y) * Core.GEM_COUNT / worldMap.Height);

            if (x < 0 || x >= Core.GEM_COUNT - 1 || y < 0 || y >= Core.GEM_COUNT - 1)
            {
                return;
            }

            worldMap.SetCell(x, y, e.Button == System.Windows.Forms.MouseButtons.Left);

            _isMouseDown = true;
        }

        private void worldMap_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (openDLG.ShowDialog(this) == DialogResult.OK)
            {
                if (openDLG.FileName.Length == 0)
                    return;

                FileStream fs = new FileStream(openDLG.FileName, FileMode.Open, FileAccess.Read);

                byte[] header = new byte[13];
                fs.Read(header, 0, header.Length);

                byte[] v1 = new byte[4];
                byte[] v2 = new byte[4];
                byte[] v3 = new byte[4];
                byte[] v4 = new byte[4];

                fs.Read(v1, 0, v1.Length);
                fs.ReadByte();
                fs.Read(v2, 0, v2.Length);
                fs.ReadByte();
                fs.Read(v3, 0, v3.Length);
                fs.ReadByte();
                fs.Read(v4, 0, v4.Length);

                Version version = new Version(BitConverter.ToInt32(v1, 0), BitConverter.ToInt32(v2, 0), 
                    BitConverter.ToInt32(v3, 0), BitConverter.ToInt32(v4, 0));
                Version ApplicationVersion = new Version(Application.ProductVersion);

                if (version != ApplicationVersion)
                {
                    MessageBox.Show("迷宫文件版本与当前版本不一致，可能出现解析出错的情况", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                byte[] gemCount = new byte[4];
                byte[] dataLength = new byte[8];
                fs.Read(gemCount, 0, gemCount.Length);
                fs.ReadByte();
                fs.Read(dataLength, 0, dataLength.Length);

                int count = BitConverter.ToInt32(gemCount, 0);

                if (count != Core.GEM_COUNT)
                {
                    MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }

                for (int y = 0; y < Core.GEM_COUNT; y++)
                    for (int x = 0; x < Core.GEM_COUNT; x++)
                        worldMap.Matrix[x + y * Core.GEM_COUNT] = (byte)fs.ReadByte();

                fs.Close();
                worldMap.Invalidate();
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            saveDLG.InitialDirectory = Application.StartupPath;

            if (saveDLG.ShowDialog(this) == DialogResult.OK)
            {
                if (saveDLG.FileName.Length == 0)
                    return;

                FileStream fs = new FileStream(saveDLG.FileName, FileMode.Create, FileAccess.Write);

                byte[] header = Encoding.UTF8.GetBytes("NanQi GemTD V");
                fs.Write(header, 0, header.Length);

                Version ApplicationVersion = new Version(Application.ProductVersion);
                var v1 = BitConverter.GetBytes(ApplicationVersion.Major);
                var v2 = BitConverter.GetBytes(ApplicationVersion.Minor);
                var v3 = BitConverter.GetBytes(ApplicationVersion.Build);
                var v4 = BitConverter.GetBytes(ApplicationVersion.Revision);

                fs.Write(v1, 0, v1.Length);
                fs.WriteByte(46);
                fs.Write(v2, 0, v2.Length);
                fs.WriteByte(46);
                fs.Write(v3, 0, v3.Length);
                fs.WriteByte(46);
                fs.Write(v4, 0, v4.Length);

                var count = BitConverter.GetBytes(Core.GEM_COUNT);
                long tmpLen = Core.GEM_COUNT * Core.GEM_COUNT;
                var dataLength = BitConverter.GetBytes(tmpLen);

                fs.Write(count, 0, count.Length);
                fs.WriteByte((byte)',');
                fs.Write(dataLength, 0, dataLength.Length);

                for (int y = 0; y < Core.GEM_COUNT; y++)
                    for (int x = 0; x < Core.GEM_COUNT; x++)
                        fs.WriteByte(worldMap.Matrix[x + y * Core.GEM_COUNT]);

                fs.Close();
            }
        }

        private void tsmiReset_Click(object sender, EventArgs e)
        {
            worldMap.CreateWorld(1);
        }
    }
}
