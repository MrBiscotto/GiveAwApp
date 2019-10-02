using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiveAwApp
{
    public partial class MainForm : Form
    {
        private int updateAdd = 0;
        private int positionTrv = 0;
        private int listIndex = 0;
        private List<GiveAway> listGive;
        private WriteSaveXML xmlWS = new WriteSaveXML();

        public MainForm()
        {
            InitializeComponent();
            listGive = new List<GiveAway>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            clearText();
            updateAdd = 1;
            disableAll();
            btnSubmit.Enabled = true;
            grBGive.Enabled = true;
        }

        private void disableAll()
        {
            trvGive.Enabled = false;
            tbPAdd.Controls.OfType<Button>().ToList().ForEach(b => b.Enabled = false);
        }

        private void enableAll()
        {
            trvGive.Enabled = true;
            tbPAdd.Controls.OfType<Button>().ToList().ForEach(b => b.Enabled = true);
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void clearText()
        {
            mtxtBGive.Text = null;
            txtBWhere.Text = null;
            rtxtBResume.Text = null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(mtxtBGive.Text.Length !=0 && txtBWhere.Text.Length != 0)
            {
                //Tag node result
                int tag = 0;

                if (updateAdd == 1)
                {
                    trvGive.Nodes.Add(mtxtBGive.Text + " [" + txtBWhere.Text + "]");

                    GiveAway newGive = new GiveAway(mtxtBGive.Text,txtBWhere.Text,rtxtBResume.Text);
                    listGive.Add(newGive);
                    trvGive.Nodes[listGive.Count-1].Tag = listGive.IndexOf(newGive);
                    tag = listGive.IndexOf(newGive);
                }
                else
                {
                    trvGive.Nodes[positionTrv].Text = mtxtBGive.Text + " [" + txtBWhere.Text + "]";

                    int index = (int)trvGive.Nodes[positionTrv].Tag;
                    tag = index;
                    GiveAway newGive = new GiveAway(mtxtBGive.Text, txtBWhere.Text, rtxtBResume.Text);
                    listGive[index] = newGive;
                }

                //Add or Update node trvResult
                verifNodeResult(mtxtBGive.Text, txtBWhere.Text, tag);

                clearText();
                enableAll();
                grBGive.Enabled = false;
                btnCancel.Visible = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("An error occured !");
            }
        }

        private void trvGive_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node != null)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                positionTrv = e.Node.Index;
                listIndex = (int)e.Node.Tag;

                mtxtBGive.Text = listGive[(int)e.Node.Tag].Date;
                txtBWhere.Text = listGive[(int)e.Node.Tag].Platform;
                rtxtBResume.Text = listGive[(int)e.Node.Tag].Resume;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            updateAdd = 2;
            grBGive.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearText();
            enableAll();
            grBGive.Enabled = false;
            btnCancel.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listGive.RemoveAt(listIndex);
            int i = 0;
            foreach(TreeNode node in trvGive.Nodes)
            {
                if ((int)node.Tag > listIndex)
                {
                    trvGive.Nodes[i].Tag = (int)node.Tag - 1;
                }
                    i++;
            }
            trvGive.Nodes.RemoveAt(positionTrv);
            clearText();
            enableAll();

            //Remove node result
            deleteNodeResult(listIndex);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save Xml File
            if (listGive.Count != 0)
            {
                xmlWS.saveXml(this.listGive);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //xmlWS.readXml();
            if (File.Exists("GiveAwayData.xml"))
            {
                listGive = xmlWS.readXml();

                int i = 0;

                foreach (GiveAway g in listGive)
                {
                    trvGive.Nodes.Add(g.Date + " [" + g.Platform + "]");
                    trvGive.Nodes[i].Tag = i;

                    verifNodeResult(g.Date, g.Platform,i);

                    i++;
                }
            }

        }

        //Nb nodes trvResult
        private int index = 0;

        private void verifNodeResult(String date,String plat,int tag)
        {
            DateTime oDate = Convert.ToDateTime(date);

            if (oDate <= DateTime.Now && oDate >= DateTime.Now.AddDays(-5))
            {
                trvResult.Visible = true;
                trvResult.Nodes.Add(date + " [" + plat + "]");
                trvResult.Nodes[index].Tag = tag;
                index++;
            }
        }

        private void deleteNodeResult(int tag)
        {
            int i = 0;
            foreach(TreeNode node in trvResult.Nodes)
            {
                if((int)node.Tag == tag)
                {
                    trvResult.Nodes[i].Remove();
                    break;
                }
                i++;
            }
        }

    }
}
