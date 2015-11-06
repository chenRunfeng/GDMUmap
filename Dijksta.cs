using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace mapdemo2
{
    class Dijksta
    {
          
        private int row;//定义点数
        private double[] distance = new double[1000];  //用来保存距离    
        public ArrayList ways = new ArrayList();//用来保存路径

        public Dijksta(int n, params  double[] d)//保存距离权值
        {
            this.row = n;
            //distance = new int[row * row];
            for (int i = 0; i < row * row; i++)//保存距离
            {
                this.distance[i] = d[i];
            }
            for (int i = 0; i < this.row; i++)  //有row个点，则从中心到各点的路有row-1条
            {
                ArrayList w = new ArrayList();//动态数组里面的元素也是动态数组，类似于二维数组

                int j = 0;//首先保存起点
                w.Add(j);

                ways.Add(w);//每一条路径都有一个共同的起点
            }
        }
        //------------------------------
        public void Find_way()
        {
            ArrayList S = new ArrayList(1);
            ArrayList Sr = new ArrayList(1);
            int[] Indexof_distance = new int[this.row];

            for (int i = 0; i < row; i++)
            {
                Indexof_distance[i] = i;
            }

            S.Add(Indexof_distance[0]);

            for (int i = 0; i < this.row; i++)
            {
                Sr.Add(Indexof_distance[i]);//将中心点到每个点的距离添加到Sr
            }
            Sr.RemoveAt(0);
            double[] D = new double[this.row];    //存放中心点到每个点的距离

            //---------------以上已经初始化了，S和Sr(里边放的都是点的编号)------------------
            int Count = this.row - 1;//编号从0开始，最大为r-1
            while (Count > 0)
            {
                //假定中心点的编号是0的贪吃法求路径
                for (int i = 0; i < row; i++)//存放中心点到每个点的距离
                    D[i] = this.distance[i];

                int min_num = (int)Sr[0];  //距中心点的最小距离点编号

                foreach (int s in Sr)//遍历Sr里面最小距离标号输出距离并和最小距离比较
                {
                    if (D[s] < D[min_num]) min_num = s;
                }

                //以上可以排序优化
                S.Add(min_num);
                Sr.Remove(min_num);
                //-----------把最新包含进来的点也加到路径中-------------
                ((ArrayList)ways[min_num]).Add(min_num);
                //-----------------------------------------------
                foreach (int element in Sr)
                {
                    int position = element * (this.row) + min_num;
                    bool exchange = false;      //有交换标志

                    if (D[element] < D[min_num] + this.distance[position])
                        D[element] = D[element];
                    else
                    {
                        D[element] = this.distance[position] + D[min_num];
                        exchange = true;
                    }
                    //修改距离矩阵                   
                    this.distance[element] = D[element];
                    position = element * this.row;
                    this.distance[position] = D[element];

                    //修改路径---------------
                    if (exchange == true)
                    {
                        ((ArrayList)ways[element]).Clear();
                        foreach (int point in (ArrayList)ways[min_num])
                            ((ArrayList)ways[element]).Add(point);
                    }
                }
                --Count;
            }

        }
        public void Display(ref string way,string end,NodesCollection nodes)
        {
            //------中心到各点的最短路径----------
            //Console.WriteLine("中心到各点的最短路径如下: \n\n");
            //MessageBox.Show("中心到各点的最短路径如下: \n\n");
            int sum_d_index = 0;

            int c = 0;
            int d=0 ;
            //ArrayList p = new ArrayList();

            foreach (ArrayList mother in ways)//遍历每一项{{0}，{012}，{013}}
            {
                string information = nodes[d].Name;
                int[] IResult = (int[])mother.ToArray(typeof(Int32));//输出每一项并转化为数组类型


                if (information == end)//判断要输出的终点
                {
                    for (c = 0; c < IResult.Length; c++)//输出路径
                    {
                        way += nodes[IResult[c]].Name + "--";
                    }
                    way.Remove(way.LastIndexOf("--"),2);
                    way += "距离:" + distance[sum_d_index] + "\r\n";
                }
                d++;
                sum_d_index++;

            }

        }
    }
}
