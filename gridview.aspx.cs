using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace graph2
{
    struct dstthrough {
       public string dstination;
       public string throughdst;
    }
    public partial class gridview : System.Web.UI.Page
    {
       
       

        int Inf = 99999;
        int[,] D = new int[39, 39];       /// provided adjancency matrix in exvel sheet
        int[,] P = new int[39, 39];    
        List<String> YrStrList2 = new List<string>();
        Graph mygraph = new Graph();
        string myitem;
        string myitem2;
        public DataSet ExcelToDS()          // reading from excel file
        {
            string Path = @"H:\Algo-Spring2016-SampleGraphApr28.xlsx";
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0; ";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            strExcel = "select * from [sheet1$]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");
            return ds;      
        }
    
        protected int[,] resetMatrix(int[,]arr) {           // initially reset matrix for normally floyed  working
            //initialize array D
            for (int i = 0; i < 39; i++)
            {
                for (int j = 0; j < 39; j++)
                {
                   
                    P[i, j] = 0;    //initialize array P with zeros
                    if (i == j)
                    {
                       
                        D[i, j] = 0;
                        
                    }
                    else if (arr[i, j] == 0)
                    {
                        
                        D[i, j] = Inf;
                       
                    }
                    else
                    {  
                        D[i, j] = arr[i, j];
                        
                    }
                }
            }

            for (int i = 0; i < 39; i++)
            {
                for (int j = 0; j < 39; j++)
                {
                    
                    if (D[i, j] != Inf)
                    {
                       
                        D[j, i] = D[i, j];
                    }
                }
            }


            return D;

        }
   
        protected int[,] Floyd(int [,] D,int n)     //  floyed algo that give matrxi D, computed shortest path between all cities
        {
            
            
            //========================================//


            for (int k = 0; k < n; k++)

            {
               
                for (int i = 0; i < n; i++)

                {

                    for (int j = 0; j < n; j++)

                    {
                      
                        if (D[i, k] + D[k, j] < D[i, j])

                        {
                            
                            D[i, j] = D[i, k] + D[k, j];

                            P[i, j] = k;



                        }
                      
                    }

                }

            }


           
            return D;
        }

        //==============================================Back Track Matrxi P for path finding===============================================
        string shortest(int i, int j, string through)

        {

            int k = P[i, j];

            if (k > 0)

            {

                through = shortest(i, k, through);

                Console.WriteLine("  " + k + "  ");
                through = through + k.ToString() + ",";

                through = shortest(k, j, through);

            }
            return through;
        }
        string findpath(int[,] a, int i, int j, int n)

        {
            string through = null;
            for (int i1 = 0; i1 < n; i1++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    a[i, j] = a[i, j];
                }

            }


            Console.WriteLine("Path from " + i + " to " + j + ":");

            if (a[i, j] < Inf)

            {
                through = through + i.ToString() + ",";

                Console.WriteLine("  " + i + "  ");


                through = shortest(i, j, through);

                Console.WriteLine("  " + j + "  ");
                through = through + j.ToString() + ",";
            }
            return through;
        }

        /// <summary>
        ///  Initilaization of graphs, vertices , edgess
        /// </summary>
        protected void loadData()
        {
           
            
            DataSet db = new DataSet();
            db = ExcelToDS();
           
            
            for (int i = 1; i < 40; i++)
            {
                Vertex v = new Vertex();
                v.Name = db.Tables[0].Columns[i].ToString();
                mygraph.Vertices.Add(v);
              
                   
            }

            
            mygraph.vedges = new int[39, 39];
            int INF = 99999;
            for (int i = 0; i < 39; i++)
            {
                int k = 0;
                for (int j = 1; j < 40; j++)
                {
                    if (Convert.ToInt32(db.Tables[0].Rows[i][j].ToString()) == 0)
                    {
                        mygraph.vedges[i, k] = INF;
                    }
                    else if (Convert.ToInt32(db.Tables[0].Rows[i][j].ToString()) >0) {
                        mygraph.vedges[i, k] = Convert.ToInt32(db.Tables[0].Rows[i][j].ToString()); }
                    if (i==k) {
                        mygraph.vedges[i, k] = 0;
                    }
                    k++;
                }
            }
        
        }

        protected void Page_Load(object sender, EventArgs e)
        {   
            List<string> cities = new List<string>();
            cities.Add("Gilgit");
           cities.Add("Chitral");
          cities.Add("Dasu");
            cities.Add("Dir");
            cities.Add("Malakand");
            cities.Add("Noshera");
           cities.Add("Mansehra");
           cities.Add("Hassan Abdal");
            cities.Add("Peshawar");
           cities.Add("Attock");
            cities.Add("Kohat");
            cities.Add("Islamabad");
            cities.Add("Murree");
            cities.Add("Rawat");
           cities.Add("Balkasar");
           cities.Add("Chakwal");
            cities.Add("Mianwali");
            cities.Add("Bhera");
            cities.Add("Sargoda");
           cities.Add("Pindi Bhattian");
            cities.Add("Jhang");
           cities.Add("Faisalabad");
            cities.Add("Lahore");
            cities.Add("Dina");
           cities.Add("Gujranwala");
            cities.Add("Multan");
          cities.Add("DG Khan");
            cities.Add("Bahwalpur");
           cities.Add("Sukkur");
            cities.Add("Rajanpur");
           cities.Add("Loralai");
            cities.Add("Jacobabad");
            cities.Add("Quetta");
            cities.Add("Khuzdar");
            cities.Add("Karachi");
            cities.Add("Lasbela");
           cities.Add("Gwadar");
           cities.Add("Awaran");
            cities.Add("Turbat");



            if (!IsPostBack) {
                CheckBoxList1.DataSource = cities;
                CheckBoxList2.DataSource = cities;
                CheckBoxList3.DataSource = cities;
                CheckBoxList1.DataBind();
                CheckBoxList2.DataBind();
                CheckBoxList3.DataBind();
                
            }
            GridView1.DataSource = ExcelToDS().Tables[0];
            GridView1.DataBind();

            loadData();
            int[,] prep2 = new int[39,39];
            int[,] D1 = resetMatrix(mygraph.vedges);
            for (int i = 0; i < 39; i++)
            {
                for (int j = 0; j < 39; j++)
                {
                    prep2[i, j] = D1[i,j];
                }

            }
         //   int[,] prevD = resetMatrix2(mygraph.vedges);
            int [,] Dp= Floyd(D1, 39);
   
           //========================================================================//
            
            Prims obj = new Prims();
            List<totaledgs> newlist= obj.primMST(mygraph.vedges);
            ListBox7.DataSource = newlist;
            ListBox8.DataSource = newlist;
            ListBox9.DataSource = newlist;
            Label2.Text = newlist[1].Weight.ToString();
            ListBox7.DataTextField = "src";
            ListBox7.DataBind();
            ListBox8.DataTextField = "dst";
            ListBox8.DataBind();
            ListBox9.DataTextField = "weight";
            ListBox9.DataBind();
           
        }

        // check box lis handler to get value of selected item
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> YrStrList = new List<string>();
           
            // Loop through each item.
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    // If the item is selected, add the value to the list.
                    YrStrList.Add(item.Value);
                    myitem = item.Value;
                }
                else
                {
                    // Item is not selected, do something else.
                }
            }
        }

        protected void CheckBoxList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> YrStrList2 = new List<string>();
            
            // Loop through each item.
            foreach (ListItem item in CheckBoxList2.Items)
            {
                if (item.Selected)
                {
                    // If the item is selected, add the value to the list.
                    YrStrList2.Add(item.Value);
                    myitem2 = item.Value;
                    
                }
                else
                {
                    // Item is not selected, do something else.
                }
            }

        }
        protected void CheckBoxList3_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            // Loop through each item.
            foreach (ListItem item in CheckBoxList3.Items)
            {
                if (item.Selected)
                {
                    // If the item is selected, add the value to the list.
                    YrStrList2.Add(item.Value);
                   

                }
                else
                {
                    // Item is not selected, do something else.
                }
            }
            ListBox10.DataSource = YrStrList2;
            ListBox10.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)// button for single source Short 
        {
           
           var accounts1 = new Dictionary<string, int>();
            accounts1["Gilgit"] = 0;
            accounts1["Chitral"] = 1;
            accounts1["Dasu"] = 2;
            accounts1["Dir"] = 3;
            accounts1["Malakand"] = 4;
            accounts1["Noshera"] = 5;
            accounts1["Mansehra"] = 6;
            accounts1["Hassan Abdal"] = 7;
            accounts1["Peshawar"] = 8;
            accounts1["Attock"] = 9;
            accounts1["Kohat"] = 10;
            accounts1["Islamabad"] = 11;
            accounts1["Murree"] = 12;
            accounts1["Rawat"] = 13;
            accounts1["Balkasar"] = 14;
            accounts1["Chakwal"] = 15;
            accounts1["Mianwali"] = 16;
            accounts1["Bhera"] = 17;
            accounts1["Sargoda"] = 18;
            accounts1["Pindi Bhattian"] = 19;
            accounts1["Jhang"] = 20;
            accounts1["Faisalabad"] = 21;
            accounts1["Lahore"] = 22;
            accounts1["Dina"] = 23;
            accounts1["Gujranwala"] = 24;
            accounts1["Multan"] = 25;
            accounts1["DG Khan"] = 26;
            accounts1["Bahwalpur"] = 27;
            accounts1["Sukkur"] = 28;
            accounts1["Rajanpur"] = 29;
            accounts1["Loralai"] = 30;
            accounts1["Jacobabad"] = 31;
            accounts1["Quetta"] = 32;
            accounts1["Khuzdar"] = 33;
            accounts1["Karachi"] = 34;
            accounts1["Lasbela"] = 35;
            accounts1["Gwadar"] = 36;
            accounts1["Awaran"] = 37;
            accounts1["Turbat"] = 38;


            var accounts = new Dictionary<int, string>();
            accounts[0] = "Gilgit";
            accounts[1] = "Chitral";
            accounts[2] = "Dasu";
            accounts[3] = "Dir";
            accounts[4] = "Malakand";
            accounts[5] = "Noshera";
            accounts[6] = "Mansehra";
            accounts[7] = "Hassan Abdal";
            accounts[8] = "Peshawar";
            accounts[9] = "Attock";
            accounts[10] = "Kohat";
            accounts[11] = "Islamabad";
            accounts[12] = "Murree";
            accounts[13] = "Rawat";
            accounts[14] = "Balkasar";
            accounts[15] = "Chakwal";
            accounts[16] = "Mianwali";
            accounts[17] = "Bhera";
            accounts[18] = "Sargoda";
            accounts[19] = "Pindi Bhattian";
            accounts[20] = "Jhang";
            accounts[21] = "Faisalabad";
            accounts[22] = "Lahore";
            accounts[23] = "Dina";
            accounts[24] = "Gujranwala";
            accounts[25] = "Multan";
            accounts[26] = "DG Khan";
            accounts[27] = "Bahwalpur";
            accounts[28] = "Sukkur";
            accounts[29] = "Rajanpur";
            accounts[30] = "Loralai";
            accounts[31] = "Jacobabad";
            accounts[32] = "Quetta";
            accounts[33] = "Khuzdar";
            accounts[34] = "Karachi";
            accounts[35] = "Lasbela";
            accounts[36] = "Gwadar";
            accounts[37] = "Awaran";
            accounts[38] = "Turbat";
            //int[,] D = resetMatrix(mygraph.vedges);
            //Floyd(D, 39);
            //
            var str= accounts1[myitem];
            var str2 = accounts1[myitem2];
            string res = findpath(D, str , str2, 39);
            Label1.Text = res;

            string[] values = res.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();
            }
            //Label1.Text = values[0];
            //  Label2.Text = accounts[3];
            for (int i = 0; i < values.Length-1; i++)
            {
                values[i] = accounts[Convert.ToInt32(values[i])];
            }
            ListBox1.DataSource = values;
            ListBox1.DataBind();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "  <script>singlePairo();</script>");
        }

        protected void Button2_Click(object sender, EventArgs e) // single destination
        {
            
            var accounts1 = new Dictionary<string, int>();
            accounts1["Gilgit"] = 0;
            accounts1["Chitral"] = 1;
            accounts1["Dasu"] = 2;
            accounts1["Dir"] = 3;
            accounts1["Malakand"] = 4;
            accounts1["Noshera"] = 5;
            accounts1["Mansehra"] = 6;
            accounts1["Hassan Abdal"] = 7;
            accounts1["Peshawar"] = 8;
            accounts1["Attock"] = 9;
            accounts1["Kohat"] = 10;
            accounts1["Islamabad"] = 11;
            accounts1["Murree"] = 12;
            accounts1["Rawat"] = 13;
            accounts1["Balkasar"] = 14;
            accounts1["Chakwal"] = 15;
            accounts1["Mianwali"] = 16;
            accounts1["Bhera"] = 17;
            accounts1["Sargoda"] = 18;
            accounts1["Pindi Bhattian"] = 19;
            accounts1["Jhang"] = 20;
            accounts1["Faisalabad"] = 21;
            accounts1["Lahore"] = 22;
            accounts1["Dina"] = 23;
            accounts1["Gujranwala"] = 24;
            accounts1["Multan"] = 25;
            accounts1["DG Khan"] = 26;
            accounts1["Bahwalpur"] = 27;
            accounts1["Sukkur"] = 28;
            accounts1["Rajanpur"] = 29;
            accounts1["Loralai"] = 30;
            accounts1["Jacobabad"] = 31;
            accounts1["Quetta"] = 32;
            accounts1["Khuzdar"] = 33;
            accounts1["Karachi"] = 34;
            accounts1["Lasbela"] = 35;
            accounts1["Gwadar"] = 36;
            accounts1["Awaran"] = 37;
            accounts1["Turbat"] = 38;


            var accounts = new Dictionary<int, string>();
            accounts[0] = "Gilgit";
            accounts[1] = "Chitral";
            accounts[2] = "Dasu";
            accounts[3] = "Dir";
            accounts[4] = "Malakand";
            accounts[5] = "Noshera";
            accounts[6] = "Mansehra";
            accounts[7] = "Hassan Abdal";
            accounts[8] = "Peshawar";
            accounts[9] = "Attock";
            accounts[10] = "Kohat";
            accounts[11] = "Islamabad";
            accounts[12] = "Murree";
            accounts[13] = "Rawat";
            accounts[14] = "Balkasar";
            accounts[15] = "Chakwal";
            accounts[16] = "Mianwali";
            accounts[17] = "Bhera";
            accounts[18] = "Sargoda";
            accounts[19] = "Pindi Bhattian";
            accounts[20] = "Jhang";
            accounts[21] = "Faisalabad";
            accounts[22] = "Lahore";
            accounts[23] = "Dina";
            accounts[24] = "Gujranwala";
            accounts[25] = "Multan";
            accounts[26] = "DG Khan";
            accounts[27] = "Bahwalpur";
            accounts[28] = "Sukkur";
            accounts[29] = "Rajanpur";
            accounts[30] = "Loralai";
            accounts[31] = "Jacobabad";
            accounts[32] = "Quetta";
            accounts[33] = "Khuzdar";
            accounts[34] = "Karachi";
            accounts[35] = "Lasbela";
            accounts[36] = "Gwadar";
            accounts[37] = "Awaran";
            accounts[38] = "Turbat";
            string src=TextBox1.Text;
            int src1 = accounts1[src];
            List<dstthrough> throughlist = new List<dstthrough>();
            for (int i = 0; i < mygraph.Vertices.Count(); i++)
            {
                
                 dstthrough obj;
               if (!src.Equals(mygraph.Vertices[i].Name)) {
                 int dst = accounts1[mygraph.Vertices[i].Name.ToString()];
                 obj.dstination = mygraph.Vertices[i].Name;

                 string res = findpath(D, src1, dst, 39);
                 obj.throughdst = res;
                 throughlist.Add(obj);



                }


            }
            
            List<string> dstt = new List<string>();
            List<string> pth = new List<string>();
            
            for (int i=0; i< throughlist.Count();i++) {
                string thr = "";
                dstt.Add(throughlist[i].dstination);
                string[] values = throughlist[i].throughdst.Split(',');
                for (int j = 0; j < values.Length-1; j++)
                {
                    Label2.Text = values[j];
                    thr += accounts[Convert.ToInt32(values[j])] +"->";
                }

                pth.Add(thr);
            }
            Label1.Text = dstt[37];
            ListBox2.DataSource = dstt;
            ListBox2.DataBind();
            ListBox3.DataSource = pth;
          
            ListBox3.DataBind();

            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "  <script>singlesrgraph();</script>");
            //  Label2.Text = throughlist.Count().ToString();




        }
        protected void Button4_Click(object sender, EventArgs e)        // single pair
        {
            Label1.Text = "hi";
            var accounts1 = new Dictionary<string, int>();
            accounts1["Gilgit"] = 0;
            accounts1["Chitral"] = 1;
            accounts1["Dasu"] = 2;
            accounts1["Dir"] = 3;
            accounts1["Malakand"] = 4;
            accounts1["Noshera"] = 5;
            accounts1["Mansehra"] = 6;
            accounts1["Hassan Abdal"] = 7;
            accounts1["Peshawar"] = 8;
            accounts1["Attock"] = 9;
            accounts1["Kohat"] = 10;
            accounts1["Islamabad"] = 11;
            accounts1["Murree"] = 12;
            accounts1["Rawat"] = 13;
            accounts1["Balkasar"] = 14;
            accounts1["Chakwal"] = 15;
            accounts1["Mianwali"] = 16;
            accounts1["Bhera"] = 17;
            accounts1["Sargoda"] = 18;
            accounts1["Pindi Bhattian"] = 19;
            accounts1["Jhang"] = 20;
            accounts1["Faisalabad"] = 21;
            accounts1["Lahore"] = 22;
            accounts1["Dina"] = 23;
            accounts1["Gujranwala"] = 24;
            accounts1["Multan"] = 25;
            accounts1["DG Khan"] = 26;
            accounts1["Bahwalpur"] = 27;
            accounts1["Sukkur"] = 28;
            accounts1["Rajanpur"] = 29;
            accounts1["Loralai"] = 30;
            accounts1["Jacobabad"] = 31;
            accounts1["Quetta"] = 32;
            accounts1["Khuzdar"] = 33;
            accounts1["Karachi"] = 34;
            accounts1["Lasbela"] = 35;
            accounts1["Gwadar"] = 36;
            accounts1["Awaran"] = 37;
            accounts1["Turbat"] = 38;


            var accounts = new Dictionary<int, string>();
            accounts[0] = "Gilgit";
            accounts[1] = "Chitral";
            accounts[2] = "Dasu";
            accounts[3] = "Dir";
            accounts[4] = "Malakand";
            accounts[5] = "Noshera";
            accounts[6] = "Mansehra";
            accounts[7] = "Hassan Abdal";
            accounts[8] = "Peshawar";
            accounts[9] = "Attock";
            accounts[10] = "Kohat";
            accounts[11] = "Islamabad";
            accounts[12] = "Murree";
            accounts[13] = "Rawat";
            accounts[14] = "Balkasar";
            accounts[15] = "Chakwal";
            accounts[16] = "Mianwali";
            accounts[17] = "Bhera";
            accounts[18] = "Sargoda";
            accounts[19] = "Pindi Bhattian";
            accounts[20] = "Jhang";
            accounts[21] = "Faisalabad";
            accounts[22] = "Lahore";
            accounts[23] = "Dina";
            accounts[24] = "Gujranwala";
            accounts[25] = "Multan";
            accounts[26] = "DG Khan";
            accounts[27] = "Bahwalpur";
            accounts[28] = "Sukkur";
            accounts[29] = "Rajanpur";
            accounts[30] = "Loralai";
            accounts[31] = "Jacobabad";
            accounts[32] = "Quetta";
            accounts[33] = "Khuzdar";
            accounts[34] = "Karachi";
            accounts[35] = "Lasbela";
            accounts[36] = "Gwadar";
            accounts[37] = "Awaran";
            accounts[38] = "Turbat";
            string src = TextBox3.Text;
            int src1 = accounts1[src];
            List<dstthrough> throughlist = new List<dstthrough>();
            for (int i = 0; i < mygraph.Vertices.Count(); i++)
            {

                dstthrough obj;
                if (!src.Equals(mygraph.Vertices[i].Name))
                {
                    int dst = accounts1[mygraph.Vertices[i].Name.ToString()];
                    obj.dstination = mygraph.Vertices[i].Name;

                    string res = findpath(D, dst, src1, 39);
                    obj.throughdst = res;
                    throughlist.Add(obj);



                }


            }

            List<string> dstt = new List<string>();
            List<string> pth = new List<string>();

            for (int i = 0; i < throughlist.Count(); i++)
            {
                string thr = "";
                dstt.Add(throughlist[i].dstination);
                string[] values = throughlist[i].throughdst.Split(',');
                for (int j = 0; j < values.Length - 1; j++)
                {
                    Label2.Text = values[j];
                    thr += accounts[Convert.ToInt32(values[j])] + "->";
                }

                pth.Add(thr);
            }
            //Label1.Text = dstt[37];
            ListBox4.DataSource = dstt;
            ListBox4.DataBind();
            ListBox5.DataSource = pth;

            ListBox5.DataBind();

            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "  <script>singledstgraph();</script>");
            //  Label2.Text = throughlist.Count().ToString();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string someVaribaleName = GridView1.SelectedRow.Cells[1].Text;
            Label1.Text = someVaribaleName;

        }

        protected void Button5_Click(object sender, EventArgs e)            // all pair
        {
            
            var accounts1 = new Dictionary<string, int>();
            accounts1["Gilgit"] = 0;
            accounts1["Chitral"] = 1;
            accounts1["Dasu"] = 2;
            accounts1["Dir"] = 3;
            accounts1["Malakand"] = 4;
            accounts1["Noshera"] = 5;
            accounts1["Mansehra"] = 6;
            accounts1["Hassan Abdal"] = 7;
            accounts1["Peshawar"] = 8;
            accounts1["Attock"] = 9;
            accounts1["Kohat"] = 10;
            accounts1["Islamabad"] = 11;
            accounts1["Murree"] = 12;
            accounts1["Rawat"] = 13;
            accounts1["Balkasar"] = 14;
            accounts1["Chakwal"] = 15;
            accounts1["Mianwali"] = 16;
            accounts1["Bhera"] = 17;
            accounts1["Sargoda"] = 18;
            accounts1["Pindi Bhattian"] = 19;
            accounts1["Jhang"] = 20;
            accounts1["Faisalabad"] = 21;
            accounts1["Lahore"] = 22;
            accounts1["Dina"] = 23;
            accounts1["Gujranwala"] = 24;
            accounts1["Multan"] = 25;
            accounts1["DG Khan"] = 26;
            accounts1["Bahwalpur"] = 27;
            accounts1["Sukkur"] = 28;
            accounts1["Rajanpur"] = 29;
            accounts1["Loralai"] = 30;
            accounts1["Jacobabad"] = 31;
            accounts1["Quetta"] = 32;
            accounts1["Khuzdar"] = 33;
            accounts1["Karachi"] = 34;
            accounts1["Lasbela"] = 35;
            accounts1["Gwadar"] = 36;
            accounts1["Awaran"] = 37;
            accounts1["Turbat"] = 38;
            var accounts = new Dictionary<int, string>();
            accounts[0] = "Gilgit";
            accounts[1] = "Chitral";
            accounts[2] = "Dasu";
            accounts[3] = "Dir";
            accounts[4] = "Malakand";
            accounts[5] = "Noshera";
            accounts[6] = "Mansehra";
            accounts[7] = "Hassan Abdal";
            accounts[8] = "Peshawar";
            accounts[9] = "Attock";
            accounts[10] = "Kohat";
            accounts[11] = "Islamabad";
            accounts[12] = "Murree";
            accounts[13] = "Rawat";
            accounts[14] = "Balkasar";
            accounts[15] = "Chakwal";
            accounts[16] = "Mianwali";
            accounts[17] = "Bhera";
            accounts[18] = "Sargoda";
            accounts[19] = "Pindi Bhattian";
            accounts[20] = "Jhang";
            accounts[21] = "Faisalabad";
            accounts[22] = "Lahore";
            accounts[23] = "Dina";
            accounts[24] = "Gujranwala";
            accounts[25] = "Multan";
            accounts[26] = "DG Khan";
            accounts[27] = "Bahwalpur";
            accounts[28] = "Sukkur";
            accounts[29] = "Rajanpur";
            accounts[30] = "Loralai";
            accounts[31] = "Jacobabad";
            accounts[32] = "Quetta";
            accounts[33] = "Khuzdar";
            accounts[34] = "Karachi";
            accounts[35] = "Lasbela";
            accounts[36] = "Gwadar";
            accounts[37] = "Awaran";
            accounts[38] = "Turbat";
            
            string src= TextBox4.Text;
            string dst = TextBox5.Text;
            int src1 = accounts1[src];
            int dst1 = accounts1[dst];
            string res = findpath(D, src1, dst1, 39);
            string[] values = res.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();
            }
            //Label1.Text = values[0];
            //  Label2.Text = accounts[3];
            for (int i = 0; i < values.Length - 1; i++)
            {
                values[i] = accounts[Convert.ToInt32(values[i])];
            }
            ListBox6.DataSource = values;
            ListBox6.DataBind();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "  <script>allpairoshrt();</script>");


        }

        protected void Button3_Click(object sender, EventArgs e)
        {


            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "  <script>DistProd();</script>");

        }
     
       
   
    }
}