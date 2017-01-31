<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gridview.aspx.cs" Inherits="graph2.gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="JS/jquery-1.11.0.min.js"></script>
    <script src="kuchbhi/arbor.js"></script>
    
    <script src="kuchbhi/graphics.js"></script>
    <script src="kuchbhi/renderer.js"></script>
    <link href="style.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 120px;
        }
        .auto-style3 {
            width: 39px;
        }
        .auto-style4 {
            width: 367px;
        }
        .auto-style5 {
            width: 172px;
        }
        .auto-style6 {
            width: 232px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
        <nav id="main-menu" class="collapse navbar-collapse pull-right">
                <ul class="nav navbar-nav">
                    
                    <li><a href="#GrpahPlot">Graph</a></li>
                </ul>
            </nav><!-- /.navbar-collapse -->

        <div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            </div>
    
    
        

           <!-- Service Section-->
    <section id="GrpahPlot">
                    <div id ="grpah">
                         <canvas id="viewport" width="1300" height="700">

                               </canvas>
                    </div>
    </section><!-- /#services -->

    <h1> SINGLE SOURCE SHORTEST PATH</h1>
     <section id ="SingleSource">
         <asp:TextBox ID="TextBox1" runat="server"  Text="Enter Source"></asp:TextBox><br />
         <asp:Button ID="Button2" runat="server" Text="Find" OnClick="Button2_Click" Width="126px" />
          &nbsp;&nbsp;&nbsp;
        
          <br />
&nbsp;<table class="auto-style1">
             <tr>
                 <td class="auto-style3">Destination&nbsp;&nbsp; </td>
                 <td class="auto-style4">&nbsp;Path</td>
             </tr>
             <tr>
                 <td class="auto-style3">
          <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>                  </td>
                 <td class="auto-style4">                  <asp:ListBox ID="ListBox3" runat="server"></asp:ListBox>

                 </td>
             </tr>
         </table>

         <div id="graph2">

            <canvas id="singlesrc" width="1300" height="700">
              </canvas>
         </div>

     </section>
        
         <h2> SINGLE DESTINATION SHORTEST PATH</h2>
     <section id ="SingleDst">
         <asp:TextBox ID="TextBox3" runat="server"  Text="Enter Destination"></asp:TextBox><br />
         <asp:Button ID="Button4" runat="server" Text="Find"  Width="126px" OnClick="Button4_Click" />
          <br />
&nbsp;<table class="auto-style1">
             <tr>
                 <td class="auto-style3">Destination&nbsp;&nbsp; </td>
                 <td class="auto-style4">&nbsp;Path</td>
             </tr>
             <tr>
                 <td class="auto-style3">
          <asp:ListBox ID="ListBox4" runat="server"></asp:ListBox>                  </td>
                 <td class="auto-style4">                  <asp:ListBox ID="ListBox5" runat="server"></asp:ListBox>

                 </td>
             </tr>
         </table>

         <div id="graph3">

            <canvas id="singledst" width="1300" height="700">
              </canvas>
         </div>

     </section>


        <br />
    <!-- Service Section-->
        <h1>Single Pair Shortest path</h1>
    <section id="allPair">
            
                <div id="AllPairShort">
                     <canvas id="singlepair" width="1000" height="1000"></canvas>
                </div><div id="allpairlist">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Source" Font-Bold="True" Font-Size="X-Large" ForeColor="#003300"></asp:Label>              </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#003300" Text="Destination"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" ></asp:CheckBoxList>      </td>
                            <td>
                                <asp:CheckBoxList ID="CheckBoxList2" runat="server" OnSelectedIndexChanged="CheckBoxList2_SelectedIndexChanged">
                                </asp:CheckBoxList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="Button1" runat="server" BackColor="Gray" Font-Bold="True" ForeColor="Black" OnClick="Button1_Click" Text="Find Optimum Path" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#003300" Text="Through"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:ListBox ID="ListBox1" runat="server" BackColor="White"></asp:ListBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                      </div>


                <br />


    </section>
        <section id="allpairsshrt">
                    <h1>All Pair Shortest Paths</h1>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>




                    <asp:GridView ID="GridView3" runat="server">
                    </asp:GridView>




                    <br />
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style5">
                                <asp:TextBox ID="TextBox4" runat="server">Source</asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server">Destination</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:ListBox ID="ListBox6" runat="server"></asp:ListBox>
                            </td>
                            <td>
                                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Find" Width="129px" />
                            </td>
                        </tr>
                    </table>
            <div id="myPairsShort">
                     <canvas id="allpairos" width="1300" height="1000"></canvas>
               </div>




        </section>
        <section id ="Prductionunit">
            <div id =" prod">


                <table class="auto-style1">
                    <tr>
                        <td class="auto-style6">
                            <asp:ListBox ID="ListBox7" runat="server"></asp:ListBox>
                        </td>
                        <td>
                            <asp:ListBox ID="ListBox8" runat="server"></asp:ListBox>
                        </td>
                        <td>
                            <asp:ListBox ID="ListBox9" runat="server"></asp:ListBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <asp:Button ID="Button3" runat="server" Text="Find" OnClick="Button3_Click" Width="99px" />

            </div>
            <h2>Enter Source</h2>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:ListBox ID="ListBox10" runat="server"></asp:ListBox>
            <h2>Select Distribution Units</h2>
            <asp:CheckBoxList ID="CheckBoxList3" runat="server" OnSelectedIndexChanged="CheckBoxList3_SelectedIndexChanged"></asp:CheckBoxList>
            <div id="distgraph">
                <canvas id="DistToProd" width="1300" height="1000"></canvas>
            </div>



        </section>
    
        </div>
    <script language="javascript" type="text/javascript">
       
        var sys = arbor.ParticleSystem(1000, 400, 1);
        sys.parameters({ gravity: true });
        sys.renderer = Renderer("#viewport");


        var tlb = document.getElementById('GridView1');
        for (var i = 1; i < 40; i++) {


            var tb = tlb.rows[parseInt(0)];
            var cal = tb.cells[i];
            var g = cal.innerHTML.toString();
            var dog = sys.addNode(g, { 'color': 'green', 'shape': 'dot', 'fixed':true , 'label': g });
            //alert(g);
        }

        
        var count = 0;
       for (var i = 1; i < 40; i++) {
            for (var j = 1; j < 40; j++) {
                var rw = tlb.rows[parseInt(i)];
                var col = rw.cells[j];
                var dist = col.innerHTML.toString();
                var x = parseInt(dist);

                if (x > 0) {
                    //--------------Node1-------------
                    var rw1 = tlb.rows[parseInt(0)];

                    var col1 = rw1.cells[j];
                    var n1 = col1.innerHTML.toString();
                    //--------------Node2-------------
                    var rw2 = tlb.rows[parseInt(i)];
                    var col2 = rw2.cells[0];
                    var n2 = col2.innerHTML.toString();
                    //--------------Add Edge----------
                    sys.addEdge(n1, n2, { 'name': x });
                    count++;
                
                }

            }
       }
       var accounts1 = {};
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
        //===============================//
       var accounts = {};
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
       accounts[17]= "Bhera";
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

       function singlesrgraph() {
           var sys1 = arbor.ParticleSystem(1000, 400, 1);
           sys1.parameters({ gravity: true });
           sys1.renderer = Renderer("#singlesrc");
           var list2 = document.getElementById('ListBox2');
           var srcnode = document.getElementById('TextBox1').value;
           var node = sys1.addNode(srcnode, { 'color': 'red', 'shape': 'dot', 'fixed': true, 'label': srcnode});
           for (var i = 0; i < list2.options.length; i++) {
               var dststr = list2.options[i].value;
              // alert(dststr);
               var nodeith = sys1.addNode(dststr, { 'color': 'green', 'shape': 'dot', 'fixed': true, 'label': dststr });
           }
           //========================================Edges =============================================
           var list3 = document.getElementById('ListBox3');
           
           for (var i = 0; i < list3.options.length; i++) {
               var dststr = list3.options[i].value;
           
               var maarray = dststr.split('->');
              
               for (var j = 0; j < maarray.length-1; j++) {
                   var rwindx = accounts1[maarray[j].trim()];
                   
              
                   if (j+1 == maarray.length - 1) {
                    break;
                   }
                
                   var colindx = accounts1[maarray[j + 1].trim()];
                 

                   var rw1 = tlb.rows[rwindx + 1];
                  
                   var col1 = rw1.cells[colindx + 1];
                   
                  var dist1 = col1.innerHTML.toString();
                  sys1.addEdge(maarray[j].trim(), maarray[j+1].trim(), { 'name': dist1 });
               }
               //var nodeith = sys1.addNode(dststr, { 'color': 'green', 'shape': 'dot', 'fixed': true, 'label': dststr });
           }


       }
        //======================================================SingleDEST=============================================
       function singledstgraph() {
           var sys2 = arbor.ParticleSystem(1000, 400, 1);
           sys2.parameters({ gravity: true });
           sys2.renderer = Renderer("#singledst");
           var list2 = document.getElementById('ListBox4');
           var srcnode = document.getElementById('TextBox3').value;
           var node = sys2.addNode(srcnode, { 'color': 'red', 'shape': 'dot', 'fixed': true, 'label': srcnode });
           for (var i = 0; i < list2.options.length; i++) {
               var dststr = list2.options[i].value;
             
               var nodeith = sys2.addNode(dststr, { 'color': 'green', 'shape': 'dot', 'fixed': true, 'label': dststr });
           }
           //========================================Edges =============================================
           var list3 = document.getElementById('ListBox5');

           for (var i = 0; i < list3.options.length; i++) {
               var dststr = list3.options[i].value;

               var maarray = dststr.split('->');

               for (var j = 0; j < maarray.length - 1; j++) {
                   var rwindx = accounts1[maarray[j].trim()];


                   if (j + 1 == maarray.length - 1) {
                       break;
                   }

                   var colindx = accounts1[maarray[j + 1].trim()];


                   var rw1 = tlb.rows[rwindx + 1];

                   var col1 = rw1.cells[colindx + 1];

                   var dist1 = col1.innerHTML.toString();
                   sys2.addEdge(maarray[j].trim(), maarray[j + 1].trim(), { 'name': dist1 });
               }
               //var nodeith = sys1.addNode(dststr, { 'color': 'green', 'shape': 'dot', 'fixed': true, 'label': dststr });
           }
       }

        //======================================================single pair====================================

       function singlePairo() {
           alert("i am called");
           var syss = arbor.ParticleSystem(1000, 400, 1);
           syss.parameters({ gravity: true });
           syss.renderer = Renderer("#singlepair");
           var listo = document.getElementById('ListBox1');
           for (var i = 0; i < listo.options.length-1; i++) {
               var dststr = listo.options[i].value;
               
               var nodeith = syss.addNode(dststr, { 'color': 'orange', 'shape': 'dot', 'fixed': true, 'label': dststr });
           }


           alert("total lenght" + listo.options.length);
           for (var i = 0; i < listo.options.length-1; i++) {
               alert("node1" + listo.options[i].value);
               var rwindx = accounts1[listo.options[i].value];
               

               if (i + 1 == listo.options.length - 1 && i == listo.options.length - 2) {
                   var colindx2 = accounts1[listo.options[i - 1].value];
                   var rw2 = tlb.rows[rwindx + 1];

                   var col2 = rw2.cells[colindx2 + 1];
                   var dist3 = col2.innerHTML.toString();
                   alert("iside if node1" + listo.options[i - 1].value);
                   alert("iside if node2" + listo.options[i].value);
                   syss.addEdge(listo.options[i - 1].value, listo.options[i].value, { 'name': dist3 });
                   break;
               }
               
               var colindx = accounts1[listo.options[i+1].value];
               alert("node2" + listo.options[i + 1].value);
               var rw1 = tlb.rows[rwindx + 1];

               var col1 = rw1.cells[colindx + 1];

               var dist1 = col1.innerHTML.toString();
               
               alert("index" + i);
               syss.addEdge(listo.options[i].value, listo.options[i + 1].value, { 'name': dist1 });
             //  i = i + 1;
        
        
        

           }


       }
        //==========================================All pAIRS====================================================
       function allpairoshrt() {
           
           var sysss = arbor.ParticleSystem(1000, 400, 1);
           sysss.parameters({ gravity: true });
           sysss.renderer = Renderer("#allpairos");
           var listo = document.getElementById('ListBox6');
           for (var i = 0; i < listo.options.length - 1; i++) {
               var dststr = listo.options[i].value;

               var nodeith = sysss.addNode(dststr, { 'color': 'orange', 'shape': 'dot', 'fixed': true, 'label': dststr });
           }


           alert("total lenght" + listo.options.length);
           for (var i = 0; i < listo.options.length - 1; i++) {
               alert("node1" + listo.options[i].value);
               var rwindx = accounts1[listo.options[i].value];


               if (i + 1 == listo.options.length - 1 && i == listo.options.length - 2) {
                   var colindx2 = accounts1[listo.options[i - 1].value];
                   var rw2 = tlb.rows[rwindx + 1];

                   var col2 = rw2.cells[colindx2 + 1];
                   var dist3 = col2.innerHTML.toString();
                   alert("iside if node1" + listo.options[i - 1].value);
                   alert("iside if node2" + listo.options[i].value);
                   sysss.addEdge(listo.options[i - 1].value, listo.options[i].value, { 'name': dist3 });
                   break;
               }

               var colindx = accounts1[listo.options[i + 1].value];
               alert("node2" + listo.options[i + 1].value);
               var rw1 = tlb.rows[rwindx + 1];

               var col1 = rw1.cells[colindx + 1];

               var dist1 = col1.innerHTML.toString();

               alert("index" + i);
               sysss.addEdge(listo.options[i].value, listo.options[i + 1].value, { 'name': dist1 });
               //  i = i + 1;




           }





       }
        
        //============================================= Distrubution+ Prod

       function DistProd() {

           var syssss = arbor.ParticleSystem(1000, 400, 1);
           syssss.parameters({ gravity: true });
           syssss.renderer = Renderer("#DistToProd");
           var listo1 = document.getElementById('ListBox7');
           var listo2 = document.getElementById('ListBox8');
           var listo3 = document.getElementById('ListBox9');
           var listo4 = document.getElementById('ListBox10');
           var scrr = document.getElementById("TextBox2").value;
          // scrr = scrr.trim();
           var color = 'orange';
           var color1 = "orange";
           for (var i = 0; i < listo1.options.length; i++) {
              // alert(listo1.options[i].value);
               // alert(parseInt(listo1.options[i].value));
               color = 'orange';
               color1 = 'orange';
               var sr = accounts[parseInt(listo1.options[i].value)];
               var ds = accounts[parseInt(listo2.options[i].value)];
                          
               if (sr == scrr) {
                         color = 'red';
                        
                   }
               if(ds == scrr){
                   color1 = 'red';
                  
                   }
              
             
               for (var j = 0; j < listo4.options.length; j++) {
                   if (sr == listo4.options[j].value ){
                       color = 'green';

                   }
                  
                   if (ds == listo4.options[j].value) {
                       color1 = 'green';
                   }
                   
               }
               var nodeith1 = syssss.addNode(sr, { 'color': color, 'shape': 'dot', 'fixed': true, 'label': sr });
               var nodeith2 = syssss.addNode(ds, { 'color': color1, 'shape': 'dot', 'fixed': true, 'label': ds });
               syssss.addEdge(nodeith1, nodeith2, { 'name': listo3.options[i].value});
           }
           
           //==================================================Distribution shortest path==================================//
         
          //==============================================================================================================//







       }


        // var animals = sys.addNode('Animals', { 'color': 'orange', 'shape': 'dot', 'label': 'Animals' });
      //  var dog = sys.addNode(hello, { 'color': 'green', 'shape': 'dot', 'label': hello });
     //   var cat = sys.addNode('cat', { 'color': 'red', 'shape': 'dot', 'label': 'cat' });
        //   sys.addEdge(animals, dog);
      //  sys.addEdge(dog, cat, { 'name': '10' });


    
       

    </script>
        
    </form>
    </body>
</html>
