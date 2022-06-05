using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarineControl.HMS.Layout
{
    class MyLayout
    {
        //存储Form的list
        private List<Form> formList = new List<Form>();

        public MyLayout(){}

        /// <summary>
        /// 只加载一个Form到一个Panel
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="objPanel"></param>
        /// <param name="ds"></param>
        public void LoadForm2Panel(Form frm,Panel objPanel,DockStyle ds=DockStyle.Fill)
        {
            frm.TopLevel = false;
            frm.TopMost = false;

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置为无边框

            objPanel.Controls.Add(frm);

            frm.Dock = ds;

            frm.Show();
        }

        /// <summary>
        /// 将多个Form加载入同一个Panel
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="objPanel"></param>
        /// <param name="ds"></param>
        public void LoadForms2Panel(Form frm, Panel objPanel, DockStyle ds = DockStyle.Fill)
        {
            frm.TopLevel = false;
            frm.TopMost = false;

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置为无边框

            if(objPanel.Contains(frm)==false)//以及有了就不添加
                objPanel.Controls.Add(frm);

            frm.Dock = ds;

            formList.Add(frm);//添加到列表中
        }

        /// <summary>
        /// 切换Form
        /// </summary>
        /// <param name="form2show"></param>
        public void SwitchFrom(Form form2show)
        {
            foreach (var item in formList)
            {
                if(item==form2show)
                {
                    item.Show();
                    item.Enabled = true;
                }
                else
                {
                    item.Hide();
                    item.Enabled = false;
                }
            }
        }
        public void SwitchFrom(Form form2show,Panel panel2Move,Button objBtn)
        {
            foreach (var item in formList)
            {
                if (item == form2show)
                {
                    item.Show();
                    item.Enabled = true;
                }
                else
                {
                    item.Hide();
                    item.Enabled = false;
                }
            }

            panel2Move.Location = new System.Drawing.Point(panel2Move.Location.X, objBtn.Location.Y);

        }

        /// <summary>
        /// 清除所有Form
        /// </summary>
        public void ClearAllForms() => formList.Clear();

        /// <summary>
        /// 移除多个Form
        /// </summary>
        /// <param name="forms"></param>
        public void ClearForms(params Form[] forms)
        {
            foreach (var item in forms)
            {
                formList.ForEach((frm) =>
                {
                    if(frm==item)
                    {
                        formList.Remove(frm);
                    }
                });
            }
        }

        /// <summary>
        /// 使始终保持在中间
        /// </summary>
        /// <param name="refer"></param>
        /// <param name="obj"></param>
        public void KeepCenter(Panel refer,Panel obj)
        {
            var tem = refer.Location.X + (refer.Size.Width / 2) - (obj.Size.Width/2);
            obj.Location = new System.Drawing.Point(tem,obj.Location.Y);
        }
        public void KeepCenter(Panel refer, Label obj)
        {
            var tem = refer.Location.X + (refer.Size.Width / 2) - (obj.Size.Width / 2);
            obj.Location = new System.Drawing.Point(tem, obj.Location.Y);
        }
    }
}
