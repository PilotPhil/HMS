using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

using serialCom;

using HMS.LAYOUT;

namespace SimpleDataAnalyse
{
    public partial class Communication : Form
    {
        serial sc = new serial();

        MyLayout layout = new MyLayout();

        List<Form> formList = new List<Form>();

        public delegate void ProcessComDataHandler(string data);

        public event ProcessComDataHandler ProcessComData;

        public Communication()
        {
            InitializeComponent();

            sc.ProcessDataEvent += GetComData;

            layout.LoadForms2Panel(sc, this.panel_chooseCom);

            sc.Show();

            sc.Enabled = false;
        }

        //事件包装事件
        private void GetComData(string data)
        {
            if (ProcessComData != null)
                ProcessComData(data);
        }

        //
        private void checkedListBox_chooseCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox_chooseCom.SelectedIndex;
            switch(index)
            {
                case 0:
                    layout.SwitchFrom(sc);
                    checkedListBox_chooseCom.SetItemCheckState(1, System.Windows.Forms.CheckState.Unchecked);
                    checkedListBox_chooseCom.SetItemCheckState(2, System.Windows.Forms.CheckState.Unchecked);
                    break;
                case 1:
                    layout.SwitchFrom(new Form());
                    checkedListBox_chooseCom.SetItemCheckState(0, System.Windows.Forms.CheckState.Unchecked);
                    checkedListBox_chooseCom.SetItemCheckState(2, System.Windows.Forms.CheckState.Unchecked);
                    break;
                case 2:
                    checkedListBox_chooseCom.SetItemCheckState(1, System.Windows.Forms.CheckState.Unchecked);
                    checkedListBox_chooseCom.SetItemCheckState(0, System.Windows.Forms.CheckState.Unchecked);
                    break;
                default:
                    break;
            }
        }
    }



}
