using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 正则表达式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //修改指定键值
        private void button1_Click(object sender, EventArgs e)
        {
            string line = "ADDR=1234;NAME=ZHANG;PHONE=6789";
            Regex reg = new Regex("NAME=(.+);");
            string modified = reg.Replace(line, "NAME=WANG;");
            textBox1.Text = modified;
        }

        //读取指定键值
        private void button2_Click(object sender, EventArgs e)
        {
            string line = "ADDR=1234;NAME=ZHANG;PHONE=6789";
            Regex reg = new Regex("NAME=(.*);");
            //例如我想提取line中的NAME值
            Match match = reg.Match(line);
            string value = match.Groups[1].Value;
            textBox1.Text = value;
        }

        //获取一个字符串的两个值
        private void button3_Click(object sender, EventArgs e)
        {
            //文本中含有"speed=30.3mph",需要提取该速度值，但是速度的单位可能是公制也可能是英制，mph,km/h,m/s都有可能；另外前后可能有空格。
            string line = "lane=1;speed=30.3mph;acceleration=2.5mph/s";
            Regex reg = new Regex(@"speed=([\d\.]+)(mph|km/h|m/s)");
            Match match = reg.Match(line);
            //那么在返回的结果中match.Groups[1].Value将含有数值，而match.Groups[2].Value将含有单位。
            var 值 = match.Groups[1].Value;
            var 单位 = match.Groups[2].Value;
            textBox1.Text = 值.ToString();
            textBox2.Text = 单位.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //数字
            Regex reg = new Regex(@"^[0-9]*$");
            ////n位的数字
            //Regex reg = new Regex(@"^\d{n}$");
            ////至少n位的数字
            //Regex reg = new Regex(@"^\d{n,}$");
            ////m-n位的数字
            //Regex reg = new Regex(@"^\d{m,n}$");
            ////零和非零开头的数字
            //Regex reg = new Regex(@"^(0|[1-9][0-9]*)$");
            ////非零开头的最多带两位小数的数字
            //Regex reg = new Regex(@"^([1-9][0-9]*)+(.[0-9]{1,2})?$");
            ////带1-2位小数的正数或负数
            //Regex reg = new Regex(@"^(\-)?\d+(\.\d{1,2})?$");
            ////正数、负数、和小数
            //Regex reg = new Regex(@"^(\-|\+)?\d+(\.\d+)?$");
            ////有两位小数的正实数
            //Regex reg = new Regex(@"^[0-9]+(.[0-9]{2})?$");
            ////有1~3位小数的正实数
            //Regex reg = new Regex(@"^[0-9]+(.[0-9]{1,3})?$");
            ////非零的正整数
            //Regex reg = new Regex(@"^[1-9]\d*$ 或 ^([1-9][0-9]*){1,3}$ 或 ^\+?[1-9][0-9]*$");
            ////非零的负整数
            //Regex reg = new Regex(@"^\-[1-9][]0-9″*$ 或 ^-[1-9]\d*$");
            ////非负整数
            //Regex reg = new Regex(@"^\d+$ 或 ^[1-9]\d*|0$");
            ////非正整数
            //Regex reg = new Regex(@"^-[1-9]\d*|0$ 或 ^((-\d+)|(0+))$");
            ////非负浮点数
            //Regex reg = new Regex(@"^\d+(\.\d+)?$ 或 ^[1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0$");
            ////非正浮点数
            //Regex reg = new Regex(@"^((-\d+(\.\d+)?)|(0+(\.0+)?))$ 或 ^(-([1-9]\d*\.\d*|0\.\d*[1-9]\d*))|0?\.0+|0$");
            ////正浮点数
            //Regex reg = new Regex(@"^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$ 或 ^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*))$");
            ////负浮点数
            //Regex reg = new Regex(@"^-([1-9]\d*\.\d*|0\.\d*[1-9]\d*)$ 或 ^(-(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*)))$");
            ////浮点数
            //Regex reg = new Regex(@"^(-?\d+)(\.\d+)?$ 或 ^-?([1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0)$");


            ////汉字
            //Regex reg = new Regex(@"^[\u4e00-\u9fa5]{0,}$");
            ////英文和数字
            //Regex reg = new Regex(@"^[A-Za-z0-9]+$ 或 ^[A-Za-z0-9]{4,40}$");
            ////长度为3-20的所有字符
            //Regex reg = new Regex(@"^.{3,20}$");
            ////由26个英文字母组成的字符串
            //Regex reg = new Regex(@"^[A-Za-z]+$");
            ////由26个大写英文字母组成的字符串
            //Regex reg = new Regex(@"^[A-Z]+$");
            ////由26个小写英文字母组成的字符串
            //Regex reg = new Regex(@"^[a-z]+$");
            ////由数字和26个英文字母组成的字符串
            //Regex reg = new Regex(@"^[A-Za-z0-9]+$");
            ////由数字、26个英文字母或者下划线组成的字符串
            //Regex reg = new Regex(@"^\w+$ 或 ^\w{3,20}$");
            ////中文、英文、数字包括下划线
            //Regex reg = new Regex(@"^[\u4E00-\u9FA5A-Za-z0-9_]+$");
            ////中文、英文、数字但不包括下划线等符号
            //Regex reg = new Regex(@"^[\u4E00-\u9FA5A-Za-z0-9]+$ 或 ^[\u4E00-\u9FA5A-Za-z0-9]{2,20}$");
            ////可以输入含有^%&’,;=?$\”等字符
            //Regex reg = new Regex(@"[^%&’,;=?$\x22]+");
            ////禁止输入含有~的字符
            //Regex reg = new Regex(@"[^~\x22]+");
        }
    }
}
