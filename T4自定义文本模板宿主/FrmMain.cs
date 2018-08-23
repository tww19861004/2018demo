using Microsoft.VisualStudio.TextTemplating;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace T4Generator
{
    public partial class FrmMain : Form
    {
        //定义引擎对象
        private Engine engine; //Microsoft.VisualStudio.TextTemplating命名空间下

        public FrmMain()
        {
            InitializeComponent();
            this.engine = new Engine();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string connString = string.Format("Data Source={0};Database={1};uid={2};pwd={3}", txtServer.Text, txtDB.Text, txtUser.Text, txtPwd.Text);

            //创建参数对象
            HostParam param = new HostParam();
            param.TableName = this.txtTableName.Text;
            param.NameSpace = this.txtNameSpace.Text;
            param.ColumnList = DBHelper.GetSchema(connString, param.TableName);

            //模板文件
            string templateFile = "Entity.txt";
            string content = File.ReadAllText(templateFile);

            //创建宿主
            TemplateHost host = new TemplateHost
            {
                TemplateFile = templateFile,
                Param = param
            };

            //生成代码
            this.txtCode.Text = engine.ProcessTemplate(content, host);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
