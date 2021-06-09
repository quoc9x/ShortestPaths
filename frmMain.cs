using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace ShortestPaths
{
    public partial class frmMain : Form
    {
        #region InitializeProgram
        public frmMain()
        {
            InitializeComponent();
        }
        
        private Graph graph;
        private DijkstraShortestPathAlg spAlg;
        private YenTopKShortestPathsAlg yenAlg;
        /// <summary>
        /// Kiểm tra đỉnh bắt đầu
        /// </summary>
        private int minVertex = 1000000;
        /// <summary>
        /// Max của độ dài các cạnh
        /// </summary>
        const int MAXINT = 1000000000;

        #endregion

        #region Các hàm hỗ trợ
        void ReadData()
        {
            try
            {
                string path = Application.StartupPath;
                OpenFileDialog Odg = new OpenFileDialog()
                {
                    FileName = "Select a File",
                    Filter = "Select files (*.txt)|*.txt",
                    Title = "Open file"
                };

                Odg.InitialDirectory = path;

                if (Odg.ShowDialog() == DialogResult.OK)
                {
                    string filePath = Odg.FileName;

                    using (var reader = new StreamReader(filePath))
                    {
                        string data = reader.ReadLine();
                        n = Convert.ToInt32(data.Trim());
                        A = new int[n + 1, n + 1];
                        while ((data = reader.ReadLine()) != null)
                        {
                            data = data.Trim();
                            var s = data.Split('\t', ' ');
                            if (s.Length == 3)
                            {
                                int x = Convert.ToInt32(s[0]);
                                int y = Convert.ToInt32(s[1]);
                                int z = Convert.ToInt32(s[2]);
                                A[x, y] = z;
                                if (x < minVertex) minVertex = x;
                                else if (y < minVertex) minVertex = y;
                            }
                        }
                    }
                    if (graph != null)
                    {
                        graph = null;
                    }
                    graph = new VariableGraph(System.IO.Path.GetFileNameWithoutExtension(Odg.FileName) + ".txt");
                    MessageBox.Show("Đọc dữ liệu thành công", "Đường đi ngắn nhất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSource.Enabled = true;
                    txtDest.Enabled = true;
                    btnExecute.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi! \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Reset()
        {
            Cursor.Current = Cursors.WaitCursor;
            txtDest.Text = "";
            txtSource.Text = "";
            rtbResult.Text = "";
            txtSource.Enabled = false;
            txtDest.Enabled = false;
            btnExecute.Enabled = false;
            graph = null;
            Cursor.Current = Cursors.Default;
        }

        #endregion

        #region BFS
        // Mảng lưu dữ liệu đồ thị
        int[,] A;
        // Mảng lưu đường đi
        int[] L;
        // Điểm đi, điểm đến
        int source, dest;
        // Số đỉnh của đồ thị
        int n;
        // Mảng đánh dấu các đỉnh đã đi qua
        int[] Tick;
        // Giá trị đường đi ngắn nhất
        int minLength = MAXINT;
        // Các đỉnh đã đi qua
        string minPath = "";

        void InitializeBFS()
        {
            L = new int[n + 1];
            Tick = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                Tick[i] = 0;
                L[i] = 0;
            }
            Tick[source] = 1;
            L[1] = source;
            minLength = MAXINT;
        }

        void SaveResult(int edge)
        {
            string path = source.ToString() + " -> ";
            int length = 0;
            for (int i = 2; i <= edge; i++)
            {
                path = path + L[i].ToString() + " -> ";
                length = length + A[L[i - 1], L[i]];
            }
            if (length < minLength)
            {
                minLength = length;
                minPath = path;
            }
        }

        // Hàm đệ quy tìm mọi đường đi ngắn nhất giữa hai đỉnh
        void TryBFS(int edge)
        {
            if (L[edge] == dest)
            {
                // Mảng L là mảng lưu kết quả đường đi
                SaveResult(edge);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                    if (A[L[edge], i] > 0 && Tick[i] == 0)
                    {
                        L[edge + 1] = i;
                        Tick[i] = 1;
                        TryBFS(edge + 1);
                        L[edge + 1] = 0;
                        Tick[i] = 0;
                    }
            }
        }

        #endregion

        #region Ford-Bellman
        int[] d;
        int[] Trace;
        void InitializeFord_Bellman()
        {
            d = new int[n + 1];
            Trace = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                d[i] = MAXINT;
                for (int j = 1; j <= n; j++)
                {
                    if (A[i, j] == 0 && i != j)
                        A[i, j] = MAXINT;
                }
            }
            d[source] = 0;
        }

        void Restore()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (A[i, j] == MAXINT)
                        A[i, j] = 0;
                }
            }
        }

        void Ford_Bellman()
        {
            bool isStop;
            for (int i = 1; i < n; i++)
            {
                isStop = true;
                for (int u = 1; u <= n; u++)
                    for (int v = 1; v <= n; v++)
                    {
                        if (A[u, v] + d[u] < d[v])
                        {
                            d[v] = d[u] + A[u, v];
                            Trace[v] = u;
                            isStop = false;
                        }
                    }

                if (isStop) break;
            }
        }

        string PrintResult()
        {
            string res = "";
            if (d[dest] == MAXINT)
            {
                res = "Không có đường đi từ " + source + "đến " + dest;
            }
            else
            {
                int path = d[dest];
                while (dest != source)
                {
                    res += dest + " <-- ";
                    dest = Trace[dest];
                }
                res += source + ": " + path;
            }
            return res;
        }
        #endregion

        #region Dijkstra
        string Dijkstra(int[,] A, int n, int src, int des)
        {
            int[] DanhDau = new int[n + 1];
            int[] Nhan = new int[n + 1];
            int[] Truoc = new int[n + 1];
            int XP, min, i;
            for (i = 1; i <= n; i++)
            {
                Nhan[i] = MAXINT;
                DanhDau[i] = 0;
                Truoc[i] = src;
            }
            Nhan[src] = 0;
            DanhDau[src] = 1;
            XP = src;
            while (XP != des)
            {
                for (int j = 1; j <= n; j++)
                    if (A[XP, j] > 0 && Nhan[j] > A[XP, j] + Nhan[XP] && DanhDau[j] == 0)
                    {
                        Nhan[j] = A[XP, j] + Nhan[XP];
                        Truoc[j] = XP;
                    }
                min = MAXINT;
                for (int j = 1; j <= n; j++)
                    if (min > Nhan[j] && DanhDau[j] == 0)
                    {
                        min = Nhan[j];
                        XP = j;
                    }
                DanhDau[XP] = 1;
            }

            // Truy vết đường đi và in kết quả
            string[] temp = new string[n + 1];
            temp[0] = des.ToString();
            temp[1] = Truoc[des].ToString();
            i = Truoc[des];
            int count = 2;
            while (i != src)
            {
                i = Truoc[i];
                temp[count] = i.ToString();
                count++;
            }
            string res = "";
            for (i = count - 1; i >= 1; i--)
                res += temp[i] + " --> ";
            res += temp[0] + ": " + Nhan[des];

            return res;
        }
        #endregion

        #region Các hàm xử lý sự kiện

        
        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                source = Convert.ToInt16(txtSource.Text);
                dest = Convert.ToInt16(txtDest.Text);

                if (source >= minVertex && dest <= n)
                {
                    var watch = new Stopwatch();
                    watch.Start();
                    if (rdoBFS.Checked)
                    {
                        InitializeBFS();
                        TryBFS(source);
                        minPath = minPath.Substring(0, minPath.Length - 3);
                        rtbResult.Text = minPath + ": " + minLength;
                    }
                    else if (rdoFordBellman.Checked)
                    {
                        InitializeFord_Bellman();
                        Ford_Bellman();
                        rtbResult.Text = PrintResult();
                        Restore();
                    }
                    else if (rdoDijkstra.Checked)
                    {
                        rtbResult.Text = Dijkstra(A, n, source, dest);
                    }
                    else if (rdoYen.Checked)
                    {
                        int numberYen = Convert.ToInt32(txtNumberYen.Text);
                        spAlg = new DijkstraShortestPathAlg(graph);
                        yenAlg = new YenTopKShortestPathsAlg(graph);

                        Path sp = spAlg.get_shortest_path(graph.get_vertex(source), graph.get_vertex(dest));
                        rtbResult.Text = "Top " + numberYen + " đường đi ngắn nhất: \n";

                        List<Path> shortest_paths_list = yenAlg.get_shortest_paths(
                            graph.get_vertex(source), graph.get_vertex(dest), numberYen);

                        foreach (Path path in shortest_paths_list)
                        {
                            rtbResult.Text += path.ToString() + "\n";
                        }
                    }
                    watch.Stop();
                    lbTime.Text = "Thời gian thực hiện chương trình: " + watch.Elapsed.TotalMilliseconds + " ms";
                }
                else
                {
                    MessageBox.Show("Điểm bắt đầu phải >= " + minVertex + " và Điểm đến phải <= " + n,
                        "Đường đi ngắn nhất", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mniOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
                Cursor.Current = Cursors.WaitCursor;
                ReadData();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "Đường đi ngắn nhất", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdoYen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYen.Checked)
            {
                txtNumberYen.Enabled = true;
            }
            else
            {
                txtNumberYen.Enabled = false;
            }
        }

        private void mniReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        #endregion
    }
}
